//HintName: G.Models.CorrectionItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A single correction applied to a span of text in the generated text.
    /// </summary>
    public sealed partial class CorrectionItem
    {
        /// <summary>
        /// The original text containing a hallucination or error.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("original_text", Required = global::Newtonsoft.Json.Required.Always)]
        public string OriginalText { get; set; } = default!;

        /// <summary>
        /// The corrected version of the text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("corrected_text", Required = global::Newtonsoft.Json.Required.Always)]
        public string CorrectedText { get; set; } = default!;

        /// <summary>
        /// An explanation of why the correction was needed for the text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("explanation", Required = global::Newtonsoft.Json.Required.Always)]
        public string Explanation { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CorrectionItem" /> class.
        /// </summary>
        /// <param name="originalText">
        /// The original text containing a hallucination or error.
        /// </param>
        /// <param name="correctedText">
        /// The corrected version of the text.
        /// </param>
        /// <param name="explanation">
        /// An explanation of why the correction was needed for the text.
        /// </param>
        public CorrectionItem(
            string originalText,
            string correctedText,
            string explanation)
        {
            this.OriginalText = originalText ?? throw new global::System.ArgumentNullException(nameof(originalText));
            this.CorrectedText = correctedText ?? throw new global::System.ArgumentNullException(nameof(correctedText));
            this.Explanation = explanation ?? throw new global::System.ArgumentNullException(nameof(explanation));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CorrectionItem" /> class.
        /// </summary>
        public CorrectionItem()
        {
        }
    }
}