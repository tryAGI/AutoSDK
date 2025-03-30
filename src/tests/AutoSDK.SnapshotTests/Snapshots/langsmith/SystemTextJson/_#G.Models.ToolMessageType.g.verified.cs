//HintName: G.Models.ToolMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: tool
    /// </summary>
    public enum ToolMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolMessageType value)
        {
            return value switch
            {
                ToolMessageType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolMessageType? ToEnum(string value)
        {
            return value switch
            {
                "tool" => ToolMessageType.Tool,
                _ => null,
            };
        }
    }
}