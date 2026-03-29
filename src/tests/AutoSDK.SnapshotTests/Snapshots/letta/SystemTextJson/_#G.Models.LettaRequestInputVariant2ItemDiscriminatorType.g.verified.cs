//HintName: G.Models.LettaRequestInputVariant2ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LettaRequestInputVariant2ItemDiscriminatorType
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
    public static class LettaRequestInputVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LettaRequestInputVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                LettaRequestInputVariant2ItemDiscriminatorType.Image => "image",
                LettaRequestInputVariant2ItemDiscriminatorType.OmittedReasoning => "omitted_reasoning",
                LettaRequestInputVariant2ItemDiscriminatorType.Reasoning => "reasoning",
                LettaRequestInputVariant2ItemDiscriminatorType.RedactedReasoning => "redacted_reasoning",
                LettaRequestInputVariant2ItemDiscriminatorType.SummarizedReasoning => "summarized_reasoning",
                LettaRequestInputVariant2ItemDiscriminatorType.Text => "text",
                LettaRequestInputVariant2ItemDiscriminatorType.ToolCall => "tool_call",
                LettaRequestInputVariant2ItemDiscriminatorType.ToolReturn => "tool_return",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LettaRequestInputVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image" => LettaRequestInputVariant2ItemDiscriminatorType.Image,
                "omitted_reasoning" => LettaRequestInputVariant2ItemDiscriminatorType.OmittedReasoning,
                "reasoning" => LettaRequestInputVariant2ItemDiscriminatorType.Reasoning,
                "redacted_reasoning" => LettaRequestInputVariant2ItemDiscriminatorType.RedactedReasoning,
                "summarized_reasoning" => LettaRequestInputVariant2ItemDiscriminatorType.SummarizedReasoning,
                "text" => LettaRequestInputVariant2ItemDiscriminatorType.Text,
                "tool_call" => LettaRequestInputVariant2ItemDiscriminatorType.ToolCall,
                "tool_return" => LettaRequestInputVariant2ItemDiscriminatorType.ToolReturn,
                _ => null,
            };
        }
    }
}