//HintName: G.Models.CompletionsPostRequestBodyContentApplicationJsonSchemaOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Options to affect the output of the response.
    /// </summary>
    public sealed partial class CompletionsPostRequestBodyContentApplicationJsonSchemaOutput
    {
        /// <summary>
        /// Set to true to turn on factuality processing.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("factuality")]
        public bool? Factuality { get; set; }

        /// <summary>
        /// Set to true to turn on toxicity processing.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toxicity")]
        public bool? Toxicity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionsPostRequestBodyContentApplicationJsonSchemaOutput" /> class.
        /// </summary>
        /// <param name="factuality">
        /// Set to true to turn on factuality processing.
        /// </param>
        /// <param name="toxicity">
        /// Set to true to turn on toxicity processing.
        /// </param>
        public CompletionsPostRequestBodyContentApplicationJsonSchemaOutput(
            bool? factuality,
            bool? toxicity)
        {
            this.Factuality = factuality;
            this.Toxicity = toxicity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionsPostRequestBodyContentApplicationJsonSchemaOutput" /> class.
        /// </summary>
        public CompletionsPostRequestBodyContentApplicationJsonSchemaOutput()
        {
        }
    }
}