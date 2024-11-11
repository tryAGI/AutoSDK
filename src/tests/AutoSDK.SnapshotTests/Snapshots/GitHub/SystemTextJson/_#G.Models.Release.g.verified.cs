//HintName: G.Models.Release.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A release.
    /// </summary>
    public sealed partial class Release
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assets_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AssetsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UploadUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tarball_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? TarballUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zipball_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? ZipballUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// The name of the tag.<br/>
        /// Example: v1.0.0
        /// </summary>
        /// <example>v1.0.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TagName { get; set; }

        /// <summary>
        /// Specifies the commitish value that determines where the Git tag is created from.<br/>
        /// Example: master
        /// </summary>
        /// <example>master</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_commitish")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetCommitish { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// true to create a draft (unpublished) release, false to create a published one.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("draft")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Draft { get; set; }

        /// <summary>
        /// Whether to identify the release as a prerelease or a full release.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prerelease")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Prerelease { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("published_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? PublishedAt { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SimpleUser Author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ReleaseAsset> Assets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body_html")]
        public string? BodyHtml { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body_text")]
        public string? BodyText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mentions_count")]
        public int? MentionsCount { get; set; }

        /// <summary>
        /// The URL of the release discussion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussion_url")]
        public string? DiscussionUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reactions")]
        public global::G.ReactionRollup? Reactions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Release" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="assetsUrl"></param>
        /// <param name="uploadUrl"></param>
        /// <param name="tarballUrl"></param>
        /// <param name="zipballUrl"></param>
        /// <param name="id"></param>
        /// <param name="nodeId"></param>
        /// <param name="tagName">
        /// The name of the tag.<br/>
        /// Example: v1.0.0
        /// </param>
        /// <param name="targetCommitish">
        /// Specifies the commitish value that determines where the Git tag is created from.<br/>
        /// Example: master
        /// </param>
        /// <param name="name"></param>
        /// <param name="body"></param>
        /// <param name="draft">
        /// true to create a draft (unpublished) release, false to create a published one.<br/>
        /// Example: false
        /// </param>
        /// <param name="prerelease">
        /// Whether to identify the release as a prerelease or a full release.<br/>
        /// Example: false
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="publishedAt"></param>
        /// <param name="author">
        /// A GitHub user.
        /// </param>
        /// <param name="assets"></param>
        /// <param name="bodyHtml"></param>
        /// <param name="bodyText"></param>
        /// <param name="mentionsCount"></param>
        /// <param name="discussionUrl">
        /// The URL of the release discussion.
        /// </param>
        /// <param name="reactions"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Release(
            string url,
            string htmlUrl,
            string assetsUrl,
            string uploadUrl,
            string? tarballUrl,
            string? zipballUrl,
            int id,
            string nodeId,
            string tagName,
            string targetCommitish,
            string? name,
            bool draft,
            bool prerelease,
            global::System.DateTime createdAt,
            global::System.DateTime? publishedAt,
            global::G.SimpleUser author,
            global::System.Collections.Generic.IList<global::G.ReleaseAsset> assets,
            string? body,
            string? bodyHtml,
            string? bodyText,
            int? mentionsCount,
            string? discussionUrl,
            global::G.ReactionRollup? reactions)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.AssetsUrl = assetsUrl ?? throw new global::System.ArgumentNullException(nameof(assetsUrl));
            this.UploadUrl = uploadUrl ?? throw new global::System.ArgumentNullException(nameof(uploadUrl));
            this.TarballUrl = tarballUrl ?? throw new global::System.ArgumentNullException(nameof(tarballUrl));
            this.ZipballUrl = zipballUrl ?? throw new global::System.ArgumentNullException(nameof(zipballUrl));
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.TagName = tagName ?? throw new global::System.ArgumentNullException(nameof(tagName));
            this.TargetCommitish = targetCommitish ?? throw new global::System.ArgumentNullException(nameof(targetCommitish));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Draft = draft;
            this.Prerelease = prerelease;
            this.CreatedAt = createdAt;
            this.PublishedAt = publishedAt;
            this.Author = author ?? throw new global::System.ArgumentNullException(nameof(author));
            this.Assets = assets ?? throw new global::System.ArgumentNullException(nameof(assets));
            this.Body = body;
            this.BodyHtml = bodyHtml;
            this.BodyText = bodyText;
            this.MentionsCount = mentionsCount;
            this.DiscussionUrl = discussionUrl;
            this.Reactions = reactions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Release" /> class.
        /// </summary>
        public Release()
        {
        }


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
        public static global::G.Release? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.Release),
                jsonSerializerContext) as global::G.Release;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.Release? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.Release>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.Release?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.Release),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.Release;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.Release?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.Release?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}