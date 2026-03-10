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
        public global::G.WebhookReleasePrereleasedReleaseAuthor? Author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

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
        public string? Name { get; set; }

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
        public global::System.DateTime? PublishedAt { get; set; }

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
        public string? TarballUrl { get; set; }

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
        public string? ZipballUrl { get; set; }

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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookReleasePrereleasedRelease(
            global::System.Collections.Generic.IList<global::G.WebhookReleasePrereleasedReleaseAsset> assets,
            string assetsUrl,
            bool draft,
            string htmlUrl,
            int id,
            string nodeId,
            bool prerelease,
            string tagName,
            string targetCommitish,
            string uploadUrl,
            string url,
            global::G.WebhookReleasePrereleasedReleaseAuthor? author,
            string? body,
            global::System.DateTime? createdAt,
            string? discussionUrl,
            string? name,
            global::System.DateTime? publishedAt,
            global::G.WebhookReleasePrereleasedReleaseReactions? reactions,
            string? tarballUrl,
            string? zipballUrl)
        {
            this.Assets = assets ?? throw new global::System.ArgumentNullException(nameof(assets));
            this.AssetsUrl = assetsUrl ?? throw new global::System.ArgumentNullException(nameof(assetsUrl));
            this.Draft = draft;
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Prerelease = prerelease;
            this.TagName = tagName ?? throw new global::System.ArgumentNullException(nameof(tagName));
            this.TargetCommitish = targetCommitish ?? throw new global::System.ArgumentNullException(nameof(targetCommitish));
            this.UploadUrl = uploadUrl ?? throw new global::System.ArgumentNullException(nameof(uploadUrl));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Author = author;
            this.Body = body;
            this.CreatedAt = createdAt;
            this.DiscussionUrl = discussionUrl;
            this.Name = name;
            this.PublishedAt = publishedAt;
            this.Reactions = reactions;
            this.TarballUrl = tarballUrl;
            this.ZipballUrl = zipballUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookReleasePrereleasedRelease" /> class.
        /// </summary>
        public WebhookReleasePrereleasedRelease()
        {
        }
    }
}