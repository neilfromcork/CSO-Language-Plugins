//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GenericLanguagePlugin.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("GenericLanguagePlugin.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to {
        ///  
        ///    &quot;words&quot;: [
        ///
        ///    ],
        ///    &quot;regex&quot;: &quot;[^a-zA-Z\\d\\s]&quot;
        ///  
        ///}
        ///.
        /// </summary>
        internal static string keywordMetadata {
            get {
                return ResourceManager.GetString("keywordMetadata", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;static&quot;: {
        ///    &quot;release&quot;: &quot;Release&quot;,
        ///    &quot;all-groups&quot;: &quot;All Groups&quot;
        ///  },
        ///  &quot;error&quot;: {
        ///    &quot;authentication&quot;: &quot;Invalid authentication. Access denied.&quot;,
        ///    &quot;create&quot;: &quot;No record has been created. Please review your input.&quot;,
        ///    &quot;delete&quot;: &quot;No record has been deleted. Please review your selection.&quot;,
        ///    &quot;duplicate&quot;: &quot;No record has been created. A duplicate record already exists. Please review your input.&quot;,
        ///    &quot;exception&quot;: &quot;An unexpected error has occurred. Please seek technical support.&quot;,
        ///    &quot;i [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string language {
            get {
                return ResourceManager.GetString("language", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [{&quot;match&quot;:&quot;car&quot;,&quot;lemma&quot;:&quot;automobile&quot;},{&quot;match&quot;:&quot;machine&quot;,&quot;lemma&quot;:&quot;automobile&quot;},{&quot;match&quot;:&quot;auto&quot;,&quot;lemma&quot;:&quot;automobile&quot;},{&quot;match&quot;:&quot;motorcar&quot;,&quot;lemma&quot;:&quot;automobile&quot;},{&quot;match&quot;:&quot;sportsman&quot;,&quot;lemma&quot;:&quot;sport&quot;},{&quot;match&quot;:&quot;sportswoman&quot;,&quot;lemma&quot;:&quot;sport&quot;}].
        /// </summary>
        internal static string synonym {
            get {
                return ResourceManager.GetString("synonym", resourceCulture);
            }
        }
    }
}
