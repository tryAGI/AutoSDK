//HintName: G.Models.PostToolsExecuteProxyRequestCustomConnectionDataVariant8AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostToolsExecuteProxyRequestCustomConnectionDataVariant8AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        NoAuth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolsExecuteProxyRequestCustomConnectionDataVariant8AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolsExecuteProxyRequestCustomConnectionDataVariant8AuthScheme value)
        {
            return value switch
            {
                PostToolsExecuteProxyRequestCustomConnectionDataVariant8AuthScheme.NoAuth => "NO_AUTH",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolsExecuteProxyRequestCustomConnectionDataVariant8AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "NO_AUTH" => PostToolsExecuteProxyRequestCustomConnectionDataVariant8AuthScheme.NoAuth,
                _ => null,
            };
        }
    }
}