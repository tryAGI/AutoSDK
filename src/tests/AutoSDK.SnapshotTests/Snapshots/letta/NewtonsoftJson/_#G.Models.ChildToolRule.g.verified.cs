//HintName: G.Models.ChildToolRule.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A ToolRule represents a tool that can be invoked by the agent.
    /// </summary>
    public sealed partial class ChildToolRule
    {
        /// <summary>
        /// The name of the tool. Must exist in the database for the user's organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolName { get; set; } = default!;

        /// <summary>
        /// Default Value: constrain_child_tools
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Optional template string (ignored).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_template")]
        public string? PromptTemplate { get; set; }

        /// <summary>
        /// The children tools that can be invoked.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("children", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Children { get; set; } = default!;

        /// <summary>
        /// Optional list of typed child argument overrides. Each node must reference a child in 'children'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("child_arg_nodes")]
        public global::System.Collections.Generic.IList<global::G.ToolCallNode>? ChildArgNodes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChildToolRule" /> class.
        /// </summary>
        /// <param name="toolName">
        /// The name of the tool. Must exist in the database for the user's organization.
        /// </param>
        /// <param name="children">
        /// The children tools that can be invoked.
        /// </param>
        /// <param name="type">
        /// Default Value: constrain_child_tools
        /// </param>
        /// <param name="promptTemplate">
        /// Optional template string (ignored).
        /// </param>
        /// <param name="childArgNodes">
        /// Optional list of typed child argument overrides. Each node must reference a child in 'children'.
        /// </param>
        public ChildToolRule(
            string toolName,
            global::System.Collections.Generic.IList<string> children,
            string? type,
            string? promptTemplate,
            global::System.Collections.Generic.IList<global::G.ToolCallNode>? childArgNodes)
        {
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.Type = type;
            this.PromptTemplate = promptTemplate;
            this.Children = children ?? throw new global::System.ArgumentNullException(nameof(children));
            this.ChildArgNodes = childArgNodes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChildToolRule" /> class.
        /// </summary>
        public ChildToolRule()
        {
        }
    }
}