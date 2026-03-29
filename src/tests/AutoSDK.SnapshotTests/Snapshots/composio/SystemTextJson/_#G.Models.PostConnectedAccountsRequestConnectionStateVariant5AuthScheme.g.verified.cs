//HintName: G.Models.PostConnectedAccountsRequestConnectionStateVariant5AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostConnectedAccountsRequestConnectionStateVariant5AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        BearerToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostConnectedAccountsRequestConnectionStateVariant5AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsRequestConnectionStateVariant5AuthScheme value)
        {
            return value switch
            {
                PostConnectedAccountsRequestConnectionStateVariant5AuthScheme.BearerToken => "BEARER_TOKEN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsRequestConnectionStateVariant5AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "BEARER_TOKEN" => PostConnectedAccountsRequestConnectionStateVariant5AuthScheme.BearerToken,
                _ => null,
            };
        }
    }
}