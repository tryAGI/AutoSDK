//HintName: G.Models.PromptMessageContentVariant2ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptMessageContentVariant2ItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        ToolCall,
        /// <summary>
        /// 
        /// </summary>
        ToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptMessageContentVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptMessageContentVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                PromptMessageContentVariant2ItemDiscriminatorType.Text => "text",
                PromptMessageContentVariant2ItemDiscriminatorType.ToolCall => "tool_call",
                PromptMessageContentVariant2ItemDiscriminatorType.ToolResult => "tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptMessageContentVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "text" => PromptMessageContentVariant2ItemDiscriminatorType.Text,
                "tool_call" => PromptMessageContentVariant2ItemDiscriminatorType.ToolCall,
                "tool_result" => PromptMessageContentVariant2ItemDiscriminatorType.ToolResult,
                _ => null,
            };
        }
    }
}