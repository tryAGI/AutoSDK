//HintName: G.Models.TranscribeSpeechRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscribeSpeechRequest
    {
        /// <summary>
        /// Audio file (WAV, MP3, AAC, AIFF, OGG, OPUS, FLAC, MP4/M4A, AMR, WMA, WebM, PCM)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// Audio file (WAV, MP3, AAC, AIFF, OGG, OPUS, FLAC, MP4/M4A, AMR, WMA, WebM, PCM)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Speech-to-text model<br/>
        /// Default Value: saarika:v2.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TranscribeSpeechRequestModelJsonConverter))]
        public global::G.TranscribeSpeechRequestModel? Model { get; set; }

        /// <summary>
        /// Operation mode (saaras:v3 only)<br/>
        /// Default Value: transcribe
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TranscribeSpeechRequestModeJsonConverter))]
        public global::G.TranscribeSpeechRequestMode? Mode { get; set; }

        /// <summary>
        /// Language of the audio (BCP-47). Optional for saarika:v2.5.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TranscribeSpeechRequestLanguageCodeJsonConverter))]
        public global::G.TranscribeSpeechRequestLanguageCode? LanguageCode { get; set; }

        /// <summary>
        /// Required for PCM format files
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio_codec")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TranscribeSpeechRequestInputAudioCodecJsonConverter))]
        public global::G.TranscribeSpeechRequestInputAudioCodec? InputAudioCodec { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscribeSpeechRequest" /> class.
        /// </summary>
        /// <param name="file">
        /// Audio file (WAV, MP3, AAC, AIFF, OGG, OPUS, FLAC, MP4/M4A, AMR, WMA, WebM, PCM)
        /// </param>
        /// <param name="filename">
        /// Audio file (WAV, MP3, AAC, AIFF, OGG, OPUS, FLAC, MP4/M4A, AMR, WMA, WebM, PCM)
        /// </param>
        /// <param name="model">
        /// Speech-to-text model<br/>
        /// Default Value: saarika:v2.5
        /// </param>
        /// <param name="mode">
        /// Operation mode (saaras:v3 only)<br/>
        /// Default Value: transcribe
        /// </param>
        /// <param name="languageCode">
        /// Language of the audio (BCP-47). Optional for saarika:v2.5.
        /// </param>
        /// <param name="inputAudioCodec">
        /// Required for PCM format files
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscribeSpeechRequest(
            byte[] file,
            string filename,
            global::G.TranscribeSpeechRequestModel? model,
            global::G.TranscribeSpeechRequestMode? mode,
            global::G.TranscribeSpeechRequestLanguageCode? languageCode,
            global::G.TranscribeSpeechRequestInputAudioCodec? inputAudioCodec)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Model = model;
            this.Mode = mode;
            this.LanguageCode = languageCode;
            this.InputAudioCodec = inputAudioCodec;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscribeSpeechRequest" /> class.
        /// </summary>
        public TranscribeSpeechRequest()
        {
        }
    }
}