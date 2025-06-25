//HintName: G.Models.BetaRequestToolResultBlockType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestToolResultBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestToolResultBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestToolResultBlockType value)
        {
            return value switch
            {
                BetaRequestToolResultBlockType.ToolResult => "tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestToolResultBlockType? ToEnum(string value)
        {
            return value switch
            {
                "tool_result" => BetaRequestToolResultBlockType.ToolResult,
                _ => null,
            };
        }
    }
}