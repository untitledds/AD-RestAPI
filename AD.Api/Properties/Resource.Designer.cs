﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AD.Api.Properties {
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
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AD.Api.Properties.Resource", typeof(Resource).Assembly);
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
        ///   Looks up a localized string similar to (DC\=.+)$.
        /// </summary>
        internal static string DN_DomainCapture {
            get {
                return ResourceManager.GetString("DN_DomainCapture", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not a valid domain name or is not configured..
        /// </summary>
        internal static string Error_InvalidDomainName {
            get {
                return ResourceManager.GetString("Error_InvalidDomainName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An &apos;Add&apos; operation requires &apos;newValues&apos; to be defined..
        /// </summary>
        internal static string Exception_IllegalOp_Add {
            get {
                return ResourceManager.GetString("Exception_IllegalOp_Add", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid parameters for an AD modification were specified.  {0}.
        /// </summary>
        internal static string Exception_IllegalOp_Format {
            get {
                return ResourceManager.GetString("Exception_IllegalOp_Format", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A &apos;Remove&apos; operation requires &apos;oldValues&apos; to be defined..
        /// </summary>
        internal static string Exception_IllegalOp_Remove {
            get {
                return ResourceManager.GetString("Exception_IllegalOp_Remove", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A &apos;Replace&apos; operation requires both &apos;newValues&apos; and &apos;oldValues&apos; to be defined..
        /// </summary>
        internal static string Exception_IllegalOp_Replace {
            get {
                return ResourceManager.GetString("Exception_IllegalOp_Replace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A &apos;Set&apos; operation requires &apos;newValues&apos; to be defined..
        /// </summary>
        internal static string Exception_IllegalOp_Set {
            get {
                return ResourceManager.GetString("Exception_IllegalOp_Set", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An unknown error occurred..
        /// </summary>
        internal static string Exception_UnknownError {
            get {
                return ResourceManager.GetString("Exception_UnknownError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to System.Collections.Generic.IEnumerable`1[{0}].
        /// </summary>
        internal static string IEnumerableT_Format {
            get {
                return ResourceManager.GetString("IEnumerableT_Format", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;WKGUID={0},{1}&gt;.
        /// </summary>
        internal static string LDAP_Format_WKO {
            get {
                return ResourceManager.GetString("LDAP_Format_WKO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LDAP://&lt;WKGUID=AA312825768811D1ADED00C04FD8D5CD,{0}&gt;.
        /// </summary>
        internal static string LDAP_Format_WKO_Computers {
            get {
                return ResourceManager.GetString("LDAP_Format_WKO_Computers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LDAP://&lt;WKGUID=A9D1CA15768811D1ADED00C04FD8D5CD,{0}&gt;.
        /// </summary>
        internal static string LDAP_Format_WKO_Users {
            get {
                return ResourceManager.GetString("LDAP_Format_WKO_Users", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LDAP://.
        /// </summary>
        internal static string LDAP_Prefix {
            get {
                return ResourceManager.GetString("LDAP_Prefix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LDAP://{0}.
        /// </summary>
        internal static string LDAP_PrefixFormat {
            get {
                return ResourceManager.GetString("LDAP_PrefixFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LDAP://RootDSE.
        /// </summary>
        internal static string LDAP_RootDSE {
            get {
                return ResourceManager.GetString("LDAP_RootDSE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to and.
        /// </summary>
        internal static string LDAPQuery_And {
            get {
                return ResourceManager.GetString("LDAPQuery_And", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to operator.
        /// </summary>
        internal static string LDAPQuery_Operator {
            get {
                return ResourceManager.GetString("LDAPQuery_Operator", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to or.
        /// </summary>
        internal static string LDAPQuery_Or {
            get {
                return ResourceManager.GetString("LDAPQuery_Or", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to objectCategory=person.
        /// </summary>
        internal static string LDAPQuery_User_ObjectCategory {
            get {
                return ResourceManager.GetString("LDAPQuery_User_ObjectCategory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to objectClass=user.
        /// </summary>
        internal static string LDAPQuery_User_ObjectClass {
            get {
                return ResourceManager.GetString("LDAPQuery_User_ObjectClass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SMTP:.
        /// </summary>
        internal static string SMTP_Prefix_Primary {
            get {
                return ResourceManager.GetString("SMTP_Prefix_Primary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ^SMTP\:.
        /// </summary>
        internal static string SMTP_Prefix_PrimaryRegex {
            get {
                return ResourceManager.GetString("SMTP_Prefix_PrimaryRegex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to smtp:.
        /// </summary>
        internal static string STMP_Prefix {
            get {
                return ResourceManager.GetString("STMP_Prefix", resourceCulture);
            }
        }
    }
}
