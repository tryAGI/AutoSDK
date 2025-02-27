//HintName: G.Models.ContentBlockDeltaEventDeltaDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ContentBlockDeltaEventDeltaDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="citations_delta")]
        CitationsDelta,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="input_json_delta")]
        InputJsonDelta,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="signature_delta")]
        SignatureDelta,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text_delta")]
        TextDelta,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thinking_delta")]
        ThinkingDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentBlockDeltaEventDeltaDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentBlockDeltaEventDeltaDiscriminatorType value)
        {
            return value switch
            {
                ContentBlockDeltaEventDeltaDiscriminatorType.CitationsDelta => "citations_delta",
                ContentBlockDeltaEventDeltaDiscriminatorType.InputJsonDelta => "input_json_delta",
                ContentBlockDeltaEventDeltaDiscriminatorType.SignatureDelta => "signature_delta",
                ContentBlockDeltaEventDeltaDiscriminatorType.TextDelta => "text_delta",
                ContentBlockDeltaEventDeltaDiscriminatorType.ThinkingDelta => "thinking_delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentBlockDeltaEventDeltaDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "citations_delta" => ContentBlockDeltaEventDeltaDiscriminatorType.CitationsDelta,
                "input_json_delta" => ContentBlockDeltaEventDeltaDiscriminatorType.InputJsonDelta,
                "signature_delta" => ContentBlockDeltaEventDeltaDiscriminatorType.SignatureDelta,
                "text_delta" => ContentBlockDeltaEventDeltaDiscriminatorType.TextDelta,
                "thinking_delta" => ContentBlockDeltaEventDeltaDiscriminatorType.ThinkingDelta,
                _ => null,
            };
        }
    }
}