﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Thinktecture.IdentityModel.Oidc
{


    /// <summary>
    /// The OidcClientConfigurationSection Configuration Section.
    /// </summary>
    public partial class OidcClientConfigurationSection : global::System.Configuration.ConfigurationSection
    {

        #region Singleton Instance
        /// <summary>
        /// The XML name of the OidcClientConfigurationSection Configuration Section.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string OidcClientConfigurationSectionSectionName = "oidcClient";

        /// <summary>
        /// Gets the OidcClientConfigurationSection instance.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        public static global::Thinktecture.IdentityModel.Oidc.OidcClientConfigurationSection Instance
        {
            get
            {
                return ((global::Thinktecture.IdentityModel.Oidc.OidcClientConfigurationSection)(global::System.Configuration.ConfigurationManager.GetSection(global::Thinktecture.IdentityModel.Oidc.OidcClientConfigurationSection.OidcClientConfigurationSectionSectionName)));
            }
        }
        #endregion

        #region Xmlns Property
        /// <summary>
        /// The XML name of the <see cref="Xmlns"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string XmlnsPropertyName = "xmlns";

        /// <summary>
        /// Gets the XML namespace of this Configuration Section.
        /// </summary>
        /// <remarks>
        /// This property makes sure that if the configuration file contains the XML namespace,
        /// the parser doesn't throw an exception because it encounters the unknown "xmlns" attribute.
        /// </remarks>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Thinktecture.IdentityModel.Oidc.OidcClientConfigurationSection.XmlnsPropertyName, IsRequired = false, IsKey = false, IsDefaultCollection = false)]
        public string Xmlns
        {
            get
            {
                return ((string)(base[global::Thinktecture.IdentityModel.Oidc.OidcClientConfigurationSection.XmlnsPropertyName]));
            }
        }
        #endregion

        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion

        #region ClientId Property
        /// <summary>
        /// The XML name of the <see cref="ClientId"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string ClientIdPropertyName = "clientId";

        /// <summary>
        /// Gets or sets the ClientId.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        [global::System.ComponentModel.DescriptionAttribute("The ClientId.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Thinktecture.IdentityModel.Oidc.OidcClientConfigurationSection.ClientIdPropertyName, IsRequired = false, IsKey = false, IsDefaultCollection = false)]
        public virtual string ClientId
        {
            get
            {
                return ((string)(base[global::Thinktecture.IdentityModel.Oidc.OidcClientConfigurationSection.ClientIdPropertyName]));
            }
            set
            {
                base[global::Thinktecture.IdentityModel.Oidc.OidcClientConfigurationSection.ClientIdPropertyName] = value;
            }
        }
        #endregion

        #region ClientSecret Property
        /// <summary>
        /// The XML name of the <see cref="ClientSecret"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string ClientSecretPropertyName = "clientSecret";

        /// <summary>
        /// Gets or sets the ClientSecret.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        [global::System.ComponentModel.DescriptionAttribute("The ClientSecret.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Thinktecture.IdentityModel.Oidc.OidcClientConfigurationSection.ClientSecretPropertyName, IsRequired = false, IsKey = false, IsDefaultCollection = false)]
        public virtual string ClientSecret
        {
            get
            {
                return ((string)(base[global::Thinktecture.IdentityModel.Oidc.OidcClientConfigurationSection.ClientSecretPropertyName]));
            }
            set
            {
                base[global::Thinktecture.IdentityModel.Oidc.OidcClientConfigurationSection.ClientSecretPropertyName] = value;
            }
        }
        #endregion

        #region Scope Property
        /// <summary>
        /// The XML name of the <see cref="Scope"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string ScopePropertyName = "scope";

        /// <summary>
        /// Gets or sets the Scope.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        [global::System.ComponentModel.DescriptionAttribute("The Scope.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Thinktecture.IdentityModel.Oidc.OidcClientConfigurationSection.ScopePropertyName, IsRequired = false, IsKey = false, IsDefaultCollection = false)]
        public virtual string Scope
        {
            get
            {
                return ((string)(base[global::Thinktecture.IdentityModel.Oidc.OidcClientConfigurationSection.ScopePropertyName]));
            }
            set
            {
                base[global::Thinktecture.IdentityModel.Oidc.OidcClientConfigurationSection.ScopePropertyName] = value;
            }
        }
        #endregion

        #region IssuerName Property
        /// <summary>
        /// The XML name of the <see cref="IssuerName"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string IssuerNamePropertyName = "issuerName";

        /// <summary>
        /// Gets or sets the IssuerName.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        [global::System.ComponentModel.DescriptionAttribute("The IssuerName.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Thinktecture.IdentityModel.Oidc.OidcClientConfigurationSection.IssuerNamePropertyName, IsRequired = false, IsKey = false, IsDefaultCollection = false)]
        public virtual string IssuerName
        {
            get
            {
                return ((string)(base[global::Thinktecture.IdentityModel.Oidc.OidcClientConfigurationSection.IssuerNamePropertyName]));
            }
            set
            {
                base[global::Thinktecture.IdentityModel.Oidc.OidcClientConfigurationSection.IssuerNamePropertyName] = value;
            }
        }
        #endregion

        #region SigningCertificate Property
        /// <summary>
        /// The XML name of the <see cref="SigningCertificate"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string SigningCertificatePropertyName = "signingCertificate";

        /// <summary>
        /// Gets or sets the SigningCertificate.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        [global::System.ComponentModel.DescriptionAttribute("The SigningCertificate.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Thinktecture.IdentityModel.Oidc.OidcClientConfigurationSection.SigningCertificatePropertyName, IsRequired = false, IsKey = false, IsDefaultCollection = false)]
        public virtual string SigningCertificate
        {
            get
            {
                return ((string)(base[global::Thinktecture.IdentityModel.Oidc.OidcClientConfigurationSection.SigningCertificatePropertyName]));
            }
            set
            {
                base[global::Thinktecture.IdentityModel.Oidc.OidcClientConfigurationSection.SigningCertificatePropertyName] = value;
            }
        }
        #endregion

        #region AppRelativeCallbackUrl Property
        /// <summary>
        /// The XML name of the <see cref="AppRelativeCallbackUrl"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string AppRelativeCallbackUrlPropertyName = "appRelativeCallbackUrl";

        /// <summary>
        /// Gets or sets the AppRelativeCallbackUrl.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        [global::System.ComponentModel.DescriptionAttribute("The AppRelativeCallbackUrl.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Thinktecture.IdentityModel.Oidc.OidcClientConfigurationSection.AppRelativeCallbackUrlPropertyName, IsRequired = false, IsKey = false, IsDefaultCollection = false, DefaultValue = "~/oidccallback")]
        public virtual string AppRelativeCallbackUrl
        {
            get
            {
                return ((string)(base[global::Thinktecture.IdentityModel.Oidc.OidcClientConfigurationSection.AppRelativeCallbackUrlPropertyName]));
            }
            set
            {
                base[global::Thinktecture.IdentityModel.Oidc.OidcClientConfigurationSection.AppRelativeCallbackUrlPropertyName] = value;
            }
        }
        #endregion

        #region CallUserInfoEndpoint Property
        /// <summary>
        /// The XML name of the <see cref="CallUserInfoEndpoint"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string CallUserInfoEndpointPropertyName = "callUserInfoEndpoint";

        /// <summary>
        /// Gets or sets the CallUserInfoEndpoint.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        [global::System.ComponentModel.DescriptionAttribute("The CallUserInfoEndpoint.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Thinktecture.IdentityModel.Oidc.OidcClientConfigurationSection.CallUserInfoEndpointPropertyName, IsRequired = false, IsKey = false, IsDefaultCollection = false, DefaultValue = true)]
        public virtual bool CallUserInfoEndpoint
        {
            get
            {
                return ((bool)(base[global::Thinktecture.IdentityModel.Oidc.OidcClientConfigurationSection.CallUserInfoEndpointPropertyName]));
            }
            set
            {
                base[global::Thinktecture.IdentityModel.Oidc.OidcClientConfigurationSection.CallUserInfoEndpointPropertyName] = value;
            }
        }
        #endregion

        #region Endpoints Property
        /// <summary>
        /// The XML name of the <see cref="Endpoints"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string EndpointsPropertyName = "endpoints";

        /// <summary>
        /// Gets or sets the Endpoints.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        [global::System.ComponentModel.DescriptionAttribute("The Endpoints.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Thinktecture.IdentityModel.Oidc.OidcClientConfigurationSection.EndpointsPropertyName, IsRequired = false, IsKey = false, IsDefaultCollection = false)]
        public virtual global::Thinktecture.IdentityModel.Oidc.EndpointsConfigurationElement Endpoints
        {
            get
            {
                return ((global::Thinktecture.IdentityModel.Oidc.EndpointsConfigurationElement)(base[global::Thinktecture.IdentityModel.Oidc.OidcClientConfigurationSection.EndpointsPropertyName]));
            }
            set
            {
                base[global::Thinktecture.IdentityModel.Oidc.OidcClientConfigurationSection.EndpointsPropertyName] = value;
            }
        }
        #endregion
    }
}
namespace Thinktecture.IdentityModel.Oidc
{


