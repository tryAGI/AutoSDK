//HintName: G.Models.LettaStreamingRequestInputVariant2ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LettaStreamingRequestInputVariant2ItemDiscriminatorType
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
    public static class LettaStreamingRequestInputVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LettaStreamingRequestInputVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                LettaStreamingRequestInputVariant2ItemDiscriminatorType.Image => "image",
                LettaStreamingRequestInputVariant2ItemDiscriminatorType.OmittedReasoning => "omitted_reasoning",
                LettaStreamingRequestInputVariant2ItemDiscriminatorType.Reasoning => "reasoning",
                LettaStreamingRequestInputVariant2ItemDiscriminatorType.RedactedReasoning => "redacted_reasoning",
                LettaStreamingRequestInputVariant2ItemDiscriminatorType.SummarizedReasoning => "summarized_reasoning",
                LettaStreamingRequestInputVariant2ItemDiscriminatorType.Text => "text",
                LettaStreamingRequestInputVariant2ItemDiscriminatorType.ToolCall => "tool_call",
                LettaStreamingRequestInputVariant2ItemDiscriminatorType.ToolReturn => "tool_return",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LettaStreamingRequestInputVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image" => LettaStreamingRequestInputVariant2ItemDiscriminatorType.Image,
                "omitted_reasoning" => LettaStreamingRequestInputVariant2ItemDiscriminatorType.OmittedReasoning,
                "reasoning" => LettaStreamingRequestInputVariant2ItemDiscriminatorType.Reasoning,
                "redacted_reasoning" => LettaStreamingRequestInputVariant2ItemDiscriminatorType.RedactedReasoning,
                "summarized_reasoning" => LettaStreamingRequestInputVariant2ItemDiscriminatorType.SummarizedReasoning,
                "text" => LettaStreamingRequestInputVariant2ItemDiscriminatorType.Text,
                "tool_call" => LettaStreamingRequestInputVariant2ItemDiscriminatorType.ToolCall,
                "tool_return" => LettaStreamingRequestInputVariant2ItemDiscriminatorType.ToolReturn,
                _ => null,
            };
        }
    }
}