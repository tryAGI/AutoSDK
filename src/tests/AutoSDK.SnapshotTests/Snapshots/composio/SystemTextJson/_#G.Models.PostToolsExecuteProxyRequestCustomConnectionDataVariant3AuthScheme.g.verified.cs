//HintName: G.Models.PostToolsExecuteProxyRequestCustomConnectionDataVariant3AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostToolsExecuteProxyRequestCustomConnectionDataVariant3AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        ApiKey,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolsExecuteProxyRequestCustomConnectionDataVariant3AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolsExecuteProxyRequestCustomConnectionDataVariant3AuthScheme value)
        {
            return value switch
            {
                PostToolsExecuteProxyRequestCustomConnectionDataVariant3AuthScheme.ApiKey => "API_KEY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolsExecuteProxyRequestCustomConnectionDataVariant3AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "API_KEY" => PostToolsExecuteProxyRequestCustomConnectionDataVariant3AuthScheme.ApiKey,
                _ => null,
            };
        }
    }
}