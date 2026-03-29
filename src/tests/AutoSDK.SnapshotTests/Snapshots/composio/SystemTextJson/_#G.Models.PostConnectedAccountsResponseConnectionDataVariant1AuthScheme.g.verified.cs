//HintName: G.Models.PostConnectedAccountsResponseConnectionDataVariant1AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostConnectedAccountsResponseConnectionDataVariant1AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        Oauth1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostConnectedAccountsResponseConnectionDataVariant1AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsResponseConnectionDataVariant1AuthScheme value)
        {
            return value switch
            {
                PostConnectedAccountsResponseConnectionDataVariant1AuthScheme.Oauth1 => "OAUTH1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsResponseConnectionDataVariant1AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "OAUTH1" => PostConnectedAccountsResponseConnectionDataVariant1AuthScheme.Oauth1,
                _ => null,
            };
        }
    }
}