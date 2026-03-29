//HintName: G.Models.TextToSpeechRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextToSpeechRequest
    {
        /// <summary>
        /// Text to convert to speech (max 2500 chars for v3, 1500 for v2). Supports code-mixed text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Language code (BCP-47) for text normalization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_language_code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TextToSpeechRequestTargetLanguageCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TextToSpeechRequestTargetLanguageCode TargetLanguageCode { get; set; }

        /// <summary>
        /// TTS model to use<br/>
        /// Default Value: bulbul:v3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TextToSpeechRequestModelJsonConverter))]
        public global::G.TextToSpeechRequestModel? Model { get; set; }

        /// <summary>
        /// Speaker voice (default: shubh for v3, anushka for v2)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TextToSpeechRequestSpeakerJsonConverter))]
        public global::G.TextToSpeechRequestSpeaker? Speaker { get; set; }

        /// <summary>
        /// Pitch adjustment (-0.75 to 0.75). v2 only.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pitch")]
        public double? Pitch { get; set; }

        /// <summary>
        /// Speech speed (v3: 0.5-2.0, v2: 0.3-3.0)<br/>
        /// Default Value: 1.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pace")]
        public double? Pace { get; set; }

        /// <summary>
        /// Loudness (0.3-3.0). v2 only.<br/>
        /// Default Value: 1.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loudness")]
        public double? Loudness { get; set; }

        /// <summary>
        /// Randomness/expressiveness (0.01-2.0). v3 only.<br/>
        /// Default Value: 0.6
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Audio sample rate in Hz<br/>
        /// Default Value: 24000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_sample_rate")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TextToSpeechRequestSpeechSampleRateJsonConverter))]
        public global::G.TextToSpeechRequestSpeechSampleRate? SpeechSampleRate { get; set; }

        /// <summary>
        /// Output audio format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_audio_codec")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TextToSpeechRequestOutputAudioCodecJsonConverter))]
        public global::G.TextToSpeechRequestOutputAudioCodec? OutputAudioCodec { get; set; }

        /// <summary>
        /// Enable preprocessing. v2 only.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_preprocessing")]
        public bool? EnablePreprocessing { get; set; }

        /// <summary>
        /// Custom pronunciation dictionary ID. v3 only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dict_id")]
        public string? DictId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToSpeechRequest" /> class.
        /// </summary>
        /// <param name="text">
        /// Text to convert to speech (max 2500 chars for v3, 1500 for v2). Supports code-mixed text.
        /// </param>
        /// <param name="targetLanguageCode">
        /// Language code (BCP-47) for text normalization
        /// </param>
        /// <param name="model">
        /// TTS model to use<br/>
        /// Default Value: bulbul:v3
        /// </param>
        /// <param name="speaker">
        /// Speaker voice (default: shubh for v3, anushka for v2)
        /// </param>
        /// <param name="pitch">
        /// Pitch adjustment (-0.75 to 0.75). v2 only.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="pace">
        /// Speech speed (v3: 0.5-2.0, v2: 0.3-3.0)<br/>
        /// Default Value: 1.0
        /// </param>
        /// <param name="loudness">
        /// Loudness (0.3-3.0). v2 only.<br/>
        /// Default Value: 1.0
        /// </param>
        /// <param name="temperature">
        /// Randomness/expressiveness (0.01-2.0). v3 only.<br/>
        /// Default Value: 0.6
        /// </param>
        /// <param name="speechSampleRate">
        /// Audio sample rate in Hz<br/>
        /// Default Value: 24000
        /// </param>
        /// <param name="outputAudioCodec">
        /// Output audio format
        /// </param>
        /// <param name="enablePreprocessing">
        /// Enable preprocessing. v2 only.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="dictId">
        /// Custom pronunciation dictionary ID. v3 only.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextToSpeechRequest(
            string text,
            global::G.TextToSpeechRequestTargetLanguageCode targetLanguageCode,
            global::G.TextToSpeechRequestModel? model,
            global::G.TextToSpeechRequestSpeaker? speaker,
            double? pitch,
            double? pace,
            double? loudness,
            double? temperature,
            global::G.TextToSpeechRequestSpeechSampleRate? speechSampleRate,
            global::G.TextToSpeechRequestOutputAudioCodec? outputAudioCodec,
            bool? enablePreprocessing,
            string? dictId)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.TargetLanguageCode = targetLanguageCode;
            this.Model = model;
            this.Speaker = speaker;
            this.Pitch = pitch;
            this.Pace = pace;
            this.Loudness = loudness;
            this.Temperature = temperature;
            this.SpeechSampleRate = speechSampleRate;
            this.OutputAudioCodec = outputAudioCodec;
            this.EnablePreprocessing = enablePreprocessing;
            this.DictId = dictId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToSpeechRequest" /> class.
        /// </summary>
        public TextToSpeechRequest()
        {
        }
    }
}