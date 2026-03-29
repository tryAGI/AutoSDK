//HintName: G.Models.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1ChildArgNode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1ChildArgNode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("args")]
        public object? Args { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1ChildArgNode" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="args"></param>
        public TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1ChildArgNode(
            string name,
            object? args)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Args = args;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1ChildArgNode" /> class.
        /// </summary>
        public TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1ChildArgNode()
        {
        }
    }
}