﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Unicorn.FontTools.OpenType;
using Unicorn.Interfaces;

namespace Unicorn.FontTools
{
    /// <summary>
    /// An <see cref="IFontDescriptor" /> implementation for OpenType fonts.
    /// </summary>
    public class OpenTypeFontDescriptor : IFontDescriptor
    {
        private readonly OpenTypeFont _underlyingFont;

        /// <summary>
        /// The PostScript font name of the underlying font.
        /// </summary>
        public string BaseFontName
        {
            get
            {
                NameRecord psName = _underlyingFont.Naming.Search(NameField.PostScriptName).FirstOrDefault();
                if (psName is null)
                {
                    psName = _underlyingFont.Naming.Search(NameField.Family).FirstOrDefault();
                }
                return psName?.Content;
            }
        }

        /// <summary>
        /// A unique identifier for this font face, constructed from the filename of the underlying font program file.
        /// </summary>
        public string UnderlyingKey => "OpenType_" + _underlyingFont.Filename;

        /// <summary>
        /// Preferred text encoding when using this font.  FIXME this should be picked up from the cmap table and should match the encoding in the PDF 
        /// font resource table
        /// </summary>
        public Encoding PreferredEncoding => Encoding.Unicode;

        /// <summary>
        /// The point size to render this font in.
        /// </summary>
        public double PointSize { get; }

        /// <summary>
        /// Whether to use Windows-style or Macintosh-style calculations when doing platform-dependent metrics calculations.
        /// </summary>
        public CalculationStyle CalculationStyle { get; set; } = CalculationStyle.Windows;

        /// <summary>
        /// The height of the ascenders of this font.
        /// </summary>
        public double Ascent
        {
            get
            {
                if (CalculationStyle == CalculationStyle.Macintosh || !_underlyingFont.OS2Metrics.Ascender.HasValue)
                {
                    return PointScaleTransform(_underlyingFont.HorizontalHeader.Ascender);
                }
                else
                {
                    return PointScaleTransform(_underlyingFont.OS2Metrics.Ascender.Value);
                }
            }
        }

        /// <summary>
        /// The height of the descenders of this font.
        /// </summary>
        public double Descent
        {
            get
            {
                if (CalculationStyle == CalculationStyle.Macintosh || !_underlyingFont.OS2Metrics.Descender.HasValue)
                {
                    return PointScaleTransform(_underlyingFont.HorizontalHeader.Descender);
                }
                else
                {
                    return PointScaleTransform(_underlyingFont.OS2Metrics.Descender.Value);
                }
            }
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="font">The underlying font.</param>
        /// <param name="pointSize">The point size the font will be rendered at.</param>
        internal OpenTypeFontDescriptor(OpenTypeFont font, double pointSize)
        {
            PointSize = pointSize;
            _underlyingFont = font;
        }

        /// <summary>
        /// Measure the width of a space in this font, using the value of the "break character" field in the "OS/2" table if it is populated.
        /// </summary>
        /// <param name="context">Ignored.</param>
        /// <returns>The width of this font's standard space character.</returns>
        public double GetNormalSpaceWidth(IGraphicsContext context)
        {
            if (_underlyingFont.OS2Metrics.BreakChar.HasValue)
            {
                return PointScaleTransform(_underlyingFont.AdvanceWidth(PlatformId.Windows, _underlyingFont.OS2Metrics.BreakChar.Value));
            }
            return PointScaleTransform(_underlyingFont.AdvanceWidth(PlatformId.Windows, 0x20));
        }

        /// <summary>
        /// Measure the rendered size of a string in this font.
        /// </summary>
        /// <param name="str">The string to be measured.</param>
        /// <returns>A <see cref="UniSize" /> value describing the height and width of the rendered string.</returns>
        public UniSize MeasureString(string str)
        {
            byte[] codeBytes = Encoding.UTF32.GetBytes(str);
            List<uint> codePoints = new List<uint>(codeBytes.Length / 4);
            for (int i = 0; i < codeBytes.Length - 3; i += 4)
            {
                codePoints.Add(codeBytes[i] | ((uint)codeBytes[i + 1] << 8) | ((uint)codeBytes[i + 2] << 16) | ((uint)codeBytes[i + 3] << 24));
            }
            int totWidth = codePoints.Select(p => _underlyingFont.AdvanceWidth(PlatformId.Windows, p)).Sum();
            return new UniSize(PointScaleTransform(totWidth), Ascent - Descent);
        }

        private double PointScaleTransform(double distInFontUnits) => PointSize * distInFontUnits / _underlyingFont.DesignUnitsPerEm;
    }
}
