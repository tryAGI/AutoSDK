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
        [global::Newtonsoft.Json.JsonProperty("file_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileName { get; set; } = default!;

        /// <summary>
        /// If null, the default project is used
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entity_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CompleteMultipartUploadRequestEntityType EntityType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entity_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid EntityId { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("container_id")]
        public global::System.Guid? ContainerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_size", Required = global::Newtonsoft.Json.Required.Always)]
        public long FileSize { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mime_type")]
        public string? MimeType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("upload_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UploadId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uploaded_file_parts", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.MultipartUploadPart> UploadedFileParts { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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