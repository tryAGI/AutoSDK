//HintName: G.Models.SsoProviderResponseModelProviderType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SsoProviderResponseModelProviderType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="saml")]
        Saml,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="oidc")]
        Oidc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SsoProviderResponseModelProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SsoProviderResponseModelProviderType value)
        {
            return value switch
            {
                SsoProviderResponseModelProviderType.Saml => "saml",
                SsoProviderResponseModelProviderType.Oidc => "oidc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SsoProviderResponseModelProviderType? ToEnum(string value)
        {
            return value switch
            {
                "saml" => SsoProviderResponseModelProviderType.Saml,
                "oidc" => SsoProviderResponseModelProviderType.Oidc,
                _ => null,
            };
        }
    }
}