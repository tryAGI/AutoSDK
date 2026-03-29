//HintName: G.Models.PostToolRouterSessionBySessionIdProxyExecuteRequestParameterType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameter type (header or query)<br/>
    /// Example: header
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostToolRouterSessionBySessionIdProxyExecuteRequestParameterType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="header")]
        Header,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="query")]
        Query,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolRouterSessionBySessionIdProxyExecuteRequestParameterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionBySessionIdProxyExecuteRequestParameterType value)
        {
            return value switch
            {
                PostToolRouterSessionBySessionIdProxyExecuteRequestParameterType.Header => "header",
                PostToolRouterSessionBySessionIdProxyExecuteRequestParameterType.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionBySessionIdProxyExecuteRequestParameterType? ToEnum(string value)
        {
            return value switch
            {
                "header" => PostToolRouterSessionBySessionIdProxyExecuteRequestParameterType.Header,
                "query" => PostToolRouterSessionBySessionIdProxyExecuteRequestParameterType.Query,
                _ => null,
            };
        }
    }
}