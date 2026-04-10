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
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("systemPrompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string SystemPrompt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toolIds")]
        public global::System.Collections.Generic.IList<string>? ToolIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sourceIds")]
        public global::System.Collections.Generic.IList<string>? SourceIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("memoryVariables")]
        public global::G.TemplatesGetTemplateSnapshotResponseAgentMemoryVariables? MemoryVariables { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toolVariables")]
        public global::G.TemplatesGetTemplateSnapshotResponseAgentToolVariables? ToolVariables { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("identityIds")]
        public global::System.Collections.Generic.IList<string>? IdentityIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toolRules")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1, global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant2, global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant3, global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant4, global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant5, global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant6, global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant7, global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant8, global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant9>>? ToolRules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agentType", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentAgentTypeJsonConverter))]
        public global::G.TemplatesGetTemplateSnapshotResponseAgentAgentType AgentType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("properties")]
        public global::G.TemplatesGetTemplateSnapshotResponseAgentProperties? Properties { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entityId", Required = global::Newtonsoft.Json.Required.Always)]
        public string EntityId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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