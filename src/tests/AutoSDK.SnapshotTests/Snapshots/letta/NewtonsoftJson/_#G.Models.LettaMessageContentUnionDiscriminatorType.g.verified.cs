//HintName: G.Models.LettaMessageContentUnionDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LettaMessageContentUnionDiscriminatorType
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
    public static class LettaMessageContentUnionDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LettaMessageContentUnionDiscriminatorType value)
        {
            return value switch
            {
                LettaMessageContentUnionDiscriminatorType.Image => "image",
                LettaMessageContentUnionDiscriminatorType.OmittedReasoning => "omitted_reasoning",
                LettaMessageContentUnionDiscriminatorType.Reasoning => "reasoning",
                LettaMessageContentUnionDiscriminatorType.RedactedReasoning => "redacted_reasoning",
                LettaMessageContentUnionDiscriminatorType.Text => "text",
                LettaMessageContentUnionDiscriminatorType.ToolCall => "tool_call",
                LettaMessageContentUnionDiscriminatorType.ToolReturn => "tool_return",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LettaMessageContentUnionDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image" => LettaMessageContentUnionDiscriminatorType.Image,
                "omitted_reasoning" => LettaMessageContentUnionDiscriminatorType.OmittedReasoning,
                "reasoning" => LettaMessageContentUnionDiscriminatorType.Reasoning,
                "redacted_reasoning" => LettaMessageContentUnionDiscriminatorType.RedactedReasoning,
                "text" => LettaMessageContentUnionDiscriminatorType.Text,
                "tool_call" => LettaMessageContentUnionDiscriminatorType.ToolCall,
                "tool_return" => LettaMessageContentUnionDiscriminatorType.ToolReturn,
                _ => null,
            };
        }
    }
}