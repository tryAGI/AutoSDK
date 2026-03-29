//HintName: G.Models.LettaStreamingRequestInputVariant2ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LettaStreamingRequestInputVariant2ItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image")]
        Image,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="omitted_reasoning")]
        OmittedReasoning,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reasoning")]
        Reasoning,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="redacted_reasoning")]
        RedactedReasoning,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="summarized_reasoning")]
        SummarizedReasoning,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_call")]
        ToolCall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_return")]
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