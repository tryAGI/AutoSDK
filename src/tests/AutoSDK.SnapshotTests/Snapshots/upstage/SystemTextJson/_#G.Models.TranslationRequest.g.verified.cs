//HintName: G.Models.TranslationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslationRequest
    {
        /// <summary>
        /// The model to use for translation.<br/>
        /// Default: solar-1-mini-translate-enko<br/>
        /// Example: solar-1-mini-translate-enko
        /// </summary>
        /// <example>solar-1-mini-translate-enko</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The text to translate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Source language code (e.g., en, ko, ja).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_lang")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceLang { get; set; }

        /// <summary>
        /// Target language code (e.g., en, ko, ja).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_lang")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetLang { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The model to use for translation.<br/>
        /// Default: solar-1-mini-translate-enko<br/>
        /// Example: solar-1-mini-translate-enko
        /// </param>
        /// <param name="text">
        /// The text to translate.
        /// </param>
        /// <param name="sourceLang">
        /// Source language code (e.g., en, ko, ja).
        /// </param>
        /// <param name="targetLang">
        /// Target language code (e.g., en, ko, ja).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationRequest(
            string model,
            string text,
            string sourceLang,
            string targetLang)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.SourceLang = sourceLang ?? throw new global::System.ArgumentNullException(nameof(sourceLang));
            this.TargetLang = targetLang ?? throw new global::System.ArgumentNullException(nameof(targetLang));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationRequest" /> class.
        /// </summary>
        public TranslationRequest()
        {
        }
    }
}