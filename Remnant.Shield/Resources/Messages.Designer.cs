﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Remnant.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Remnant.Shield.Resources.Messages", typeof(Messages).Assembly);
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
        ///   Looks up a localized string similar to The expression to shield against was evaluated to true..
        /// </summary>
        internal static string AssertMessage {
            get {
                return ResourceManager.GetString("AssertMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The variable &apos;{0}&apos; cannot be null..
        /// </summary>
        internal static string CannotBeNull {
            get {
                return ResourceManager.GetString("CannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The variable &apos;{0}&apos; cannot be null or empty..
        /// </summary>
        internal static string CannotBeNullOrEmpty {
            get {
                return ResourceManager.GetString("CannotBeNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The variable &apos;{0}&apos; cannot be null or whitespace..
        /// </summary>
        internal static string CannotBeNullOrWhitespace {
            get {
                return ResourceManager.GetString("CannotBeNullOrWhitespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The object &apos;{0}&apos; is not of the specified type {1}..
        /// </summary>
        internal static string InvalidType {
            get {
                return ResourceManager.GetString("InvalidType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The variable &apos;{0}&apos; must be null..
        /// </summary>
        internal static string MustBeNull {
            get {
                return ResourceManager.GetString("MustBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The argument &apos;{0}&apos; is out of range. Range specified between {1} and {2}..
        /// </summary>
        internal static string OutOfRange {
            get {
                return ResourceManager.GetString("OutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value for &apos;{0}&apos; falls outside the required minimum and maximum range (min={1}, max={2}).
        /// </summary>
        internal static string OutsideMinMaxRange {
            get {
                return ResourceManager.GetString("OutsideMinMaxRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The exception message &apos;{0}&apos; contains parameter placeholders but none or incorrect amount were defined!.
        /// </summary>
        internal static string ParameterCountMismatch {
            get {
                return ResourceManager.GetString("ParameterCountMismatch", resourceCulture);
            }
        }
    }
}
