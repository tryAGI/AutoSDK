//HintName: G.Models.ConditionalToolRule.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A ToolRule that conditionally maps to different child tools based on the output.
    /// </summary>
    public sealed partial class ConditionalToolRule
    {
        /// <summary>
        /// The name of the tool. Must exist in the database for the user's organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolName { get; set; } = default!;

        /// <summary>
        /// Default Value: conditional
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Optional template string (ignored).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_template")]
        public string? PromptTemplate { get; set; }

        /// <summary>
        /// The default child tool to be called. If None, any tool can be called.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_child")]
        public string? DefaultChild { get; set; }

        /// <summary>
        /// The output case to check for mapping
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("child_output_mapping", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string> ChildOutputMapping { get; set; } = default!;

        /// <summary>
        /// Whether to throw an error when output doesn't match any case<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("require_output_mapping")]
        public bool? RequireOutputMapping { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionalToolRule" /> class.
        /// </summary>
        /// <param name="toolName">
        /// The name of the tool. Must exist in the database for the user's organization.
        /// </param>
        /// <param name="childOutputMapping">
        /// The output case to check for mapping
        /// </param>
        /// <param name="type">
        /// Default Value: conditional
        /// </param>
        /// <param name="promptTemplate">
        /// Optional template string (ignored).
        /// </param>
        /// <param name="defaultChild">
        /// The default child tool to be called. If None, any tool can be called.
        /// </param>
        /// <param name="requireOutputMapping">
        /// Whether to throw an error when output doesn't match any case<br/>
        /// Default Value: false
        /// </param>
        public ConditionalToolRule(
            string toolName,
            global::System.Collections.Generic.Dictionary<string, string> childOutputMapping,
            string? type,
            string? promptTemplate,
            string? defaultChild,
            bool? requireOutputMapping)
        {
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.Type = type;
            this.PromptTemplate = promptTemplate;
            this.DefaultChild = defaultChild;
            this.ChildOutputMapping = childOutputMapping ?? throw new global::System.ArgumentNullException(nameof(childOutputMapping));
            this.RequireOutputMapping = requireOutputMapping;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionalToolRule" /> class.
        /// </summary>
        public ConditionalToolRule()
        {
        }
    }
}