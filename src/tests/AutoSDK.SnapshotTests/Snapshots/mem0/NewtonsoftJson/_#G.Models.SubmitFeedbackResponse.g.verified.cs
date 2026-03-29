//HintName: G.Models.SubmitFeedbackResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubmitFeedbackResponse
    {
        /// <summary>
        /// Feedback ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Type of feedback
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback")]
        public global::G.SubmitFeedbackResponseFeedback? Feedback { get; set; }

        /// <summary>
        /// Reason for the feedback
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback_reason")]
        public string? FeedbackReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitFeedbackResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Feedback ID
        /// </param>
        /// <param name="feedback">
        /// Type of feedback
        /// </param>
        /// <param name="feedbackReason">
        /// Reason for the feedback
        /// </param>
        public SubmitFeedbackResponse(
            global::System.Guid? id,
            global::G.SubmitFeedbackResponseFeedback? feedback,
            string? feedbackReason)
        {
            this.Id = id;
            this.Feedback = feedback;
            this.FeedbackReason = feedbackReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitFeedbackResponse" /> class.
        /// </summary>
        public SubmitFeedbackResponse()
        {
        }
    }
}