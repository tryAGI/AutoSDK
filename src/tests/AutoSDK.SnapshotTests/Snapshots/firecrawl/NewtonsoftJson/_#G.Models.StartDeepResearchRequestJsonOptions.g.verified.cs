//HintName: G.Models.StartDeepResearchRequestJsonOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Options for JSON output
    /// </summary>
    public sealed partial class StartDeepResearchRequestJsonOptions
    {
        /// <summary>
        /// The schema to use for the JSON output. Must conform to [JSON Schema](https://json-schema.org/).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// The system prompt to use for the JSON output
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("systemPrompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// The prompt to use for the JSON output
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartDeepResearchRequestJsonOptions" /> class.
        /// </summary>
        /// <param name="schema">
        /// The schema to use for the JSON output. Must conform to [JSON Schema](https://json-schema.org/).
        /// </param>
        /// <param name="systemPrompt">
        /// The system prompt to use for the JSON output
        /// </param>
        /// <param name="prompt">
        /// The prompt to use for the JSON output
        /// </param>
        public StartDeepResearchRequestJsonOptions(
            object? schema,
            string? systemPrompt,
            string? prompt)
        {
            this.Schema = schema;
            this.SystemPrompt = systemPrompt;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartDeepResearchRequestJsonOptions" /> class.
        /// </summary>
        public StartDeepResearchRequestJsonOptions()
        {
        }
    }
}