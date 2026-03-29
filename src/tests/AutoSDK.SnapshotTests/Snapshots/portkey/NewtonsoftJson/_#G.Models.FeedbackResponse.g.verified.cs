//HintName: G.Models.FeedbackResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedbackResponse
    {
        /// <summary>
        /// success or failure
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Confirmation message indicating successful feedback submission.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Ids of Feedbacks created returned in the same order as input
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback_ids")]
        public global::System.Collections.Generic.IList<string>? FeedbackIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// success or failure
        /// </param>
        /// <param name="message">
        /// Confirmation message indicating successful feedback submission.
        /// </param>
        /// <param name="feedbackIds">
        /// Ids of Feedbacks created returned in the same order as input
        /// </param>
        public FeedbackResponse(
            string? status,
            string? message,
            global::System.Collections.Generic.IList<string>? feedbackIds)
        {
            this.Status = status;
            this.Message = message;
            this.FeedbackIds = feedbackIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackResponse" /> class.
        /// </summary>
        public FeedbackResponse()
        {
        }
    }
}