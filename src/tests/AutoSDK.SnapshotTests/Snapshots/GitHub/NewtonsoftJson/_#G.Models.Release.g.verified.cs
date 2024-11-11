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
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assets_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string AssetsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("upload_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string UploadUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tarball_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string? TarballUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("zipball_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string? ZipballUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// The name of the tag.<br/>
        /// Example: v1.0.0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tag_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string TagName { get; set; } = default!;

        /// <summary>
        /// Specifies the commitish value that determines where the Git tag is created from.<br/>
        /// Example: master
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_commitish", Required = global::Newtonsoft.Json.Required.Always)]
        public string TargetCommitish { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body")]
        public string? Body { get; set; }

        /// <summary>
        /// true to create a draft (unpublished) release, false to create a published one.<br/>
        /// Example: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("draft", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Draft { get; set; } = default!;

        /// <summary>
        /// Whether to identify the release as a prerelease or a full release.<br/>
        /// Example: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prerelease", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Prerelease { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("published_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? PublishedAt { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleUser Author { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assets", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ReleaseAsset> Assets { get; set; } = default!;

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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mentions_count")]
        public int? MentionsCount { get; set; }

        /// <summary>
        /// The URL of the release discussion.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("discussion_url")]
        public string? DiscussionUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reactions")]
        public global::G.ReactionRollup? Reactions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        public static global::G.Release? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Release>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.Release?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.Release?>(serializer.Deserialize<global::G.Release>(jsonReader));
        }

    }
}