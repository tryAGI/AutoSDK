//HintName: G.Models.AgentFileAttachment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response model for agent file attachments showing file status in agent context
    /// </summary>
    public sealed partial class AgentFileAttachment
    {
        /// <summary>
        /// Unique identifier of the file-agent relationship
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileId { get; set; } = default!;

        /// <summary>
        /// Name of the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileName { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the folder/source
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("folder_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FolderId { get; set; } = default!;

        /// <summary>
        /// Name of the folder/source
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("folder_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string FolderName { get; set; } = default!;

        /// <summary>
        /// Whether the file is currently open in the agent's context
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_open", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsOpen { get; set; } = default!;

        /// <summary>
        /// Timestamp of last access by the agent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_accessed_at")]
        public global::System.DateTime? LastAccessedAt { get; set; }

        /// <summary>
        /// Portion of the file visible to the agent if open
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("visible_content")]
        public string? VisibleContent { get; set; }

        /// <summary>
        /// Starting line number if file was opened with line range
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_line")]
        public int? StartLine { get; set; }

        /// <summary>
        /// Ending line number if file was opened with line range
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_line")]
        public int? EndLine { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentFileAttachment" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the file-agent relationship
        /// </param>
        /// <param name="fileId">
        /// Unique identifier of the file
        /// </param>
        /// <param name="fileName">
        /// Name of the file
        /// </param>
        /// <param name="folderId">
        /// Unique identifier of the folder/source
        /// </param>
        /// <param name="folderName">
        /// Name of the folder/source
        /// </param>
        /// <param name="isOpen">
        /// Whether the file is currently open in the agent's context
        /// </param>
        /// <param name="lastAccessedAt">
        /// Timestamp of last access by the agent
        /// </param>
        /// <param name="visibleContent">
        /// Portion of the file visible to the agent if open
        /// </param>
        /// <param name="startLine">
        /// Starting line number if file was opened with line range
        /// </param>
        /// <param name="endLine">
        /// Ending line number if file was opened with line range
        /// </param>
        public AgentFileAttachment(
            string id,
            string fileId,
            string fileName,
            string folderId,
            string folderName,
            bool isOpen,
            global::System.DateTime? lastAccessedAt,
            string? visibleContent,
            int? startLine,
            int? endLine)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.FileName = fileName ?? throw new global::System.ArgumentNullException(nameof(fileName));
            this.FolderId = folderId ?? throw new global::System.ArgumentNullException(nameof(folderId));
            this.FolderName = folderName ?? throw new global::System.ArgumentNullException(nameof(folderName));
            this.IsOpen = isOpen;
            this.LastAccessedAt = lastAccessedAt;
            this.VisibleContent = visibleContent;
            this.StartLine = startLine;
            this.EndLine = endLine;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentFileAttachment" /> class.
        /// </summary>
        public AgentFileAttachment()
        {
        }
    }
}