//HintName: G.Models.PromptCachingBetaRequestToolResultBlockType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptCachingBetaRequestToolResultBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptCachingBetaRequestToolResultBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptCachingBetaRequestToolResultBlockType value)
        {
            return value switch
            {
                PromptCachingBetaRequestToolResultBlockType.ToolResult => "tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptCachingBetaRequestToolResultBlockType? ToEnum(string value)
        {
            return value switch
            {
                "tool_result" => PromptCachingBetaRequestToolResultBlockType.ToolResult,
                _ => null,
            };
        }
    }
}