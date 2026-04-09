//HintName: G.Models.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant7.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant7
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
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant7TypeJsonConverter))]
        public global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant7Type? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_template")]
        public string? PromptTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_count_limit", Required = global::Newtonsoft.Json.Required.Always)]
        public double MaxCountLimit { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant7" /> class.
        /// </summary>
        /// <param name="toolName"></param>
        /// <param name="maxCountLimit"></param>
        /// <param name="type"></param>
        /// <param name="promptTemplate"></param>
        public TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant7(
            string toolName,
            double maxCountLimit,
            global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant7Type? type,
            string? promptTemplate)
        {
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.Type = type;
            this.PromptTemplate = promptTemplate;
            this.MaxCountLimit = maxCountLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant7" /> class.
        /// </summary>
        public TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant7()
        {
        }
    }
}