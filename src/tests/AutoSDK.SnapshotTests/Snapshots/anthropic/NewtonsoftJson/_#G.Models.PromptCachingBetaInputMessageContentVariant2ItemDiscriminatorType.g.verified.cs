//HintName: G.Models.PromptCachingBetaInputMessageContentVariant2ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptCachingBetaInputMessageContentVariant2ItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image")]
        Image,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_result")]
        ToolResult,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_use")]
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