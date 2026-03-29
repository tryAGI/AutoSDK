//HintName: G.Models.LlamaParseAgenticOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Options for AI-powered parsing tiers (cost_effective, agentic, agentic_plus).<br/>
    /// These options customize how the AI processes and interprets document content.<br/>
    /// Only applicable when using non-fast tiers.
    /// </summary>
    public sealed partial class LlamaParseAgenticOptions
    {
        /// <summary>
        /// Custom instructions for the AI parser. Use to guide extraction behavior, specify output formatting, or provide domain-specific context. Example: 'Extract financial tables with currency symbols. Format dates as YYYY-MM-DD.'
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_prompt")]
        public string? CustomPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParseAgenticOptions" /> class.
        /// </summary>
        /// <param name="customPrompt">
        /// Custom instructions for the AI parser. Use to guide extraction behavior, specify output formatting, or provide domain-specific context. Example: 'Extract financial tables with currency symbols. Format dates as YYYY-MM-DD.'
        /// </param>
        public LlamaParseAgenticOptions(
            string? customPrompt)
        {
            this.CustomPrompt = customPrompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParseAgenticOptions" /> class.
        /// </summary>
        public LlamaParseAgenticOptions()
        {
        }
    }
}