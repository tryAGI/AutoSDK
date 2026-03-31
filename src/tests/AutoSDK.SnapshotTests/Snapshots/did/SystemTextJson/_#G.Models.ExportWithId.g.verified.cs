//HintName: G.Models.ExportWithId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExportWithId
    {
        /// <summary>
        /// The id of the agent that the export will run for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// The start of the time range for the export.  If not provided, the export will start from the beginning of the agent's data<br/>
        /// Example: 2024-05-15T12:00:00Z
        /// </summary>
        /// <example>2024-05-15T12:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        public string? From { get; set; }

        /// <summary>
        /// The end of the time range for the export. If not provided, the export will run until the current time<br/>
        /// Example: 2024-05-15T12:00:00Z
        /// </summary>
        /// <example>2024-05-15T12:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        public string? To { get; set; }

        /// <summary>
        /// Determines if the export should fetch persistent chats. Defaults to true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("persistent_chats")]
        public bool? PersistentChats { get; set; }

        /// <summary>
        /// Who created the export
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedBy { get; set; }

        /// <summary>
        /// When the export was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Indicates full partial or failed export
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ExportWithIdStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ExportWithIdStatus Status { get; set; }

        /// <summary>
        /// When the export was completed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public string? CompletedAt { get; set; }

        /// <summary>
        /// The result of the export.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::G.ExportWithIdResult? Result { get; set; }

        /// <summary>
        /// Error message if the export failed. Known errors include: 'No chats found', 'No chats found in range', 'All chats in dates range have been exported'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// The total amount of the files in the export
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_files_count")]
        public double? TotalFilesCount { get; set; }

        /// <summary>
        /// The total size of the files in the export
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_files_size")]
        public double? TotalFilesSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("export_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExportId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Modified { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportWithId" /> class.
        /// </summary>
        /// <param name="agentId">
        /// The id of the agent that the export will run for
        /// </param>
        /// <param name="createdBy">
        /// Who created the export
        /// </param>
        /// <param name="createdAt">
        /// When the export was created
        /// </param>
        /// <param name="status">
        /// Indicates full partial or failed export
        /// </param>
        /// <param name="exportId"></param>
        /// <param name="ownerId"></param>
        /// <param name="modified"></param>
        /// <param name="from">
        /// The start of the time range for the export.  If not provided, the export will start from the beginning of the agent's data<br/>
        /// Example: 2024-05-15T12:00:00Z
        /// </param>
        /// <param name="to">
        /// The end of the time range for the export. If not provided, the export will run until the current time<br/>
        /// Example: 2024-05-15T12:00:00Z
        /// </param>
        /// <param name="persistentChats">
        /// Determines if the export should fetch persistent chats. Defaults to true.
        /// </param>
        /// <param name="completedAt">
        /// When the export was completed
        /// </param>
        /// <param name="result">
        /// The result of the export.
        /// </param>
        /// <param name="error">
        /// Error message if the export failed. Known errors include: 'No chats found', 'No chats found in range', 'All chats in dates range have been exported'
        /// </param>
        /// <param name="totalFilesCount">
        /// The total amount of the files in the export
        /// </param>
        /// <param name="totalFilesSize">
        /// The total size of the files in the export
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExportWithId(
            string agentId,
            string createdBy,
            string createdAt,
            global::G.ExportWithIdStatus status,
            string exportId,
            string ownerId,
            string modified,
            string? from,
            string? to,
            bool? persistentChats,
            string? completedAt,
            global::G.ExportWithIdResult? result,
            string? error,
            double? totalFilesCount,
            double? totalFilesSize)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.From = from;
            this.To = to;
            this.PersistentChats = persistentChats;
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Status = status;
            this.CompletedAt = completedAt;
            this.Result = result;
            this.Error = error;
            this.TotalFilesCount = totalFilesCount;
            this.TotalFilesSize = totalFilesSize;
            this.ExportId = exportId ?? throw new global::System.ArgumentNullException(nameof(exportId));
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.Modified = modified ?? throw new global::System.ArgumentNullException(nameof(modified));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportWithId" /> class.
        /// </summary>
        public ExportWithId()
        {
        }
    }
}