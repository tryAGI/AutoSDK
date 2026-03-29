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
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// The text to translate.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Source language code (e.g., en, ko, ja).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_lang", Required = global::Newtonsoft.Json.Required.Always)]
        public string SourceLang { get; set; } = default!;

        /// <summary>
        /// Target language code (e.g., en, ko, ja).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_lang", Required = global::Newtonsoft.Json.Required.Always)]
        public string TargetLang { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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