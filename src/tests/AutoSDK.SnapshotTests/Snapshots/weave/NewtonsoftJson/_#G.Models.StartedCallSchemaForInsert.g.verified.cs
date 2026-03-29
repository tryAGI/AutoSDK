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
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("trace_id")]
        public string? TraceId { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("otel_dump")]
        public object? OtelDump { get; set; }

        /// <summary>
        /// Do not set directly. Server will automatically populate this field.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wb_user_id")]
        public string? WbUserId { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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