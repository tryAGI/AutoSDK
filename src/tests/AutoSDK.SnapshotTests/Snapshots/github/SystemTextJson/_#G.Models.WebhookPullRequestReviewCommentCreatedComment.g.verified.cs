//HintName: G.Models.WebhookPullRequestReviewCommentCreatedComment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The [comment](https://docs.github.com/rest/pulls/comments#get-a-review-comment-for-a-pull-request) itself.
    /// </summary>
    public sealed partial class WebhookPullRequestReviewCommentCreatedComment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_links")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookPullRequestReviewCommentCreatedCommentLinks Links { get; set; }

        /// <summary>
        /// How the author is associated with the repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author_association")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookPullRequestReviewCommentCreatedCommentAuthorAssociationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookPullRequestReviewCommentCreatedCommentAuthorAssociation AuthorAssociation { get; set; }

        /// <summary>
        /// The text of the comment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Body { get; set; }

        /// <summary>
        /// The SHA of the commit to which the comment applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommitId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The diff of the line that the comment refers to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diff_hunk")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DiffHunk { get; set; }

        /// <summary>
        /// HTML URL for the pull request review comment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// The ID of the pull request review comment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The comment ID to reply to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in_reply_to_id")]
        public int? InReplyToId { get; set; }

        /// <summary>
        /// The line of the blob to which the comment applies. The last line of the range for a multi-line comment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? Line { get; set; }

        /// <summary>
        /// The node ID of the pull request review comment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// The SHA of the original commit to which the comment applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_commit_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OriginalCommitId { get; set; }

        /// <summary>
        /// The line of the blob to which the comment applies. The last line of the range for a multi-line comment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_line")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? OriginalLine { get; set; }

        /// <summary>
        /// The index of the original line in the diff to which the comment applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_position")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OriginalPosition { get; set; }

        /// <summary>
        /// The first line of the range for a multi-line comment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_start_line")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? OriginalStartLine { get; set; }

        /// <summary>
        /// The relative path of the file to which the comment applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// The line index in the diff to which the comment applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? Position { get; set; }

        /// <summary>
        /// The ID of the pull request review to which the comment belongs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_request_review_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? PullRequestReviewId { get; set; }

        /// <summary>
        /// URL for the pull request that the review comment belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_request_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PullRequestUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reactions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookPullRequestReviewCommentCreatedCommentReactions Reactions { get; set; }

        /// <summary>
        /// The side of the first line of the range for a multi-line comment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("side")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookPullRequestReviewCommentCreatedCommentSideJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookPullRequestReviewCommentCreatedCommentSide Side { get; set; }

        /// <summary>
        /// The first line of the range for a multi-line comment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_line")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? StartLine { get; set; }

        /// <summary>
        /// The side of the first line of the range for a multi-line comment.<br/>
        /// Default Value: RIGHT
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_side")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookPullRequestReviewCommentCreatedCommentStartSideJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookPullRequestReviewCommentCreatedCommentStartSide? StartSide { get; set; }

        /// <summary>
        /// The level at which the comment is targeted, can be a diff line or a file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookPullRequestReviewCommentCreatedCommentSubjectTypeJsonConverter))]
        public global::G.WebhookPullRequestReviewCommentCreatedCommentSubjectType? SubjectType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// URL for the pull request review comment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookPullRequestReviewCommentCreatedCommentUser? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestReviewCommentCreatedComment" /> class.
        /// </summary>
        /// <param name="links"></param>
        /// <param name="authorAssociation">
        /// How the author is associated with the repository.
        /// </param>
        /// <param name="body">
        /// The text of the comment.
        /// </param>
        /// <param name="commitId">
        /// The SHA of the commit to which the comment applies.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="diffHunk">
        /// The diff of the line that the comment refers to.
        /// </param>
        /// <param name="htmlUrl">
        /// HTML URL for the pull request review comment.
        /// </param>
        /// <param name="id">
        /// The ID of the pull request review comment.
        /// </param>
        /// <param name="inReplyToId">
        /// The comment ID to reply to.
        /// </param>
        /// <param name="line">
        /// The line of the blob to which the comment applies. The last line of the range for a multi-line comment
        /// </param>
        /// <param name="nodeId">
        /// The node ID of the pull request review comment.
        /// </param>
        /// <param name="originalCommitId">
        /// The SHA of the original commit to which the comment applies.
        /// </param>
        /// <param name="originalLine">
        /// The line of the blob to which the comment applies. The last line of the range for a multi-line comment
        /// </param>
        /// <param name="originalPosition">
        /// The index of the original line in the diff to which the comment applies.
        /// </param>
        /// <param name="originalStartLine">
        /// The first line of the range for a multi-line comment.
        /// </param>
        /// <param name="path">
        /// The relative path of the file to which the comment applies.
        /// </param>
        /// <param name="position">
        /// The line index in the diff to which the comment applies.
        /// </param>
        /// <param name="pullRequestReviewId">
        /// The ID of the pull request review to which the comment belongs.
        /// </param>
        /// <param name="pullRequestUrl">
        /// URL for the pull request that the review comment belongs to.
        /// </param>
        /// <param name="reactions"></param>
        /// <param name="side">
        /// The side of the first line of the range for a multi-line comment.
        /// </param>
        /// <param name="startLine">
        /// The first line of the range for a multi-line comment.
        /// </param>
        /// <param name="startSide">
        /// The side of the first line of the range for a multi-line comment.<br/>
        /// Default Value: RIGHT
        /// </param>
        /// <param name="subjectType">
        /// The level at which the comment is targeted, can be a diff line or a file.
        /// </param>
        /// <param name="updatedAt"></param>
        /// <param name="url">
        /// URL for the pull request review comment
        /// </param>
        /// <param name="user"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookPullRequestReviewCommentCreatedComment(
            global::G.WebhookPullRequestReviewCommentCreatedCommentLinks links,
            global::G.WebhookPullRequestReviewCommentCreatedCommentAuthorAssociation authorAssociation,
            string body,
            string commitId,
            global::System.DateTime createdAt,
            string diffHunk,
            string htmlUrl,
            int id,
            int? line,
            string nodeId,
            string originalCommitId,
            int? originalLine,
            int originalPosition,
            int? originalStartLine,
            string path,
            int? position,
            int? pullRequestReviewId,
            string pullRequestUrl,
            global::G.WebhookPullRequestReviewCommentCreatedCommentReactions reactions,
            global::G.WebhookPullRequestReviewCommentCreatedCommentSide side,
            int? startLine,
            global::G.WebhookPullRequestReviewCommentCreatedCommentStartSide? startSide,
            global::System.DateTime updatedAt,
            string url,
            global::G.WebhookPullRequestReviewCommentCreatedCommentUser? user,
            int? inReplyToId,
            global::G.WebhookPullRequestReviewCommentCreatedCommentSubjectType? subjectType)
        {
            this.Links = links ?? throw new global::System.ArgumentNullException(nameof(links));
            this.AuthorAssociation = authorAssociation;
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.CommitId = commitId ?? throw new global::System.ArgumentNullException(nameof(commitId));
            this.CreatedAt = createdAt;
            this.DiffHunk = diffHunk ?? throw new global::System.ArgumentNullException(nameof(diffHunk));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Id = id;
            this.Line = line;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.OriginalCommitId = originalCommitId ?? throw new global::System.ArgumentNullException(nameof(originalCommitId));
            this.OriginalLine = originalLine;
            this.OriginalPosition = originalPosition;
            this.OriginalStartLine = originalStartLine;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Position = position;
            this.PullRequestReviewId = pullRequestReviewId;
            this.PullRequestUrl = pullRequestUrl ?? throw new global::System.ArgumentNullException(nameof(pullRequestUrl));
            this.Reactions = reactions ?? throw new global::System.ArgumentNullException(nameof(reactions));
            this.Side = side;
            this.StartLine = startLine;
            this.StartSide = startSide;
            this.UpdatedAt = updatedAt;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.InReplyToId = inReplyToId;
            this.SubjectType = subjectType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestReviewCommentCreatedComment" /> class.
        /// </summary>
        public WebhookPullRequestReviewCommentCreatedComment()
        {
        }
    }
}