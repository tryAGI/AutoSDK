//HintName: G.Models.AudioToTextControllerAudioTranscriptionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioToTextControllerAudioTranscriptionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public byte[]? Audio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioname")]
        public string? Audioname { get; set; }

        /// <summary>
        /// Default Value: http://files.gladia.io/example/audio-transcription/split_infinity.wav
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        public string? AudioUrl { get; set; }

        /// <summary>
        /// Default Value: automatic single language
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_behaviour")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AudioToTextControllerAudioTranscriptionRequestLanguageBehaviourJsonConverter))]
        public global::G.AudioToTextControllerAudioTranscriptionRequestLanguageBehaviour? LanguageBehaviour { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AudioToTextControllerAudioTranscriptionRequestLanguageJsonConverter))]
        public global::G.AudioToTextControllerAudioTranscriptionRequestLanguage? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription_hint")]
        public string? TranscriptionHint { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toggle_diarization")]
        public bool? ToggleDiarization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diarization_num_speakers")]
        public int? DiarizationNumSpeakers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diarization_min_speakers")]
        public int? DiarizationMinSpeakers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diarization_max_speakers")]
        public int? DiarizationMaxSpeakers { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toggle_direct_translate")]
        public bool? ToggleDirectTranslate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_translation_language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AudioToTextControllerAudioTranscriptionRequestTargetTranslationLanguageJsonConverter))]
        public global::G.AudioToTextControllerAudioTranscriptionRequestTargetTranslationLanguage? TargetTranslationLanguage { get; set; }

        /// <summary>
        /// Default Value: json
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AudioToTextControllerAudioTranscriptionRequestOutputFormatJsonConverter))]
        public global::G.AudioToTextControllerAudioTranscriptionRequestOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toggle_noise_reduction")]
        public bool? ToggleNoiseReduction { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toggle_accurate_words_timestamps")]
        public bool? ToggleAccurateWordsTimestamps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioToTextControllerAudioTranscriptionRequest" /> class.
        /// </summary>
        /// <param name="audio"></param>
        /// <param name="audioname"></param>
        /// <param name="audioUrl">
        /// Default Value: http://files.gladia.io/example/audio-transcription/split_infinity.wav
        /// </param>
        /// <param name="languageBehaviour">
        /// Default Value: automatic single language
        /// </param>
        /// <param name="language"></param>
        /// <param name="transcriptionHint"></param>
        /// <param name="toggleDiarization">
        /// Default Value: false
        /// </param>
        /// <param name="diarizationNumSpeakers"></param>
        /// <param name="diarizationMinSpeakers"></param>
        /// <param name="diarizationMaxSpeakers"></param>
        /// <param name="toggleDirectTranslate">
        /// Default Value: false
        /// </param>
        /// <param name="targetTranslationLanguage"></param>
        /// <param name="outputFormat">
        /// Default Value: json
        /// </param>
        /// <param name="toggleNoiseReduction">
        /// Default Value: false
        /// </param>
        /// <param name="toggleAccurateWordsTimestamps">
        /// Default Value: false
        /// </param>
        /// <param name="webhookUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioToTextControllerAudioTranscriptionRequest(
            byte[]? audio,
            string? audioname,
            string? audioUrl,
            global::G.AudioToTextControllerAudioTranscriptionRequestLanguageBehaviour? languageBehaviour,
            global::G.AudioToTextControllerAudioTranscriptionRequestLanguage? language,
            string? transcriptionHint,
            bool? toggleDiarization,
            int? diarizationNumSpeakers,
            int? diarizationMinSpeakers,
            int? diarizationMaxSpeakers,
            bool? toggleDirectTranslate,
            global::G.AudioToTextControllerAudioTranscriptionRequestTargetTranslationLanguage? targetTranslationLanguage,
            global::G.AudioToTextControllerAudioTranscriptionRequestOutputFormat? outputFormat,
            bool? toggleNoiseReduction,
            bool? toggleAccurateWordsTimestamps,
            string? webhookUrl)
        {
            this.Audio = audio;
            this.Audioname = audioname;
            this.AudioUrl = audioUrl;
            this.LanguageBehaviour = languageBehaviour;
            this.Language = language;
            this.TranscriptionHint = transcriptionHint;
            this.ToggleDiarization = toggleDiarization;
            this.DiarizationNumSpeakers = diarizationNumSpeakers;
            this.DiarizationMinSpeakers = diarizationMinSpeakers;
            this.DiarizationMaxSpeakers = diarizationMaxSpeakers;
            this.ToggleDirectTranslate = toggleDirectTranslate;
            this.TargetTranslationLanguage = targetTranslationLanguage;
            this.OutputFormat = outputFormat;
            this.ToggleNoiseReduction = toggleNoiseReduction;
            this.ToggleAccurateWordsTimestamps = toggleAccurateWordsTimestamps;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioToTextControllerAudioTranscriptionRequest" /> class.
        /// </summary>
        public AudioToTextControllerAudioTranscriptionRequest()
        {
        }
    }
}