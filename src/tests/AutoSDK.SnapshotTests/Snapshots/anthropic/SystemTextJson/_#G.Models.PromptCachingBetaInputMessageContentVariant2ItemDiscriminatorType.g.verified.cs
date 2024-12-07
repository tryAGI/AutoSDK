//HintName: G.Models.PromptCachingBetaInputMessageContentVariant2ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptCachingBetaInputMessageContentVariant2ItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        ToolResult,
        /// <summary>
        /// 
        /// </summary>
        ToolUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptCachingBetaInputMessageContentVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptCachingBetaInputMessageContentVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                PromptCachingBetaInputMessageContentVariant2ItemDiscriminatorType.Image => "image",
                PromptCachingBetaInputMessageContentVariant2ItemDiscriminatorType.Text => "text",
                PromptCachingBetaInputMessageContentVariant2ItemDiscriminatorType.ToolResult => "tool_result",
                PromptCachingBetaInputMessageContentVariant2ItemDiscriminatorType.ToolUse => "tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptCachingBetaInputMessageContentVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image" => PromptCachingBetaInputMessageContentVariant2ItemDiscriminatorType.Image,
                "text" => PromptCachingBetaInputMessageContentVariant2ItemDiscriminatorType.Text,
                "tool_result" => PromptCachingBetaInputMessageContentVariant2ItemDiscriminatorType.ToolResult,
                "tool_use" => PromptCachingBetaInputMessageContentVariant2ItemDiscriminatorType.ToolUse,
                _ => null,
            };
        }
    }
}