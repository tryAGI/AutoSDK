//HintName: G.Models.SpeechToTextChunkResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Chunk-level detail of the transcription with timing information.
    /// </summary>
    public sealed partial class SpeechToTextChunkResponseModel
    {
        /// <summary>
        /// The detected language code (e.g. 'eng' for English).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LanguageCode { get; set; }

        /// <summary>
        /// The confidence score of the language detection (0 to 1).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_probability")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double LanguageProbability { get; set; }

        /// <summary>
        /// The raw text of the transcription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// List of words with their timing information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.SpeechToTextWordResponseModel> Words { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechToTextChunkResponseModel" /> class.
        /// </summary>
        /// <param name="languageCode">
        /// The detected language code (e.g. 'eng' for English).
        /// </param>
        /// <param name="languageProbability">
        /// The confidence score of the language detection (0 to 1).
        /// </param>
        /// <param name="text">
        /// The raw text of the transcription.
        /// </param>
        /// <param name="words">
        /// List of words with their timing information.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechToTextChunkResponseModel(
            string languageCode,
            double languageProbability,
            string text,
            global::System.Collections.Generic.IList<global::G.SpeechToTextWordResponseModel> words)
        {
            this.LanguageCode = languageCode ?? throw new global::System.ArgumentNullException(nameof(languageCode));
            this.LanguageProbability = languageProbability;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Words = words ?? throw new global::System.ArgumentNullException(nameof(words));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechToTextChunkResponseModel" /> class.
        /// </summary>
        public SpeechToTextChunkResponseModel()
        {
        }
    }
}