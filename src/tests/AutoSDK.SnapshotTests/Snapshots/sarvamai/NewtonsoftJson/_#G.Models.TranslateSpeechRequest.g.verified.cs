//HintName: G.Models.TranslateSpeechRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslateSpeechRequest
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
        /// Default Value: saaras:v3
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TranslateSpeechRequestModelJsonConverter))]
        public global::G.TranslateSpeechRequestModel? Model { get; set; }

        /// <summary>
        /// Language of the audio (BCP-47)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language_code")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TranslateSpeechRequestLanguageCodeJsonConverter))]
        public global::G.TranslateSpeechRequestLanguageCode? LanguageCode { get; set; }

        /// <summary>
        /// Required for PCM format files
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_audio_codec")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TranslateSpeechRequestInputAudioCodecJsonConverter))]
        public global::G.TranslateSpeechRequestInputAudioCodec? InputAudioCodec { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslateSpeechRequest" /> class.
        /// </summary>
        /// <param name="file">
        /// Audio file (WAV, MP3, AAC, AIFF, OGG, OPUS, FLAC, MP4/M4A, AMR, WMA, WebM, PCM)
        /// </param>
        /// <param name="filename">
        /// Audio file (WAV, MP3, AAC, AIFF, OGG, OPUS, FLAC, MP4/M4A, AMR, WMA, WebM, PCM)
        /// </param>
        /// <param name="model">
        /// Speech-to-text model<br/>
        /// Default Value: saaras:v3
        /// </param>
        /// <param name="languageCode">
        /// Language of the audio (BCP-47)
        /// </param>
        /// <param name="inputAudioCodec">
        /// Required for PCM format files
        /// </param>
        public TranslateSpeechRequest(
            byte[] file,
            string filename,
            global::G.TranslateSpeechRequestModel? model,
            global::G.TranslateSpeechRequestLanguageCode? languageCode,
            global::G.TranslateSpeechRequestInputAudioCodec? inputAudioCodec)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Model = model;
            this.LanguageCode = languageCode;
            this.InputAudioCodec = inputAudioCodec;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslateSpeechRequest" /> class.
        /// </summary>
        public TranslateSpeechRequest()
        {
        }
    }
}