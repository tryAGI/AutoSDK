//HintName: G.Models.SubmitFeedbackRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubmitFeedbackRequest
    {
        /// <summary>
        /// ID of the memory to provide feedback for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MemoryId { get; set; }

        /// <summary>
        /// Type of feedback
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SubmitFeedbackRequestFeedbackJsonConverter))]
        public global::G.SubmitFeedbackRequestFeedback? Feedback { get; set; }

        /// <summary>
        /// Reason for the feedback
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_reason")]
        public string? FeedbackReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitFeedbackRequest" /> class.
        /// </summary>
        /// <param name="memoryId">
        /// ID of the memory to provide feedback for
        /// </param>
        /// <param name="feedback">
        /// Type of feedback
        /// </param>
        /// <param name="feedbackReason">
        /// Reason for the feedback
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitFeedbackRequest(
            string memoryId,
            global::G.SubmitFeedbackRequestFeedback? feedback,
            string? feedbackReason)
        {
            this.MemoryId = memoryId ?? throw new global::System.ArgumentNullException(nameof(memoryId));
            this.Feedback = feedback;
            this.FeedbackReason = feedbackReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitFeedbackRequest" /> class.
        /// </summary>
        public SubmitFeedbackRequest()
        {
        }
    }
}