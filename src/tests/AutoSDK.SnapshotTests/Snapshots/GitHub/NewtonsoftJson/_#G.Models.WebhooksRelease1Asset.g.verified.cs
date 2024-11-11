//HintName: G.Models.WebhooksRelease1Asset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Data related to a release.
    /// </summary>
    public sealed partial class WebhooksRelease1Asset
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("browser_download_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string BrowserDownloadUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string ContentType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("download_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int DownloadCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Label { get; set; } = default!;

        /// <summary>
        /// The file name of the asset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size", Required = global::Newtonsoft.Json.Required.Always)]
        public int Size { get; set; } = default!;

        /// <summary>
        /// State of the release asset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public global::G.WebhooksRelease1AssetState State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uploader")]
        public global::G.WebhooksRelease1AssetUploader? Uploader { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksRelease1Asset" /> class.
        /// </summary>
        /// <param name="browserDownloadUrl"></param>
        /// <param name="contentType"></param>
        /// <param name="createdAt"></param>
        /// <param name="downloadCount"></param>
        /// <param name="id"></param>
        /// <param name="label"></param>
        /// <param name="name">
        /// The file name of the asset.
        /// </param>
        /// <param name="nodeId"></param>
        /// <param name="size"></param>
        /// <param name="state">
        /// State of the release asset.
        /// </param>
        /// <param name="updatedAt"></param>
        /// <param name="uploader"></param>
        /// <param name="url"></param>
        public WebhooksRelease1Asset(
            string browserDownloadUrl,
            string contentType,
            global::System.DateTime createdAt,
            int downloadCount,
            int id,
            string? label,
            string name,
            string nodeId,
            int size,
            global::System.DateTime updatedAt,
            string url,
            global::G.WebhooksRelease1AssetState state,
            global::G.WebhooksRelease1AssetUploader? uploader)
        {
            this.BrowserDownloadUrl = browserDownloadUrl ?? throw new global::System.ArgumentNullException(nameof(browserDownloadUrl));
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.CreatedAt = createdAt;
            this.DownloadCount = downloadCount;
            this.Id = id;
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Size = size;
            this.UpdatedAt = updatedAt;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.State = state;
            this.Uploader = uploader;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksRelease1Asset" /> class.
        /// </summary>
        public WebhooksRelease1Asset()
        {
        }
    }
}