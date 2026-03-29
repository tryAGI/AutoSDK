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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OpName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TraceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_id")]
        public string? ThreadId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_id")]
        public string? TurnId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Attributes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ended_at")]
        public global::System.DateTime? EndedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exception")]
        public string? Exception { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public object? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public object? Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wb_user_id")]
        public string? WbUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wb_username")]
        public string? WbUsername { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wb_run_id")]
        public string? WbRunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wb_run_step")]
        public int? WbRunStep { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wb_run_step_end")]
        public int? WbRunStepEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_at")]
        public global::System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage_size_bytes")]
        public long? StorageSizeBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_storage_size_bytes")]
        public long? TotalStorageSizeBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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