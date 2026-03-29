//HintName: G.Models.PostFilesUploadRequestResponseMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostFilesUploadRequestResponseMetadata
    {
        /// <summary>
        /// Storage backend used for the file. If this is azure, use `x-ms-blob-type` header to set the blob type to `BlockBlob` while uploading the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage_backend")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PostFilesUploadRequestResponseMetadataStorageBackendJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PostFilesUploadRequestResponseMetadataStorageBackend StorageBackend { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostFilesUploadRequestResponseMetadata" /> class.
        /// </summary>
        /// <param name="storageBackend">
        /// Storage backend used for the file. If this is azure, use `x-ms-blob-type` header to set the blob type to `BlockBlob` while uploading the file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostFilesUploadRequestResponseMetadata(
            global::G.PostFilesUploadRequestResponseMetadataStorageBackend storageBackend)
        {
            this.StorageBackend = storageBackend;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostFilesUploadRequestResponseMetadata" /> class.
        /// </summary>
        public PostFilesUploadRequestResponseMetadata()
        {
        }
    }
}