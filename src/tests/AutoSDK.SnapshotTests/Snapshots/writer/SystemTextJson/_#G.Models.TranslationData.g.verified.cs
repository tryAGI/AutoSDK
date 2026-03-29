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
        [global::System.Text.Json.Serialization.JsonPropertyName("source_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceText { get; set; }

        /// <summary>
        /// The language code of the source text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_language_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceLanguageCode { get; set; }

        /// <summary>
        /// The language code of the target text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_language_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetLanguageCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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