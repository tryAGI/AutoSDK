//HintName: G.Models.RealtimeSessionCreateResponse.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A new Realtime session configuration, with an ephermeral key. Default TTL<br/>
    /// for keys is one minute.
    /// </summary>
    public sealed partial class RealtimeSessionCreateResponse
    {
        /// <summary>
        /// Ephemeral key returned by the API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("client_secret", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RealtimeSessionCreateResponseClientSecret ClientSecret { get; set; } = default!;

        /// <summary>
        /// The format of input audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_audio_format")]
        public string? InputAudioFormat { get; set; }

        /// <summary>
        /// Configuration for input audio transcription, defaults to off and can be <br/>
        /// set to `null` to turn off once on. Input audio transcription is not native <br/>
        /// to the model, since the model consumes audio directly. Transcription runs <br/>
        /// asynchronously through Whisper and should be treated as rough guidance <br/>
        /// rather than the representation understood by the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_audio_transcription")]
        public global::G.RealtimeSessionCreateResponseInputAudioTranscription? InputAudioTranscription { get; set; }

        /// <summary>
        /// The default system instructions (i.e. system message) prepended to model <br/>
        /// calls. This field allows the client to guide the model on desired <br/>
        /// responses. The model can be instructed on response content and format, <br/>
        /// (e.g. "be extremely succinct", "act friendly", "here are examples of good <br/>
        /// responses") and on audio behavior (e.g. "talk quickly", "inject emotion <br/>
        /// into your voice", "laugh frequently"). The instructions are not guaranteed <br/>
        /// to be followed by the model, but they provide guidance to the model on the <br/>
        /// desired behavior.<br/>
        /// Note that the server sets default instructions which will be used if this <br/>
        /// field is not set and are visible in the `session.created` event at the <br/>
        /// start of the session.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Maximum number of output tokens for a single assistant response,<br/>
        /// inclusive of tool calls. Provide an integer between 1 and 4096 to<br/>
        /// limit output tokens, or `inf` for the maximum available tokens for a<br/>
        /// given model. Defaults to `inf`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_response_output_tokens")]
        public global::G.OneOf<int?, global::G.RealtimeSessionCreateResponseMaxResponseOutputTokens?>? MaxResponseOutputTokens { get; set; }

        /// <summary>
        /// The set of modalities the model can respond with. To disable audio,<br/>
        /// set this to ["text"].
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modalities")]
        public global::System.Collections.Generic.IList<global::G.RealtimeSessionCreateResponseModalitie>? Modalities { get; set; }

        /// <summary>
        /// The format of output audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_audio_format")]
        public string? OutputAudioFormat { get; set; }

        /// <summary>
        /// Sampling temperature for the model, limited to [0.6, 1.2]. Defaults to 0.8.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// How the model chooses tools. Options are `auto`, `none`, `required`, or <br/>
        /// specify a function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_choice")]
        public string? ToolChoice { get; set; }

        /// <summary>
        /// Tools (functions) available to the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::System.Collections.Generic.IList<global::G.RealtimeSessionCreateResponseTool>? Tools { get; set; }

        /// <summary>
        /// Configuration for turn detection. Can be set to `null` to turn off. Server <br/>
        /// VAD means that the model will detect the start and end of speech based on <br/>
        /// audio volume and respond at the end of user speech.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("turn_detection")]
        public global::G.RealtimeSessionCreateResponseTurnDetection? TurnDetection { get; set; }

        /// <summary>
        /// The voice the model uses to respond. Voice cannot be changed during the <br/>
        /// session once the model has responded with audio at least once. Current <br/>
        /// voice options are `alloy`, `ash`, `ballad`, `coral`, `echo` `sage`, <br/>
        /// `shimmer` and `verse`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice")]
        public global::G.RealtimeSessionCreateResponseVoice? Voice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateResponse" /> class.
        /// </summary>
        /// <param name="clientSecret">
        /// Ephemeral key returned by the API.
        /// </param>
        /// <param name="inputAudioFormat">
        /// The format of input audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.
        /// </param>
        /// <param name="inputAudioTranscription">
        /// Configuration for input audio transcription, defaults to off and can be <br/>
        /// set to `null` to turn off once on. Input audio transcription is not native <br/>
        /// to the model, since the model consumes audio directly. Transcription runs <br/>
        /// asynchronously through Whisper and should be treated as rough guidance <br/>
        /// rather than the representation understood by the model.
        /// </param>
        /// <param name="instructions">
        /// The default system instructions (i.e. system message) prepended to model <br/>
        /// calls. This field allows the client to guide the model on desired <br/>
        /// responses. The model can be instructed on response content and format, <br/>
        /// (e.g. "be extremely succinct", "act friendly", "here are examples of good <br/>
        /// responses") and on audio behavior (e.g. "talk quickly", "inject emotion <br/>
        /// into your voice", "laugh frequently"). The instructions are not guaranteed <br/>
        /// to be followed by the model, but they provide guidance to the model on the <br/>
        /// desired behavior.<br/>
        /// Note that the server sets default instructions which will be used if this <br/>
        /// field is not set and are visible in the `session.created` event at the <br/>
        /// start of the session.
        /// </param>
        /// <param name="maxResponseOutputTokens">
        /// Maximum number of output tokens for a single assistant response,<br/>
        /// inclusive of tool calls. Provide an integer between 1 and 4096 to<br/>
        /// limit output tokens, or `inf` for the maximum available tokens for a<br/>
        /// given model. Defaults to `inf`.
        /// </param>
        /// <param name="modalities">
        /// The set of modalities the model can respond with. To disable audio,<br/>
        /// set this to ["text"].
        /// </param>
        /// <param name="outputAudioFormat">
        /// The format of output audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature for the model, limited to [0.6, 1.2]. Defaults to 0.8.
        /// </param>
        /// <param name="toolChoice">
        /// How the model chooses tools. Options are `auto`, `none`, `required`, or <br/>
        /// specify a function.
        /// </param>
        /// <param name="tools">
        /// Tools (functions) available to the model.
        /// </param>
        /// <param name="turnDetection">
        /// Configuration for turn detection. Can be set to `null` to turn off. Server <br/>
        /// VAD means that the model will detect the start and end of speech based on <br/>
        /// audio volume and respond at the end of user speech.
        /// </param>
        /// <param name="voice">
        /// The voice the model uses to respond. Voice cannot be changed during the <br/>
        /// session once the model has responded with audio at least once. Current <br/>
        /// voice options are `alloy`, `ash`, `ballad`, `coral`, `echo` `sage`, <br/>
        /// `shimmer` and `verse`.
        /// </param>
        public RealtimeSessionCreateResponse(
            global::G.RealtimeSessionCreateResponseClientSecret clientSecret,
            string? inputAudioFormat,
            global::G.RealtimeSessionCreateResponseInputAudioTranscription? inputAudioTranscription,
            string? instructions,
            global::G.OneOf<int?, global::G.RealtimeSessionCreateResponseMaxResponseOutputTokens?>? maxResponseOutputTokens,
            global::System.Collections.Generic.IList<global::G.RealtimeSessionCreateResponseModalitie>? modalities,
            string? outputAudioFormat,
            double? temperature,
            string? toolChoice,
            global::System.Collections.Generic.IList<global::G.RealtimeSessionCreateResponseTool>? tools,
            global::G.RealtimeSessionCreateResponseTurnDetection? turnDetection,
            global::G.RealtimeSessionCreateResponseVoice? voice)
        {
            this.ClientSecret = clientSecret ?? throw new global::System.ArgumentNullException(nameof(clientSecret));
            this.InputAudioFormat = inputAudioFormat;
            this.InputAudioTranscription = inputAudioTranscription;
            this.Instructions = instructions;
            this.MaxResponseOutputTokens = maxResponseOutputTokens;
            this.Modalities = modalities;
            this.OutputAudioFormat = outputAudioFormat;
            this.Temperature = temperature;
            this.ToolChoice = toolChoice;
            this.Tools = tools;
            this.TurnDetection = turnDetection;
            this.Voice = voice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateResponse" /> class.
        /// </summary>
        public RealtimeSessionCreateResponse()
        {
        }
    }
}