//HintName: G.Models.PostFilesUploadRequestResponseMetadataStorageBackend.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Storage backend used for the file. If this is azure, use `x-ms-blob-type` header to set the blob type to `BlockBlob` while uploading the file
    /// </summary>
    public enum PostFilesUploadRequestResponseMetadataStorageBackend
    {
        /// <summary>
        /// 
        /// </summary>
        AzureBlobStorage,
        /// <summary>
        /// 
        /// </summary>
        S3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostFilesUploadRequestResponseMetadataStorageBackendExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostFilesUploadRequestResponseMetadataStorageBackend value)
        {
            return value switch
            {
                PostFilesUploadRequestResponseMetadataStorageBackend.AzureBlobStorage => "azure_blob_storage",
                PostFilesUploadRequestResponseMetadataStorageBackend.S3 => "s3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostFilesUploadRequestResponseMetadataStorageBackend? ToEnum(string value)
        {
            return value switch
            {
                "azure_blob_storage" => PostFilesUploadRequestResponseMetadataStorageBackend.AzureBlobStorage,
                "s3" => PostFilesUploadRequestResponseMetadataStorageBackend.S3,
                _ => null,
            };
        }
    }
}