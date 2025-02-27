//HintName: G.Models.BetaContentBlockDeltaEventDeltaDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaContentBlockDeltaEventDeltaDiscriminatorType
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
    public static class BetaContentBlockDeltaEventDeltaDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaContentBlockDeltaEventDeltaDiscriminatorType value)
        {
            return value switch
            {
                BetaContentBlockDeltaEventDeltaDiscriminatorType.CitationsDelta => "citations_delta",
                BetaContentBlockDeltaEventDeltaDiscriminatorType.InputJsonDelta => "input_json_delta",
                BetaContentBlockDeltaEventDeltaDiscriminatorType.SignatureDelta => "signature_delta",
                BetaContentBlockDeltaEventDeltaDiscriminatorType.TextDelta => "text_delta",
                BetaContentBlockDeltaEventDeltaDiscriminatorType.ThinkingDelta => "thinking_delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaContentBlockDeltaEventDeltaDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "citations_delta" => BetaContentBlockDeltaEventDeltaDiscriminatorType.CitationsDelta,
                "input_json_delta" => BetaContentBlockDeltaEventDeltaDiscriminatorType.InputJsonDelta,
                "signature_delta" => BetaContentBlockDeltaEventDeltaDiscriminatorType.SignatureDelta,
                "text_delta" => BetaContentBlockDeltaEventDeltaDiscriminatorType.TextDelta,
                "thinking_delta" => BetaContentBlockDeltaEventDeltaDiscriminatorType.ThinkingDelta,
                _ => null,
            };
        }
    }
}