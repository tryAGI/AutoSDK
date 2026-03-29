//HintName: G.Models.CallSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("op_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string OpName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string TraceId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thread_id")]
        public string? ThreadId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("turn_id")]
        public string? TurnId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime StartedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("attributes", Required = global::Newtonsoft.Json.Required.Always)]
        public object Attributes { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs", Required = global::Newtonsoft.Json.Required.Always)]
        public object Inputs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ended_at")]
        public global::System.DateTime? EndedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exception")]
        public string? Exception { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output")]
        public object? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary")]
        public object? Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wb_user_id")]
        public string? WbUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wb_username")]
        public string? WbUsername { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wb_run_id")]
        public string? WbRunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wb_run_step")]
        public int? WbRunStep { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wb_run_step_end")]
        public int? WbRunStepEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted_at")]
        public global::System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("storage_size_bytes")]
        public long? StorageSizeBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_storage_size_bytes")]
        public long? TotalStorageSizeBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallSchema" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="projectId"></param>
        /// <param name="opName"></param>
        /// <param name="traceId"></param>
        /// <param name="startedAt"></param>
        /// <param name="attributes"></param>
        /// <param name="inputs"></param>
        /// <param name="displayName"></param>
        /// <param name="parentId"></param>
        /// <param name="threadId"></param>
        /// <param name="turnId"></param>
        /// <param name="endedAt"></param>
        /// <param name="exception"></param>
        /// <param name="output"></param>
        /// <param name="summary"></param>
        /// <param name="wbUserId"></param>
        /// <param name="wbUsername"></param>
        /// <param name="wbRunId"></param>
        /// <param name="wbRunStep"></param>
        /// <param name="wbRunStepEnd"></param>
        /// <param name="deletedAt"></param>
        /// <param name="storageSizeBytes"></param>
        /// <param name="totalStorageSizeBytes"></param>
        public CallSchema(
            string id,
            string projectId,
            string opName,
            string traceId,
            global::System.DateTime startedAt,
            object attributes,
            object inputs,
            string? displayName,
            string? parentId,
            string? threadId,
            string? turnId,
            global::System.DateTime? endedAt,
            string? exception,
            object? output,
            object? summary,
            string? wbUserId,
            string? wbUsername,
            string? wbRunId,
            int? wbRunStep,
            int? wbRunStepEnd,
            global::System.DateTime? deletedAt,
            long? storageSizeBytes,
            long? totalStorageSizeBytes)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.OpName = opName ?? throw new global::System.ArgumentNullException(nameof(opName));
            this.DisplayName = displayName;
            this.TraceId = traceId ?? throw new global::System.ArgumentNullException(nameof(traceId));
            this.ParentId = parentId;
            this.ThreadId = threadId;
            this.TurnId = turnId;
            this.StartedAt = startedAt;
            this.Attributes = attributes ?? throw new global::System.ArgumentNullException(nameof(attributes));
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.EndedAt = endedAt;
            this.Exception = exception;
            this.Output = output;
            this.Summary = summary;
            this.WbUserId = wbUserId;
            this.WbUsername = wbUsername;
            this.WbRunId = wbRunId;
            this.WbRunStep = wbRunStep;
            this.WbRunStepEnd = wbRunStepEnd;
            this.DeletedAt = deletedAt;
            this.StorageSizeBytes = storageSizeBytes;
            this.TotalStorageSizeBytes = totalStorageSizeBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallSchema" /> class.
        /// </summary>
        public CallSchema()
        {
        }
    }
}