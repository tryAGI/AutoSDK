//HintName: G.Models.TranslationResponseOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslationResponseOutput
    {
        /// <summary>
        /// The translated text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The detected or specified source language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_lang")]
        public string? SourceLang { get; set; }

        /// <summary>
        /// The target language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_lang")]
        public string? TargetLang { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationResponseOutput" /> class.
        /// </summary>
        /// <param name="text">
        /// The translated text.
        /// </param>
        /// <param name="sourceLang">
        /// The detected or specified source language.
        /// </param>
        /// <param name="targetLang">
        /// The target language.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationResponseOutput(
            string? text,
            string? sourceLang,
            string? targetLang)
        {
            this.Text = text;
            this.SourceLang = sourceLang;
            this.TargetLang = targetLang;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationResponseOutput" /> class.
        /// </summary>
        public TranslationResponseOutput()
        {
        }
    }
}