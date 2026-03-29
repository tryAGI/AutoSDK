//HintName: G.Models.PostToolsExecuteProxyRequestParameterType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameter type (header or query)<br/>
    /// Example: header
    /// </summary>
    public enum PostToolsExecuteProxyRequestParameterType
    {
        /// <summary>
        /// 
        /// </summary>
        Header,
        /// <summary>
        /// 
        /// </summary>
        Query,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolsExecuteProxyRequestParameterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolsExecuteProxyRequestParameterType value)
        {
            return value switch
            {
                PostToolsExecuteProxyRequestParameterType.Header => "header",
                PostToolsExecuteProxyRequestParameterType.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolsExecuteProxyRequestParameterType? ToEnum(string value)
        {
            return value switch
            {
                "header" => PostToolsExecuteProxyRequestParameterType.Header,
                "query" => PostToolsExecuteProxyRequestParameterType.Query,
                _ => null,
            };
        }
    }
}