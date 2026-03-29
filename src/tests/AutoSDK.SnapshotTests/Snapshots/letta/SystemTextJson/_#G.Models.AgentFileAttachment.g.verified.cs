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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Unique identifier of the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// Name of the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileName { get; set; }

        /// <summary>
        /// Unique identifier of the folder/source
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FolderId { get; set; }

        /// <summary>
        /// Name of the folder/source
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FolderName { get; set; }

        /// <summary>
        /// Whether the file is currently open in the agent's context
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_open")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsOpen { get; set; }

        /// <summary>
        /// Timestamp of last access by the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_accessed_at")]
        public global::System.DateTime? LastAccessedAt { get; set; }

        /// <summary>
        /// Portion of the file visible to the agent if open
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visible_content")]
        public string? VisibleContent { get; set; }

        /// <summary>
        /// Starting line number if file was opened with line range
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_line")]
        public int? StartLine { get; set; }

        /// <summary>
        /// Ending line number if file was opened with line range
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_line")]
        public int? EndLine { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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