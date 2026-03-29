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
        [global::Newtonsoft.Json.JsonProperty("file", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] File { get; set; } = default!;

        /// <summary>
        /// Audio file (WAV, MP3, AAC, AIFF, OGG, OPUS, FLAC, MP4/M4A, AMR, WMA, WebM, PCM)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// Speech-to-text model<br/>
        /// Default Value: saarika:v2.5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public global::G.TranscribeSpeechRequestModel? Model { get; set; }

        /// <summary>
        /// Operation mode (saaras:v3 only)<br/>
        /// Default Value: transcribe
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mode")]
        public global::G.TranscribeSpeechRequestMode? Mode { get; set; }

        /// <summary>
        /// Language of the audio (BCP-47). Optional for saarika:v2.5.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language_code")]
        public global::G.TranscribeSpeechRequestLanguageCode? LanguageCode { get; set; }

        /// <summary>
        /// Required for PCM format files
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_audio_codec")]
        public global::G.TranscribeSpeechRequestInputAudioCodec? InputAudioCodec { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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