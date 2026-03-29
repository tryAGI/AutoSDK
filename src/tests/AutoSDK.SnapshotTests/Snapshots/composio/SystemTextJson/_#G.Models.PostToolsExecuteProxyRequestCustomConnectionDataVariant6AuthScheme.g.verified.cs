//HintName: G.Models.PostToolsExecuteProxyRequestCustomConnectionDataVariant6AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostToolsExecuteProxyRequestCustomConnectionDataVariant6AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        BearerToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolsExecuteProxyRequestCustomConnectionDataVariant6AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolsExecuteProxyRequestCustomConnectionDataVariant6AuthScheme value)
        {
            return value switch
            {
                PostToolsExecuteProxyRequestCustomConnectionDataVariant6AuthScheme.BearerToken => "BEARER_TOKEN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolsExecuteProxyRequestCustomConnectionDataVariant6AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "BEARER_TOKEN" => PostToolsExecuteProxyRequestCustomConnectionDataVariant6AuthScheme.BearerToken,
                _ => null,
            };
        }
    }
}