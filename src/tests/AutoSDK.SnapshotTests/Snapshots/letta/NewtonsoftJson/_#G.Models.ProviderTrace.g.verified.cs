//HintName: G.Models.ProviderTrace.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Letta's internal representation of a provider trace.<br/>
    /// Attributes:<br/>
    ///     id (str): The unique identifier of the provider trace.<br/>
    ///     request_json (Dict[str, Any]): JSON content of the provider request.<br/>
    ///     response_json (Dict[str, Any]): JSON content of the provider response.<br/>
    ///     step_id (str): ID of the step that this trace is associated with.<br/>
    ///     agent_id (str): ID of the agent that generated this trace.<br/>
    ///     agent_tags (list[str]): Tags associated with the agent for filtering.<br/>
    ///     call_type (str): Type of call (agent_step, summarization, etc.).<br/>
    ///     run_id (str): ID of the run this trace is associated with.<br/>
    ///     source (str): Source service that generated this trace (memgpt-server, lettuce-py).<br/>
    ///     organization_id (str): The unique identifier of the organization.<br/>
    ///     user_id (str): The unique identifier of the user who initiated the request.<br/>
    ///     compaction_settings (Dict[str, Any]): Compaction/summarization settings (only for summarization calls).<br/>
    ///     llm_config (Dict[str, Any]): LLM configuration used for this call (only for non-summarization calls).<br/>
    ///     created_at (datetime): The timestamp when the object was created.
    /// </summary>
    public sealed partial class ProviderTrace
    {
        /// <summary>
        /// The id of the user that made this object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by_id")]
        public string? CreatedById { get; set; }

        /// <summary>
        /// The id of the user that made this object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated_by_id")]
        public string? LastUpdatedById { get; set; }

        /// <summary>
        /// The timestamp when the object was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The timestamp when the object was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The human-friendly ID of the Provider_trace
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// JSON content of the provider request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_json", Required = global::Newtonsoft.Json.Required.Always)]
        public object RequestJson { get; set; } = default!;

        /// <summary>
        /// JSON content of the provider response
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_json", Required = global::Newtonsoft.Json.Required.Always)]
        public object ResponseJson { get; set; } = default!;

        /// <summary>
        /// ID of the step that this trace is associated with
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("step_id")]
        public string? StepId { get; set; }

        /// <summary>
        /// ID of the agent that generated this trace
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// Tags associated with the agent for filtering
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_tags")]
        public global::System.Collections.Generic.IList<string>? AgentTags { get; set; }

        /// <summary>
        /// Type of call (agent_step, summarization, etc.)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_type")]
        public string? CallType { get; set; }

        /// <summary>
        /// ID of the run this trace is associated with
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_id")]
        public string? RunId { get; set; }

        /// <summary>
        /// Source service that generated this trace (memgpt-server, lettuce-py)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source")]
        public string? Source { get; set; }

        /// <summary>
        /// ID of the organization
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("org_id")]
        public string? OrgId { get; set; }

        /// <summary>
        /// Compaction/summarization settings (summarization calls only)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("compaction_settings")]
        public object? CompactionSettings { get; set; }

        /// <summary>
        /// LLM configuration used for this call (non-summarization calls only)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("llm_config")]
        public object? LlmConfig { get; set; }

        /// <summary>
        /// Billing context from request headers
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("billing_context")]
        public global::G.BillingContext? BillingContext { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderTrace" /> class.
        /// </summary>
        /// <param name="requestJson">
        /// JSON content of the provider request
        /// </param>
        /// <param name="responseJson">
        /// JSON content of the provider response
        /// </param>
        /// <param name="createdById">
        /// The id of the user that made this object.
        /// </param>
        /// <param name="lastUpdatedById">
        /// The id of the user that made this object.
        /// </param>
        /// <param name="createdAt">
        /// The timestamp when the object was created.
        /// </param>
        /// <param name="updatedAt">
        /// The timestamp when the object was last updated.
        /// </param>
        /// <param name="id">
        /// The human-friendly ID of the Provider_trace
        /// </param>
        /// <param name="stepId">
        /// ID of the step that this trace is associated with
        /// </param>
        /// <param name="agentId">
        /// ID of the agent that generated this trace
        /// </param>
        /// <param name="agentTags">
        /// Tags associated with the agent for filtering
        /// </param>
        /// <param name="callType">
        /// Type of call (agent_step, summarization, etc.)
        /// </param>
        /// <param name="runId">
        /// ID of the run this trace is associated with
        /// </param>
        /// <param name="source">
        /// Source service that generated this trace (memgpt-server, lettuce-py)
        /// </param>
        /// <param name="orgId">
        /// ID of the organization
        /// </param>
        /// <param name="compactionSettings">
        /// Compaction/summarization settings (summarization calls only)
        /// </param>
        /// <param name="llmConfig">
        /// LLM configuration used for this call (non-summarization calls only)
        /// </param>
        /// <param name="billingContext">
        /// Billing context from request headers
        /// </param>
        public ProviderTrace(
            object requestJson,
            object responseJson,
            string? createdById,
            string? lastUpdatedById,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            string? id,
            string? stepId,
            string? agentId,
            global::System.Collections.Generic.IList<string>? agentTags,
            string? callType,
            string? runId,
            string? source,
            string? orgId,
            object? compactionSettings,
            object? llmConfig,
            global::G.BillingContext? billingContext)
        {
            this.CreatedById = createdById;
            this.LastUpdatedById = lastUpdatedById;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Id = id;
            this.RequestJson = requestJson ?? throw new global::System.ArgumentNullException(nameof(requestJson));
            this.ResponseJson = responseJson ?? throw new global::System.ArgumentNullException(nameof(responseJson));
            this.StepId = stepId;
            this.AgentId = agentId;
            this.AgentTags = agentTags;
            this.CallType = callType;
            this.RunId = runId;
            this.Source = source;
            this.OrgId = orgId;
            this.CompactionSettings = compactionSettings;
            this.LlmConfig = llmConfig;
            this.BillingContext = billingContext;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderTrace" /> class.
        /// </summary>
        public ProviderTrace()
        {
        }
    }
}