//HintName: G.Models.GetConnectedAccountsResponseItemStateVariant12AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConnectedAccountsResponseItemStateVariant12AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        Saml,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsResponseItemStateVariant12AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsResponseItemStateVariant12AuthScheme value)
        {
            return value switch
            {
                GetConnectedAccountsResponseItemStateVariant12AuthScheme.Saml => "SAML",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsResponseItemStateVariant12AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "SAML" => GetConnectedAccountsResponseItemStateVariant12AuthScheme.Saml,
                _ => null,
            };
        }
    }
}