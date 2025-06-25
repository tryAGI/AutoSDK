//HintName: G.Models.RequestToolResultBlockType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestToolResultBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestToolResultBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestToolResultBlockType value)
        {
            return value switch
            {
                RequestToolResultBlockType.ToolResult => "tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestToolResultBlockType? ToEnum(string value)
        {
            return value switch
            {
                "tool_result" => RequestToolResultBlockType.ToolResult,
                _ => null,
            };
        }
    }
}