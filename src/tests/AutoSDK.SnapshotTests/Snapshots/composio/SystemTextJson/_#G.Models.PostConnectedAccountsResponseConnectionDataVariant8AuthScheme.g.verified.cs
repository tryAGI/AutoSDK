//HintName: G.Models.PostConnectedAccountsResponseConnectionDataVariant8AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostConnectedAccountsResponseConnectionDataVariant8AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        CalcomAuth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostConnectedAccountsResponseConnectionDataVariant8AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsResponseConnectionDataVariant8AuthScheme value)
        {
            return value switch
            {
                PostConnectedAccountsResponseConnectionDataVariant8AuthScheme.CalcomAuth => "CALCOM_AUTH",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsResponseConnectionDataVariant8AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "CALCOM_AUTH" => PostConnectedAccountsResponseConnectionDataVariant8AuthScheme.CalcomAuth,
                _ => null,
            };
        }
    }
}