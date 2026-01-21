//HintName: G.Models.SpeechToTextChunkResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Chunk-level detail of the transcription with timing information.<br/>
    /// Example: {"language_code":"en","language_probability":0.98,"text":"Hello world!","words":[{"end":0.5,"speaker_id":"speaker_1","start":0,"text":"Hello","type":"word"},{"end":0.5,"speaker_id":"speaker_1","start":0.5,"text":" ","type":"spacing"},{"end":1.2,"speaker_id":"speaker_1","start":0.5,"text":"world!","type":"word"}]}
    /// </summary>
    public sealed partial class SpeechToTextChunkResponseModel
    {
        /// <summary>
        /// The detected language code (e.g. 'eng' for English).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language_code", Required = global::Newtonsoft.Json.Required.Always)]
        public string LanguageCode { get; set; } = default!;

        /// <summary>
        /// The confidence score of the language detection (0 to 1).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language_probability", Required = global::Newtonsoft.Json.Required.Always)]
        public double LanguageProbability { get; set; } = default!;

        /// <summary>
        /// The raw text of the transcription.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// List of words with their timing information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("words", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SpeechToTextWordResponseModel> Words { get; set; } = default!;

        /// <summary>
        /// Requested additional formats of the transcript.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("additional_formats")]
        public global::System.Collections.Generic.IList<global::G.AdditionalFormatResponseModel>? AdditionalFormats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        /// <param name="additionalFormats">
        /// Requested additional formats of the transcript.
        /// </param>
        public SpeechToTextChunkResponseModel(
            string languageCode,
            double languageProbability,
            string text,
            global::System.Collections.Generic.IList<global::G.SpeechToTextWordResponseModel> words,
            global::System.Collections.Generic.IList<global::G.AdditionalFormatResponseModel>? additionalFormats)
        {
            this.LanguageCode = languageCode ?? throw new global::System.ArgumentNullException(nameof(languageCode));
            this.LanguageProbability = languageProbability;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Words = words ?? throw new global::System.ArgumentNullException(nameof(words));
            this.AdditionalFormats = additionalFormats;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechToTextChunkResponseModel" /> class.
        /// </summary>
        public SpeechToTextChunkResponseModel()
        {
        }
    }
}