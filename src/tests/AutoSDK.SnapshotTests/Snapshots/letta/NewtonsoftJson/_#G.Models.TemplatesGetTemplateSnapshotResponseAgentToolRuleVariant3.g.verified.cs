//HintName: G.Models.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant3TypeJsonConverter))]
        public global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant3Type? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_template")]
        public string? PromptTemplate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant3" /> class.
        /// </summary>
        /// <param name="toolName"></param>
        /// <param name="type"></param>
        /// <param name="promptTemplate"></param>
        public TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant3(
            string toolName,
            global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant3Type? type,
            string? promptTemplate)
        {
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.Type = type;
            this.PromptTemplate = promptTemplate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant3" /> class.
        /// </summary>
        public TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant3()
        {
        }
    }
}