//HintName: G.Models.TalkscriberTranscriber.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TalkscriberTranscriber
    {
        /// <summary>
        /// This is the transcription provider that will be used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TalkscriberTranscriberProviderJsonConverter))]
        public global::G.TalkscriberTranscriberProvider Provider { get; set; }

        /// <summary>
        /// This is the model that will be used for the transcription.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TalkscriberTranscriberModelJsonConverter))]
        public global::G.TalkscriberTranscriberModel? Model { get; set; }

        /// <summary>
        /// This is the language that will be set for the transcription. The list of languages Whisper supports can be found here: https://github.com/openai/whisper/blob/main/whisper/tokenizer.py
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TalkscriberTranscriberLanguageJsonConverter))]
        public global::G.TalkscriberTranscriberLanguage? Language { get; set; }

        /// <summary>
        /// This is the plan for transcriber provider fallbacks in the event that the primary transcriber provider fails.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fallbackPlan")]
        public global::G.FallbackTranscriberPlan? FallbackPlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TalkscriberTranscriber" /> class.
        /// </summary>
        /// <param name="provider">
        /// This is the transcription provider that will be used.
        /// </param>
        /// <param name="model">
        /// This is the model that will be used for the transcription.
        /// </param>
        /// <param name="language">
        /// This is the language that will be set for the transcription. The list of languages Whisper supports can be found here: https://github.com/openai/whisper/blob/main/whisper/tokenizer.py
        /// </param>
        /// <param name="fallbackPlan">
        /// This is the plan for transcriber provider fallbacks in the event that the primary transcriber provider fails.
        /// </param>
        public TalkscriberTranscriber(
            global::G.TalkscriberTranscriberProvider provider,
            global::G.TalkscriberTranscriberModel? model,
            global::G.TalkscriberTranscriberLanguage? language,
            global::G.FallbackTranscriberPlan? fallbackPlan)
        {
            this.Provider = provider;
            this.Model = model;
            this.Language = language;
            this.FallbackPlan = fallbackPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TalkscriberTranscriber" /> class.
        /// </summary>
        public TalkscriberTranscriber()
        {
        }
    }
}