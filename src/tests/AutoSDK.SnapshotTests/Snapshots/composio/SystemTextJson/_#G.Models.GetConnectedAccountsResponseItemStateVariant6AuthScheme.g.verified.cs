//HintName: G.Models.GetConnectedAccountsResponseItemStateVariant6AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConnectedAccountsResponseItemStateVariant6AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        GoogleServiceAccount,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsResponseItemStateVariant6AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsResponseItemStateVariant6AuthScheme value)
        {
            return value switch
            {
                GetConnectedAccountsResponseItemStateVariant6AuthScheme.GoogleServiceAccount => "GOOGLE_SERVICE_ACCOUNT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsResponseItemStateVariant6AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "GOOGLE_SERVICE_ACCOUNT" => GetConnectedAccountsResponseItemStateVariant6AuthScheme.GoogleServiceAccount,
                _ => null,
            };
        }
    }
}