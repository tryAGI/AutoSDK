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
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.WebhookPullRequestReviewCommentCreatedComment? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.WebhookPullRequestReviewCommentCreatedComment),
                jsonSerializerContext) as global::G.WebhookPullRequestReviewCommentCreatedComment;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.WebhookPullRequestReviewCommentCreatedComment? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.WebhookPullRequestReviewCommentCreatedComment>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.WebhookPullRequestReviewCommentCreatedComment?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.WebhookPullRequestReviewCommentCreatedComment),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.WebhookPullRequestReviewCommentCreatedComment;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.WebhookPullRequestReviewCommentCreatedComment?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.WebhookPullRequestReviewCommentCreatedComment?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}