//HintName: G.Models.GetPublicApiUserUploadedAssetResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPublicApiUserUploadedAssetResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The title of the user uploaded asset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// AssetContentType specifies the MIME type of a particular asset, and provides some helper methods and properties
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contentType", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AssetContentType ContentType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PublicApiUserUploadedAssetStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetPublicApiMediaAssetMetadataResponse Metadata { get; set; } = default!;

        /// <summary>
        /// The code associated with the status. For example if error the reason behind it<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464<br/>
        /// Example: asset_upload
        /// </summary>
        /// <example>asset_upload</example>
        [global::Newtonsoft.Json.JsonProperty("errorCode")]
        public global::G.PublicApiUserUploadedAssetErrorCodes? ErrorCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPublicApiUserUploadedAssetResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title">
        /// The title of the user uploaded asset.
        /// </param>
        /// <param name="contentType">
        /// AssetContentType specifies the MIME type of a particular asset, and provides some helper methods and properties
        /// </param>
        /// <param name="status"></param>
        /// <param name="metadata"></param>
        /// <param name="errorCode">
        /// The code associated with the status. For example if error the reason behind it<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464<br/>
        /// Example: asset_upload
        /// </param>
        public GetPublicApiUserUploadedAssetResponse(
            string id,
            string title,
            global::G.AssetContentType contentType,
            global::G.PublicApiUserUploadedAssetStatus status,
            global::G.GetPublicApiMediaAssetMetadataResponse metadata,
            global::G.PublicApiUserUploadedAssetErrorCodes? errorCode)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.ContentType = contentType;
            this.Status = status;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPublicApiUserUploadedAssetResponse" /> class.
        /// </summary>
        public GetPublicApiUserUploadedAssetResponse()
        {
        }
    }
}