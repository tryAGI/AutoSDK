﻿//HintName: G.Models.ReleaseAsset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Data related to a release.
    /// </summary>
    public sealed partial class ReleaseAsset
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("browser_download_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string BrowserDownloadUrl { get; set; } = default!;

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
        /// The file name of the asset.<br/>
        /// Example: Team Environment
        /// </summary>
        /// <example>Team Environment</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Label { get; set; } = default!;

        /// <summary>
        /// State of the release asset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ReleaseAssetState State { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string ContentType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size", Required = global::Newtonsoft.Json.Required.Always)]
        public int Size { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("download_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int DownloadCount { get; set; } = default!;

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
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uploader", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? Uploader { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReleaseAsset" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="browserDownloadUrl"></param>
        /// <param name="id"></param>
        /// <param name="nodeId"></param>
        /// <param name="name">
        /// The file name of the asset.<br/>
        /// Example: Team Environment
        /// </param>
        /// <param name="label"></param>
        /// <param name="state">
        /// State of the release asset.
        /// </param>
        /// <param name="contentType"></param>
        /// <param name="size"></param>
        /// <param name="downloadCount"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="uploader">
        /// A GitHub user.
        /// </param>
        public ReleaseAsset(
            string url,
            string browserDownloadUrl,
            int id,
            string nodeId,
            string name,
            string? label,
            global::G.ReleaseAssetState state,
            string contentType,
            int size,
            int downloadCount,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::G.NullableSimpleUser? uploader)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.BrowserDownloadUrl = browserDownloadUrl ?? throw new global::System.ArgumentNullException(nameof(browserDownloadUrl));
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.State = state;
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.Size = size;
            this.DownloadCount = downloadCount;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Uploader = uploader ?? throw new global::System.ArgumentNullException(nameof(uploader));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReleaseAsset" /> class.
        /// </summary>
        public ReleaseAsset()
        {
        }
    }
}