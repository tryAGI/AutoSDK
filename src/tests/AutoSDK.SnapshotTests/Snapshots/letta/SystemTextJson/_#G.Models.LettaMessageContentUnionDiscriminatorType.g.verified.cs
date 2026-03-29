//HintName: G.Models.LettaMessageContentUnionDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LettaMessageContentUnionDiscriminatorType
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