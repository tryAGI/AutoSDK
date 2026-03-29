//HintName: G.Models.PostConnectedAccountsRequestConnectionStateVariant12AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostConnectedAccountsRequestConnectionStateVariant12AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SAML")]
        Saml,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostConnectedAccountsRequestConnectionStateVariant12AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsRequestConnectionStateVariant12AuthScheme value)
        {
            return value switch
            {
                PostConnectedAccountsRequestConnectionStateVariant12AuthScheme.Saml => "SAML",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsRequestConnectionStateVariant12AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "SAML" => PostConnectedAccountsRequestConnectionStateVariant12AuthScheme.Saml,
                _ => null,
            };
        }
    }
}