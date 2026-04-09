//HintName: G.Models.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1
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
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1TypeJsonConverter))]
        public global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1Type? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_template")]
        public string? PromptTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("children", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Children { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("child_arg_nodes")]
        public global::System.Collections.Generic.IList<global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1ChildArgNode>? ChildArgNodes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1" /> class.
        /// </summary>
        /// <param name="toolName"></param>
        /// <param name="children"></param>
        /// <param name="type"></param>
        /// <param name="promptTemplate"></param>
        /// <param name="childArgNodes"></param>
        public TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1(
            string toolName,
            global::System.Collections.Generic.IList<string> children,
            global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1Type? type,
            string? promptTemplate,
            global::System.Collections.Generic.IList<global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1ChildArgNode>? childArgNodes)
        {
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.Type = type;
            this.PromptTemplate = promptTemplate;
            this.Children = children ?? throw new global::System.ArgumentNullException(nameof(children));
            this.ChildArgNodes = childArgNodes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1" /> class.
        /// </summary>
        public TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1()
        {
        }
    }
}