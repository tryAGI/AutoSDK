//HintName: G.Models.PullRequestLinks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PullRequestLinks
    {
        /// <summary>
        /// Hypermedia Link
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Link Comments { get; set; }

        /// <summary>
        /// Hypermedia Link
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Link Commits { get; set; }

        /// <summary>
        /// Hypermedia Link
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Link Statuses { get; set; }

        /// <summary>
        /// Hypermedia Link
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Link Html { get; set; }

        /// <summary>
        /// Hypermedia Link
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Link Issue { get; set; }

        /// <summary>
        /// Hypermedia Link
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_comments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Link ReviewComments { get; set; }

        /// <summary>
        /// Hypermedia Link
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_comment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Link ReviewComment { get; set; }

        /// <summary>
        /// Hypermedia Link
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Link Self { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestLinks" /> class.
        /// </summary>
        /// <param name="comments">
        /// Hypermedia Link
        /// </param>
        /// <param name="commits">
        /// Hypermedia Link
        /// </param>
        /// <param name="statuses">
        /// Hypermedia Link
        /// </param>
        /// <param name="html">
        /// Hypermedia Link
        /// </param>
        /// <param name="issue">
        /// Hypermedia Link
        /// </param>
        /// <param name="reviewComments">
        /// Hypermedia Link
        /// </param>
        /// <param name="reviewComment">
        /// Hypermedia Link
        /// </param>
        /// <param name="self">
        /// Hypermedia Link
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PullRequestLinks(
            global::G.Link comments,
            global::G.Link commits,
            global::G.Link statuses,
            global::G.Link html,
            global::G.Link issue,
            global::G.Link reviewComments,
            global::G.Link reviewComment,
            global::G.Link self)
        {
            this.Comments = comments ?? throw new global::System.ArgumentNullException(nameof(comments));
            this.Commits = commits ?? throw new global::System.ArgumentNullException(nameof(commits));
            this.Statuses = statuses ?? throw new global::System.ArgumentNullException(nameof(statuses));
            this.Html = html ?? throw new global::System.ArgumentNullException(nameof(html));
            this.Issue = issue ?? throw new global::System.ArgumentNullException(nameof(issue));
            this.ReviewComments = reviewComments ?? throw new global::System.ArgumentNullException(nameof(reviewComments));
            this.ReviewComment = reviewComment ?? throw new global::System.ArgumentNullException(nameof(reviewComment));
            this.Self = self ?? throw new global::System.ArgumentNullException(nameof(self));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestLinks" /> class.
        /// </summary>
        public PullRequestLinks()
        {
        }
    }
}