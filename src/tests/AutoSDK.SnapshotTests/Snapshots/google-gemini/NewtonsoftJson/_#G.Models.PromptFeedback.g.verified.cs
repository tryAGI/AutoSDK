﻿//HintName: G.Models.PromptFeedback.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A set of the feedback metadata the prompt specified in `GenerateContentRequest.content`.
    /// </summary>
    public sealed partial class PromptFeedback
    {
        /// <summary>
        /// Ratings for safety of the prompt. There is at most one rating per category.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("safetyRatings")]
        public global::System.Collections.Generic.IList<global::G.SafetyRating>? SafetyRatings { get; set; }

        /// <summary>
        /// Optional. If set, the prompt was blocked and no candidates are returned. Rephrase your prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("blockReason")]
        public global::G.PromptFeedbackBlockReason? BlockReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptFeedback" /> class.
        /// </summary>
        /// <param name="safetyRatings">
        /// Ratings for safety of the prompt. There is at most one rating per category.
        /// </param>
        /// <param name="blockReason">
        /// Optional. If set, the prompt was blocked and no candidates are returned. Rephrase your prompt.
        /// </param>
        public PromptFeedback(
            global::System.Collections.Generic.IList<global::G.SafetyRating>? safetyRatings,
            global::G.PromptFeedbackBlockReason? blockReason)
        {
            this.SafetyRatings = safetyRatings;
            this.BlockReason = blockReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptFeedback" /> class.
        /// </summary>
        public PromptFeedback()
        {
        }
    }
}