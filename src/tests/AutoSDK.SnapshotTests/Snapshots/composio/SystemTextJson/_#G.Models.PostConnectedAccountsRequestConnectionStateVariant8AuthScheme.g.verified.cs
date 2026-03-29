//HintName: G.Models.PostConnectedAccountsRequestConnectionStateVariant8AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostConnectedAccountsRequestConnectionStateVariant8AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        CalcomAuth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostConnectedAccountsRequestConnectionStateVariant8AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsRequestConnectionStateVariant8AuthScheme value)
        {
            return value switch
            {
                PostConnectedAccountsRequestConnectionStateVariant8AuthScheme.CalcomAuth => "CALCOM_AUTH",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsRequestConnectionStateVariant8AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "CALCOM_AUTH" => PostConnectedAccountsRequestConnectionStateVariant8AuthScheme.CalcomAuth,
                _ => null,
            };
        }
    }
}