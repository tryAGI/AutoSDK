//HintName: G.Models.WebhookPullRequestReviewCommentDeletedPullRequestLinksSelf.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPullRequestReviewCommentDeletedPullRequestLinksSelf
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("href")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Href { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestReviewCommentDeletedPullRequestLinksSelf" /> class.
        /// </summary>
        /// <param name="href"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookPullRequestReviewCommentDeletedPullRequestLinksSelf(
            string href)
        {
            this.Href = href ?? throw new global::System.ArgumentNullException(nameof(href));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestReviewCommentDeletedPullRequestLinksSelf" /> class.
        /// </summary>
        public WebhookPullRequestReviewCommentDeletedPullRequestLinksSelf()
        {
        }
    }
}