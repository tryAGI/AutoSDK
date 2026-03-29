//HintName: G.Models.PostConnectedAccountsRequestConnectionStateVariant13AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostConnectedAccountsRequestConnectionStateVariant13AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        DcrOauth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostConnectedAccountsRequestConnectionStateVariant13AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsRequestConnectionStateVariant13AuthScheme value)
        {
            return value switch
            {
                PostConnectedAccountsRequestConnectionStateVariant13AuthScheme.DcrOauth => "DCR_OAUTH",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsRequestConnectionStateVariant13AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "DCR_OAUTH" => PostConnectedAccountsRequestConnectionStateVariant13AuthScheme.DcrOauth,
                _ => null,
            };
        }
    }
}