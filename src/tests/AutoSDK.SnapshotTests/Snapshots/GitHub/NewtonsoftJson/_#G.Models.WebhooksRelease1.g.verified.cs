//HintName: G.Models.WebhooksRelease1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The [release](https://docs.github.com/rest/releases/releases/#get-a-release) object.
    /// </summary>
    public sealed partial class WebhooksRelease1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assets", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WebhooksRelease1Asset> Assets { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assets_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string AssetsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhooksRelease1Author? Author { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Body { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("discussion_url")]
        public string? DiscussionUrl { get; set; }

        /// <summary>
        /// Whether the release is a draft or published
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("draft", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Draft { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// Whether the release is identified as a prerelease or a full release.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prerelease", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Prerelease { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("published_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? PublishedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reactions")]
        public global::G.WebhooksRelease1Reactions? Reactions { get; set; }

        /// <summary>
        /// The name of the tag.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tag_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string TagName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tarball_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string? TarballUrl { get; set; } = default!;

        /// <summary>
        /// Specifies the commitish value that determines where the Git tag is created from.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_commitish", Required = global::Newtonsoft.Json.Required.Always)]
        public string TargetCommitish { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("upload_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string UploadUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("zipball_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string? ZipballUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksRelease1" /> class.
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
        public WebhooksRelease1(
            global::System.Collections.Generic.IList<global::G.WebhooksRelease1Asset> assets,
            string assetsUrl,
            global::G.WebhooksRelease1Author? author,
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
            global::G.WebhooksRelease1Reactions? reactions)
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
        /// Initializes a new instance of the <see cref="WebhooksRelease1" /> class.
        /// </summary>
        public WebhooksRelease1()
        {
        }
    }
}