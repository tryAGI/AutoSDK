//HintName: G.Models.TranslationData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslationData
    {
        /// <summary>
        /// The text the tool translated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_text", Required = global::Newtonsoft.Json.Required.Always)]
        public string SourceText { get; set; } = default!;

        /// <summary>
        /// The language code of the source text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_language_code", Required = global::Newtonsoft.Json.Required.Always)]
        public string SourceLanguageCode { get; set; } = default!;

        /// <summary>
        /// The language code of the target text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_language_code", Required = global::Newtonsoft.Json.Required.Always)]
        public string TargetLanguageCode { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationData" /> class.
        /// </summary>
        /// <param name="sourceText">
        /// The text the tool translated.
        /// </param>
        /// <param name="sourceLanguageCode">
        /// The language code of the source text.
        /// </param>
        /// <param name="targetLanguageCode">
        /// The language code of the target text.
        /// </param>
        public TranslationData(
            string sourceText,
            string sourceLanguageCode,
            string targetLanguageCode)
        {
            this.SourceText = sourceText ?? throw new global::System.ArgumentNullException(nameof(sourceText));
            this.SourceLanguageCode = sourceLanguageCode ?? throw new global::System.ArgumentNullException(nameof(sourceLanguageCode));
            this.TargetLanguageCode = targetLanguageCode ?? throw new global::System.ArgumentNullException(nameof(targetLanguageCode));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationData" /> class.
        /// </summary>
        public TranslationData()
        {
        }
    }
}