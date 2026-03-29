//HintName: G.Models.McpCallContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: mcp_call
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum McpCallContentType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mcp_call")]
        McpCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpCallContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpCallContentType value)
        {
            return value switch
            {
                McpCallContentType.McpCall => "mcp_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpCallContentType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_call" => McpCallContentType.McpCall,
                _ => null,
            };
        }
    }
}