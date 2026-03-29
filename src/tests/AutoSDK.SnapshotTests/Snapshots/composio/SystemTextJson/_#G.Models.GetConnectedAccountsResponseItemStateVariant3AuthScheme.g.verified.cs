//HintName: G.Models.GetConnectedAccountsResponseItemStateVariant3AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConnectedAccountsResponseItemStateVariant3AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        ApiKey,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsResponseItemStateVariant3AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsResponseItemStateVariant3AuthScheme value)
        {
            return value switch
            {
                GetConnectedAccountsResponseItemStateVariant3AuthScheme.ApiKey => "API_KEY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsResponseItemStateVariant3AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "API_KEY" => GetConnectedAccountsResponseItemStateVariant3AuthScheme.ApiKey,
                _ => null,
            };
        }
    }
}