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
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        /// Default Value: constrain_child_tools
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Optional template string (ignored).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_template")]
        public string? PromptTemplate { get; set; }

        /// <summary>
        /// The children tools that can be invoked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("children")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Children { get; set; }

        /// <summary>
        /// Optional list of typed child argument overrides. Each node must reference a child in 'children'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("child_arg_nodes")]
        public global::System.Collections.Generic.IList<global::G.ToolCallNode>? ChildArgNodes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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