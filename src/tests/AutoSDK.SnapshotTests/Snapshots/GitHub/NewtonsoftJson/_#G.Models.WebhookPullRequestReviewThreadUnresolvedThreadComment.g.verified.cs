//HintName: G.Models.WebhookPullRequestReviewThreadUnresolvedThreadComment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The [comment](https://docs.github.com/rest/pulls/comments#get-a-review-comment-for-a-pull-request) itself.
    /// </summary>
    public sealed partial class WebhookPullRequestReviewThreadUnresolvedThreadComment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_links", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestReviewThreadUnresolvedThreadCommentLinks Links { get; set; } = default!;

        /// <summary>
        /// How the author is associated with the repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author_association", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestReviewThreadUnresolvedThreadCommentAuthorAssociation AuthorAssociation { get; set; } = default!;

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
        public global::G.WebhookPullRequestReviewThreadUnresolvedThreadCommentReactions Reactions { get; set; } = default!;

        /// <summary>
        /// The side of the first line of the range for a multi-line comment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("side", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPullRequestReviewThreadUnresolvedThreadCommentSide Side { get; set; } = default!;

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
        public global::G.WebhookPullRequestReviewThreadUnresolvedThreadCommentStartSide? StartSide { get; set; } = default!;

        /// <summary>
        /// The level at which the comment is targeted, can be a diff line or a file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subject_type")]
        public global::G.WebhookPullRequestReviewThreadUnresolvedThreadCommentSubjectType? SubjectType { get; set; }

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
        public global::G.WebhookPullRequestReviewThreadUnresolvedThreadCommentUser? User { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


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
        public static global::G.WebhookPullRequestReviewThreadUnresolvedThreadComment? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.WebhookPullRequestReviewThreadUnresolvedThreadComment>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.WebhookPullRequestReviewThreadUnresolvedThreadComment?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.WebhookPullRequestReviewThreadUnresolvedThreadComment?>(serializer.Deserialize<global::G.WebhookPullRequestReviewThreadUnresolvedThreadComment>(jsonReader));
        }

    }
}