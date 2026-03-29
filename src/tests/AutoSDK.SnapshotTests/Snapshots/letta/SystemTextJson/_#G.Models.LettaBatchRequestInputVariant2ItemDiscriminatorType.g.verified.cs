//HintName: G.Models.LettaBatchRequestInputVariant2ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LettaBatchRequestInputVariant2ItemDiscriminatorType
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
    public static class LettaBatchRequestInputVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LettaBatchRequestInputVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                LettaBatchRequestInputVariant2ItemDiscriminatorType.Image => "image",
                LettaBatchRequestInputVariant2ItemDiscriminatorType.OmittedReasoning => "omitted_reasoning",
                LettaBatchRequestInputVariant2ItemDiscriminatorType.Reasoning => "reasoning",
                LettaBatchRequestInputVariant2ItemDiscriminatorType.RedactedReasoning => "redacted_reasoning",
                LettaBatchRequestInputVariant2ItemDiscriminatorType.SummarizedReasoning => "summarized_reasoning",
                LettaBatchRequestInputVariant2ItemDiscriminatorType.Text => "text",
                LettaBatchRequestInputVariant2ItemDiscriminatorType.ToolCall => "tool_call",
                LettaBatchRequestInputVariant2ItemDiscriminatorType.ToolReturn => "tool_return",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LettaBatchRequestInputVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image" => LettaBatchRequestInputVariant2ItemDiscriminatorType.Image,
                "omitted_reasoning" => LettaBatchRequestInputVariant2ItemDiscriminatorType.OmittedReasoning,
                "reasoning" => LettaBatchRequestInputVariant2ItemDiscriminatorType.Reasoning,
                "redacted_reasoning" => LettaBatchRequestInputVariant2ItemDiscriminatorType.RedactedReasoning,
                "summarized_reasoning" => LettaBatchRequestInputVariant2ItemDiscriminatorType.SummarizedReasoning,
                "text" => LettaBatchRequestInputVariant2ItemDiscriminatorType.Text,
                "tool_call" => LettaBatchRequestInputVariant2ItemDiscriminatorType.ToolCall,
                "tool_return" => LettaBatchRequestInputVariant2ItemDiscriminatorType.ToolReturn,
                _ => null,
            };
        }
    }
}