//HintName: G.Models.FileAgentSchema.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// File-Agent relationship with human-readable ID for agent file
    /// </summary>
    public sealed partial class FileAgentSchema
    {
        /// <summary>
        /// Unique identifier of the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// Unique identifier of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// Deprecated: Use `folder_id` field instead. Unique identifier of the source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceId { get; set; }

        /// <summary>
        /// Name of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileName { get; set; }

        /// <summary>
        /// True if the agent currently has the file open.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_open")]
        public bool? IsOpen { get; set; }

        /// <summary>
        /// Portion of the file the agent is focused on (may be large).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visible_content")]
        public string? VisibleContent { get; set; }

        /// <summary>
        /// UTC timestamp of the agent's most recent access to this file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_accessed_at")]
        public global::System.DateTime? LastAccessedAt { get; set; }

        /// <summary>
        /// Starting line number (1-indexed) when file was opened with line range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_line")]
        public int? StartLine { get; set; }

        /// <summary>
        /// Ending line number (exclusive) when file was opened with line range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_line")]
        public int? EndLine { get; set; }

        /// <summary>
        /// Human-readable identifier for this file-agent relationship in the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileAgentSchema" /> class.
        /// </summary>
        /// <param name="agentId">
        /// Unique identifier of the agent.
        /// </param>
        /// <param name="fileId">
        /// Unique identifier of the file.
        /// </param>
        /// <param name="sourceId">
        /// Deprecated: Use `folder_id` field instead. Unique identifier of the source.
        /// </param>
        /// <param name="fileName">
        /// Name of the file.
        /// </param>
        /// <param name="id">
        /// Human-readable identifier for this file-agent relationship in the file
        /// </param>
        /// <param name="isOpen">
        /// True if the agent currently has the file open.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="visibleContent">
        /// Portion of the file the agent is focused on (may be large).
        /// </param>
        /// <param name="lastAccessedAt">
        /// UTC timestamp of the agent's most recent access to this file.
        /// </param>
        /// <param name="startLine">
        /// Starting line number (1-indexed) when file was opened with line range.
        /// </param>
        /// <param name="endLine">
        /// Ending line number (exclusive) when file was opened with line range.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileAgentSchema(
            string agentId,
            string fileId,
            string sourceId,
            string fileName,
            string id,
            bool? isOpen,
            string? visibleContent,
            global::System.DateTime? lastAccessedAt,
            int? startLine,
            int? endLine)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.SourceId = sourceId ?? throw new global::System.ArgumentNullException(nameof(sourceId));
            this.FileName = fileName ?? throw new global::System.ArgumentNullException(nameof(fileName));
            this.IsOpen = isOpen;
            this.VisibleContent = visibleContent;
            this.LastAccessedAt = lastAccessedAt;
            this.StartLine = startLine;
            this.EndLine = endLine;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileAgentSchema" /> class.
        /// </summary>
        public FileAgentSchema()
        {
        }
    }
}