    /// <summary>
    /// The EndpointsConfigurationElement Configuration Element.
    /// </summary>
    public partial class EndpointsConfigurationElement : global::System.Configuration.ConfigurationElement
    {

        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion

        #region Authorize Property
        /// <summary>
        /// The XML name of the <see cref="Authorize"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string AuthorizePropertyName = "authorize";

        /// <summary>
        /// Gets or sets the Authorize.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        [global::System.ComponentModel.DescriptionAttribute("The Authorize.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Thinktecture.IdentityModel.Oidc.EndpointsConfigurationElement.AuthorizePropertyName, IsRequired = false, IsKey = false, IsDefaultCollection = false)]
        public virtual string Authorize
        {
            get
            {
                return ((string)(base[global::Thinktecture.IdentityModel.Oidc.EndpointsConfigurationElement.AuthorizePropertyName]));
            }
            set
            {
                base[global::Thinktecture.IdentityModel.Oidc.EndpointsConfigurationElement.AuthorizePropertyName] = value;
            }
        }
        #endregion

        #region Token Property
        /// <summary>
        /// The XML name of the <see cref="Token"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string TokenPropertyName = "token";

        /// <summary>
        /// Gets or sets the Token.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        [global::System.ComponentModel.DescriptionAttribute("The Token.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Thinktecture.IdentityModel.Oidc.EndpointsConfigurationElement.TokenPropertyName, IsRequired = false, IsKey = false, IsDefaultCollection = false)]
        public virtual string Token
        {
            get
            {
                return ((string)(base[global::Thinktecture.IdentityModel.Oidc.EndpointsConfigurationElement.TokenPropertyName]));
            }
            set
            {
                base[global::Thinktecture.IdentityModel.Oidc.EndpointsConfigurationElement.TokenPropertyName] = value;
            }
        }
        #endregion

        #region UserInfo Property
        /// <summary>
        /// The XML name of the <see cref="UserInfo"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        internal const string UserInfoPropertyName = "userInfo";

        /// <summary>
        /// Gets or sets the UserInfo.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.0")]
        [global::System.ComponentModel.DescriptionAttribute("The UserInfo.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::Thinktecture.IdentityModel.Oidc.EndpointsConfigurationElement.UserInfoPropertyName, IsRequired = false, IsKey = false, IsDefaultCollection = false)]
        public virtual string UserInfo
        {
            get
            {
                return ((string)(base[global::Thinktecture.IdentityModel.Oidc.EndpointsConfigurationElement.UserInfoPropertyName]));
            }
            set
            {
                base[global::Thinktecture.IdentityModel.Oidc.EndpointsConfigurationElement.UserInfoPropertyName] = value;
            }
        }
        #endregion
    }
}