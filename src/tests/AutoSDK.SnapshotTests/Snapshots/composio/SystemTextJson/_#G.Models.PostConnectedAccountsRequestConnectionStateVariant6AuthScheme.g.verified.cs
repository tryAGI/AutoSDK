//HintName: G.Models.PostConnectedAccountsRequestConnectionStateVariant6AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostConnectedAccountsRequestConnectionStateVariant6AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        GoogleServiceAccount,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostConnectedAccountsRequestConnectionStateVariant6AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsRequestConnectionStateVariant6AuthScheme value)
        {
            return value switch
            {
                PostConnectedAccountsRequestConnectionStateVariant6AuthScheme.GoogleServiceAccount => "GOOGLE_SERVICE_ACCOUNT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsRequestConnectionStateVariant6AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "GOOGLE_SERVICE_ACCOUNT" => PostConnectedAccountsRequestConnectionStateVariant6AuthScheme.GoogleServiceAccount,
                _ => null,
            };
        }
    }
}