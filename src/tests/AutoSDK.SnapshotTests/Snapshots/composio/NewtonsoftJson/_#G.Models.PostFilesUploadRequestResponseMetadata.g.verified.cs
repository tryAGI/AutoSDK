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
        [global::Newtonsoft.Json.JsonProperty("storage_backend", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PostFilesUploadRequestResponseMetadataStorageBackend StorageBackend { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostFilesUploadRequestResponseMetadata" /> class.
        /// </summary>
        /// <param name="storageBackend">
        /// Storage backend used for the file. If this is azure, use `x-ms-blob-type` header to set the blob type to `BlockBlob` while uploading the file
        /// </param>
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