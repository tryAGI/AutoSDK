//HintName: G.Models.AgentState.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Representation of an agent's state. This is the state of the agent at a given time, and is persisted in the DB backend. The state has all the information needed to recreate a persisted agent.
    /// </summary>
    public sealed partial class AgentState
    {
        /// <summary>
        /// The id of the user that made this object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by_id")]
        public string? CreatedById { get; set; }

        /// <summary>
        /// The id of the user that made this object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_by_id")]
        public string? LastUpdatedById { get; set; }

        /// <summary>
        /// The timestamp when the object was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The timestamp when the object was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The id of the agent. Assigned by the database.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The name of the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The list of tool rules.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_rules")]
        public global::System.Collections.Generic.IList<global::G.ToolRulesVariant1Item>? ToolRules { get; set; }

        /// <summary>
        /// The ids of the messages in the agent's in-context memory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_ids")]
        public global::System.Collections.Generic.IList<string>? MessageIds { get; set; }

        /// <summary>
        /// The system prompt used by the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string System { get; set; }

        /// <summary>
        /// The type of agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AgentType AgentType { get; set; }

        /// <summary>
        /// Deprecated: Use `model` field instead. The LLM configuration used by the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.LLMConfig LlmConfig { get; set; }

        /// <summary>
        /// Deprecated: Use `embedding` field instead. The embedding configuration used by the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_config")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.EmbeddingConfig? EmbeddingConfig { get; set; }

        /// <summary>
        /// The model handle used by the agent (format: provider/model-name).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The embedding model handle used by the agent (format: provider/model-name).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding")]
        public string? Embedding { get; set; }

        /// <summary>
        /// The model settings used by the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_settings")]
        public global::G.ModelSettingsVariant1? ModelSettings { get; set; }

        /// <summary>
        /// The compaction settings configuration used for compaction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compaction_settings")]
        public global::G.CompactionSettingsOutput? CompactionSettings { get; set; }

        /// <summary>
        /// The response format used by the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        public global::G.ResponseFormatVariant1? ResponseFormat { get; set; }

        /// <summary>
        /// The description of the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The metadata of the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Deprecated: Use `blocks` field instead. The in-context memory of the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Memory Memory { get; set; }

        /// <summary>
        /// The memory blocks used by the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Block> Blocks { get; set; }

        /// <summary>
        /// The tools used by the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Tool> Tools { get; set; }

        /// <summary>
        /// Deprecated: Use `folders` field instead. The sources used by the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Source2> Sources { get; set; }

        /// <summary>
        /// The tags associated with the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// Deprecated: use `secrets` field instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_exec_environment_variables")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::G.AgentEnvironmentVariable>? ToolExecEnvironmentVariables { get; set; }

        /// <summary>
        /// The environment variables for tool execution specific to this agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        public global::System.Collections.Generic.IList<global::G.AgentEnvironmentVariable>? Secrets { get; set; }

        /// <summary>
        /// The id of the project the agent belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// The id of the template the agent belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// The base template id of the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_template_id")]
        public string? BaseTemplateId { get; set; }

        /// <summary>
        /// The id of the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_id")]
        public string? DeploymentId { get; set; }

        /// <summary>
        /// The id of the entity within the template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string? EntityId { get; set; }

        /// <summary>
        /// Deprecated: Use `identities` field instead. The ids of the identities associated with this agent.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity_ids")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? IdentityIds { get; set; }

        /// <summary>
        /// The identities associated with this agent.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identities")]
        public global::System.Collections.Generic.IList<global::G.Identity>? Identities { get; set; }

        /// <summary>
        /// The latest approval request message pending for this agent, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_approval")]
        public global::G.ApprovalRequestMessage? PendingApproval { get; set; }

        /// <summary>
        /// If set to True, the agent will not remember previous messages (though the agent will still retain state via core memory blocks and archival/recall memory). Not recommended unless you have an advanced use case.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_buffer_autoclear")]
        public bool? MessageBufferAutoclear { get; set; }

        /// <summary>
        /// If set to True, memory management will move to a background agent thread.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_sleeptime")]
        public bool? EnableSleeptime { get; set; }

        /// <summary>
        /// Deprecated: Use `managed_group` field instead. The multi-agent group that this agent manages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multi_agent_group")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.Group? MultiAgentGroup { get; set; }

        /// <summary>
        /// The multi-agent group that this agent manages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("managed_group")]
        public global::G.Group? ManagedGroup { get; set; }

        /// <summary>
        /// The timestamp when the agent last completed a run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_run_completion")]
        public global::System.DateTime? LastRunCompletion { get; set; }

        /// <summary>
        /// The duration in milliseconds of the agent's last run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_run_duration_ms")]
        public int? LastRunDurationMs { get; set; }

        /// <summary>
        /// The stop reason from the agent's last run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_stop_reason")]
        public global::G.StopReasonType? LastStopReason { get; set; }

        /// <summary>
        /// The timezone of the agent (IANA format).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Maximum number of files that can be open at once for this agent. Setting this too high may exceed the context window, which will break the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_files_open")]
        public int? MaxFilesOpen { get; set; }

        /// <summary>
        /// The per-file view window character limit for this agent. Setting this too high may exceed the context window, which will break the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("per_file_view_window_char_limit")]
        public int? PerFileViewWindowCharLimit { get; set; }

        /// <summary>
        /// If set to True, the agent will be hidden.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hidden")]
        public bool? Hidden { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentState" /> class.
        /// </summary>
        /// <param name="id">
        /// The id of the agent. Assigned by the database.
        /// </param>
        /// <param name="name">
        /// The name of the agent.
        /// </param>
        /// <param name="system">
        /// The system prompt used by the agent.
        /// </param>
        /// <param name="agentType">
        /// The type of agent.
        /// </param>
        /// <param name="llmConfig">
        /// Deprecated: Use `model` field instead. The LLM configuration used by the agent.
        /// </param>
        /// <param name="memory">
        /// Deprecated: Use `blocks` field instead. The in-context memory of the agent.
        /// </param>
        /// <param name="blocks">
        /// The memory blocks used by the agent.
        /// </param>
        /// <param name="tools">
        /// The tools used by the agent.
        /// </param>
        /// <param name="sources">
        /// Deprecated: Use `folders` field instead. The sources used by the agent.
        /// </param>
        /// <param name="tags">
        /// The tags associated with the agent.
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
        /// <param name="toolRules">
        /// The list of tool rules.
        /// </param>
        /// <param name="messageIds">
        /// The ids of the messages in the agent's in-context memory.
        /// </param>
        /// <param name="model">
        /// The model handle used by the agent (format: provider/model-name).
        /// </param>
        /// <param name="embedding">
        /// The embedding model handle used by the agent (format: provider/model-name).
        /// </param>
        /// <param name="modelSettings">
        /// The model settings used by the agent.
        /// </param>
        /// <param name="compactionSettings">
        /// The compaction settings configuration used for compaction.
        /// </param>
        /// <param name="responseFormat">
        /// The response format used by the agent
        /// </param>
        /// <param name="description">
        /// The description of the agent.
        /// </param>
        /// <param name="metadata">
        /// The metadata of the agent.
        /// </param>
        /// <param name="secrets">
        /// The environment variables for tool execution specific to this agent.
        /// </param>
        /// <param name="projectId">
        /// The id of the project the agent belongs to.
        /// </param>
        /// <param name="templateId">
        /// The id of the template the agent belongs to.
        /// </param>
        /// <param name="baseTemplateId">
        /// The base template id of the agent.
        /// </param>
        /// <param name="deploymentId">
        /// The id of the deployment.
        /// </param>
        /// <param name="entityId">
        /// The id of the entity within the template.
        /// </param>
        /// <param name="identities">
        /// The identities associated with this agent.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="pendingApproval">
        /// The latest approval request message pending for this agent, if any.
        /// </param>
        /// <param name="messageBufferAutoclear">
        /// If set to True, the agent will not remember previous messages (though the agent will still retain state via core memory blocks and archival/recall memory). Not recommended unless you have an advanced use case.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="enableSleeptime">
        /// If set to True, memory management will move to a background agent thread.
        /// </param>
        /// <param name="managedGroup">
        /// The multi-agent group that this agent manages
        /// </param>
        /// <param name="lastRunCompletion">
        /// The timestamp when the agent last completed a run.
        /// </param>
        /// <param name="lastRunDurationMs">
        /// The duration in milliseconds of the agent's last run.
        /// </param>
        /// <param name="lastStopReason">
        /// The stop reason from the agent's last run.
        /// </param>
        /// <param name="timezone">
        /// The timezone of the agent (IANA format).
        /// </param>
        /// <param name="maxFilesOpen">
        /// Maximum number of files that can be open at once for this agent. Setting this too high may exceed the context window, which will break the agent.
        /// </param>
        /// <param name="perFileViewWindowCharLimit">
        /// The per-file view window character limit for this agent. Setting this too high may exceed the context window, which will break the agent.
        /// </param>
        /// <param name="hidden">
        /// If set to True, the agent will be hidden.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentState(
            string id,
            string name,
            string system,
            global::G.AgentType agentType,
            global::G.LLMConfig llmConfig,
            global::G.Memory memory,
            global::System.Collections.Generic.IList<global::G.Block> blocks,
            global::System.Collections.Generic.IList<global::G.Tool> tools,
            global::System.Collections.Generic.IList<global::G.Source2> sources,
            global::System.Collections.Generic.IList<string> tags,
            string? createdById,
            string? lastUpdatedById,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::System.Collections.Generic.IList<global::G.ToolRulesVariant1Item>? toolRules,
            global::System.Collections.Generic.IList<string>? messageIds,
            string? model,
            string? embedding,
            global::G.ModelSettingsVariant1? modelSettings,
            global::G.CompactionSettingsOutput? compactionSettings,
            global::G.ResponseFormatVariant1? responseFormat,
            string? description,
            object? metadata,
            global::System.Collections.Generic.IList<global::G.AgentEnvironmentVariable>? secrets,
            string? projectId,
            string? templateId,
            string? baseTemplateId,
            string? deploymentId,
            string? entityId,
            global::System.Collections.Generic.IList<global::G.Identity>? identities,
            global::G.ApprovalRequestMessage? pendingApproval,
            bool? messageBufferAutoclear,
            bool? enableSleeptime,
            global::G.Group? managedGroup,
            global::System.DateTime? lastRunCompletion,
            int? lastRunDurationMs,
            global::G.StopReasonType? lastStopReason,
            string? timezone,
            int? maxFilesOpen,
            int? perFileViewWindowCharLimit,
            bool? hidden)
        {
            this.CreatedById = createdById;
            this.LastUpdatedById = lastUpdatedById;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ToolRules = toolRules;
            this.MessageIds = messageIds;
            this.System = system ?? throw new global::System.ArgumentNullException(nameof(system));
            this.AgentType = agentType;
            this.LlmConfig = llmConfig ?? throw new global::System.ArgumentNullException(nameof(llmConfig));
            this.Model = model;
            this.Embedding = embedding;
            this.ModelSettings = modelSettings;
            this.CompactionSettings = compactionSettings;
            this.ResponseFormat = responseFormat;
            this.Description = description;
            this.Metadata = metadata;
            this.Memory = memory ?? throw new global::System.ArgumentNullException(nameof(memory));
            this.Blocks = blocks ?? throw new global::System.ArgumentNullException(nameof(blocks));
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.Sources = sources ?? throw new global::System.ArgumentNullException(nameof(sources));
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.Secrets = secrets;
            this.ProjectId = projectId;
            this.TemplateId = templateId;
            this.BaseTemplateId = baseTemplateId;
            this.DeploymentId = deploymentId;
            this.EntityId = entityId;
            this.Identities = identities;
            this.PendingApproval = pendingApproval;
            this.MessageBufferAutoclear = messageBufferAutoclear;
            this.EnableSleeptime = enableSleeptime;
            this.ManagedGroup = managedGroup;
            this.LastRunCompletion = lastRunCompletion;
            this.LastRunDurationMs = lastRunDurationMs;
            this.LastStopReason = lastStopReason;
            this.Timezone = timezone;
            this.MaxFilesOpen = maxFilesOpen;
            this.PerFileViewWindowCharLimit = perFileViewWindowCharLimit;
            this.Hidden = hidden;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentState" /> class.
        /// </summary>
        public AgentState()
        {
        }
    }
}