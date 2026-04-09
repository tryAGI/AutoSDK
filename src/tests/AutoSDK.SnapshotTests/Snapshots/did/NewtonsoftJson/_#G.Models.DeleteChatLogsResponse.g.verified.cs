//HintName: G.Models.DeleteChatLogsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteChatLogsResponse
    {
        /// <summary>
        /// The id of the agent that the export will run for
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// The start of the time range for the export.  If not provided, the export will start from the beginning of the agent's data<br/>
        /// Example: 2024-05-15T12:00:00Z
        /// </summary>
        /// <example>2024-05-15T12:00:00Z</example>
        [global::Newtonsoft.Json.JsonProperty("from")]
        public string? From { get; set; }

        /// <summary>
        /// The end of the time range for the export. If not provided, the export will run until the current time<br/>
        /// Example: 2024-05-15T12:00:00Z
        /// </summary>
        /// <example>2024-05-15T12:00:00Z</example>
        [global::Newtonsoft.Json.JsonProperty("to")]
        public string? To { get; set; }

        /// <summary>
        /// Determines if the export should fetch persistent chats. Defaults to true.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("persistent_chats")]
        public bool? PersistentChats { get; set; }

        /// <summary>
        /// Who created the export
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedBy { get; set; } = default!;

        /// <summary>
        /// When the export was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Indicates full partial or failed export
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.DeleteChatLogsResponseStatusJsonConverter))]
        public global::G.DeleteChatLogsResponseStatus Status { get; set; } = default!;

        /// <summary>
        /// When the export was completed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at")]
        public string? CompletedAt { get; set; }

        /// <summary>
        /// The result of the export.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result")]
        public global::G.DeleteChatLogsResponseResult? Result { get; set; }

        /// <summary>
        /// Error message if the export failed. Known errors include: 'No chats found', 'No chats found in range', 'All chats in dates range have been exported'
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// The total amount of the files in the export
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_files_count")]
        public double? TotalFilesCount { get; set; }

        /// <summary>
        /// The total size of the files in the export
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_files_size")]
        public double? TotalFilesSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("export_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExportId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OwnerId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modified", Required = global::Newtonsoft.Json.Required.Always)]
        public string Modified { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteChatLogsResponse" /> class.
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
        public DeleteChatLogsResponse(
            string agentId,
            string createdBy,
            string createdAt,
            global::G.DeleteChatLogsResponseStatus status,
            string exportId,
            string ownerId,
            string modified,
            string? from,
            string? to,
            bool? persistentChats,
            string? completedAt,
            global::G.DeleteChatLogsResponseResult? result,
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
        /// Initializes a new instance of the <see cref="DeleteChatLogsResponse" /> class.
        /// </summary>
        public DeleteChatLogsResponse()
        {
        }
    }
}