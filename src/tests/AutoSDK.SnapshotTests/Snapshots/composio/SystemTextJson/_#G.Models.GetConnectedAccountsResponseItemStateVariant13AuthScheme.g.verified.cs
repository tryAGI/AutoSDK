//HintName: G.Models.GetConnectedAccountsResponseItemStateVariant13AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConnectedAccountsResponseItemStateVariant13AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        DcrOauth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsResponseItemStateVariant13AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsResponseItemStateVariant13AuthScheme value)
        {
            return value switch
            {
                GetConnectedAccountsResponseItemStateVariant13AuthScheme.DcrOauth => "DCR_OAUTH",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsResponseItemStateVariant13AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "DCR_OAUTH" => GetConnectedAccountsResponseItemStateVariant13AuthScheme.DcrOauth,
                _ => null,
            };
        }
    }
}