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
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("core_memory")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CoreMemoryBlockSchema> CoreMemory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Configuration for embedding model connection and processing parameters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EmbeddingConfig EmbeddingConfig { get; set; }

        /// <summary>
        /// Configuration for Language Model (LLM) connection and generation parameters.<br/>
        /// .. deprecated::<br/>
        ///     LLMConfig is deprecated and should not be used as an input or return type in API calls.<br/>
        ///     Use the schemas in letta.schemas.model (ModelSettings, OpenAIModelSettings, etc.) instead.<br/>
        ///     For conversion, use the _to_model() method or Model._from_llm_config() method.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.LLMConfig LlmConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_buffer_autoclear")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool MessageBufferAutoclear { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in_context_message_indices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> InContextMessageIndices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.LettaSerializeSchemasPydanticAgentSchemaMessageSchema> Messages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multi_agent_group")]
        public object? MultiAgentGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string System { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TagSchema> Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_exec_environment_variables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ToolEnvVarSchema> ToolExecEnvironmentVariables { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_rules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AnyOf<global::G.BaseToolRuleSchema, global::G.ChildToolRuleSchema, global::G.MaxCountPerStepToolRuleSchema, global::G.ConditionalToolRuleSchema>> ToolRules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.LettaSerializeSchemasPydanticAgentSchemaToolSchema> Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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