//HintName: G.Models.GetToolRouterSessionBySessionIdResponseMcpType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the MCP server. Can be http
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetToolRouterSessionBySessionIdResponseMcpType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="http")]
        Http,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetToolRouterSessionBySessionIdResponseMcpTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetToolRouterSessionBySessionIdResponseMcpType value)
        {
            return value switch
            {
                GetToolRouterSessionBySessionIdResponseMcpType.Http => "http",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetToolRouterSessionBySessionIdResponseMcpType? ToEnum(string value)
        {
            return value switch
            {
                "http" => GetToolRouterSessionBySessionIdResponseMcpType.Http,
                _ => null,
            };
        }
    }
}