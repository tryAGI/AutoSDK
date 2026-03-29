//HintName: G.Models.LettaRequestInputVariant2ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LettaRequestInputVariant2ItemDiscriminatorType
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