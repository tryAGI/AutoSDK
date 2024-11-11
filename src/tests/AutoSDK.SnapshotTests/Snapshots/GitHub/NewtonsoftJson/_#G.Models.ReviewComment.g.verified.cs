//HintName: G.Models.ReviewComment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Legacy Review Comment
    /// </summary>
    public sealed partial class ReviewComment
    {
        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls/comments/1
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/pulls/comments/1</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: 42L
        /// </summary>
        /// <example>42L</example>
        [global::Newtonsoft.Json.JsonProperty("pull_request_review_id", Required = global::Newtonsoft.Json.Required.Always)]
        public long? PullRequestReviewId { get; set; } = default!;

        /// <summary>
        /// Example: 10L
        /// </summary>
        /// <example>10L</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public long Id { get; set; } = default!;

        /// <summary>
        /// Example: MDI0OlB1bGxSZXF1ZXN0UmV2aWV3Q29tbWVudDEw
        /// </summary>
        /// <example>MDI0OlB1bGxSZXF1ZXN0UmV2aWV3Q29tbWVudDEw</example>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// Example: @@ -16,33 +16,40 @@ public class Connection : IConnection...
        /// </summary>
        /// <example>@@ -16,33 +16,40 @@ public class Connection : IConnection...</example>
        [global::Newtonsoft.Json.JsonProperty("diff_hunk", Required = global::Newtonsoft.Json.Required.Always)]
        public string DiffHunk { get; set; } = default!;

        /// <summary>
        /// Example: file1.txt
        /// </summary>
        /// <example>file1.txt</example>
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string Path { get; set; } = default!;

        /// <summary>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("position", Required = global::Newtonsoft.Json.Required.Always)]
        public int? Position { get; set; } = default!;

        /// <summary>
        /// Example: 4
        /// </summary>
        /// <example>4</example>
        [global::Newtonsoft.Json.JsonProperty("original_position", Required = global::Newtonsoft.Json.Required.Always)]
        public int OriginalPosition { get; set; } = default!;

        /// <summary>
        /// Example: 6dcb09b5b57875f334f61aebed695e2e4193db5e
        /// </summary>
        /// <example>6dcb09b5b57875f334f61aebed695e2e4193db5e</example>
        [global::Newtonsoft.Json.JsonProperty("commit_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommitId { get; set; } = default!;

        /// <summary>
        /// Example: 9c48853fa3dc5c1c3d6f1f1cd1f2743e72652840
        /// </summary>
        /// <example>9c48853fa3dc5c1c3d6f1f1cd1f2743e72652840</example>
        [global::Newtonsoft.Json.JsonProperty("original_commit_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OriginalCommitId { get; set; } = default!;

        /// <summary>
        /// Example: 8
        /// </summary>
        /// <example>8</example>
        [global::Newtonsoft.Json.JsonProperty("in_reply_to_id")]
        public int? InReplyToId { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? User { get; set; } = default!;

        /// <summary>
        /// Example: Great stuff
        /// </summary>
        /// <example>Great stuff</example>
        [global::Newtonsoft.Json.JsonProperty("body", Required = global::Newtonsoft.Json.Required.Always)]
        public string Body { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/pull/1#discussion-diff-1
        /// </summary>
        /// <example>https://github.com/octocat/Hello-World/pull/1#discussion-diff-1</example>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls/1
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/pulls/1</example>
        [global::Newtonsoft.Json.JsonProperty("pull_request_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PullRequestUrl { get; set; } = default!;

        /// <summary>
        /// How the author is associated with the repository.<br/>
        /// Example: OWNER
        /// </summary>
        /// <example>OWNER</example>
        [global::Newtonsoft.Json.JsonProperty("author_association", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AuthorAssociation AuthorAssociation { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_links", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ReviewCommentLinks Links { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body_text")]
        public string? BodyText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body_html")]
        public string? BodyHtml { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reactions")]
        public global::G.ReactionRollup? Reactions { get; set; }

        /// <summary>
        /// The side of the first line of the range for a multi-line comment.<br/>
        /// Default Value: RIGHT
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("side")]
        public global::G.ReviewCommentSide? Side { get; set; }

        /// <summary>
        /// The side of the first line of the range for a multi-line comment.<br/>
        /// Default Value: RIGHT
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_side")]
        public global::G.ReviewCommentStartSide? StartSide { get; set; }

        /// <summary>
        /// The line of the blob to which the comment applies. The last line of the range for a multi-line comment<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::Newtonsoft.Json.JsonProperty("line")]
        public int? Line { get; set; }

        /// <summary>
        /// The original line of the blob to which the comment applies. The last line of the range for a multi-line comment<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::Newtonsoft.Json.JsonProperty("original_line")]
        public int? OriginalLine { get; set; }

        /// <summary>
        /// The first line of the range for a multi-line comment.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::Newtonsoft.Json.JsonProperty("start_line")]
        public int? StartLine { get; set; }

        /// <summary>
        /// The original first line of the range for a multi-line comment.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::Newtonsoft.Json.JsonProperty("original_start_line")]
        public int? OriginalStartLine { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewComment" /> class.
        /// </summary>
        /// <param name="url">
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls/comments/1
        /// </param>
        /// <param name="pullRequestReviewId">
        /// Example: 42L
        /// </param>
        /// <param name="id">
        /// Example: 10L
        /// </param>
        /// <param name="nodeId">
        /// Example: MDI0OlB1bGxSZXF1ZXN0UmV2aWV3Q29tbWVudDEw
        /// </param>
        /// <param name="diffHunk">
        /// Example: @@ -16,33 +16,40 @@ public class Connection : IConnection...
        /// </param>
        /// <param name="path">
        /// Example: file1.txt
        /// </param>
        /// <param name="position">
        /// Example: 1
        /// </param>
        /// <param name="originalPosition">
        /// Example: 4
        /// </param>
        /// <param name="commitId">
        /// Example: 6dcb09b5b57875f334f61aebed695e2e4193db5e
        /// </param>
        /// <param name="originalCommitId">
        /// Example: 9c48853fa3dc5c1c3d6f1f1cd1f2743e72652840
        /// </param>
        /// <param name="inReplyToId">
        /// Example: 8
        /// </param>
        /// <param name="user">
        /// A GitHub user.
        /// </param>
        /// <param name="body">
        /// Example: Great stuff
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/octocat/Hello-World/pull/1#discussion-diff-1
        /// </param>
        /// <param name="pullRequestUrl">
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls/1
        /// </param>
        /// <param name="authorAssociation">
        /// How the author is associated with the repository.<br/>
        /// Example: OWNER
        /// </param>
        /// <param name="links"></param>
        /// <param name="bodyText"></param>
        /// <param name="bodyHtml"></param>
        /// <param name="reactions"></param>
        /// <param name="side">
        /// The side of the first line of the range for a multi-line comment.<br/>
        /// Default Value: RIGHT
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
        /// The original line of the blob to which the comment applies. The last line of the range for a multi-line comment<br/>
        /// Example: 2
        /// </param>
        /// <param name="startLine">
        /// The first line of the range for a multi-line comment.<br/>
        /// Example: 2
        /// </param>
        /// <param name="originalStartLine">
        /// The original first line of the range for a multi-line comment.<br/>
        /// Example: 2
        /// </param>
        public ReviewComment(
            string url,
            long? pullRequestReviewId,
            long id,
            string nodeId,
            string diffHunk,
            string path,
            int? position,
            int originalPosition,
            string commitId,
            string originalCommitId,
            global::G.NullableSimpleUser? user,
            string body,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string htmlUrl,
            string pullRequestUrl,
            global::G.AuthorAssociation authorAssociation,
            global::G.ReviewCommentLinks links,
            int? inReplyToId,
            string? bodyText,
            string? bodyHtml,
            global::G.ReactionRollup? reactions,
            global::G.ReviewCommentSide? side,
            global::G.ReviewCommentStartSide? startSide,
            int? line,
            int? originalLine,
            int? startLine,
            int? originalStartLine)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.PullRequestReviewId = pullRequestReviewId;
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.DiffHunk = diffHunk ?? throw new global::System.ArgumentNullException(nameof(diffHunk));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Position = position;
            this.OriginalPosition = originalPosition;
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
            this.InReplyToId = inReplyToId;
            this.BodyText = bodyText;
            this.BodyHtml = bodyHtml;
            this.Reactions = reactions;
            this.Side = side;
            this.StartSide = startSide;
            this.Line = line;
            this.OriginalLine = originalLine;
            this.StartLine = startLine;
            this.OriginalStartLine = originalStartLine;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewComment" /> class.
        /// </summary>
        public ReviewComment()
        {
        }
    }
}