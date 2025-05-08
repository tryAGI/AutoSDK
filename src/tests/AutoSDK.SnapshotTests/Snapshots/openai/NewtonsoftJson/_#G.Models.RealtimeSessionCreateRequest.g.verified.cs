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
        /// The set of modalities the model can respond with. To disable audio,<br/>
        /// set this to ["text"].
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modalities")]
        public global::System.Collections.Generic.IList<global::G.RealtimeSessionCreateRequestModalitie>? Modalities { get; set; }

        /// <summary>
        /// The Realtime model used for this session.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public global::G.RealtimeSessionCreateRequestModel? Model { get; set; }

        /// <summary>
        /// The default system instructions (i.e. system message) prepended to model  calls. This field allows the client to guide the model on desired  responses. The model can be instructed on response content and format,  (e.g. "be extremely succinct", "act friendly", "here are examples of good  responses") and on audio behavior (e.g. "talk quickly", "inject emotion  into your voice", "laugh frequently"). The instructions are not guaranteed  to be followed by the model, but they provide guidance to the model on the desired behavior.<br/>
        /// Note that the server sets default instructions which will be used if this  field is not set and are visible in the `session.created` event at the  start of the session.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Example: ash
        /// </summary>
        /// <example>ash</example>
        [global::Newtonsoft.Json.JsonProperty("voice")]
        public global::G.VoiceIdsShared? Voice { get; set; }

        /// <summary>
        /// The format of input audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.<br/>
        /// For `pcm16`, input audio must be 16-bit PCM at a 24kHz sample rate, <br/>
        /// single channel (mono), and little-endian byte order.<br/>
        /// Default Value: pcm16
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_audio_format")]
        public global::G.RealtimeSessionCreateRequestInputAudioFormat? InputAudioFormat { get; set; }

        /// <summary>
        /// The format of output audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.<br/>
        /// For `pcm16`, output audio is sampled at a rate of 24kHz.<br/>
        /// Default Value: pcm16
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_audio_format")]
        public global::G.RealtimeSessionCreateRequestOutputAudioFormat? OutputAudioFormat { get; set; }

        /// <summary>
        /// Configuration for input audio transcription, defaults to off and can be  set to `null` to turn off once on. Input audio transcription is not native to the model, since the model consumes audio directly. Transcription runs  asynchronously through [the /audio/transcriptions endpoint](https://platform.openai.com/docs/api-reference/audio/createTranscription) and should be treated as guidance of input audio content rather than precisely what the model heard. The client can optionally set the language and prompt for transcription, these offer additional guidance to the transcription service.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_audio_transcription")]
        public global::G.RealtimeSessionCreateRequestInputAudioTranscription? InputAudioTranscription { get; set; }

        /// <summary>
        /// Configuration for turn detection, ether Server VAD or Semantic VAD. This can be set to `null` to turn off, in which case the client must manually trigger model response.<br/>
        /// Server VAD means that the model will detect the start and end of speech based on audio volume and respond at the end of user speech.<br/>
        /// Semantic VAD is more advanced and uses a turn detection model (in conjuction with VAD) to semantically estimate whether the user has finished speaking, then dynamically sets a timeout based on this probability. For example, if user audio trails off with "uhhm", the model will score a low probability of turn end and wait longer for the user to continue speaking. This can be useful for more natural conversations, but may have a higher latency.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("turn_detection")]
        public global::G.RealtimeSessionCreateRequestTurnDetection? TurnDetection { get; set; }

        /// <summary>
        /// Configuration for input audio noise reduction. This can be set to `null` to turn off.<br/>
        /// Noise reduction filters audio added to the input audio buffer before it is sent to VAD and the model.<br/>
        /// Filtering the audio can improve VAD and turn detection accuracy (reducing false positives) and model performance by improving perception of the input audio.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_audio_noise_reduction")]
        public global::G.RealtimeSessionCreateRequestInputAudioNoiseReduction? InputAudioNoiseReduction { get; set; }

        /// <summary>
        /// Tools (functions) available to the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::System.Collections.Generic.IList<global::G.RealtimeSessionCreateRequestTool>? Tools { get; set; }

        /// <summary>
        /// How the model chooses tools. Options are `auto`, `none`, `required`, or <br/>
        /// specify a function.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_choice")]
        public string? ToolChoice { get; set; }

        /// <summary>
        /// Sampling temperature for the model, limited to [0.6, 1.2]. For audio models a temperature of 0.8 is highly recommended for best performance.<br/>
        /// Default Value: 0.8
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Maximum number of output tokens for a single assistant response,<br/>
        /// inclusive of tool calls. Provide an integer between 1 and 4096 to<br/>
        /// limit output tokens, or `inf` for the maximum available tokens for a<br/>
        /// given model. Defaults to `inf`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_response_output_tokens")]
        public global::G.OneOf<int?, global::G.RealtimeSessionCreateRequestMaxResponseOutputTokens?>? MaxResponseOutputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateRequest" /> class.
        /// </summary>
        /// <param name="modalities">
        /// The set of modalities the model can respond with. To disable audio,<br/>
        /// set this to ["text"].
        /// </param>
        /// <param name="model">
        /// The Realtime model used for this session.
        /// </param>
        /// <param name="instructions">
        /// The default system instructions (i.e. system message) prepended to model  calls. This field allows the client to guide the model on desired  responses. The model can be instructed on response content and format,  (e.g. "be extremely succinct", "act friendly", "here are examples of good  responses") and on audio behavior (e.g. "talk quickly", "inject emotion  into your voice", "laugh frequently"). The instructions are not guaranteed  to be followed by the model, but they provide guidance to the model on the desired behavior.<br/>
        /// Note that the server sets default instructions which will be used if this  field is not set and are visible in the `session.created` event at the  start of the session.
        /// </param>
        /// <param name="voice">
        /// Example: ash
        /// </param>
        /// <param name="inputAudioFormat">
        /// The format of input audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.<br/>
        /// For `pcm16`, input audio must be 16-bit PCM at a 24kHz sample rate, <br/>
        /// single channel (mono), and little-endian byte order.<br/>
        /// Default Value: pcm16
        /// </param>
        /// <param name="outputAudioFormat">
        /// The format of output audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.<br/>
        /// For `pcm16`, output audio is sampled at a rate of 24kHz.<br/>
        /// Default Value: pcm16
        /// </param>
        /// <param name="inputAudioTranscription">
        /// Configuration for input audio transcription, defaults to off and can be  set to `null` to turn off once on. Input audio transcription is not native to the model, since the model consumes audio directly. Transcription runs  asynchronously through [the /audio/transcriptions endpoint](https://platform.openai.com/docs/api-reference/audio/createTranscription) and should be treated as guidance of input audio content rather than precisely what the model heard. The client can optionally set the language and prompt for transcription, these offer additional guidance to the transcription service.
        /// </param>
        /// <param name="turnDetection">
        /// Configuration for turn detection, ether Server VAD or Semantic VAD. This can be set to `null` to turn off, in which case the client must manually trigger model response.<br/>
        /// Server VAD means that the model will detect the start and end of speech based on audio volume and respond at the end of user speech.<br/>
        /// Semantic VAD is more advanced and uses a turn detection model (in conjuction with VAD) to semantically estimate whether the user has finished speaking, then dynamically sets a timeout based on this probability. For example, if user audio trails off with "uhhm", the model will score a low probability of turn end and wait longer for the user to continue speaking. This can be useful for more natural conversations, but may have a higher latency.
        /// </param>
        /// <param name="inputAudioNoiseReduction">
        /// Configuration for input audio noise reduction. This can be set to `null` to turn off.<br/>
        /// Noise reduction filters audio added to the input audio buffer before it is sent to VAD and the model.<br/>
        /// Filtering the audio can improve VAD and turn detection accuracy (reducing false positives) and model performance by improving perception of the input audio.
        /// </param>
        /// <param name="tools">
        /// Tools (functions) available to the model.
        /// </param>
        /// <param name="toolChoice">
        /// How the model chooses tools. Options are `auto`, `none`, `required`, or <br/>
        /// specify a function.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature for the model, limited to [0.6, 1.2]. For audio models a temperature of 0.8 is highly recommended for best performance.<br/>
        /// Default Value: 0.8
        /// </param>
        /// <param name="maxResponseOutputTokens">
        /// Maximum number of output tokens for a single assistant response,<br/>
        /// inclusive of tool calls. Provide an integer between 1 and 4096 to<br/>
        /// limit output tokens, or `inf` for the maximum available tokens for a<br/>
        /// given model. Defaults to `inf`.
        /// </param>
        public RealtimeSessionCreateRequest(
            global::System.Collections.Generic.IList<global::G.RealtimeSessionCreateRequestModalitie>? modalities,
            global::G.RealtimeSessionCreateRequestModel? model,
            string? instructions,
            global::G.VoiceIdsShared? voice,
            global::G.RealtimeSessionCreateRequestInputAudioFormat? inputAudioFormat,
            global::G.RealtimeSessionCreateRequestOutputAudioFormat? outputAudioFormat,
            global::G.RealtimeSessionCreateRequestInputAudioTranscription? inputAudioTranscription,
            global::G.RealtimeSessionCreateRequestTurnDetection? turnDetection,
            global::G.RealtimeSessionCreateRequestInputAudioNoiseReduction? inputAudioNoiseReduction,
            global::System.Collections.Generic.IList<global::G.RealtimeSessionCreateRequestTool>? tools,
            string? toolChoice,
            double? temperature,
            global::G.OneOf<int?, global::G.RealtimeSessionCreateRequestMaxResponseOutputTokens?>? maxResponseOutputTokens)
        {
            this.Modalities = modalities;
            this.Model = model;
            this.Instructions = instructions;
            this.Voice = voice;
            this.InputAudioFormat = inputAudioFormat;
            this.OutputAudioFormat = outputAudioFormat;
            this.InputAudioTranscription = inputAudioTranscription;
            this.TurnDetection = turnDetection;
            this.InputAudioNoiseReduction = inputAudioNoiseReduction;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.Temperature = temperature;
            this.MaxResponseOutputTokens = maxResponseOutputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateRequest" /> class.
        /// </summary>
        public RealtimeSessionCreateRequest()
        {
        }
    }
}