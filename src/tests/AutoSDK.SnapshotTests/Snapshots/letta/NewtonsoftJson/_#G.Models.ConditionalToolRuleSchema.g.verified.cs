//HintName: G.Models.ConditionalToolRuleSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConditionalToolRuleSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_child")]
        public string? DefaultChild { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("child_output_mapping", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string> ChildOutputMapping { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("require_output_mapping", Required = global::Newtonsoft.Json.Required.Always)]
        public bool RequireOutputMapping { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionalToolRuleSchema" /> class.
        /// </summary>
        /// <param name="toolName"></param>
        /// <param name="type"></param>
        /// <param name="childOutputMapping"></param>
        /// <param name="requireOutputMapping"></param>
        /// <param name="defaultChild"></param>
        public ConditionalToolRuleSchema(
            string toolName,
            string type,
            global::System.Collections.Generic.Dictionary<string, string> childOutputMapping,
            bool requireOutputMapping,
            string? defaultChild)
        {
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.DefaultChild = defaultChild;
            this.ChildOutputMapping = childOutputMapping ?? throw new global::System.ArgumentNullException(nameof(childOutputMapping));
            this.RequireOutputMapping = requireOutputMapping;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionalToolRuleSchema" /> class.
        /// </summary>
        public ConditionalToolRuleSchema()
        {
        }
    }
}