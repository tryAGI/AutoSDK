//HintName: G.Models.PullRequestReview.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Pull Request Reviews are reviews on pull requests.
    /// </summary>
    public sealed partial class PullRequestReview
    {
        /// <summary>
        /// Unique identifier of the review<br/>
        /// Example: 42L
        /// </summary>
        /// <example>42L</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public long Id { get; set; } = default!;

        /// <summary>
        /// Example: MDE3OlB1bGxSZXF1ZXN0UmV2aWV3ODA=
        /// </summary>
        /// <example>MDE3OlB1bGxSZXF1ZXN0UmV2aWV3ODA=</example>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? User { get; set; } = default!;

        /// <summary>
        /// The text of the review.<br/>
        /// Example: This looks great.
        /// </summary>
        /// <example>This looks great.</example>
        [global::Newtonsoft.Json.JsonProperty("body", Required = global::Newtonsoft.Json.Required.Always)]
        public string Body { get; set; } = default!;

        /// <summary>
        /// Example: CHANGES_REQUESTED
        /// </summary>
        /// <example>CHANGES_REQUESTED</example>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public string State { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/pull/12#pullrequestreview-80
        /// </summary>
        /// <example>https://github.com/octocat/Hello-World/pull/12#pullrequestreview-80</example>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls/12
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/pulls/12</example>
        [global::Newtonsoft.Json.JsonProperty("pull_request_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PullRequestUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_links", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PullRequestReviewLinks Links { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("submitted_at")]
        public global::System.DateTime? SubmittedAt { get; set; }

        /// <summary>
        /// A commit SHA for the review. If the commit object was garbage collected or forcibly deleted, then it no longer exists in Git and this value will be `null`.<br/>
        /// Example: 54bb654c9e6025347f57900a4a5c2313a96b8035
        /// </summary>
        /// <example>54bb654c9e6025347f57900a4a5c2313a96b8035</example>
        [global::Newtonsoft.Json.JsonProperty("commit_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string? CommitId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body_html")]
        public string? BodyHtml { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body_text")]
        public string? BodyText { get; set; }

        /// <summary>
        /// How the author is associated with the repository.<br/>
        /// Example: OWNER
        /// </summary>
        /// <example>OWNER</example>
        [global::Newtonsoft.Json.JsonProperty("author_association", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AuthorAssociation AuthorAssociation { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestReview" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the review<br/>
        /// Example: 42L
        /// </param>
        /// <param name="nodeId">
        /// Example: MDE3OlB1bGxSZXF1ZXN0UmV2aWV3ODA=
        /// </param>
        /// <param name="user">
        /// A GitHub user.
        /// </param>
        /// <param name="body">
        /// The text of the review.<br/>
        /// Example: This looks great.
        /// </param>
        /// <param name="state">
        /// Example: CHANGES_REQUESTED
        /// </param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/octocat/Hello-World/pull/12#pullrequestreview-80
        /// </param>
        /// <param name="pullRequestUrl">
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls/12
        /// </param>
        /// <param name="links"></param>
        /// <param name="submittedAt"></param>
        /// <param name="commitId">
        /// A commit SHA for the review. If the commit object was garbage collected or forcibly deleted, then it no longer exists in Git and this value will be `null`.<br/>
        /// Example: 54bb654c9e6025347f57900a4a5c2313a96b8035
        /// </param>
        /// <param name="bodyHtml"></param>
        /// <param name="bodyText"></param>
        /// <param name="authorAssociation">
        /// How the author is associated with the repository.<br/>
        /// Example: OWNER
        /// </param>
        public PullRequestReview(
            long id,
            string nodeId,
            global::G.NullableSimpleUser? user,
            string body,
            string state,
            string htmlUrl,
            string pullRequestUrl,
            global::G.PullRequestReviewLinks links,
            string? commitId,
            global::G.AuthorAssociation authorAssociation,
            global::System.DateTime? submittedAt,
            string? bodyHtml,
            string? bodyText)
        {
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.PullRequestUrl = pullRequestUrl ?? throw new global::System.ArgumentNullException(nameof(pullRequestUrl));
            this.Links = links ?? throw new global::System.ArgumentNullException(nameof(links));
            this.CommitId = commitId ?? throw new global::System.ArgumentNullException(nameof(commitId));
            this.AuthorAssociation = authorAssociation;
            this.SubmittedAt = submittedAt;
            this.BodyHtml = bodyHtml;
            this.BodyText = bodyText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestReview" /> class.
        /// </summary>
        public PullRequestReview()
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
        public static global::G.PullRequestReview? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.PullRequestReview>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.PullRequestReview?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.PullRequestReview?>(serializer.Deserialize<global::G.PullRequestReview>(jsonReader));
        }

    }
}