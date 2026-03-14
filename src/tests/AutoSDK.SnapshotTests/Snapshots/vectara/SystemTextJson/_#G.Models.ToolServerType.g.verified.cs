//HintName: G.Models.ToolServerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool server.<br/>
    /// Example: mcp
    /// </summary>
    public enum ToolServerType
    {
        /// <summary>
        /// 
        /// </summary>
        Mcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolServerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolServerType value)
        {
            return value switch
            {
                ToolServerType.Mcp => "mcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolServerType? ToEnum(string value)
        {
            return value switch
            {
                "mcp" => ToolServerType.Mcp,
                _ => null,
            };
        }
    }
}