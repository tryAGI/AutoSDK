//HintName: G.Models.ScrapeOptionsJsonOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// JSON options object
    /// </summary>
    public sealed partial class ScrapeOptionsJsonOptions
    {
        /// <summary>
        /// The schema to use for the extraction (Optional). Must conform to [JSON Schema](https://json-schema.org/).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// The system prompt to use for the extraction (Optional)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("systemPrompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// The prompt to use for the extraction without a schema (Optional)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapeOptionsJsonOptions" /> class.
        /// </summary>
        /// <param name="schema">
        /// The schema to use for the extraction (Optional). Must conform to [JSON Schema](https://json-schema.org/).
        /// </param>
        /// <param name="systemPrompt">
        /// The system prompt to use for the extraction (Optional)
        /// </param>
        /// <param name="prompt">
        /// The prompt to use for the extraction without a schema (Optional)
        /// </param>
        public ScrapeOptionsJsonOptions(
            object? schema,
            string? systemPrompt,
            string? prompt)
        {
            this.Schema = schema;
            this.SystemPrompt = systemPrompt;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapeOptionsJsonOptions" /> class.
        /// </summary>
        public ScrapeOptionsJsonOptions()
        {
        }
    }
}