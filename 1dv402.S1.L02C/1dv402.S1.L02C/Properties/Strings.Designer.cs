﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _1dv402.S1.L02C.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("_1dv402.S1.L02C.Properties.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to 
        ///Tryck tangent för ny beräkning - Esc avslutar.
        /// </summary>
        internal static string Continue_Prompt {
            get {
                return ResourceManager.GetString("Continue_Prompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ange det udda antalet asterisker &lt;max {0}&gt; i diamantens midja:.
        /// </summary>
        internal static string DiamondSize_Prompt {
            get {
                return ResourceManager.GetString("DiamondSize_Prompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; kan inte tolkas som en korrekt inmatning!.
        /// </summary>
        internal static string IncorrectInput_Error {
            get {
                return ResourceManager.GetString("IncorrectInput_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Det angivna värdet är inte udda!.
        /// </summary>
        internal static string NotOdd_Error {
            get {
                return ResourceManager.GetString("NotOdd_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Det angivna värdet &apos;{0}&apos; ligger inte mellan 1-79!.
        /// </summary>
        internal static string OutOfRange_Error {
            get {
                return ResourceManager.GetString("OutOfRange_Error", resourceCulture);
            }
        }
    }
}