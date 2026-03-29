//HintName: G.Models.UpdateAgent.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAgent
    {
        /// <summary>
        /// The name of the agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The ids of the tools used by the agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_ids")]
        public global::System.Collections.Generic.IList<string>? ToolIds { get; set; }

        /// <summary>
        /// Deprecated: Use `folder_ids` field instead. The ids of the sources used by the agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_ids")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? SourceIds { get; set; }

        /// <summary>
        /// The ids of the folders used by the agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("folder_ids")]
        public global::System.Collections.Generic.IList<string>? FolderIds { get; set; }

        /// <summary>
        /// The ids of the blocks used by the agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("block_ids")]
        public global::System.Collections.Generic.IList<string>? BlockIds { get; set; }

        /// <summary>
        /// The tags associated with the agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// The system prompt used by the agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("system")]
        public string? System { get; set; }

        /// <summary>
        /// The tool rules governing the agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_rules")]
        public global::System.Collections.Generic.IList<global::G.ToolRulesVariant1Item4>? ToolRules { get; set; }

        /// <summary>
        /// The ids of the messages in the agent's in-context memory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message_ids")]
        public global::System.Collections.Generic.IList<string>? MessageIds { get; set; }

        /// <summary>
        /// The description of the agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The metadata of the agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Deprecated: use `secrets` field instead
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_exec_environment_variables")]
        public global::System.Collections.Generic.Dictionary<string, string>? ToolExecEnvironmentVariables { get; set; }

        /// <summary>
        /// The environment variables for tool execution specific to this agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secrets")]
        public global::System.Collections.Generic.Dictionary<string, string>? Secrets { get; set; }

        /// <summary>
        /// The id of the project the agent belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// The id of the template the agent belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("template_id")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// The base template id of the agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base_template_id")]
        public string? BaseTemplateId { get; set; }

        /// <summary>
        /// The ids of the identities associated with this agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("identity_ids")]
        public global::System.Collections.Generic.IList<string>? IdentityIds { get; set; }

        /// <summary>
        /// If set to True, the agent will not remember previous messages (though the agent will still retain state via core memory blocks and archival/recall memory). Not recommended unless you have an advanced use case.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message_buffer_autoclear")]
        public bool? MessageBufferAutoclear { get; set; }

        /// <summary>
        /// The model handle used by the agent (format: provider/model-name).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The embedding model handle used by the agent (format: provider/model-name).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding")]
        public string? Embedding { get; set; }

        /// <summary>
        /// The model settings for the agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_settings")]
        public global::G.ModelSettingsVariant18? ModelSettings { get; set; }

        /// <summary>
        /// The compaction settings configuration used for compaction.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("compaction_settings")]
        public global::G.CompactionSettingsInput? CompactionSettings { get; set; }

        /// <summary>
        /// The context window limit used by the agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context_window_limit")]
        public int? ContextWindowLimit { get; set; }

        /// <summary>
        /// Deprecated: Use `model` field to configure reasoning instead. Whether to enable reasoning for this agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? Reasoning { get; set; }

        /// <summary>
        /// Deprecated: Use `model` field instead. The LLM configuration used by the agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("llm_config")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.LLMConfig? LlmConfig { get; set; }

        /// <summary>
        /// The embedding configuration used by the agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_config")]
        public global::G.EmbeddingConfig? EmbeddingConfig { get; set; }

        /// <summary>
        /// Deprecated: Use `model_settings` to configure parallel tool calls instead. If set to True, enables parallel tool calling.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parallel_tool_calls")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// Deprecated: Use `model_settings` field to configure response format instead. The response format for the agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_format")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.ResponseFormatVariant114? ResponseFormat { get; set; }

        /// <summary>
        /// Deprecated: Use `model` field to configure max output tokens instead. The maximum number of tokens to generate, including reasoning step.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_tokens")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// If set to True, memory management will move to a background agent thread.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable_sleeptime")]
        public bool? EnableSleeptime { get; set; }

        /// <summary>
        /// The timestamp when the agent last completed a run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_run_completion")]
        public global::System.DateTime? LastRunCompletion { get; set; }

        /// <summary>
        /// The duration in milliseconds of the agent's last run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_run_duration_ms")]
        public int? LastRunDurationMs { get; set; }

        /// <summary>
        /// The stop reason from the agent's last run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_stop_reason")]
        public global::G.StopReasonType? LastStopReason { get; set; }

        /// <summary>
        /// The timezone of the agent (IANA format).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Maximum number of files that can be open at once for this agent. Setting this too high may exceed the context window, which will break the agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_files_open")]
        public int? MaxFilesOpen { get; set; }

        /// <summary>
        /// The per-file view window character limit for this agent. Setting this too high may exceed the context window, which will break the agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("per_file_view_window_char_limit")]
        public int? PerFileViewWindowCharLimit { get; set; }

        /// <summary>
        /// If set to True, the agent will be hidden.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hidden")]
        public bool? Hidden { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgent" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the agent.
        /// </param>
        /// <param name="toolIds">
        /// The ids of the tools used by the agent.
        /// </param>
        /// <param name="folderIds">
        /// The ids of the folders used by the agent.
        /// </param>
        /// <param name="blockIds">
        /// The ids of the blocks used by the agent.
        /// </param>
        /// <param name="tags">
        /// The tags associated with the agent.
        /// </param>
        /// <param name="system">
        /// The system prompt used by the agent.
        /// </param>
        /// <param name="toolRules">
        /// The tool rules governing the agent.
        /// </param>
        /// <param name="messageIds">
        /// The ids of the messages in the agent's in-context memory.
        /// </param>
        /// <param name="description">
        /// The description of the agent.
        /// </param>
        /// <param name="metadata">
        /// The metadata of the agent.
        /// </param>
        /// <param name="toolExecEnvironmentVariables">
        /// Deprecated: use `secrets` field instead
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
        /// <param name="identityIds">
        /// The ids of the identities associated with this agent.
        /// </param>
        /// <param name="messageBufferAutoclear">
        /// If set to True, the agent will not remember previous messages (though the agent will still retain state via core memory blocks and archival/recall memory). Not recommended unless you have an advanced use case.
        /// </param>
        /// <param name="model">
        /// The model handle used by the agent (format: provider/model-name).
        /// </param>
        /// <param name="embedding">
        /// The embedding model handle used by the agent (format: provider/model-name).
        /// </param>
        /// <param name="modelSettings">
        /// The model settings for the agent.
        /// </param>
        /// <param name="compactionSettings">
        /// The compaction settings configuration used for compaction.
        /// </param>
        /// <param name="contextWindowLimit">
        /// The context window limit used by the agent.
        /// </param>
        /// <param name="embeddingConfig">
        /// The embedding configuration used by the agent.
        /// </param>
        /// <param name="enableSleeptime">
        /// If set to True, memory management will move to a background agent thread.
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
        public UpdateAgent(
            string? name,
            global::System.Collections.Generic.IList<string>? toolIds,
            global::System.Collections.Generic.IList<string>? folderIds,
            global::System.Collections.Generic.IList<string>? blockIds,
            global::System.Collections.Generic.IList<string>? tags,
            string? system,
            global::System.Collections.Generic.IList<global::G.ToolRulesVariant1Item4>? toolRules,
            global::System.Collections.Generic.IList<string>? messageIds,
            string? description,
            object? metadata,
            global::System.Collections.Generic.Dictionary<string, string>? toolExecEnvironmentVariables,
            global::System.Collections.Generic.Dictionary<string, string>? secrets,
            string? projectId,
            string? templateId,
            string? baseTemplateId,
            global::System.Collections.Generic.IList<string>? identityIds,
            bool? messageBufferAutoclear,
            string? model,
            string? embedding,
            global::G.ModelSettingsVariant18? modelSettings,
            global::G.CompactionSettingsInput? compactionSettings,
            int? contextWindowLimit,
            global::G.EmbeddingConfig? embeddingConfig,
            bool? enableSleeptime,
            global::System.DateTime? lastRunCompletion,
            int? lastRunDurationMs,
            global::G.StopReasonType? lastStopReason,
            string? timezone,
            int? maxFilesOpen,
            int? perFileViewWindowCharLimit,
            bool? hidden)
        {
            this.Name = name;
            this.ToolIds = toolIds;
            this.FolderIds = folderIds;
            this.BlockIds = blockIds;
            this.Tags = tags;
            this.System = system;
            this.ToolRules = toolRules;
            this.MessageIds = messageIds;
            this.Description = description;
            this.Metadata = metadata;
            this.ToolExecEnvironmentVariables = toolExecEnvironmentVariables;
            this.Secrets = secrets;
            this.ProjectId = projectId;
            this.TemplateId = templateId;
            this.BaseTemplateId = baseTemplateId;
            this.IdentityIds = identityIds;
            this.MessageBufferAutoclear = messageBufferAutoclear;
            this.Model = model;
            this.Embedding = embedding;
            this.ModelSettings = modelSettings;
            this.CompactionSettings = compactionSettings;
            this.ContextWindowLimit = contextWindowLimit;
            this.EmbeddingConfig = embeddingConfig;
            this.EnableSleeptime = enableSleeptime;
            this.LastRunCompletion = lastRunCompletion;
            this.LastRunDurationMs = lastRunDurationMs;
            this.LastStopReason = lastStopReason;
            this.Timezone = timezone;
            this.MaxFilesOpen = maxFilesOpen;
            this.PerFileViewWindowCharLimit = perFileViewWindowCharLimit;
            this.Hidden = hidden;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgent" /> class.
        /// </summary>
        public UpdateAgent()
        {
        }
    }
}