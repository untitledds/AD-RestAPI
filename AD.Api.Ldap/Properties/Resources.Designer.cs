﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AD.Api.Ldap.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AD.Api.Ldap.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to CN=.
        /// </summary>
        internal static string CN_Prefix {
            get {
                return ResourceManager.GetString("CN_Prefix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to defaultNamingContext.
        /// </summary>
        internal static string DefaultNamingContext {
            get {
                return ResourceManager.GetString("DefaultNamingContext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SetPassword.
        /// </summary>
        internal static string Invoke_PasswordSet {
            get {
                return ResourceManager.GetString("Invoke_PasswordSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;WKGUID=.
        /// </summary>
        internal static string LDAP_Format_WKO {
            get {
                return ResourceManager.GetString("LDAP_Format_WKO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to computer.
        /// </summary>
        internal static string Schema_Computer {
            get {
                return ResourceManager.GetString("Schema_Computer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to group.
        /// </summary>
        internal static string Schema_Group {
            get {
                return ResourceManager.GetString("Schema_Group", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to user.
        /// </summary>
        internal static string Schema_User {
            get {
                return ResourceManager.GetString("Schema_User", resourceCulture);
            }
        }
    }
}
