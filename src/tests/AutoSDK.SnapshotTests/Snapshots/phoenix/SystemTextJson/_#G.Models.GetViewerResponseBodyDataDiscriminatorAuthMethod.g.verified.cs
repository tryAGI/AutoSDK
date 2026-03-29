//HintName: G.Models.GetViewerResponseBodyDataDiscriminatorAuthMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetViewerResponseBodyDataDiscriminatorAuthMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Anonymous,
        /// <summary>
        /// 
        /// </summary>
        Ldap,
        /// <summary>
        /// 
        /// </summary>
        Local,
        /// <summary>
        /// 
        /// </summary>
        Oauth2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetViewerResponseBodyDataDiscriminatorAuthMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetViewerResponseBodyDataDiscriminatorAuthMethod value)
        {
            return value switch
            {
                GetViewerResponseBodyDataDiscriminatorAuthMethod.Anonymous => "ANONYMOUS",
                GetViewerResponseBodyDataDiscriminatorAuthMethod.Ldap => "LDAP",
                GetViewerResponseBodyDataDiscriminatorAuthMethod.Local => "LOCAL",
                GetViewerResponseBodyDataDiscriminatorAuthMethod.Oauth2 => "OAUTH2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetViewerResponseBodyDataDiscriminatorAuthMethod? ToEnum(string value)
        {
            return value switch
            {
                "ANONYMOUS" => GetViewerResponseBodyDataDiscriminatorAuthMethod.Anonymous,
                "LDAP" => GetViewerResponseBodyDataDiscriminatorAuthMethod.Ldap,
                "LOCAL" => GetViewerResponseBodyDataDiscriminatorAuthMethod.Local,
                "OAUTH2" => GetViewerResponseBodyDataDiscriminatorAuthMethod.Oauth2,
                _ => null,
            };
        }
    }
}