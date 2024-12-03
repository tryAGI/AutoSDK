//HintName: G.Models.SessionFeedbackDelta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// List of feedback keys with number of improvements and regressions for each.
    /// </summary>
    public sealed partial class SessionFeedbackDelta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_deltas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::G.FeedbackDelta> FeedbackDeltas { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionFeedbackDelta" /> class.
        /// </summary>
        /// <param name="feedbackDeltas"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SessionFeedbackDelta(
            global::System.Collections.Generic.Dictionary<string, global::G.FeedbackDelta> feedbackDeltas)
        {
            this.FeedbackDeltas = feedbackDeltas ?? throw new global::System.ArgumentNullException(nameof(feedbackDeltas));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionFeedbackDelta" /> class.
        /// </summary>
        public SessionFeedbackDelta()
        {
        }
    }
}