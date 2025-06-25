﻿//HintName: G.Models.ReviewComment.g.cs

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
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: 42L
        /// </summary>
        /// <example>42L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_request_review_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long? PullRequestReviewId { get; set; }

        /// <summary>
        /// Example: 10L
        /// </summary>
        /// <example>10L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// Example: MDI0OlB1bGxSZXF1ZXN0UmV2aWV3Q29tbWVudDEw
        /// </summary>
        /// <example>MDI0OlB1bGxSZXF1ZXN0UmV2aWV3Q29tbWVudDEw</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// Example: @@ -16,33 +16,40 @@ public class Connection : IConnection...
        /// </summary>
        /// <example>@@ -16,33 +16,40 @@ public class Connection : IConnection...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("diff_hunk")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DiffHunk { get; set; }

        /// <summary>
        /// Example: file1.txt
        /// </summary>
        /// <example>file1.txt</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? Position { get; set; }

        /// <summary>
        /// Example: 4
        /// </summary>
        /// <example>4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_position")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OriginalPosition { get; set; }

        /// <summary>
        /// Example: 6dcb09b5b57875f334f61aebed695e2e4193db5e
        /// </summary>
        /// <example>6dcb09b5b57875f334f61aebed695e2e4193db5e</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommitId { get; set; }

        /// <summary>
        /// Example: 9c48853fa3dc5c1c3d6f1f1cd1f2743e72652840
        /// </summary>
        /// <example>9c48853fa3dc5c1c3d6f1f1cd1f2743e72652840</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_commit_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OriginalCommitId { get; set; }

        /// <summary>
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
        public required global::G.NullableSimpleUser? User { get; set; }

        /// <summary>
        /// Example: Great stuff
        /// </summary>
        /// <example>Great stuff</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/pull/1#discussion-diff-1
        /// </summary>
        /// <example>https://github.com/octocat/Hello-World/pull/1#discussion-diff-1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
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
        public required global::G.ReviewCommentLinks Links { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body_text")]
        public string? BodyText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body_html")]
        public string? BodyHtml { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reactions")]
        public global::G.ReactionRollup? Reactions { get; set; }

        /// <summary>
        /// The side of the first line of the range for a multi-line comment.<br/>
        /// Default Value: RIGHT
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("side")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ReviewCommentSideJsonConverter))]
        public global::G.ReviewCommentSide? Side { get; set; }

        /// <summary>
        /// The side of the first line of the range for a multi-line comment.<br/>
        /// Default Value: RIGHT
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_side")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ReviewCommentStartSideJsonConverter))]
        public global::G.ReviewCommentStartSide? StartSide { get; set; }

        /// <summary>
        /// The line of the blob to which the comment applies. The last line of the range for a multi-line comment<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("line")]
        public int? Line { get; set; }

        /// <summary>
        /// The original line of the blob to which the comment applies. The last line of the range for a multi-line comment<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_line")]
        public int? OriginalLine { get; set; }

        /// <summary>
        /// The first line of the range for a multi-line comment.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_line")]
        public int? StartLine { get; set; }

        /// <summary>
        /// The original first line of the range for a multi-line comment.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_start_line")]
        public int? OriginalStartLine { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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