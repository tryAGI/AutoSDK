//HintName: G.Models.WebhookPullRequestReviewThreadUnresolvedThread.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPullRequestReviewThreadUnresolvedThread
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.WebhookPullRequestReviewThreadUnresolvedThreadComment> Comments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestReviewThreadUnresolvedThread" /> class.
        /// </summary>
        /// <param name="comments"></param>
        /// <param name="nodeId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookPullRequestReviewThreadUnresolvedThread(
            global::System.Collections.Generic.IList<global::G.WebhookPullRequestReviewThreadUnresolvedThreadComment> comments,
            string nodeId)
        {
            this.Comments = comments ?? throw new global::System.ArgumentNullException(nameof(comments));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestReviewThreadUnresolvedThread" /> class.
        /// </summary>
        public WebhookPullRequestReviewThreadUnresolvedThread()
        {
        }
    }
}