//HintName: G.Models.InternalTemplateAgentCreate.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Used for Letta Cloud
    /// </summary>
    public sealed partial class InternalTemplateAgentCreate
    {
        /// <summary>
        /// The name of the agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The blocks to create in the agent's in-context memory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("memory_blocks")]
        public global::System.Collections.Generic.IList<global::G.CreateBlock>? MemoryBlocks { get; set; }

        /// <summary>
        /// The tools used by the agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::System.Collections.Generic.IList<string>? Tools { get; set; }

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
        /// The tool rules governing the agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_rules")]
        public global::System.Collections.Generic.IList<global::G.ToolRulesVariant1Item3>? ToolRules { get; set; }

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
        /// The type of agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_type")]
        public global::G.AgentType? AgentType { get; set; }

        /// <summary>
        /// The initial set of messages to put in the agent's in-context memory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("initial_message_sequence")]
        public global::System.Collections.Generic.IList<global::G.MessageCreate>? InitialMessageSequence { get; set; }

        /// <summary>
        /// If true, attaches the Letta core tools (e.g. core_memory related functions).<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_base_tools")]
        public bool? IncludeBaseTools { get; set; }

        /// <summary>
        /// If true, attaches the Letta multi-agent tools (e.g. sending a message to another agent).<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_multi_agent_tools")]
        public bool? IncludeMultiAgentTools { get; set; }

        /// <summary>
        /// If true, attaches the Letta base tool rules (e.g. deny all tools not explicitly allowed).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_base_tool_rules")]
        public bool? IncludeBaseToolRules { get; set; }

        /// <summary>
        /// If true, automatically creates and attaches a default data source for this agent.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_default_source")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? IncludeDefaultSource { get; set; }

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
        /// Deprecated: Use `model` field instead. The LLM configuration used by the agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("llm_config")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.LLMConfig? LlmConfig { get; set; }

        /// <summary>
        /// Deprecated: Use `embedding` field instead. The embedding configuration used by the agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_config")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.EmbeddingConfig? EmbeddingConfig { get; set; }

        /// <summary>
        /// The model handle for the agent to use (format: provider/model-name).
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
        public global::G.ModelSettingsVariant17? ModelSettings { get; set; }

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
        /// Deprecated: No longer used. The embedding chunk size used by the agent.<br/>
        /// Default Value: 300
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_chunk_size")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? EmbeddingChunkSize { get; set; }

        /// <summary>
        /// Deprecated: Use `model` field to configure max output tokens instead. The maximum number of tokens to generate, including reasoning step.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_tokens")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Deprecated: Use `model` field to configure reasoning tokens instead. The maximum number of tokens to generate for reasoning step.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_reasoning_tokens")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? MaxReasoningTokens { get; set; }

        /// <summary>
        /// Deprecated: Use `model` field to configure reasoning instead. Whether to enable internal extended thinking step for a reasoner model.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable_reasoner")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? EnableReasoner { get; set; }

        /// <summary>
        /// Deprecated: Use `model` field to configure reasoning instead. Whether to enable reasoning for this agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? Reasoning { get; set; }

        /// <summary>
        /// Deprecated: please use the 'create agents from a template' endpoint instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from_template")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? FromTemplate { get; set; }

        /// <summary>
        /// Deprecated: No longer used.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("template")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? Template { get; set; }

        /// <summary>
        /// Deprecated: Project should now be passed via the X-Project header instead of in the request body. If using the SDK, this can be done via the x_project parameter.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Project { get; set; }

        /// <summary>
        /// Deprecated: Use `secrets` field instead. Environment variables for tool execution.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_exec_environment_variables")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.Dictionary<string, string>? ToolExecEnvironmentVariables { get; set; }

        /// <summary>
        /// The environment variables for tool execution specific to this agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secrets")]
        public global::System.Collections.Generic.Dictionary<string, string>? Secrets { get; set; }

        /// <summary>
        /// Deprecated: Only relevant for creating agents from a template. Use the 'create agents from a template' endpoint instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("memory_variables")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.Dictionary<string, string>? MemoryVariables { get; set; }

        /// <summary>
        /// Deprecated: No longer used. The id of the project the agent belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// The id of the template.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("template_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string TemplateId { get; set; } = default!;

        /// <summary>
        /// The id of the base template.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base_template_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BaseTemplateId { get; set; } = default!;

        /// <summary>
        /// The ids of the identities associated with this agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("identity_ids")]
        public global::System.Collections.Generic.IList<string>? IdentityIds { get; set; }

        /// <summary>
        /// If set to True, the agent will not remember previous messages (though the agent will still retain state via core memory blocks and archival/recall memory). Not recommended unless you have an advanced use case.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message_buffer_autoclear")]
        public bool? MessageBufferAutoclear { get; set; }

        /// <summary>
        /// If set to True, memory management will move to a background agent thread.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable_sleeptime")]
        public bool? EnableSleeptime { get; set; }

        /// <summary>
        /// Deprecated: Use `model_settings` field to configure response format instead. The response format for the agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_format")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.ResponseFormatVariant18? ResponseFormat { get; set; }

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
        /// Deprecated: No longer used. If set to True, the agent will be hidden.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hidden")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? Hidden { get; set; }

        /// <summary>
        /// Deprecated: Use `model_settings` to configure parallel tool calls instead. If set to True, enables parallel tool calling.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parallel_tool_calls")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// The id of the deployment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deployment_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DeploymentId { get; set; } = default!;

        /// <summary>
        /// The id of the entity within the template.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entity_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EntityId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalTemplateAgentCreate" /> class.
        /// </summary>
        /// <param name="templateId">
        /// The id of the template.
        /// </param>
        /// <param name="baseTemplateId">
        /// The id of the base template.
        /// </param>
        /// <param name="deploymentId">
        /// The id of the deployment.
        /// </param>
        /// <param name="entityId">
        /// The id of the entity within the template.
        /// </param>
        /// <param name="name">
        /// The name of the agent.
        /// </param>
        /// <param name="memoryBlocks">
        /// The blocks to create in the agent's in-context memory.
        /// </param>
        /// <param name="tools">
        /// The tools used by the agent.
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
        /// <param name="toolRules">
        /// The tool rules governing the agent.
        /// </param>
        /// <param name="tags">
        /// The tags associated with the agent.
        /// </param>
        /// <param name="system">
        /// The system prompt used by the agent.
        /// </param>
        /// <param name="agentType">
        /// The type of agent.
        /// </param>
        /// <param name="initialMessageSequence">
        /// The initial set of messages to put in the agent's in-context memory.
        /// </param>
        /// <param name="includeBaseTools">
        /// If true, attaches the Letta core tools (e.g. core_memory related functions).<br/>
        /// Default Value: true
        /// </param>
        /// <param name="includeMultiAgentTools">
        /// If true, attaches the Letta multi-agent tools (e.g. sending a message to another agent).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeBaseToolRules">
        /// If true, attaches the Letta base tool rules (e.g. deny all tools not explicitly allowed).
        /// </param>
        /// <param name="description">
        /// The description of the agent.
        /// </param>
        /// <param name="metadata">
        /// The metadata of the agent.
        /// </param>
        /// <param name="model">
        /// The model handle for the agent to use (format: provider/model-name).
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
        /// <param name="secrets">
        /// The environment variables for tool execution specific to this agent.
        /// </param>
        /// <param name="identityIds">
        /// The ids of the identities associated with this agent.
        /// </param>
        /// <param name="messageBufferAutoclear">
        /// If set to True, the agent will not remember previous messages (though the agent will still retain state via core memory blocks and archival/recall memory). Not recommended unless you have an advanced use case.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="enableSleeptime">
        /// If set to True, memory management will move to a background agent thread.
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
        public InternalTemplateAgentCreate(
            string templateId,
            string baseTemplateId,
            string deploymentId,
            string entityId,
            string? name,
            global::System.Collections.Generic.IList<global::G.CreateBlock>? memoryBlocks,
            global::System.Collections.Generic.IList<string>? tools,
            global::System.Collections.Generic.IList<string>? toolIds,
            global::System.Collections.Generic.IList<string>? folderIds,
            global::System.Collections.Generic.IList<string>? blockIds,
            global::System.Collections.Generic.IList<global::G.ToolRulesVariant1Item3>? toolRules,
            global::System.Collections.Generic.IList<string>? tags,
            string? system,
            global::G.AgentType? agentType,
            global::System.Collections.Generic.IList<global::G.MessageCreate>? initialMessageSequence,
            bool? includeBaseTools,
            bool? includeMultiAgentTools,
            bool? includeBaseToolRules,
            string? description,
            object? metadata,
            string? model,
            string? embedding,
            global::G.ModelSettingsVariant17? modelSettings,
            global::G.CompactionSettingsInput? compactionSettings,
            int? contextWindowLimit,
            global::System.Collections.Generic.Dictionary<string, string>? secrets,
            global::System.Collections.Generic.IList<string>? identityIds,
            bool? messageBufferAutoclear,
            bool? enableSleeptime,
            string? timezone,
            int? maxFilesOpen,
            int? perFileViewWindowCharLimit)
        {
            this.Name = name;
            this.MemoryBlocks = memoryBlocks;
            this.Tools = tools;
            this.ToolIds = toolIds;
            this.FolderIds = folderIds;
            this.BlockIds = blockIds;
            this.ToolRules = toolRules;
            this.Tags = tags;
            this.System = system;
            this.AgentType = agentType;
            this.InitialMessageSequence = initialMessageSequence;
            this.IncludeBaseTools = includeBaseTools;
            this.IncludeMultiAgentTools = includeMultiAgentTools;
            this.IncludeBaseToolRules = includeBaseToolRules;
            this.Description = description;
            this.Metadata = metadata;
            this.Model = model;
            this.Embedding = embedding;
            this.ModelSettings = modelSettings;
            this.CompactionSettings = compactionSettings;
            this.ContextWindowLimit = contextWindowLimit;
            this.Secrets = secrets;
            this.TemplateId = templateId ?? throw new global::System.ArgumentNullException(nameof(templateId));
            this.BaseTemplateId = baseTemplateId ?? throw new global::System.ArgumentNullException(nameof(baseTemplateId));
            this.IdentityIds = identityIds;
            this.MessageBufferAutoclear = messageBufferAutoclear;
            this.EnableSleeptime = enableSleeptime;
            this.Timezone = timezone;
            this.MaxFilesOpen = maxFilesOpen;
            this.PerFileViewWindowCharLimit = perFileViewWindowCharLimit;
            this.DeploymentId = deploymentId ?? throw new global::System.ArgumentNullException(nameof(deploymentId));
            this.EntityId = entityId ?? throw new global::System.ArgumentNullException(nameof(entityId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalTemplateAgentCreate" /> class.
        /// </summary>
        public InternalTemplateAgentCreate()
        {
        }
    }
}