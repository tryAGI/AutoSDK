//HintName: G.Models.WebhookReleasePrereleasedRelease.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The [release](https://docs.github.com/rest/releases/releases/#get-a-release) object.
    /// </summary>
    public sealed partial class WebhookReleasePrereleasedRelease
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.WebhookReleasePrereleasedReleaseAsset> Assets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assets_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AssetsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookReleasePrereleasedReleaseAuthor? Author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussion_url")]
        public string? DiscussionUrl { get; set; }

        /// <summary>
        /// Whether the release is a draft or published
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("draft")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Draft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// Whether the release is identified as a prerelease or a full release.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prerelease")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Prerelease { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("published_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? PublishedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reactions")]
        public global::G.WebhookReleasePrereleasedReleaseReactions? Reactions { get; set; }

        /// <summary>
        /// The name of the tag.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TagName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tarball_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? TarballUrl { get; set; }

        /// <summary>
        /// Specifies the commitish value that determines where the Git tag is created from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_commitish")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetCommitish { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UploadUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zipball_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? ZipballUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookReleasePrereleasedRelease" /> class.
        /// </summary>
        /// <param name="assets"></param>
        /// <param name="assetsUrl"></param>
        /// <param name="author"></param>
        /// <param name="body"></param>
        /// <param name="createdAt"></param>
        /// <param name="discussionUrl"></param>
        /// <param name="draft">
        /// Whether the release is a draft or published
        /// </param>
        /// <param name="htmlUrl"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="nodeId"></param>
        /// <param name="prerelease">
        /// Whether the release is identified as a prerelease or a full release.
        /// </param>
        /// <param name="publishedAt"></param>
        /// <param name="reactions"></param>
        /// <param name="tagName">
        /// The name of the tag.
        /// </param>
        /// <param name="tarballUrl"></param>
        /// <param name="targetCommitish">
        /// Specifies the commitish value that determines where the Git tag is created from.
        /// </param>
        /// <param name="uploadUrl"></param>
        /// <param name="url"></param>
        /// <param name="zipballUrl"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookReleasePrereleasedRelease(
            global::System.Collections.Generic.IList<global::G.WebhookReleasePrereleasedReleaseAsset> assets,
            string assetsUrl,
            global::G.WebhookReleasePrereleasedReleaseAuthor? author,
            string? body,
            global::System.DateTime? createdAt,
            bool draft,
            string htmlUrl,
            int id,
            string? name,
            string nodeId,
            bool prerelease,
            global::System.DateTime? publishedAt,
            string tagName,
            string? tarballUrl,
            string targetCommitish,
            string uploadUrl,
            string url,
            string? zipballUrl,
            string? discussionUrl,
            global::G.WebhookReleasePrereleasedReleaseReactions? reactions)
        {
            this.Assets = assets ?? throw new global::System.ArgumentNullException(nameof(assets));
            this.AssetsUrl = assetsUrl ?? throw new global::System.ArgumentNullException(nameof(assetsUrl));
            this.Author = author ?? throw new global::System.ArgumentNullException(nameof(author));
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.CreatedAt = createdAt;
            this.Draft = draft;
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Prerelease = prerelease;
            this.PublishedAt = publishedAt;
            this.TagName = tagName ?? throw new global::System.ArgumentNullException(nameof(tagName));
            this.TarballUrl = tarballUrl ?? throw new global::System.ArgumentNullException(nameof(tarballUrl));
            this.TargetCommitish = targetCommitish ?? throw new global::System.ArgumentNullException(nameof(targetCommitish));
            this.UploadUrl = uploadUrl ?? throw new global::System.ArgumentNullException(nameof(uploadUrl));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ZipballUrl = zipballUrl ?? throw new global::System.ArgumentNullException(nameof(zipballUrl));
            this.DiscussionUrl = discussionUrl;
            this.Reactions = reactions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookReleasePrereleasedRelease" /> class.
        /// </summary>
        public WebhookReleasePrereleasedRelease()
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
        public static global::G.WebhookReleasePrereleasedRelease? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.WebhookReleasePrereleasedRelease),
                jsonSerializerContext) as global::G.WebhookReleasePrereleasedRelease;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.WebhookReleasePrereleasedRelease? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.WebhookReleasePrereleasedRelease>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.WebhookReleasePrereleasedRelease?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.WebhookReleasePrereleasedRelease),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.WebhookReleasePrereleasedRelease;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.WebhookReleasePrereleasedRelease?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.WebhookReleasePrereleasedRelease?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}