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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The title of the user uploaded asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// AssetContentType specifies the MIME type of a particular asset, and provides some helper methods and properties
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AssetContentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AssetContentType ContentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PublicApiUserUploadedAssetStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PublicApiUserUploadedAssetStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetPublicApiMediaAssetMetadataResponse Metadata { get; set; }

        /// <summary>
        /// The code associated with the status. For example if error the reason behind it<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464<br/>
        /// Example: asset_upload
        /// </summary>
        /// <example>asset_upload</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorCode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PublicApiUserUploadedAssetErrorCodesJsonConverter))]
        public global::G.PublicApiUserUploadedAssetErrorCodes? ErrorCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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