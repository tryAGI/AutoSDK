//HintName: G.Models.LlamaParseOcrParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// OCR (Optical Character Recognition) configuration parameters.
    /// </summary>
    public sealed partial class LlamaParseOcrParameters
    {
        /// <summary>
        /// Languages to use for OCR text recognition. Specify multiple languages if document contains mixed-language content. Order matters - put primary language first. Example: ['en', 'es'] for English with Spanish
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<global::G.ParserLanguages>? Languages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParseOcrParameters" /> class.
        /// </summary>
        /// <param name="languages">
        /// Languages to use for OCR text recognition. Specify multiple languages if document contains mixed-language content. Order matters - put primary language first. Example: ['en', 'es'] for English with Spanish
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LlamaParseOcrParameters(
            global::System.Collections.Generic.IList<global::G.ParserLanguages>? languages)
        {
            this.Languages = languages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParseOcrParameters" /> class.
        /// </summary>
        public LlamaParseOcrParameters()
        {
        }
    }
}