﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Unicorn.Writer {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Unicorn.Writer.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Key already exists.
        /// </summary>
        internal static string Primitives_PdfDictionary_Add_Duplicate_Key_Error {
            get {
                return ResourceManager.GetString("Primitives_PdfDictionary_Add_Duplicate_Key_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The generation number must be a non-negative integer.
        /// </summary>
        internal static string Primitives_PdfIndirectObject_Invalid_Generation_Error {
            get {
                return ResourceManager.GetString("Primitives_PdfIndirectObject_Invalid_Generation_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The object ID must be a positive integer.
        /// </summary>
        internal static string Primitives_PdfIndirectObject_Invalid_ObjectId_Error {
            get {
                return ResourceManager.GetString("Primitives_PdfIndirectObject_Invalid_ObjectId_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Indirect objects may not be nested.
        /// </summary>
        internal static string Primitives_PdfIndirectObject_Nest_PdfIndirectObject_Error {
            get {
                return ResourceManager.GetString("Primitives_PdfIndirectObject_Nest_PdfIndirectObject_Error", resourceCulture);
            }
        }
    }
}
