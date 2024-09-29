//HintName: G.Models.PromptFeedbackBlockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Optional. If set, the prompt was blocked and no candidates are returned. Rephrase your prompt.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptFeedbackBlockReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BLOCK_REASON_UNSPECIFIED")]
        BLOCKREASONUNSPECIFIED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SAFETY")]
        SAFETY,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OTHER")]
        OTHER,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptFeedbackBlockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptFeedbackBlockReason value)
        {
            return value switch
            {
                PromptFeedbackBlockReason.BLOCKREASONUNSPECIFIED => "BLOCK_REASON_UNSPECIFIED",
                PromptFeedbackBlockReason.SAFETY => "SAFETY",
                PromptFeedbackBlockReason.OTHER => "OTHER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptFeedbackBlockReason? ToEnum(string value)
        {
            return value switch
            {
                "BLOCK_REASON_UNSPECIFIED" => PromptFeedbackBlockReason.BLOCKREASONUNSPECIFIED,
                "SAFETY" => PromptFeedbackBlockReason.SAFETY,
                "OTHER" => PromptFeedbackBlockReason.OTHER,
                _ => null,
            };
        }
    }
}