﻿using CommandLine;
using System;
using System.Collections.Generic;
using System.IO;
using Unicorn.FontTools.Afm;

namespace Unicorn.FontTools.Afm2Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed(o =>
                {
                    const int classContentIndent = 8;
                    List<string> discoveredFonts = new List<string>();
                    ClassCoder coder = new ClassCoder(o.NameSpace, o.ClassName);
                    string output = string.IsNullOrWhiteSpace(o.Output) ? o.ClassName + ".cs" : o.Output;
                    using StreamWriter writer = new StreamWriter(output);
                    writer.Write(coder.OutputStart(args));
                    foreach (string input in args)
                    {
                        using StreamReader reader = new StreamReader(input);
                        AfmFontMetrics metrics = AfmFontMetrics.FromReader(reader);
                        foreach (string line in FontMetricsCoder.PropertyCoder(metrics, SafeFontName(metrics.FontName), input, classContentIndent))
                        {
                            writer.WriteLine(line);
                        }
                        reader.Close();
                        discoveredFonts.Add(metrics.FontName);
                    }
                    writer.Write(coder.OutputSupportedFonts(discoveredFonts, classContentIndent));
                    writer.Write(coder.OutputEnd());
                    writer.Close();
                })
                .WithNotParsed(o => Environment.Exit(1));
        }

        private static string SafeFontName(string fn)
        {
            return fn.Replace("-", "", StringComparison.InvariantCulture);
        }
    }
}
