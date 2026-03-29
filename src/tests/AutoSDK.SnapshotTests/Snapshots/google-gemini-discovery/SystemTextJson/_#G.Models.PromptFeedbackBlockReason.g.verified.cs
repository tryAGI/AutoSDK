//HintName: G.Models.PromptFeedbackBlockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Optional. If set, the prompt was blocked and no candidates are returned. Rephrase the prompt.
    /// </summary>
    public enum PromptFeedbackBlockReason
    {
        /// <summary>
        /// Prompt was blocked due to the terms which are included from the terminology blocklist.
        /// </summary>
        Blocklist,
        /// <summary>
        /// Default value. This value is unused.
        /// </summary>
        BlockReasonUnspecified,
        /// <summary>
        /// Candidates blocked due to unsafe image generation content.
        /// </summary>
        ImageSafety,
        /// <summary>
        /// Prompt was blocked due to unknown reasons.
        /// </summary>
        Other,
        /// <summary>
        /// Prompt was blocked due to prohibited content.
        /// </summary>
        ProhibitedContent,
        /// <summary>
        /// Prompt was blocked due to safety reasons. Inspect `safety_ratings` to understand which safety category blocked it.
        /// </summary>
        Safety,
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
                PromptFeedbackBlockReason.Blocklist => "BLOCKLIST",
                PromptFeedbackBlockReason.BlockReasonUnspecified => "BLOCK_REASON_UNSPECIFIED",
                PromptFeedbackBlockReason.ImageSafety => "IMAGE_SAFETY",
                PromptFeedbackBlockReason.Other => "OTHER",
                PromptFeedbackBlockReason.ProhibitedContent => "PROHIBITED_CONTENT",
                PromptFeedbackBlockReason.Safety => "SAFETY",
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
                "BLOCKLIST" => PromptFeedbackBlockReason.Blocklist,
                "BLOCK_REASON_UNSPECIFIED" => PromptFeedbackBlockReason.BlockReasonUnspecified,
                "IMAGE_SAFETY" => PromptFeedbackBlockReason.ImageSafety,
                "OTHER" => PromptFeedbackBlockReason.Other,
                "PROHIBITED_CONTENT" => PromptFeedbackBlockReason.ProhibitedContent,
                "SAFETY" => PromptFeedbackBlockReason.Safety,
                _ => null,
            };
        }
    }
}