//HintName: G.Models.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant5
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
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant5TypeJsonConverter))]
        public global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant5Type? Type { get; set; }

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
        /// Initializes a new instance of the <see cref="TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant5" /> class.
        /// </summary>
        /// <param name="toolName"></param>
        /// <param name="type"></param>
        /// <param name="promptTemplate"></param>
        public TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant5(
            string toolName,
            global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant5Type? type,
            string? promptTemplate)
        {
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.Type = type;
            this.PromptTemplate = promptTemplate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant5" /> class.
        /// </summary>
        public TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant5()
        {
        }
    }
}