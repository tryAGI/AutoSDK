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
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RealtimeSessionCreateResponseClientSecret ClientSecret { get; set; }

        /// <summary>
        /// The set of modalities the model can respond with. To disable audio,<br/>
        /// set this to ["text"].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modalities")]
        public global::System.Collections.Generic.IList<global::G.RealtimeSessionCreateResponseModalitie>? Modalities { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Example: ash
        /// </summary>
        /// <example>ash</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VoiceIdsSharedJsonConverter))]
        public global::G.VoiceIdsShared? Voice { get; set; }

        /// <summary>
        /// The format of input audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio_format")]
        public string? InputAudioFormat { get; set; }

        /// <summary>
        /// The format of output audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_audio_format")]
        public string? OutputAudioFormat { get; set; }

        /// <summary>
        /// Configuration for input audio transcription, defaults to off and can be <br/>
        /// set to `null` to turn off once on. Input audio transcription is not native <br/>
        /// to the model, since the model consumes audio directly. Transcription runs <br/>
        /// asynchronously through Whisper and should be treated as rough guidance <br/>
        /// rather than the representation understood by the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio_transcription")]
        public global::G.RealtimeSessionCreateResponseInputAudioTranscription? InputAudioTranscription { get; set; }

        /// <summary>
        /// The speed of the model's spoken response. 1.0 is the default speed. 0.25 is<br/>
        /// the minimum speed. 1.5 is the maximum speed. This value can only be changed<br/>
        /// in between model turns, not while a response is in progress.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Configuration options for tracing. Set to null to disable tracing. Once <br/>
        /// tracing is enabled for a session, the configuration cannot be modified.<br/>
        /// `auto` will create a trace for the session with default values for the <br/>
        /// workflow name, group id, and metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracing")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.RealtimeSessionCreateResponseTracingEnum?, global::G.RealtimeSessionCreateResponseTracingEnum2>))]
        public global::G.OneOf<global::G.RealtimeSessionCreateResponseTracingEnum?, global::G.RealtimeSessionCreateResponseTracingEnum2>? Tracing { get; set; }

        /// <summary>
        /// Configuration for turn detection. Can be set to `null` to turn off. Server <br/>
        /// VAD means that the model will detect the start and end of speech based on <br/>
        /// audio volume and respond at the end of user speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_detection")]
        public global::G.RealtimeSessionCreateResponseTurnDetection? TurnDetection { get; set; }

        /// <summary>
        /// Tools (functions) available to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::G.RealtimeSessionCreateResponseTool>? Tools { get; set; }

        /// <summary>
        /// How the model chooses tools. Options are `auto`, `none`, `required`, or <br/>
        /// specify a function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        public string? ToolChoice { get; set; }

        /// <summary>
        /// Sampling temperature for the model, limited to [0.6, 1.2]. Defaults to 0.8.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Maximum number of output tokens for a single assistant response,<br/>
        /// inclusive of tool calls. Provide an integer between 1 and 4096 to<br/>
        /// limit output tokens, or `inf` for the maximum available tokens for a<br/>
        /// given model. Defaults to `inf`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_response_output_tokens")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<int?, global::G.RealtimeSessionCreateResponseMaxResponseOutputTokens?>))]
        public global::G.OneOf<int?, global::G.RealtimeSessionCreateResponseMaxResponseOutputTokens?>? MaxResponseOutputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateResponse" /> class.
        /// </summary>
        /// <param name="clientSecret">
        /// Ephemeral key returned by the API.
        /// </param>
        /// <param name="modalities">
        /// The set of modalities the model can respond with. To disable audio,<br/>
        /// set this to ["text"].
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
        /// <param name="voice">
        /// Example: ash
        /// </param>
        /// <param name="inputAudioFormat">
        /// The format of input audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.
        /// </param>
        /// <param name="outputAudioFormat">
        /// The format of output audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.
        /// </param>
        /// <param name="inputAudioTranscription">
        /// Configuration for input audio transcription, defaults to off and can be <br/>
        /// set to `null` to turn off once on. Input audio transcription is not native <br/>
        /// to the model, since the model consumes audio directly. Transcription runs <br/>
        /// asynchronously through Whisper and should be treated as rough guidance <br/>
        /// rather than the representation understood by the model.
        /// </param>
        /// <param name="speed">
        /// The speed of the model's spoken response. 1.0 is the default speed. 0.25 is<br/>
        /// the minimum speed. 1.5 is the maximum speed. This value can only be changed<br/>
        /// in between model turns, not while a response is in progress.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="tracing">
        /// Configuration options for tracing. Set to null to disable tracing. Once <br/>
        /// tracing is enabled for a session, the configuration cannot be modified.<br/>
        /// `auto` will create a trace for the session with default values for the <br/>
        /// workflow name, group id, and metadata.
        /// </param>
        /// <param name="turnDetection">
        /// Configuration for turn detection. Can be set to `null` to turn off. Server <br/>
        /// VAD means that the model will detect the start and end of speech based on <br/>
        /// audio volume and respond at the end of user speech.
        /// </param>
        /// <param name="tools">
        /// Tools (functions) available to the model.
        /// </param>
        /// <param name="toolChoice">
        /// How the model chooses tools. Options are `auto`, `none`, `required`, or <br/>
        /// specify a function.
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature for the model, limited to [0.6, 1.2]. Defaults to 0.8.
        /// </param>
        /// <param name="maxResponseOutputTokens">
        /// Maximum number of output tokens for a single assistant response,<br/>
        /// inclusive of tool calls. Provide an integer between 1 and 4096 to<br/>
        /// limit output tokens, or `inf` for the maximum available tokens for a<br/>
        /// given model. Defaults to `inf`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeSessionCreateResponse(
            global::G.RealtimeSessionCreateResponseClientSecret clientSecret,
            global::System.Collections.Generic.IList<global::G.RealtimeSessionCreateResponseModalitie>? modalities,
            string? instructions,
            global::G.VoiceIdsShared? voice,
            string? inputAudioFormat,
            string? outputAudioFormat,
            global::G.RealtimeSessionCreateResponseInputAudioTranscription? inputAudioTranscription,
            double? speed,
            global::G.OneOf<global::G.RealtimeSessionCreateResponseTracingEnum?, global::G.RealtimeSessionCreateResponseTracingEnum2>? tracing,
            global::G.RealtimeSessionCreateResponseTurnDetection? turnDetection,
            global::System.Collections.Generic.IList<global::G.RealtimeSessionCreateResponseTool>? tools,
            string? toolChoice,
            double? temperature,
            global::G.OneOf<int?, global::G.RealtimeSessionCreateResponseMaxResponseOutputTokens?>? maxResponseOutputTokens)
        {
            this.ClientSecret = clientSecret ?? throw new global::System.ArgumentNullException(nameof(clientSecret));
            this.Modalities = modalities;
            this.Instructions = instructions;
            this.Voice = voice;
            this.InputAudioFormat = inputAudioFormat;
            this.OutputAudioFormat = outputAudioFormat;
            this.InputAudioTranscription = inputAudioTranscription;
            this.Speed = speed;
            this.Tracing = tracing;
            this.TurnDetection = turnDetection;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.Temperature = temperature;
            this.MaxResponseOutputTokens = maxResponseOutputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateResponse" /> class.
        /// </summary>
        public RealtimeSessionCreateResponse()
        {
        }
    }
}