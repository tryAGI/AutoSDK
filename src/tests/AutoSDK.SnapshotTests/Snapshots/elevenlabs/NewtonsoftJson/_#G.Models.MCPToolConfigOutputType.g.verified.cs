//HintName: G.Models.MCPToolConfigOutputType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: mcp
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MCPToolConfigOutputType
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
    public static class MCPToolConfigOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPToolConfigOutputType value)
        {
            return value switch
            {
                MCPToolConfigOutputType.Mcp => "mcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPToolConfigOutputType? ToEnum(string value)
        {
            return value switch
            {
                "mcp" => MCPToolConfigOutputType.Mcp,
                _ => null,
            };
        }
    }
}