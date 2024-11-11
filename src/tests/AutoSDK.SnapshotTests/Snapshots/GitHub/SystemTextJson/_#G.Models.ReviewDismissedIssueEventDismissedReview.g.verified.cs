//HintName: G.Models.ReviewDismissedIssueEventDismissedReview.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReviewDismissedIssueEventDismissedReview
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReviewId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissal_message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? DismissalMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissal_commit_id")]
        public string? DismissalCommitId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewDismissedIssueEventDismissedReview" /> class.
        /// </summary>
        /// <param name="state"></param>
        /// <param name="reviewId"></param>
        /// <param name="dismissalMessage"></param>
        /// <param name="dismissalCommitId"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ReviewDismissedIssueEventDismissedReview(
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
        /// Initializes a new instance of the <see cref="ReviewDismissedIssueEventDismissedReview" /> class.
        /// </summary>
        public ReviewDismissedIssueEventDismissedReview()
        {
        }
    }
}