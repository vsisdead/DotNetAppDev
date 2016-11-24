﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RoadmapAnalyzer.Properties {
    using System;
    using System.Reflection;
    
    
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("RoadmapAnalyzer.Properties.Resources", typeof(Resources).GetTypeInfo().Assembly);
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
        ///   Looks up a localized string similar to Add the indefinite article for the parameter &apos;{0}&apos;.
        /// </summary>
        internal static string AddArticleToParameterCodeFix_Title {
            get {
                return ResourceManager.GetString("AddArticleToParameterCodeFix_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Names of asynchronous methods should end with Async.
        /// </summary>
        internal static string AddAsyncSuffix_Description {
            get {
                return ResourceManager.GetString("AddAsyncSuffix_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name of asynchronous method &apos;{0}&apos; does not end with Async.
        /// </summary>
        internal static string AddAsyncSuffix_MessageFormat {
            get {
                return ResourceManager.GetString("AddAsyncSuffix_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Names of asynchronous methods should end with Async.
        /// </summary>
        internal static string AddAsyncSuffix_Title {
            get {
                return ResourceManager.GetString("AddAsyncSuffix_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add Async suffix to asynchronous methods.
        /// </summary>
        internal static string AddAsyncSuffixCodeFix_Title {
            get {
                return ResourceManager.GetString("AddAsyncSuffixCodeFix_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Consider using DateTimeOffset instead of DateTime.
        /// </summary>
        internal static string ConsiderDateTimeOffsetAnalyzer_Description {
            get {
                return ResourceManager.GetString("ConsiderDateTimeOffsetAnalyzer_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Consider replacing with DateTimeOffset.
        /// </summary>
        internal static string ConsiderDateTimeOffsetAnalyzer_MessageFormat {
            get {
                return ResourceManager.GetString("ConsiderDateTimeOffsetAnalyzer_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Consider using DateTimeOffset.
        /// </summary>
        internal static string ConsiderDateTimeOffsetAnalyzer_Title {
            get {
                return ResourceManager.GetString("ConsiderDateTimeOffsetAnalyzer_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Replace with DateTimeOffset.
        /// </summary>
        internal static string ConsiderDateTimeOffsetCodeFix_Title {
            get {
                return ResourceManager.GetString("ConsiderDateTimeOffsetCodeFix_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Make first char upper case.
        /// </summary>
        internal static string PublicFieldRefactoring_Title {
            get {
                return ResourceManager.GetString("PublicFieldRefactoring_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to One-way WCF operations must return System.Void.
        /// </summary>
        internal static string WcfOneWayOperation_Title {
            get {
                return ResourceManager.GetString("WcfOneWayOperation_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Make argument parameter of &apos;{0}&apos; false.
        /// </summary>
        internal static string WcfOneWayOperationCodeFix_MakeOneWayFalse_Title {
            get {
                return ResourceManager.GetString("WcfOneWayOperationCodeFix_MakeOneWayFalse_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Replace the return type of the method &apos;{0}&apos; to void.
        /// </summary>
        internal static string WcfOneWayOperationCodeFix_MakeVoidTitle {
            get {
                return ResourceManager.GetString("WcfOneWayOperationCodeFix_MakeVoidTitle", resourceCulture);
            }
        }
    }
}
