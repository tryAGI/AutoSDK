//HintName: G.Models.PostConnectedAccountsRequestConnectionStateVariant10AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostConnectedAccountsRequestConnectionStateVariant10AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        BasicWithJwt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostConnectedAccountsRequestConnectionStateVariant10AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsRequestConnectionStateVariant10AuthScheme value)
        {
            return value switch
            {
                PostConnectedAccountsRequestConnectionStateVariant10AuthScheme.BasicWithJwt => "BASIC_WITH_JWT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsRequestConnectionStateVariant10AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "BASIC_WITH_JWT" => PostConnectedAccountsRequestConnectionStateVariant10AuthScheme.BasicWithJwt,
                _ => null,
            };
        }
    }
}