//HintName: G.Models.HallucinationCorrectionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The response that contains the hallucination correction results.
    /// </summary>
    public sealed partial class HallucinationCorrectionResponse
    {
        /// <summary>
        /// A list of corrections applied to the text, with explanations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("corrections")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CorrectionItem> Corrections { get; set; }

        /// <summary>
        /// The revised version of the text, with minimal edits made to correct unsupported or inaccurate statements. If no corrections are needed, this value is identical to the original text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("corrected_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CorrectedText { get; set; }

        /// <summary>
        /// The name of the model used for hallucination correction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HallucinationCorrectionResponse" /> class.
        /// </summary>
        /// <param name="corrections">
        /// A list of corrections applied to the text, with explanations.
        /// </param>
        /// <param name="correctedText">
        /// The revised version of the text, with minimal edits made to correct unsupported or inaccurate statements. If no corrections are needed, this value is identical to the original text.
        /// </param>
        /// <param name="model">
        /// The name of the model used for hallucination correction.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HallucinationCorrectionResponse(
            global::System.Collections.Generic.IList<global::G.CorrectionItem> corrections,
            string correctedText,
            string? model)
        {
            this.Corrections = corrections ?? throw new global::System.ArgumentNullException(nameof(corrections));
            this.CorrectedText = correctedText ?? throw new global::System.ArgumentNullException(nameof(correctedText));
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HallucinationCorrectionResponse" /> class.
        /// </summary>
        public HallucinationCorrectionResponse()
        {
        }
    }
}