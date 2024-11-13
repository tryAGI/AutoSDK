//HintName: G.Models.WebhookStatusCommitCommit.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookStatusCommitCommit
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AllOfJsonConverter<global::G.WebhookStatusCommitCommitAuthorVariant1, global::G.WebhookStatusCommitCommitAuthorVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AllOf<global::G.WebhookStatusCommitCommitAuthorVariant1, global::G.WebhookStatusCommitCommitAuthorVariant2> Author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CommentCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("committer")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AllOfJsonConverter<global::G.WebhookStatusCommitCommitCommitterVariant1, global::G.WebhookStatusCommitCommitCommitterVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AllOf<global::G.WebhookStatusCommitCommitCommitterVariant1, global::G.WebhookStatusCommitCommitCommitterVariant2> Committer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tree")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookStatusCommitCommitTree Tree { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verification")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookStatusCommitCommitVerification Verification { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookStatusCommitCommit" /> class.
        /// </summary>
        /// <param name="author"></param>
        /// <param name="commentCount"></param>
        /// <param name="committer"></param>
        /// <param name="message"></param>
        /// <param name="tree"></param>
        /// <param name="url"></param>
        /// <param name="verification"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookStatusCommitCommit(
            global::G.AllOf<global::G.WebhookStatusCommitCommitAuthorVariant1, global::G.WebhookStatusCommitCommitAuthorVariant2> author,
            int commentCount,
            global::G.AllOf<global::G.WebhookStatusCommitCommitCommitterVariant1, global::G.WebhookStatusCommitCommitCommitterVariant2> committer,
            string message,
            global::G.WebhookStatusCommitCommitTree tree,
            string url,
            global::G.WebhookStatusCommitCommitVerification verification)
        {
            this.Author = author;
            this.CommentCount = commentCount;
            this.Committer = committer;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Tree = tree ?? throw new global::System.ArgumentNullException(nameof(tree));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Verification = verification ?? throw new global::System.ArgumentNullException(nameof(verification));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookStatusCommitCommit" /> class.
        /// </summary>
        public WebhookStatusCommitCommit()
        {
        }
    }
}