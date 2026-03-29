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
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileId { get; set; } = default!;

        /// <summary>
        /// Deprecated: Use `folder_id` field instead. Unique identifier of the source.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SourceId { get; set; } = default!;

        /// <summary>
        /// Name of the file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileName { get; set; } = default!;

        /// <summary>
        /// True if the agent currently has the file open.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_open")]
        public bool? IsOpen { get; set; }

        /// <summary>
        /// Portion of the file the agent is focused on (may be large).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("visible_content")]
        public string? VisibleContent { get; set; }

        /// <summary>
        /// UTC timestamp of the agent's most recent access to this file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_accessed_at")]
        public global::System.DateTime? LastAccessedAt { get; set; }

        /// <summary>
        /// Starting line number (1-indexed) when file was opened with line range.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_line")]
        public int? StartLine { get; set; }

        /// <summary>
        /// Ending line number (exclusive) when file was opened with line range.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_line")]
        public int? EndLine { get; set; }

        /// <summary>
        /// Human-readable identifier for this file-agent relationship in the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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