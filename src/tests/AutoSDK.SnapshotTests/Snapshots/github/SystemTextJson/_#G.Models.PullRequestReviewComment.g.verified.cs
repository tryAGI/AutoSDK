//HintName: G.Models.PullRequestReviewComment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Pull Request Review Comments are comments on a portion of the Pull Request's diff.
    /// </summary>
    public sealed partial class PullRequestReviewComment
    {
        /// <summary>
        /// URL for the pull request review comment<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls/comments/1
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/pulls/comments/1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The ID of the pull request review to which the comment belongs.<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_request_review_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long? PullRequestReviewId { get; set; }

        /// <summary>
        /// The ID of the pull request review comment.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// The node ID of the pull request review comment.<br/>
        /// Example: MDI0OlB1bGxSZXF1ZXN0UmV2aWV3Q29tbWVudDEw
        /// </summary>
        /// <example>MDI0OlB1bGxSZXF1ZXN0UmV2aWV3Q29tbWVudDEw</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// The diff of the line that the comment refers to.<br/>
        /// Example: @@ -16,33 +16,40 @@ public class Connection : IConnection...
        /// </summary>
        /// <example>@@ -16,33 +16,40 @@ public class Connection : IConnection...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("diff_hunk")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DiffHunk { get; set; }

        /// <summary>
        /// The relative path of the file to which the comment applies.<br/>
        /// Example: config/database.yaml
        /// </summary>
        /// <example>config/database.yaml</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// The line index in the diff to which the comment applies. This field is deprecated; use `line` instead.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public int? Position { get; set; }

        /// <summary>
        /// The index of the original line in the diff to which the comment applies. This field is deprecated; use `original_line` instead.<br/>
        /// Example: 4
        /// </summary>
        /// <example>4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_position")]
        public int? OriginalPosition { get; set; }

        /// <summary>
        /// The SHA of the commit to which the comment applies.<br/>
        /// Example: 6dcb09b5b57875f334f61aebed695e2e4193db5e
        /// </summary>
        /// <example>6dcb09b5b57875f334f61aebed695e2e4193db5e</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommitId { get; set; }

        /// <summary>
        /// The SHA of the original commit to which the comment applies.<br/>
        /// Example: 9c48853fa3dc5c1c3d6f1f1cd1f2743e72652840
        /// </summary>
        /// <example>9c48853fa3dc5c1c3d6f1f1cd1f2743e72652840</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_commit_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OriginalCommitId { get; set; }

        /// <summary>
        /// The comment ID to reply to.<br/>
        /// Example: 8
        /// </summary>
        /// <example>8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("in_reply_to_id")]
        public int? InReplyToId { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SimpleUser User { get; set; }

        /// <summary>
        /// The text of the comment.<br/>
        /// Example: We should probably include a check for null values here.
        /// </summary>
        /// <example>We should probably include a check for null values here.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Body { get; set; }

        /// <summary>
        /// Example: 2011-04-14T16:00:49Z
        /// </summary>
        /// <example>2011-04-14T16:00:49Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Example: 2011-04-14T16:00:49Z
        /// </summary>
        /// <example>2011-04-14T16:00:49Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// HTML URL for the pull request review comment.<br/>
        /// Example: https://github.com/octocat/Hello-World/pull/1#discussion-diff-1
        /// </summary>
        /// <example>https://github.com/octocat/Hello-World/pull/1#discussion-diff-1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// URL for the pull request that the review comment belongs to.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls/1
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/pulls/1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_request_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PullRequestUrl { get; set; }

        /// <summary>
        /// How the author is associated with the repository.<br/>
        /// Example: OWNER
        /// </summary>
        /// <example>OWNER</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("author_association")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AuthorAssociationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AuthorAssociation AuthorAssociation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_links")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PullRequestReviewCommentLinks Links { get; set; }

        /// <summary>
        /// The first line of the range for a multi-line comment.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_line")]
        public int? StartLine { get; set; }

        /// <summary>
        /// The first line of the range for a multi-line comment.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_start_line")]
        public int? OriginalStartLine { get; set; }

        /// <summary>
        /// The side of the first line of the range for a multi-line comment.<br/>
        /// Default Value: RIGHT
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_side")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PullRequestReviewCommentStartSideJsonConverter))]
        public global::G.PullRequestReviewCommentStartSide? StartSide { get; set; }

        /// <summary>
        /// The line of the blob to which the comment applies. The last line of the range for a multi-line comment<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("line")]
        public int? Line { get; set; }

        /// <summary>
        /// The line of the blob to which the comment applies. The last line of the range for a multi-line comment<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_line")]
        public int? OriginalLine { get; set; }

        /// <summary>
        /// The side of the diff to which the comment applies. The side of the last line of the range for a multi-line comment<br/>
        /// Default Value: RIGHT
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("side")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PullRequestReviewCommentSideJsonConverter))]
        public global::G.PullRequestReviewCommentSide? Side { get; set; }

        /// <summary>
        /// The level at which the comment is targeted, can be a diff line or a file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PullRequestReviewCommentSubjectTypeJsonConverter))]
        public global::G.PullRequestReviewCommentSubjectType? SubjectType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reactions")]
        public global::G.ReactionRollup? Reactions { get; set; }

        /// <summary>
        /// Example: "&lt;p&gt;comment body&lt;/p&gt;"
        /// </summary>
        /// <example>"&lt;p&gt;comment body&lt;/p&gt;"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("body_html")]
        public string? BodyHtml { get; set; }

        /// <summary>
        /// Example: "comment body"
        /// </summary>
        /// <example>"comment body"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("body_text")]
        public string? BodyText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestReviewComment" /> class.
        /// </summary>
        /// <param name="url">
        /// URL for the pull request review comment<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls/comments/1
        /// </param>
        /// <param name="pullRequestReviewId">
        /// The ID of the pull request review to which the comment belongs.<br/>
        /// Example: 42
        /// </param>
        /// <param name="id">
        /// The ID of the pull request review comment.<br/>
        /// Example: 1
        /// </param>
        /// <param name="nodeId">
        /// The node ID of the pull request review comment.<br/>
        /// Example: MDI0OlB1bGxSZXF1ZXN0UmV2aWV3Q29tbWVudDEw
        /// </param>
        /// <param name="diffHunk">
        /// The diff of the line that the comment refers to.<br/>
        /// Example: @@ -16,33 +16,40 @@ public class Connection : IConnection...
        /// </param>
        /// <param name="path">
        /// The relative path of the file to which the comment applies.<br/>
        /// Example: config/database.yaml
        /// </param>
        /// <param name="position">
        /// The line index in the diff to which the comment applies. This field is deprecated; use `line` instead.<br/>
        /// Example: 1
        /// </param>
        /// <param name="originalPosition">
        /// The index of the original line in the diff to which the comment applies. This field is deprecated; use `original_line` instead.<br/>
        /// Example: 4
        /// </param>
        /// <param name="commitId">
        /// The SHA of the commit to which the comment applies.<br/>
        /// Example: 6dcb09b5b57875f334f61aebed695e2e4193db5e
        /// </param>
        /// <param name="originalCommitId">
        /// The SHA of the original commit to which the comment applies.<br/>
        /// Example: 9c48853fa3dc5c1c3d6f1f1cd1f2743e72652840
        /// </param>
        /// <param name="inReplyToId">
        /// The comment ID to reply to.<br/>
        /// Example: 8
        /// </param>
        /// <param name="user">
        /// A GitHub user.
        /// </param>
        /// <param name="body">
        /// The text of the comment.<br/>
        /// Example: We should probably include a check for null values here.
        /// </param>
        /// <param name="createdAt">
        /// Example: 2011-04-14T16:00:49Z
        /// </param>
        /// <param name="updatedAt">
        /// Example: 2011-04-14T16:00:49Z
        /// </param>
        /// <param name="htmlUrl">
        /// HTML URL for the pull request review comment.<br/>
        /// Example: https://github.com/octocat/Hello-World/pull/1#discussion-diff-1
        /// </param>
        /// <param name="pullRequestUrl">
        /// URL for the pull request that the review comment belongs to.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls/1
        /// </param>
        /// <param name="authorAssociation">
        /// How the author is associated with the repository.<br/>
        /// Example: OWNER
        /// </param>
        /// <param name="links"></param>
        /// <param name="startLine">
        /// The first line of the range for a multi-line comment.<br/>
        /// Example: 2
        /// </param>
        /// <param name="originalStartLine">
        /// The first line of the range for a multi-line comment.<br/>
        /// Example: 2
        /// </param>
        /// <param name="startSide">
        /// The side of the first line of the range for a multi-line comment.<br/>
        /// Default Value: RIGHT
        /// </param>
        /// <param name="line">
        /// The line of the blob to which the comment applies. The last line of the range for a multi-line comment<br/>
        /// Example: 2
        /// </param>
        /// <param name="originalLine">
        /// The line of the blob to which the comment applies. The last line of the range for a multi-line comment<br/>
        /// Example: 2
        /// </param>
        /// <param name="side">
        /// The side of the diff to which the comment applies. The side of the last line of the range for a multi-line comment<br/>
        /// Default Value: RIGHT
        /// </param>
        /// <param name="subjectType">
        /// The level at which the comment is targeted, can be a diff line or a file.
        /// </param>
        /// <param name="reactions"></param>
        /// <param name="bodyHtml">
        /// Example: "&lt;p&gt;comment body&lt;/p&gt;"
        /// </param>
        /// <param name="bodyText">
        /// Example: "comment body"
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PullRequestReviewComment(
            string url,
            long? pullRequestReviewId,
            long id,
            string nodeId,
            string diffHunk,
            string path,
            string commitId,
            string originalCommitId,
            global::G.SimpleUser user,
            string body,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string htmlUrl,
            string pullRequestUrl,
            global::G.AuthorAssociation authorAssociation,
            global::G.PullRequestReviewCommentLinks links,
            int? position,
            int? originalPosition,
            int? inReplyToId,
            int? startLine,
            int? originalStartLine,
            global::G.PullRequestReviewCommentStartSide? startSide,
            int? line,
            int? originalLine,
            global::G.PullRequestReviewCommentSide? side,
            global::G.PullRequestReviewCommentSubjectType? subjectType,
            global::G.ReactionRollup? reactions,
            string? bodyHtml,
            string? bodyText)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.PullRequestReviewId = pullRequestReviewId;
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.DiffHunk = diffHunk ?? throw new global::System.ArgumentNullException(nameof(diffHunk));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.CommitId = commitId ?? throw new global::System.ArgumentNullException(nameof(commitId));
            this.OriginalCommitId = originalCommitId ?? throw new global::System.ArgumentNullException(nameof(originalCommitId));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.PullRequestUrl = pullRequestUrl ?? throw new global::System.ArgumentNullException(nameof(pullRequestUrl));
            this.AuthorAssociation = authorAssociation;
            this.Links = links ?? throw new global::System.ArgumentNullException(nameof(links));
            this.Position = position;
            this.OriginalPosition = originalPosition;
            this.InReplyToId = inReplyToId;
            this.StartLine = startLine;
            this.OriginalStartLine = originalStartLine;
            this.StartSide = startSide;
            this.Line = line;
            this.OriginalLine = originalLine;
            this.Side = side;
            this.SubjectType = subjectType;
            this.Reactions = reactions;
            this.BodyHtml = bodyHtml;
            this.BodyText = bodyText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestReviewComment" /> class.
        /// </summary>
        public PullRequestReviewComment()
        {
        }
    }
}