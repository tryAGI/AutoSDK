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
        /// URL for the pull request review comment
        /// <br/>Example: https://api.github.com/repos/octocat/Hello-World/pulls/comments/1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The ID of the pull request review to which the comment belongs.
        /// <br/>Example: 42
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_request_review_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? PullRequestReviewId { get; set; }

        /// <summary>
        /// The ID of the pull request review comment.
        /// <br/>Example: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The node ID of the pull request review comment.
        /// <br/>Example: MDI0OlB1bGxSZXF1ZXN0UmV2aWV3Q29tbWVudDEw
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// The diff of the line that the comment refers to.
        /// <br/>Example: @@ -16,33 +16,40 @@ public class Connection : IConnection...
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diff_hunk")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DiffHunk { get; set; }

        /// <summary>
        /// The relative path of the file to which the comment applies.
        /// <br/>Example: config/database.yaml
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// The line index in the diff to which the comment applies. This field is deprecated; use `line` instead.
        /// <br/>Example: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public int Position { get; set; }

        /// <summary>
        /// The index of the original line in the diff to which the comment applies. This field is deprecated; use `original_line` instead.
        /// <br/>Example: 4
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_position")]
        public int OriginalPosition { get; set; }

        /// <summary>
        /// The SHA of the commit to which the comment applies.
        /// <br/>Example: 6dcb09b5b57875f334f61aebed695e2e4193db5e
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommitId { get; set; }

        /// <summary>
        /// The SHA of the original commit to which the comment applies.
        /// <br/>Example: 9c48853fa3dc5c1c3d6f1f1cd1f2743e72652840
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_commit_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OriginalCommitId { get; set; }

        /// <summary>
        /// The comment ID to reply to.
        /// <br/>Example: 8
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in_reply_to_id")]
        public int InReplyToId { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required SimpleUser User { get; set; }

        /// <summary>
        /// The text of the comment.
        /// <br/>Example: We should probably include a check for null values here.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Body { get; set; }

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// HTML URL for the pull request review comment.
        /// <br/>Example: https://github.com/octocat/Hello-World/pull/1#discussion-diff-1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// URL for the pull request that the review comment belongs to.
        /// <br/>Example: https://api.github.com/repos/octocat/Hello-World/pulls/1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_request_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PullRequestUrl { get; set; }

        /// <summary>
        /// How the author is associated with the repository.
        /// <br/>Example: OWNER
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author_association")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.PullRequestReviewCommentAuthorAssociationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required PullRequestReviewCommentAuthorAssociation AuthorAssociation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_links")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required PullRequestReviewCommentLinks Links { get; set; }

        /// <summary>
        /// The first line of the range for a multi-line comment.
        /// <br/>Example: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_line")]
        public int? StartLine { get; set; }

        /// <summary>
        /// The first line of the range for a multi-line comment.
        /// <br/>Example: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_start_line")]
        public int? OriginalStartLine { get; set; }

        /// <summary>
        /// The side of the first line of the range for a multi-line comment.
        /// <br/>Default Value: RIGHT
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_side")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.PullRequestReviewCommentStartSideJsonConverter))]
        public PullRequestReviewCommentStartSide? StartSide { get; set; } = PullRequestReviewCommentStartSide.RIGHT;

        /// <summary>
        /// The line of the blob to which the comment applies. The last line of the range for a multi-line comment
        /// <br/>Example: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line")]
        public int Line { get; set; }

        /// <summary>
        /// The line of the blob to which the comment applies. The last line of the range for a multi-line comment
        /// <br/>Example: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_line")]
        public int OriginalLine { get; set; }

        /// <summary>
        /// The side of the diff to which the comment applies. The side of the last line of the range for a multi-line comment
        /// <br/>Default Value: RIGHT
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("side")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.PullRequestReviewCommentSideJsonConverter))]
        public PullRequestReviewCommentSide? Side { get; set; } = PullRequestReviewCommentSide.RIGHT;

        /// <summary>
        /// The level at which the comment is targeted, can be a diff line or a file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.PullRequestReviewCommentSubjectTypeJsonConverter))]
        public PullRequestReviewCommentSubjectType? SubjectType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reactions")]
        public ReactionRollup? Reactions { get; set; }

        /// <summary>
        /// <br/>Example: "&lt;p&gt;comment body&lt;/p&gt;"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body_html")]
        public string? BodyHtml { get; set; }

        /// <summary>
        /// <br/>Example: "comment body"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body_text")]
        public string? BodyText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}