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
        ///   Looks up a localized string similar to Key already exists..
        /// </summary>
        internal static string Primitives_PdfDictionary_Add_Duplicate_Key_Error {
            get {
                return ResourceManager.GetString("Primitives_PdfDictionary_Add_Duplicate_Key_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Key not present..
        /// </summary>
        internal static string Primitives_PdfDictionary_Indexer_Key_Not_Found_Error {
            get {
                return ResourceManager.GetString("Primitives_PdfDictionary_Indexer_Key_Not_Found_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The generation number must be a non-negative integer..
        /// </summary>
        internal static string Primitives_PdfIndirectObject_Invalid_Generation_Error {
            get {
                return ResourceManager.GetString("Primitives_PdfIndirectObject_Invalid_Generation_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The object ID must be a positive integer..
        /// </summary>
        internal static string Primitives_PdfIndirectObject_Invalid_ObjectId_Error {
            get {
                return ResourceManager.GetString("Primitives_PdfIndirectObject_Invalid_ObjectId_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Indirect objects may not be nested..
        /// </summary>
        internal static string Primitives_PdfIndirectObject_Nest_PdfIndirectObject_Error {
            get {
                return ResourceManager.GetString("Primitives_PdfIndirectObject_Nest_PdfIndirectObject_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Indirect objects may not be used as stream content..
        /// </summary>
        internal static string Primitives_PdfIndirectObject_Write_To_PdfStream_Error {
            get {
                return ResourceManager.GetString("Primitives_PdfIndirectObject_Write_To_PdfStream_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Line dash pattern must consist of an empty array or an array of numbers..
        /// </summary>
        internal static string Primitives_PdfOperator_LineDashPattern_Content_Error {
            get {
                return ResourceManager.GetString("Primitives_PdfOperator_LineDashPattern_Content_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The start value of the line dash pattern operator must not be higher than the number of items in the pattern array..
        /// </summary>
        internal static string Primitives_PdfOperator_LineDashPattern_Index_Too_High_Error {
            get {
                return ResourceManager.GetString("Primitives_PdfOperator_LineDashPattern_Index_Too_High_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Objects in the cross-reference table must have object IDs previously issued by the cross-reference table..
        /// </summary>
        internal static string Structural_PdfCrossRefTable_SetSlot_Invalid_ObjectId_Error {
            get {
                return ResourceManager.GetString("Structural_PdfCrossRefTable_SetSlot_Invalid_ObjectId_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The generation number must be a non-negative integer..
        /// </summary>
        internal static string Structural_PdfPageTreeItem_Invalid_Generation_Error {
            get {
                return ResourceManager.GetString("Structural_PdfPageTreeItem_Invalid_Generation_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The object ID must be a positive integer..
        /// </summary>
        internal static string Structural_PdfPageTreeItem_Invalid_ObjectId_Error {
            get {
                return ResourceManager.GetString("Structural_PdfPageTreeItem_Invalid_ObjectId_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The cross-reference table address {0} appeared to be invalid..
        /// </summary>
        internal static string Structural_PdfTrailer_SetCrossReferenceTableLocation_Invalid_Location_Error {
            get {
                return ResourceManager.GetString("Structural_PdfTrailer_SetCrossReferenceTableLocation_Invalid_Location_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file trailer cannot be written when the cross-reference table location is unknown..
        /// </summary>
        internal static string Structural_PdfTrailer_WriteTo_CrossRef_Location_Not_Known_Error {
            get {
                return ResourceManager.GetString("Structural_PdfTrailer_WriteTo_CrossRef_Location_Not_Known_Error", resourceCulture);
            }
        }
    }
}
