//HintName: G.Models.GetConnectedAccountsResponseItemStateVariant14AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConnectedAccountsResponseItemStateVariant14AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        S2sOauth2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsResponseItemStateVariant14AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsResponseItemStateVariant14AuthScheme value)
        {
            return value switch
            {
                GetConnectedAccountsResponseItemStateVariant14AuthScheme.S2sOauth2 => "S2S_OAUTH2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsResponseItemStateVariant14AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "S2S_OAUTH2" => GetConnectedAccountsResponseItemStateVariant14AuthScheme.S2sOauth2,
                _ => null,
            };
        }
    }
}