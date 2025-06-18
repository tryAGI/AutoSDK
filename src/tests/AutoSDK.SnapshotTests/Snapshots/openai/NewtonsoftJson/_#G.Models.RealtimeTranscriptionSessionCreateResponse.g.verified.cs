//HintName: G.Models.RealtimeTranscriptionSessionCreateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A new Realtime transcription session configuration.<br/>
    /// When a session is created on the server via REST API, the session object<br/>
    /// also contains an ephemeral key. Default TTL for keys is 10 minutes. This <br/>
    /// property is not present when a session is updated via the WebSocket API.
    /// </summary>
    public sealed partial class RealtimeTranscriptionSessionCreateResponse
    {
        /// <summary>
        /// Ephemeral key returned by the API. Only present when the session is<br/>
        /// created on the server via REST API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("client_secret", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RealtimeTranscriptionSessionCreateResponseClientSecret ClientSecret { get; set; } = default!;

        /// <summary>
        /// The set of modalities the model can respond with. To disable audio,<br/>
        /// set this to ["text"].
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modalities")]
        public global::System.Collections.Generic.IList<global::G.RealtimeTranscriptionSessionCreateResponseModalitie>? Modalities { get; set; }

        /// <summary>
        /// The format of input audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_audio_format")]
        public string? InputAudioFormat { get; set; }

        /// <summary>
        /// Configuration of the transcription model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_audio_transcription")]
        public global::G.RealtimeTranscriptionSessionCreateResponseInputAudioTranscription? InputAudioTranscription { get; set; }

        /// <summary>
        /// Configuration for turn detection. Can be set to `null` to turn off. Server <br/>
        /// VAD means that the model will detect the start and end of speech based on <br/>
        /// audio volume and respond at the end of user speech.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("turn_detection")]
        public global::G.RealtimeTranscriptionSessionCreateResponseTurnDetection? TurnDetection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateResponse" /> class.
        /// </summary>
        /// <param name="clientSecret">
        /// Ephemeral key returned by the API. Only present when the session is<br/>
        /// created on the server via REST API.
        /// </param>
        /// <param name="modalities">
        /// The set of modalities the model can respond with. To disable audio,<br/>
        /// set this to ["text"].
        /// </param>
        /// <param name="inputAudioFormat">
        /// The format of input audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.
        /// </param>
        /// <param name="inputAudioTranscription">
        /// Configuration of the transcription model.
        /// </param>
        /// <param name="turnDetection">
        /// Configuration for turn detection. Can be set to `null` to turn off. Server <br/>
        /// VAD means that the model will detect the start and end of speech based on <br/>
        /// audio volume and respond at the end of user speech.
        /// </param>
        public RealtimeTranscriptionSessionCreateResponse(
            global::G.RealtimeTranscriptionSessionCreateResponseClientSecret clientSecret,
            global::System.Collections.Generic.IList<global::G.RealtimeTranscriptionSessionCreateResponseModalitie>? modalities,
            string? inputAudioFormat,
            global::G.RealtimeTranscriptionSessionCreateResponseInputAudioTranscription? inputAudioTranscription,
            global::G.RealtimeTranscriptionSessionCreateResponseTurnDetection? turnDetection)
        {
            this.ClientSecret = clientSecret ?? throw new global::System.ArgumentNullException(nameof(clientSecret));
            this.Modalities = modalities;
            this.InputAudioFormat = inputAudioFormat;
            this.InputAudioTranscription = inputAudioTranscription;
            this.TurnDetection = turnDetection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateResponse" /> class.
        /// </summary>
        public RealtimeTranscriptionSessionCreateResponse()
        {
        }
    }
}