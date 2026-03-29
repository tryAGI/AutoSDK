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
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        /// Default Value: conditional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Optional template string (ignored).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_template")]
        public string? PromptTemplate { get; set; }

        /// <summary>
        /// The default child tool to be called. If None, any tool can be called.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_child")]
        public string? DefaultChild { get; set; }

        /// <summary>
        /// The output case to check for mapping
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("child_output_mapping")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> ChildOutputMapping { get; set; }

        /// <summary>
        /// Whether to throw an error when output doesn't match any case<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_output_mapping")]
        public bool? RequireOutputMapping { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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