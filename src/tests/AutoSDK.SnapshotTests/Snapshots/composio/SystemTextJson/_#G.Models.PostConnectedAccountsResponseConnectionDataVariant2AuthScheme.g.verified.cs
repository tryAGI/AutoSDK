//HintName: G.Models.PostConnectedAccountsResponseConnectionDataVariant2AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostConnectedAccountsResponseConnectionDataVariant2AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        Oauth2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostConnectedAccountsResponseConnectionDataVariant2AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsResponseConnectionDataVariant2AuthScheme value)
        {
            return value switch
            {
                PostConnectedAccountsResponseConnectionDataVariant2AuthScheme.Oauth2 => "OAUTH2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsResponseConnectionDataVariant2AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "OAUTH2" => PostConnectedAccountsResponseConnectionDataVariant2AuthScheme.Oauth2,
                _ => null,
            };
        }
    }
}