//HintName: G.Models.Asset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A reference file (image, audio, or video) that you upload to the platform for use in downstream workflows such as indexing, analyzing video content, and creating entities.
    /// </summary>
    public sealed partial class Asset
    {
        /// <summary>
        /// The unique identifier of the asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// Indicates how you uploaded the asset.<br/>
        /// **Values**:<br/>
        /// - `direct`: Uploaded from your local file system<br/>
        /// - `url`: Uploaded from a publicly accessible URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AssetMethodJsonConverter))]
        public global::G.AssetMethod? Method { get; set; }

        /// <summary>
        /// Indicates the current status of the asset.<br/>
        /// **Values**:<br/>
        /// - `failed`: The platform failed to process the upload<br/>
        /// - `processing`: The platform is processing the uploaded file<br/>
        /// - `ready`: The asset is ready to use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AssetStatusJsonConverter))]
        public global::G.AssetStatus? Status { get; set; }

        /// <summary>
        /// The name of the file used to create the asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// The MIME type of the asset file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_type")]
        public string? FileType { get; set; }

        /// <summary>
        /// The date and time, in RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), when the asset was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Asset" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the asset.
        /// </param>
        /// <param name="method">
        /// Indicates how you uploaded the asset.<br/>
        /// **Values**:<br/>
        /// - `direct`: Uploaded from your local file system<br/>
        /// - `url`: Uploaded from a publicly accessible URL
        /// </param>
        /// <param name="status">
        /// Indicates the current status of the asset.<br/>
        /// **Values**:<br/>
        /// - `failed`: The platform failed to process the upload<br/>
        /// - `processing`: The platform is processing the uploaded file<br/>
        /// - `ready`: The asset is ready to use
        /// </param>
        /// <param name="filename">
        /// The name of the file used to create the asset.
        /// </param>
        /// <param name="fileType">
        /// The MIME type of the asset file.
        /// </param>
        /// <param name="createdAt">
        /// The date and time, in RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), when the asset was created.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Asset(
            string? id,
            global::G.AssetMethod? method,
            global::G.AssetStatus? status,
            string? filename,
            string? fileType,
            global::System.DateTime? createdAt)
        {
            this.Id = id;
            this.Method = method;
            this.Status = status;
            this.Filename = filename;
            this.FileType = fileType;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Asset" /> class.
        /// </summary>
        public Asset()
        {
        }
    }
}