//HintName: G.Models.LettaAsyncRequestInputVariant2ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LettaAsyncRequestInputVariant2ItemDiscriminatorType
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
    public static class LettaAsyncRequestInputVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LettaAsyncRequestInputVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                LettaAsyncRequestInputVariant2ItemDiscriminatorType.Image => "image",
                LettaAsyncRequestInputVariant2ItemDiscriminatorType.OmittedReasoning => "omitted_reasoning",
                LettaAsyncRequestInputVariant2ItemDiscriminatorType.Reasoning => "reasoning",
                LettaAsyncRequestInputVariant2ItemDiscriminatorType.RedactedReasoning => "redacted_reasoning",
                LettaAsyncRequestInputVariant2ItemDiscriminatorType.SummarizedReasoning => "summarized_reasoning",
                LettaAsyncRequestInputVariant2ItemDiscriminatorType.Text => "text",
                LettaAsyncRequestInputVariant2ItemDiscriminatorType.ToolCall => "tool_call",
                LettaAsyncRequestInputVariant2ItemDiscriminatorType.ToolReturn => "tool_return",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LettaAsyncRequestInputVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image" => LettaAsyncRequestInputVariant2ItemDiscriminatorType.Image,
                "omitted_reasoning" => LettaAsyncRequestInputVariant2ItemDiscriminatorType.OmittedReasoning,
                "reasoning" => LettaAsyncRequestInputVariant2ItemDiscriminatorType.Reasoning,
                "redacted_reasoning" => LettaAsyncRequestInputVariant2ItemDiscriminatorType.RedactedReasoning,
                "summarized_reasoning" => LettaAsyncRequestInputVariant2ItemDiscriminatorType.SummarizedReasoning,
                "text" => LettaAsyncRequestInputVariant2ItemDiscriminatorType.Text,
                "tool_call" => LettaAsyncRequestInputVariant2ItemDiscriminatorType.ToolCall,
                "tool_return" => LettaAsyncRequestInputVariant2ItemDiscriminatorType.ToolReturn,
                _ => null,
            };
        }
    }
}