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
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhooksRelease1AssetState State { get; set; } = default!;

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
    }
}