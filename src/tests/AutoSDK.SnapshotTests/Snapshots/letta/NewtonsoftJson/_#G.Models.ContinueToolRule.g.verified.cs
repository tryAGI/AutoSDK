//HintName: G.Models.ContinueToolRule.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a tool rule configuration where if this tool gets called, it must continue the agent loop.
    /// </summary>
    public sealed partial class ContinueToolRule
    {
        /// <summary>
        /// The name of the tool. Must exist in the database for the user's organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolName { get; set; } = default!;

        /// <summary>
        /// Default Value: continue_loop
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Optional template string (ignored).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_template")]
        public string? PromptTemplate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContinueToolRule" /> class.
        /// </summary>
        /// <param name="toolName">
        /// The name of the tool. Must exist in the database for the user's organization.
        /// </param>
        /// <param name="type">
        /// Default Value: continue_loop
        /// </param>
        /// <param name="promptTemplate">
        /// Optional template string (ignored).
        /// </param>
        public ContinueToolRule(
            string toolName,
            string? type,
            string? promptTemplate)
        {
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.Type = type;
            this.PromptTemplate = promptTemplate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContinueToolRule" /> class.
        /// </summary>
        public ContinueToolRule()
        {
        }
    }
}