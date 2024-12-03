//HintName: G.Models.IssueEventDismissedReview.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IssueEventDismissedReview
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public string State { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("review_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int ReviewId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dismissal_message", Required = global::Newtonsoft.Json.Required.Always)]
        public string? DismissalMessage { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dismissal_commit_id")]
        public string? DismissalCommitId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueEventDismissedReview" /> class.
        /// </summary>
        /// <param name="state"></param>
        /// <param name="reviewId"></param>
        /// <param name="dismissalMessage"></param>
        /// <param name="dismissalCommitId"></param>
        public IssueEventDismissedReview(
            string state,
            int reviewId,
            string? dismissalMessage,
            string? dismissalCommitId)
        {
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
            this.ReviewId = reviewId;
            this.DismissalMessage = dismissalMessage ?? throw new global::System.ArgumentNullException(nameof(dismissalMessage));
            this.DismissalCommitId = dismissalCommitId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueEventDismissedReview" /> class.
        /// </summary>
        public IssueEventDismissedReview()
        {
        }
    }
}