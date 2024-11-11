//HintName: G.Models.WebhooksReviewComment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The [comment](https://docs.github.com/rest/pulls/comments#get-a-review-comment-for-a-pull-request) itself.
    /// </summary>
    public sealed partial class WebhooksReviewComment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_links", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhooksReviewCommentLinks Links { get; set; } = default!;

        /// <summary>
        /// How the author is associated with the repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author_association", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhooksReviewCommentAuthorAssociation AuthorAssociation { get; set; } = default!;

        /// <summary>
        /// The text of the comment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body", Required = global::Newtonsoft.Json.Required.Always)]
        public string Body { get; set; } = default!;

        /// <summary>
        /// The SHA of the commit to which the comment applies.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommitId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The diff of the line that the comment refers to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("diff_hunk", Required = global::Newtonsoft.Json.Required.Always)]
        public string DiffHunk { get; set; } = default!;

        /// <summary>
        /// HTML URL for the pull request review comment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// The ID of the pull request review comment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// The comment ID to reply to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("in_reply_to_id")]
        public int? InReplyToId { get; set; }

        /// <summary>
        /// The line of the blob to which the comment applies. The last line of the range for a multi-line comment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("line", Required = global::Newtonsoft.Json.Required.Always)]
        public int? Line { get; set; } = default!;

        /// <summary>
        /// The node ID of the pull request review comment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// The SHA of the original commit to which the comment applies.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("original_commit_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OriginalCommitId { get; set; } = default!;

        /// <summary>
        /// The line of the blob to which the comment applies. The last line of the range for a multi-line comment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("original_line", Required = global::Newtonsoft.Json.Required.Always)]
        public int OriginalLine { get; set; } = default!;

        /// <summary>
        /// The index of the original line in the diff to which the comment applies.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("original_position", Required = global::Newtonsoft.Json.Required.Always)]
        public int OriginalPosition { get; set; } = default!;

        /// <summary>
        /// The first line of the range for a multi-line comment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("original_start_line", Required = global::Newtonsoft.Json.Required.Always)]
        public int? OriginalStartLine { get; set; } = default!;

        /// <summary>
        /// The relative path of the file to which the comment applies.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string Path { get; set; } = default!;

        /// <summary>
        /// The line index in the diff to which the comment applies.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("position", Required = global::Newtonsoft.Json.Required.Always)]
        public int? Position { get; set; } = default!;

        /// <summary>
        /// The ID of the pull request review to which the comment belongs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pull_request_review_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int? PullRequestReviewId { get; set; } = default!;

        /// <summary>
        /// URL for the pull request that the review comment belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pull_request_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PullRequestUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reactions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhooksReviewCommentReactions Reactions { get; set; } = default!;

        /// <summary>
        /// The side of the first line of the range for a multi-line comment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("side", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhooksReviewCommentSide Side { get; set; } = default!;

        /// <summary>
        /// The first line of the range for a multi-line comment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_line", Required = global::Newtonsoft.Json.Required.Always)]
        public int? StartLine { get; set; } = default!;

        /// <summary>
        /// The side of the first line of the range for a multi-line comment.<br/>
        /// Default Value: RIGHT
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_side", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhooksReviewCommentStartSide? StartSide { get; set; } = default!;

        /// <summary>
        /// The level at which the comment is targeted, can be a diff line or a file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subject_type")]
        public global::G.WebhooksReviewCommentSubjectType? SubjectType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// URL for the pull request review comment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhooksReviewCommentUser? User { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksReviewComment" /> class.
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
        public WebhooksReviewComment(
            global::G.WebhooksReviewCommentLinks links,
            global::G.WebhooksReviewCommentAuthorAssociation authorAssociation,
            string body,
            string commitId,
            global::System.DateTime createdAt,
            string diffHunk,
            string htmlUrl,
            int id,
            int? line,
            string nodeId,
            string originalCommitId,
            int originalLine,
            int originalPosition,
            int? originalStartLine,
            string path,
            int? position,
            int? pullRequestReviewId,
            string pullRequestUrl,
            global::G.WebhooksReviewCommentReactions reactions,
            global::G.WebhooksReviewCommentSide side,
            int? startLine,
            global::G.WebhooksReviewCommentStartSide? startSide,
            global::System.DateTime updatedAt,
            string url,
            global::G.WebhooksReviewCommentUser? user,
            int? inReplyToId,
            global::G.WebhooksReviewCommentSubjectType? subjectType)
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
        /// Initializes a new instance of the <see cref="WebhooksReviewComment" /> class.
        /// </summary>
        public WebhooksReviewComment()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.WebhooksReviewComment? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.WebhooksReviewComment>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.WebhooksReviewComment?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.WebhooksReviewComment?>(serializer.Deserialize<global::G.WebhooksReviewComment>(jsonReader));
        }

    }
}