﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Unicorn.FontTools.Afm2Code
{
    internal class ClassCoder
    {
        private string Namespace { get; set; }

        private string ClassName { get; set; }

        private static string _rn = Environment.NewLine;

        internal ClassCoder(string nameSpace, string className)
        {
            Namespace = nameSpace;
            ClassName = className;
        }

        internal string OutputStart(IEnumerable<string> fileNames)
        {
            string output = $"// This file was generated by {GetType().Assembly.FullName}{_rn}";
            if (fileNames != null)
            {
                string[] names = fileNames.ToArray();
                if (names.Length > 0)
                {
                    output += "// The code was generated from the following files:" + _rn;
                    foreach (string n in names)
                    {
                        output += $"//      {n}{_rn}";
                    }
                }
                output += "// Please regenerate this file instead of editing it by hand." + _rn + _rn;
            }
            return output + $"namespace {Namespace}{_rn}{{{_rn}    /// <summary>{_rn}    " +
                $"/// Embedded font metrics generated from AFM files at or before build time.{_rn}    /// </summary>{_rn}" +
                $"    public static class {ClassName}{_rn}    {{{_rn}";
        }

        internal string OutputEnd()
        {
            return $"    }}{_rn}}}{_rn}";
        }
    }
}