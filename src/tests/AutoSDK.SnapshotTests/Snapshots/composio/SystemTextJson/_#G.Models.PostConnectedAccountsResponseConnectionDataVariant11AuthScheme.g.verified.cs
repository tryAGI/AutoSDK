//HintName: G.Models.PostConnectedAccountsResponseConnectionDataVariant11AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostConnectedAccountsResponseConnectionDataVariant11AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        ServiceAccount,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostConnectedAccountsResponseConnectionDataVariant11AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsResponseConnectionDataVariant11AuthScheme value)
        {
            return value switch
            {
                PostConnectedAccountsResponseConnectionDataVariant11AuthScheme.ServiceAccount => "SERVICE_ACCOUNT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsResponseConnectionDataVariant11AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "SERVICE_ACCOUNT" => PostConnectedAccountsResponseConnectionDataVariant11AuthScheme.ServiceAccount,
                _ => null,
            };
        }
    }
}