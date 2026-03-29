//HintName: G.Models.TemplatesGetTemplateSnapshotResponseAgent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplatesGetTemplateSnapshotResponseAgent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("systemPrompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SystemPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolIds")]
        public global::System.Collections.Generic.IList<string>? ToolIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceIds")]
        public global::System.Collections.Generic.IList<string>? SourceIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memoryVariables")]
        public global::G.TemplatesGetTemplateSnapshotResponseAgentMemoryVariables? MemoryVariables { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolVariables")]
        public global::G.TemplatesGetTemplateSnapshotResponseAgentToolVariables? ToolVariables { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identityIds")]
        public global::System.Collections.Generic.IList<string>? IdentityIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolRules")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1, global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant2, global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant3, global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant4, global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant5, global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant6, global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant7, global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant8, global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant9>>? ToolRules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentAgentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TemplatesGetTemplateSnapshotResponseAgentAgentType AgentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public global::G.TemplatesGetTemplateSnapshotResponseAgentProperties? Properties { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entityId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EntityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesGetTemplateSnapshotResponseAgent" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="systemPrompt"></param>
        /// <param name="agentType"></param>
        /// <param name="entityId"></param>
        /// <param name="name"></param>
        /// <param name="toolIds"></param>
        /// <param name="sourceIds"></param>
        /// <param name="memoryVariables"></param>
        /// <param name="toolVariables"></param>
        /// <param name="tags"></param>
        /// <param name="identityIds"></param>
        /// <param name="toolRules"></param>
        /// <param name="properties"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplatesGetTemplateSnapshotResponseAgent(
            string model,
            string systemPrompt,
            global::G.TemplatesGetTemplateSnapshotResponseAgentAgentType agentType,
            string entityId,
            string name,
            global::System.Collections.Generic.IList<string>? toolIds,
            global::System.Collections.Generic.IList<string>? sourceIds,
            global::G.TemplatesGetTemplateSnapshotResponseAgentMemoryVariables? memoryVariables,
            global::G.TemplatesGetTemplateSnapshotResponseAgentToolVariables? toolVariables,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.IList<string>? identityIds,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1, global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant2, global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant3, global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant4, global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant5, global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant6, global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant7, global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant8, global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant9>>? toolRules,
            global::G.TemplatesGetTemplateSnapshotResponseAgentProperties? properties)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.SystemPrompt = systemPrompt ?? throw new global::System.ArgumentNullException(nameof(systemPrompt));
            this.ToolIds = toolIds;
            this.SourceIds = sourceIds;
            this.MemoryVariables = memoryVariables;
            this.ToolVariables = toolVariables;
            this.Tags = tags;
            this.IdentityIds = identityIds;
            this.ToolRules = toolRules;
            this.AgentType = agentType;
            this.Properties = properties;
            this.EntityId = entityId ?? throw new global::System.ArgumentNullException(nameof(entityId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesGetTemplateSnapshotResponseAgent" /> class.
        /// </summary>
        public TemplatesGetTemplateSnapshotResponseAgent()
        {
        }
    }
}