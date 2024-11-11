//HintName: G.Models.ReleaseAsset.g.cs

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
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("browser_download_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BrowserDownloadUrl { get; set; }

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
        /// The file name of the asset.<br/>
        /// Example: Team Environment
        /// </summary>
        /// <example>Team Environment</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Label { get; set; }

        /// <summary>
        /// State of the release asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ReleaseAssetStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ReleaseAssetState State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DownloadCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploader")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NullableSimpleUser? Uploader { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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