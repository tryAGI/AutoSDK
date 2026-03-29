//HintName: G.Models.ParentToolRule.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A ToolRule that only allows a child tool to be called if the parent has been called.
    /// </summary>
    public sealed partial class ParentToolRule
    {
        /// <summary>
        /// The name of the tool. Must exist in the database for the user's organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        /// Default Value: parent_last_tool
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParentToolRule" /> class.
        /// </summary>
        /// <param name="toolName">
        /// The name of the tool. Must exist in the database for the user's organization.
        /// </param>
        /// <param name="children">
        /// The children tools that can be invoked.
        /// </param>
        /// <param name="type">
        /// Default Value: parent_last_tool
        /// </param>
        /// <param name="promptTemplate">
        /// Optional template string (ignored).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParentToolRule(
            string toolName,
            global::System.Collections.Generic.IList<string> children,
            string? type,
            string? promptTemplate)
        {
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.Type = type;
            this.PromptTemplate = promptTemplate;
            this.Children = children ?? throw new global::System.ArgumentNullException(nameof(children));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParentToolRule" /> class.
        /// </summary>
        public ParentToolRule()
        {
        }
    }
}