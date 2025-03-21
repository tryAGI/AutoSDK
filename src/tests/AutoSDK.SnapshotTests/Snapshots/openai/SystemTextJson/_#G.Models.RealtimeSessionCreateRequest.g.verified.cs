//HintName: G.Models.RealtimeSessionCreateRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Realtime session object configuration.
    /// </summary>
    public sealed partial class RealtimeSessionCreateRequest
    {
        /// <summary>
        /// The format of input audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.<br/>
        /// For `pcm16`, input audio must be 16-bit PCM at a 24kHz sample rate, <br/>
        /// single channel (mono), and little-endian byte order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeSessionCreateRequestInputAudioFormatJsonConverter))]
        public global::G.RealtimeSessionCreateRequestInputAudioFormat? InputAudioFormat { get; set; }

        /// <summary>
        /// Configuration for input audio transcription, defaults to off and can be  set to `null` to turn off once on. Input audio transcription is not native to the model, since the model consumes audio directly. Transcription runs  asynchronously through [OpenAI Whisper transcription](https://platform.openai.com/docs/api-reference/audio/createTranscription) and should be treated as rough guidance rather than the representation understood by the model. The client can optionally set the language and prompt for transcription, these fields will be passed to the Whisper API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio_transcription")]
        public global::G.RealtimeSessionCreateRequestInputAudioTranscription? InputAudioTranscription { get; set; }

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
        /// Maximum number of output tokens for a single assistant response,<br/>
        /// inclusive of tool calls. Provide an integer between 1 and 4096 to<br/>
        /// limit output tokens, or `inf` for the maximum available tokens for a<br/>
        /// given model. Defaults to `inf`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_response_output_tokens")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<int?, global::G.RealtimeSessionCreateRequestMaxResponseOutputTokens?>))]
        public global::G.OneOf<int?, global::G.RealtimeSessionCreateRequestMaxResponseOutputTokens?>? MaxResponseOutputTokens { get; set; }

        /// <summary>
        /// The set of modalities the model can respond with. To disable audio,<br/>
        /// set this to ["text"].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modalities")]
        public global::System.Collections.Generic.IList<global::G.RealtimeSessionCreateRequestModalitie>? Modalities { get; set; }

        /// <summary>
        /// The Realtime model used for this session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeSessionCreateRequestModelJsonConverter))]
        public global::G.RealtimeSessionCreateRequestModel? Model { get; set; }

        /// <summary>
        /// The format of output audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.<br/>
        /// For `pcm16`, output audio is sampled at a rate of 24kHz.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_audio_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeSessionCreateRequestOutputAudioFormatJsonConverter))]
        public global::G.RealtimeSessionCreateRequestOutputAudioFormat? OutputAudioFormat { get; set; }

        /// <summary>
        /// Sampling temperature for the model, limited to [0.6, 1.2]. Defaults to 0.8.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// How the model chooses tools. Options are `auto`, `none`, `required`, or <br/>
        /// specify a function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        public string? ToolChoice { get; set; }

        /// <summary>
        /// Tools (functions) available to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::G.RealtimeSessionCreateRequestTool>? Tools { get; set; }

        /// <summary>
        /// Configuration for turn detection. Can be set to `null` to turn off. Server <br/>
        /// VAD means that the model will detect the start and end of speech based on <br/>
        /// audio volume and respond at the end of user speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_detection")]
        public global::G.RealtimeSessionCreateRequestTurnDetection? TurnDetection { get; set; }

        /// <summary>
        /// The voice the model uses to respond. Voice cannot be changed during the <br/>
        /// session once the model has responded with audio at least once. Current <br/>
        /// voice options are `alloy`, `ash`, `ballad`, `coral`, `echo` `sage`, <br/>
        /// `shimmer` and `verse`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeSessionCreateRequestVoiceJsonConverter))]
        public global::G.RealtimeSessionCreateRequestVoice? Voice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateRequest" /> class.
        /// </summary>
        /// <param name="inputAudioFormat">
        /// The format of input audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.<br/>
        /// For `pcm16`, input audio must be 16-bit PCM at a 24kHz sample rate, <br/>
        /// single channel (mono), and little-endian byte order.
        /// </param>
        /// <param name="inputAudioTranscription">
        /// Configuration for input audio transcription, defaults to off and can be  set to `null` to turn off once on. Input audio transcription is not native to the model, since the model consumes audio directly. Transcription runs  asynchronously through [OpenAI Whisper transcription](https://platform.openai.com/docs/api-reference/audio/createTranscription) and should be treated as rough guidance rather than the representation understood by the model. The client can optionally set the language and prompt for transcription, these fields will be passed to the Whisper API.
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
        /// <param name="model">
        /// The Realtime model used for this session.
        /// </param>
        /// <param name="outputAudioFormat">
        /// The format of output audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.<br/>
        /// For `pcm16`, output audio is sampled at a rate of 24kHz.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeSessionCreateRequest(
            global::G.RealtimeSessionCreateRequestInputAudioFormat? inputAudioFormat,
            global::G.RealtimeSessionCreateRequestInputAudioTranscription? inputAudioTranscription,
            string? instructions,
            global::G.OneOf<int?, global::G.RealtimeSessionCreateRequestMaxResponseOutputTokens?>? maxResponseOutputTokens,
            global::System.Collections.Generic.IList<global::G.RealtimeSessionCreateRequestModalitie>? modalities,
            global::G.RealtimeSessionCreateRequestModel? model,
            global::G.RealtimeSessionCreateRequestOutputAudioFormat? outputAudioFormat,
            double? temperature,
            string? toolChoice,
            global::System.Collections.Generic.IList<global::G.RealtimeSessionCreateRequestTool>? tools,
            global::G.RealtimeSessionCreateRequestTurnDetection? turnDetection,
            global::G.RealtimeSessionCreateRequestVoice? voice)
        {
            this.InputAudioFormat = inputAudioFormat;
            this.InputAudioTranscription = inputAudioTranscription;
            this.Instructions = instructions;
            this.MaxResponseOutputTokens = maxResponseOutputTokens;
            this.Modalities = modalities;
            this.Model = model;
            this.OutputAudioFormat = outputAudioFormat;
            this.Temperature = temperature;
            this.ToolChoice = toolChoice;
            this.Tools = tools;
            this.TurnDetection = turnDetection;
            this.Voice = voice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateRequest" /> class.
        /// </summary>
        public RealtimeSessionCreateRequest()
        {
        }
    }
}