//HintName: G.Models.MCPToolConfigInputType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: mcp
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MCPToolConfigInputType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mcp")]
        Mcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MCPToolConfigInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPToolConfigInputType value)
        {
            return value switch
            {
                MCPToolConfigInputType.Mcp => "mcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPToolConfigInputType? ToEnum(string value)
        {
            return value switch
            {
                "mcp" => MCPToolConfigInputType.Mcp,
                _ => null,
            };
        }
    }
}