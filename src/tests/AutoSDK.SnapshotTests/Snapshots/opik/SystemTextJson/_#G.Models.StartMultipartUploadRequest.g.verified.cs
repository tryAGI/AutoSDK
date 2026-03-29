//HintName: G.Models.StartMultipartUploadRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartMultipartUploadRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_of_file_parts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumOfFileParts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        public string? MimeType { get; set; }

        /// <summary>
        /// If null, the default project is used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StartMultipartUploadRequestEntityTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.StartMultipartUploadRequestEntityType EntityType { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartMultipartUploadRequest" /> class.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="numOfFileParts"></param>
        /// <param name="entityType"></param>
        /// <param name="entityId"></param>
        /// <param name="path"></param>
        /// <param name="mimeType"></param>
        /// <param name="projectName">
        /// If null, the default project is used
        /// </param>
        /// <param name="containerId">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StartMultipartUploadRequest(
            string fileName,
            int numOfFileParts,
            global::G.StartMultipartUploadRequestEntityType entityType,
            global::System.Guid entityId,
            string path,
            string? mimeType,
            string? projectName,
            global::System.Guid? containerId)
        {
            this.FileName = fileName ?? throw new global::System.ArgumentNullException(nameof(fileName));
            this.NumOfFileParts = numOfFileParts;
            this.MimeType = mimeType;
            this.ProjectName = projectName;
            this.EntityType = entityType;
            this.EntityId = entityId;
            this.ContainerId = containerId;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartMultipartUploadRequest" /> class.
        /// </summary>
        public StartMultipartUploadRequest()
        {
        }
    }
}