//HintName: G.Models.InitToolRule.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents the initial tool rule configuration.
    /// </summary>
    public sealed partial class InitToolRule
    {
        /// <summary>
        /// The name of the tool. Must exist in the database for the user's organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolName { get; set; } = default!;

        /// <summary>
        /// Default Value: run_first
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Optional template string (ignored). Rendering uses fast built-in formatting for performance.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_template")]
        public string? PromptTemplate { get; set; }

        /// <summary>
        /// Optional prefilled arguments for this tool. When present, these values will override any LLM-provided arguments with the same keys during invocation. Keys must match the tool's parameter names and values must satisfy the tool's JSON schema. Supports partial prefill; non-overlapping parameters are left to the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("args")]
        public object? Args { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InitToolRule" /> class.
        /// </summary>
        /// <param name="toolName">
        /// The name of the tool. Must exist in the database for the user's organization.
        /// </param>
        /// <param name="type">
        /// Default Value: run_first
        /// </param>
        /// <param name="promptTemplate">
        /// Optional template string (ignored). Rendering uses fast built-in formatting for performance.
        /// </param>
        /// <param name="args">
        /// Optional prefilled arguments for this tool. When present, these values will override any LLM-provided arguments with the same keys during invocation. Keys must match the tool's parameter names and values must satisfy the tool's JSON schema. Supports partial prefill; non-overlapping parameters are left to the model.
        /// </param>
        public InitToolRule(
            string toolName,
            string? type,
            string? promptTemplate,
            object? args)
        {
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.Type = type;
            this.PromptTemplate = promptTemplate;
            this.Args = args;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InitToolRule" /> class.
        /// </summary>
        public InitToolRule()
        {
        }
    }
}