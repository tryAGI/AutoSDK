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
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// The ID of the pull request review to which the comment belongs.<br/>
        /// Example: 42L
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pull_request_review_id", Required = global::Newtonsoft.Json.Required.Always)]
        public long? PullRequestReviewId { get; set; } = default!;

        /// <summary>
        /// The ID of the pull request review comment.<br/>
        /// Example: 1L
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public long Id { get; set; } = default!;

        /// <summary>
        /// The node ID of the pull request review comment.<br/>
        /// Example: MDI0OlB1bGxSZXF1ZXN0UmV2aWV3Q29tbWVudDEw
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// The diff of the line that the comment refers to.<br/>
        /// Example: @@ -16,33 +16,40 @@ public class Connection : IConnection...
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("diff_hunk", Required = global::Newtonsoft.Json.Required.Always)]
        public string DiffHunk { get; set; } = default!;

        /// <summary>
        /// The relative path of the file to which the comment applies.<br/>
        /// Example: config/database.yaml
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string Path { get; set; } = default!;

        /// <summary>
        /// The line index in the diff to which the comment applies. This field is deprecated; use `line` instead.<br/>
        /// Example: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("position")]
        public int? Position { get; set; }

        /// <summary>
        /// The index of the original line in the diff to which the comment applies. This field is deprecated; use `original_line` instead.<br/>
        /// Example: 4
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("original_position")]
        public int? OriginalPosition { get; set; }

        /// <summary>
        /// The SHA of the commit to which the comment applies.<br/>
        /// Example: 6dcb09b5b57875f334f61aebed695e2e4193db5e
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommitId { get; set; } = default!;

        /// <summary>
        /// The SHA of the original commit to which the comment applies.<br/>
        /// Example: 9c48853fa3dc5c1c3d6f1f1cd1f2743e72652840
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("original_commit_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OriginalCommitId { get; set; } = default!;

        /// <summary>
        /// The comment ID to reply to.<br/>
        /// Example: 8
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("in_reply_to_id")]
        public int? InReplyToId { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleUser User { get; set; } = default!;

        /// <summary>
        /// The text of the comment.<br/>
        /// Example: We should probably include a check for null values here.
        /// </summary>
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
        /// HTML URL for the pull request review comment.<br/>
        /// Example: https://github.com/octocat/Hello-World/pull/1#discussion-diff-1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// URL for the pull request that the review comment belongs to.<br/>
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls/1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pull_request_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PullRequestUrl { get; set; } = default!;

        /// <summary>
        /// How the author is associated with the repository.<br/>
        /// Example: OWNER
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author_association", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AuthorAssociation AuthorAssociation { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_links", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PullRequestReviewCommentLinks Links { get; set; } = default!;

        /// <summary>
        /// The first line of the range for a multi-line comment.<br/>
        /// Example: 2
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_line")]
        public int? StartLine { get; set; }

        /// <summary>
        /// The first line of the range for a multi-line comment.<br/>
        /// Example: 2
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("original_start_line")]
        public int? OriginalStartLine { get; set; }

        /// <summary>
        /// The side of the first line of the range for a multi-line comment.<br/>
        /// Default Value: RIGHT
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_side")]
        public global::G.PullRequestReviewCommentStartSide? StartSide { get; set; }

        /// <summary>
        /// The line of the blob to which the comment applies. The last line of the range for a multi-line comment<br/>
        /// Example: 2
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("line")]
        public int? Line { get; set; }

        /// <summary>
        /// The line of the blob to which the comment applies. The last line of the range for a multi-line comment<br/>
        /// Example: 2
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("original_line")]
        public int? OriginalLine { get; set; }

        /// <summary>
        /// The side of the diff to which the comment applies. The side of the last line of the range for a multi-line comment<br/>
        /// Default Value: RIGHT
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("side")]
        public global::G.PullRequestReviewCommentSide? Side { get; set; }

        /// <summary>
        /// The level at which the comment is targeted, can be a diff line or a file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subject_type")]
        public global::G.PullRequestReviewCommentSubjectType? SubjectType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reactions")]
        public global::G.ReactionRollup? Reactions { get; set; }

        /// <summary>
        /// Example: "&lt;p&gt;comment body&lt;/p&gt;"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body_html")]
        public string? BodyHtml { get; set; }

        /// <summary>
        /// Example: "comment body"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body_text")]
        public string? BodyText { get; set; }

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
        public static global::G.PullRequestReviewComment? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.PullRequestReviewComment>(
                json,
                jsonSerializerOptions);
        }

    }
}