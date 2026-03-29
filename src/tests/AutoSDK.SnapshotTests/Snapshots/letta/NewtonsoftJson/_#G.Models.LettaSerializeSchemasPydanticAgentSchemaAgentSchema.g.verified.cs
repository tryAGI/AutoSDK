//HintName: G.Models.LettaSerializeSchemasPydanticAgentSchemaAgentSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LettaSerializeSchemasPydanticAgentSchemaAgentSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("core_memory", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CoreMemoryBlockSchema> CoreMemory { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Configuration for embedding model connection and processing parameters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EmbeddingConfig EmbeddingConfig { get; set; } = default!;

        /// <summary>
        /// Configuration for Language Model (LLM) connection and generation parameters.<br/>
        /// .. deprecated::<br/>
        ///     LLMConfig is deprecated and should not be used as an input or return type in API calls.<br/>
        ///     Use the schemas in letta.schemas.model (ModelSettings, OpenAIModelSettings, etc.) instead.<br/>
        ///     For conversion, use the _to_model() method or Model._from_llm_config() method.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("llm_config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.LLMConfig LlmConfig { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message_buffer_autoclear", Required = global::Newtonsoft.Json.Required.Always)]
        public bool MessageBufferAutoclear { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("in_context_message_indices", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<int> InContextMessageIndices { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.LettaSerializeSchemasPydanticAgentSchemaMessageSchema> Messages { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata_")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("multi_agent_group")]
        public object? MultiAgentGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("system", Required = global::Newtonsoft.Json.Required.Always)]
        public string System { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TagSchema> Tags { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_exec_environment_variables", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ToolEnvVarSchema> ToolExecEnvironmentVariables { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_rules", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AnyOf<global::G.BaseToolRuleSchema, global::G.ChildToolRuleSchema, global::G.MaxCountPerStepToolRuleSchema, global::G.ConditionalToolRuleSchema>> ToolRules { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.LettaSerializeSchemasPydanticAgentSchemaToolSchema> Tools { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaSerializeSchemasPydanticAgentSchemaAgentSchema" /> class.
        /// </summary>
        /// <param name="agentType"></param>
        /// <param name="coreMemory"></param>
        /// <param name="createdAt"></param>
        /// <param name="embeddingConfig">
        /// Configuration for embedding model connection and processing parameters.
        /// </param>
        /// <param name="llmConfig">
        /// Configuration for Language Model (LLM) connection and generation parameters.<br/>
        /// .. deprecated::<br/>
        ///     LLMConfig is deprecated and should not be used as an input or return type in API calls.<br/>
        ///     Use the schemas in letta.schemas.model (ModelSettings, OpenAIModelSettings, etc.) instead.<br/>
        ///     For conversion, use the _to_model() method or Model._from_llm_config() method.
        /// </param>
        /// <param name="messageBufferAutoclear"></param>
        /// <param name="inContextMessageIndices"></param>
        /// <param name="messages"></param>
        /// <param name="name"></param>
        /// <param name="system"></param>
        /// <param name="tags"></param>
        /// <param name="toolExecEnvironmentVariables"></param>
        /// <param name="toolRules"></param>
        /// <param name="tools"></param>
        /// <param name="updatedAt"></param>
        /// <param name="version"></param>
        /// <param name="description"></param>
        /// <param name="metadata"></param>
        /// <param name="multiAgentGroup"></param>
        public LettaSerializeSchemasPydanticAgentSchemaAgentSchema(
            string agentType,
            global::System.Collections.Generic.IList<global::G.CoreMemoryBlockSchema> coreMemory,
            string createdAt,
            global::G.EmbeddingConfig embeddingConfig,
            global::G.LLMConfig llmConfig,
            bool messageBufferAutoclear,
            global::System.Collections.Generic.IList<int> inContextMessageIndices,
            global::System.Collections.Generic.IList<global::G.LettaSerializeSchemasPydanticAgentSchemaMessageSchema> messages,
            string name,
            string system,
            global::System.Collections.Generic.IList<global::G.TagSchema> tags,
            global::System.Collections.Generic.IList<global::G.ToolEnvVarSchema> toolExecEnvironmentVariables,
            global::System.Collections.Generic.IList<global::G.AnyOf<global::G.BaseToolRuleSchema, global::G.ChildToolRuleSchema, global::G.MaxCountPerStepToolRuleSchema, global::G.ConditionalToolRuleSchema>> toolRules,
            global::System.Collections.Generic.IList<global::G.LettaSerializeSchemasPydanticAgentSchemaToolSchema> tools,
            string updatedAt,
            string version,
            string? description,
            object? metadata,
            object? multiAgentGroup)
        {
            this.AgentType = agentType ?? throw new global::System.ArgumentNullException(nameof(agentType));
            this.CoreMemory = coreMemory ?? throw new global::System.ArgumentNullException(nameof(coreMemory));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Description = description;
            this.EmbeddingConfig = embeddingConfig ?? throw new global::System.ArgumentNullException(nameof(embeddingConfig));
            this.LlmConfig = llmConfig ?? throw new global::System.ArgumentNullException(nameof(llmConfig));
            this.MessageBufferAutoclear = messageBufferAutoclear;
            this.InContextMessageIndices = inContextMessageIndices ?? throw new global::System.ArgumentNullException(nameof(inContextMessageIndices));
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Metadata = metadata;
            this.MultiAgentGroup = multiAgentGroup;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.System = system ?? throw new global::System.ArgumentNullException(nameof(system));
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.ToolExecEnvironmentVariables = toolExecEnvironmentVariables ?? throw new global::System.ArgumentNullException(nameof(toolExecEnvironmentVariables));
            this.ToolRules = toolRules ?? throw new global::System.ArgumentNullException(nameof(toolRules));
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaSerializeSchemasPydanticAgentSchemaAgentSchema" /> class.
        /// </summary>
        public LettaSerializeSchemasPydanticAgentSchemaAgentSchema()
        {
        }
    }
}