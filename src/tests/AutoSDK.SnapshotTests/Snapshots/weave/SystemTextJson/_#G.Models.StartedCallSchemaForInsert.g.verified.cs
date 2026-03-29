//HintName: G.Models.StartedCallSchemaForInsert.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartedCallSchemaForInsert
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

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
        public string? TraceId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("otel_dump")]
        public object? OtelDump { get; set; }

        /// <summary>
        /// Do not set directly. Server will automatically populate this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wb_user_id")]
        public string? WbUserId { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartedCallSchemaForInsert" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="opName"></param>
        /// <param name="startedAt"></param>
        /// <param name="attributes"></param>
        /// <param name="inputs"></param>
        /// <param name="id"></param>
        /// <param name="displayName"></param>
        /// <param name="traceId"></param>
        /// <param name="parentId"></param>
        /// <param name="threadId"></param>
        /// <param name="turnId"></param>
        /// <param name="otelDump"></param>
        /// <param name="wbUserId">
        /// Do not set directly. Server will automatically populate this field.
        /// </param>
        /// <param name="wbRunId"></param>
        /// <param name="wbRunStep"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StartedCallSchemaForInsert(
            string projectId,
            string opName,
            global::System.DateTime startedAt,
            object attributes,
            object inputs,
            string? id,
            string? displayName,
            string? traceId,
            string? parentId,
            string? threadId,
            string? turnId,
            object? otelDump,
            string? wbUserId,
            string? wbRunId,
            int? wbRunStep)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Id = id;
            this.OpName = opName ?? throw new global::System.ArgumentNullException(nameof(opName));
            this.DisplayName = displayName;
            this.TraceId = traceId;
            this.ParentId = parentId;
            this.ThreadId = threadId;
            this.TurnId = turnId;
            this.StartedAt = startedAt;
            this.Attributes = attributes ?? throw new global::System.ArgumentNullException(nameof(attributes));
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.OtelDump = otelDump;
            this.WbUserId = wbUserId;
            this.WbRunId = wbRunId;
            this.WbRunStep = wbRunStep;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartedCallSchemaForInsert" /> class.
        /// </summary>
        public StartedCallSchemaForInsert()
        {
        }
    }
}