//HintName: G.Models.ConversationMessageRequestInputVariant2ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConversationMessageRequestInputVariant2ItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        OmittedReasoning,
        /// <summary>
        /// 
        /// </summary>
        Reasoning,
        /// <summary>
        /// 
        /// </summary>
        RedactedReasoning,
        /// <summary>
        /// 
        /// </summary>
        SummarizedReasoning,
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
        ToolReturn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationMessageRequestInputVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationMessageRequestInputVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                ConversationMessageRequestInputVariant2ItemDiscriminatorType.Image => "image",
                ConversationMessageRequestInputVariant2ItemDiscriminatorType.OmittedReasoning => "omitted_reasoning",
                ConversationMessageRequestInputVariant2ItemDiscriminatorType.Reasoning => "reasoning",
                ConversationMessageRequestInputVariant2ItemDiscriminatorType.RedactedReasoning => "redacted_reasoning",
                ConversationMessageRequestInputVariant2ItemDiscriminatorType.SummarizedReasoning => "summarized_reasoning",
                ConversationMessageRequestInputVariant2ItemDiscriminatorType.Text => "text",
                ConversationMessageRequestInputVariant2ItemDiscriminatorType.ToolCall => "tool_call",
                ConversationMessageRequestInputVariant2ItemDiscriminatorType.ToolReturn => "tool_return",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationMessageRequestInputVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image" => ConversationMessageRequestInputVariant2ItemDiscriminatorType.Image,
                "omitted_reasoning" => ConversationMessageRequestInputVariant2ItemDiscriminatorType.OmittedReasoning,
                "reasoning" => ConversationMessageRequestInputVariant2ItemDiscriminatorType.Reasoning,
                "redacted_reasoning" => ConversationMessageRequestInputVariant2ItemDiscriminatorType.RedactedReasoning,
                "summarized_reasoning" => ConversationMessageRequestInputVariant2ItemDiscriminatorType.SummarizedReasoning,
                "text" => ConversationMessageRequestInputVariant2ItemDiscriminatorType.Text,
                "tool_call" => ConversationMessageRequestInputVariant2ItemDiscriminatorType.ToolCall,
                "tool_return" => ConversationMessageRequestInputVariant2ItemDiscriminatorType.ToolReturn,
                _ => null,
            };
        }
    }
}