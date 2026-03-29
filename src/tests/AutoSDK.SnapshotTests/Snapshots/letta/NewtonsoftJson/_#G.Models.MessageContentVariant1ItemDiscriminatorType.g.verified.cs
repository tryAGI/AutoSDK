//HintName: G.Models.MessageContentVariant1ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageContentVariant1ItemDiscriminatorType
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
    public static class MessageContentVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageContentVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                MessageContentVariant1ItemDiscriminatorType.Image => "image",
                MessageContentVariant1ItemDiscriminatorType.OmittedReasoning => "omitted_reasoning",
                MessageContentVariant1ItemDiscriminatorType.Reasoning => "reasoning",
                MessageContentVariant1ItemDiscriminatorType.RedactedReasoning => "redacted_reasoning",
                MessageContentVariant1ItemDiscriminatorType.SummarizedReasoning => "summarized_reasoning",
                MessageContentVariant1ItemDiscriminatorType.Text => "text",
                MessageContentVariant1ItemDiscriminatorType.ToolCall => "tool_call",
                MessageContentVariant1ItemDiscriminatorType.ToolReturn => "tool_return",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageContentVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image" => MessageContentVariant1ItemDiscriminatorType.Image,
                "omitted_reasoning" => MessageContentVariant1ItemDiscriminatorType.OmittedReasoning,
                "reasoning" => MessageContentVariant1ItemDiscriminatorType.Reasoning,
                "redacted_reasoning" => MessageContentVariant1ItemDiscriminatorType.RedactedReasoning,
                "summarized_reasoning" => MessageContentVariant1ItemDiscriminatorType.SummarizedReasoning,
                "text" => MessageContentVariant1ItemDiscriminatorType.Text,
                "tool_call" => MessageContentVariant1ItemDiscriminatorType.ToolCall,
                "tool_return" => MessageContentVariant1ItemDiscriminatorType.ToolReturn,
                _ => null,
            };
        }
    }
}