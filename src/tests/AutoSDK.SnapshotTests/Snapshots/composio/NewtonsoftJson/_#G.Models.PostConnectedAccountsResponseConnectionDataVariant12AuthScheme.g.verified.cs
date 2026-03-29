//HintName: G.Models.PostConnectedAccountsResponseConnectionDataVariant12AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostConnectedAccountsResponseConnectionDataVariant12AuthScheme
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
    public static class PostConnectedAccountsResponseConnectionDataVariant12AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsResponseConnectionDataVariant12AuthScheme value)
        {
            return value switch
            {
                PostConnectedAccountsResponseConnectionDataVariant12AuthScheme.Saml => "SAML",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsResponseConnectionDataVariant12AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "SAML" => PostConnectedAccountsResponseConnectionDataVariant12AuthScheme.Saml,
                _ => null,
            };
        }
    }
}