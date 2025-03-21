//HintName: G.Models.Reasoning.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// **o-series models only**<br/>
    /// Configuration options for <br/>
    /// [reasoning models](https://platform.openai.com/docs/guides/reasoning).
    /// </summary>
    public sealed partial class Reasoning
    {
        /// <summary>
        /// **o-series models only** <br/>
        /// Constrains effort on reasoning for <br/>
        /// [reasoning models](https://platform.openai.com/docs/guides/reasoning).<br/>
        /// Currently supported values are `low`, `medium`, and `high`. Reducing<br/>
        /// reasoning effort can result in faster responses and fewer tokens used<br/>
        /// on reasoning in a response.<br/>
        /// Default Value: medium
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("effort", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ReasoningEffort? Effort { get; set; } = default!;

        /// <summary>
        /// **o-series models only** <br/>
        /// A summary of the reasoning performed by the model. This can be<br/>
        /// useful for debugging and understanding the model's reasoning process.<br/>
        /// One of `concise` or `detailed`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generate_summary")]
        public global::G.ReasoningGenerateSummary? GenerateSummary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Reasoning" /> class.
        /// </summary>
        /// <param name="effort">
        /// **o-series models only** <br/>
        /// Constrains effort on reasoning for <br/>
        /// [reasoning models](https://platform.openai.com/docs/guides/reasoning).<br/>
        /// Currently supported values are `low`, `medium`, and `high`. Reducing<br/>
        /// reasoning effort can result in faster responses and fewer tokens used<br/>
        /// on reasoning in a response.<br/>
        /// Default Value: medium
        /// </param>
        /// <param name="generateSummary">
        /// **o-series models only** <br/>
        /// A summary of the reasoning performed by the model. This can be<br/>
        /// useful for debugging and understanding the model's reasoning process.<br/>
        /// One of `concise` or `detailed`.
        /// </param>
        public Reasoning(
            global::G.ReasoningEffort? effort,
            global::G.ReasoningGenerateSummary? generateSummary)
        {
            this.Effort = effort;
            this.GenerateSummary = generateSummary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Reasoning" /> class.
        /// </summary>
        public Reasoning()
        {
        }
    }
}