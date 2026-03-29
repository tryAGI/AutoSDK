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
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        /// Default Value: max_count_per_step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Optional template string (ignored).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_template")]
        public string? PromptTemplate { get; set; }

        /// <summary>
        /// The max limit for the total number of times this tool can be invoked in a single step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_count_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxCountLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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