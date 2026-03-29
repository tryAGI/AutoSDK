//HintName: G.Models.MaxCountPerStepToolRule.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a tool rule configuration which constrains the total number of times this tool can be invoked in a single step.
    /// </summary>
    public sealed partial class MaxCountPerStepToolRule
    {
        /// <summary>
        /// The name of the tool. Must exist in the database for the user's organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolName { get; set; } = default!;

        /// <summary>
        /// Default Value: max_count_per_step
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Optional template string (ignored).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_template")]
        public string? PromptTemplate { get; set; }

        /// <summary>
        /// The max limit for the total number of times this tool can be invoked in a single step.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_count_limit", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaxCountLimit { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MaxCountPerStepToolRule" /> class.
        /// </summary>
        /// <param name="toolName">
        /// The name of the tool. Must exist in the database for the user's organization.
        /// </param>
        /// <param name="maxCountLimit">
        /// The max limit for the total number of times this tool can be invoked in a single step.
        /// </param>
        /// <param name="type">
        /// Default Value: max_count_per_step
        /// </param>
        /// <param name="promptTemplate">
        /// Optional template string (ignored).
        /// </param>
        public MaxCountPerStepToolRule(
            string toolName,
            int maxCountLimit,
            string? type,
            string? promptTemplate)
        {
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.Type = type;
            this.PromptTemplate = promptTemplate;
            this.MaxCountLimit = maxCountLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MaxCountPerStepToolRule" /> class.
        /// </summary>
        public MaxCountPerStepToolRule()
        {
        }
    }
}