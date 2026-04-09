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
        [global::Newtonsoft.Json.JsonProperty("file_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_of_file_parts", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumOfFileParts { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mime_type")]
        public string? MimeType { get; set; }

        /// <summary>
        /// If null, the default project is used
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entity_type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.StartMultipartUploadRequestEntityTypeJsonConverter))]
        public global::G.StartMultipartUploadRequestEntityType EntityType { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string Path { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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