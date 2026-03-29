//HintName: G.Models.CompleteMultipartUploadRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompleteMultipartUploadRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileName { get; set; }

        /// <summary>
        /// If null, the default project is used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CompleteMultipartUploadRequestEntityTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CompleteMultipartUploadRequestEntityType EntityType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid EntityId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container_id")]
        public global::System.Guid? ContainerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long FileSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        public string? MimeType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UploadId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploaded_file_parts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.MultipartUploadPart> UploadedFileParts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompleteMultipartUploadRequest" /> class.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="entityType"></param>
        /// <param name="entityId"></param>
        /// <param name="fileSize"></param>
        /// <param name="uploadId"></param>
        /// <param name="uploadedFileParts"></param>
        /// <param name="projectName">
        /// If null, the default project is used
        /// </param>
        /// <param name="containerId">
        /// Included only in responses
        /// </param>
        /// <param name="mimeType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompleteMultipartUploadRequest(
            string fileName,
            global::G.CompleteMultipartUploadRequestEntityType entityType,
            global::System.Guid entityId,
            long fileSize,
            string uploadId,
            global::System.Collections.Generic.IList<global::G.MultipartUploadPart> uploadedFileParts,
            string? projectName,
            global::System.Guid? containerId,
            string? mimeType)
        {
            this.FileName = fileName ?? throw new global::System.ArgumentNullException(nameof(fileName));
            this.ProjectName = projectName;
            this.EntityType = entityType;
            this.EntityId = entityId;
            this.ContainerId = containerId;
            this.FileSize = fileSize;
            this.MimeType = mimeType;
            this.UploadId = uploadId ?? throw new global::System.ArgumentNullException(nameof(uploadId));
            this.UploadedFileParts = uploadedFileParts ?? throw new global::System.ArgumentNullException(nameof(uploadedFileParts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompleteMultipartUploadRequest" /> class.
        /// </summary>
        public CompleteMultipartUploadRequest()
        {
        }
    }
}