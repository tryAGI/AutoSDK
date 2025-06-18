//HintName: G.IRealtimeClient.CreateRealtimeSession.g.cs
#nullable enable

namespace G
{
    public partial interface IRealtimeClient
    {
        /// <summary>
        /// Create an ephemeral API token for use in client-side applications with the<br/>
        /// Realtime API. Can be configured with the same session parameters as the<br/>
        /// `session.update` client event.<br/>
        /// It responds with a session object, plus a `client_secret` key which contains<br/>
        /// a usable ephemeral API token that can be used to authenticate browser clients<br/>
        /// for the Realtime API.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RealtimeSessionCreateResponse> CreateRealtimeSessionAsync(
            global::G.RealtimeSessionCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create an ephemeral API token for use in client-side applications with the<br/>
        /// Realtime API. Can be configured with the same session parameters as the<br/>
        /// `session.update` client event.<br/>
        /// It responds with a session object, plus a `client_secret` key which contains<br/>
        /// a usable ephemeral API token that can be used to authenticate browser clients<br/>
        /// for the Realtime API.
        /// </summary>
        /// <param name="modalities">
        /// The set of modalities the model can respond with. To disable audio,<br/>
        /// set this to ["text"].
        /// </param>
        /// <param name="model">
        /// The Realtime model used for this session.
        /// </param>
        /// <param name="instructions">
        /// The default system instructions (i.e. system message) prepended to model calls. This field allows the client to guide the model on desired responses. The model can be instructed on response content and format, (e.g. "be extremely succinct", "act friendly", "here are examples of good responses") and on audio behavior (e.g. "talk quickly", "inject emotion into your voice", "laugh frequently"). The instructions are not guaranteed to be followed by the model, but they provide guidance to the model on the desired behavior.<br/>
        /// Note that the server sets default instructions which will be used if this field is not set and are visible in the `session.created` event at the start of the session.
        /// </param>
        /// <param name="voice">
        /// Example: ash
        /// </param>
        /// <param name="inputAudioFormat">
        /// The format of input audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.<br/>
        /// For `pcm16`, input audio must be 16-bit PCM at a 24kHz sample rate,<br/>
        /// single channel (mono), and little-endian byte order.<br/>
        /// Default Value: pcm16
        /// </param>
        /// <param name="outputAudioFormat">
        /// The format of output audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.<br/>
        /// For `pcm16`, output audio is sampled at a rate of 24kHz.<br/>
        /// Default Value: pcm16
        /// </param>
        /// <param name="inputAudioTranscription">
        /// Configuration for input audio transcription, defaults to off and can be set to `null` to turn off once on. Input audio transcription is not native to the model, since the model consumes audio directly. Transcription runs asynchronously through [the /audio/transcriptions endpoint](https://platform.openai.com/docs/api-reference/audio/createTranscription) and should be treated as guidance of input audio content rather than precisely what the model heard. The client can optionally set the language and prompt for transcription, these offer additional guidance to the transcription service.
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
        /// <param name="tools">
        /// Tools (functions) available to the model.
        /// </param>
        /// <param name="toolChoice">
        /// How the model chooses tools. Options are `auto`, `none`, `required`, or<br/>
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
        /// <param name="clientSecret">
        /// Configuration options for the generated client secret.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RealtimeSessionCreateResponse> CreateRealtimeSessionAsync(
            global::System.Collections.Generic.IList<global::G.RealtimeSessionCreateRequestModalitie>? modalities = default,
            global::G.RealtimeSessionCreateRequestModel? model = default,
            string? instructions = default,
            global::G.VoiceIdsShared? voice = default,
            global::G.RealtimeSessionCreateRequestInputAudioFormat? inputAudioFormat = default,
            global::G.RealtimeSessionCreateRequestOutputAudioFormat? outputAudioFormat = default,
            global::G.RealtimeSessionCreateRequestInputAudioTranscription? inputAudioTranscription = default,
            global::G.RealtimeSessionCreateRequestTurnDetection? turnDetection = default,
            global::G.RealtimeSessionCreateRequestInputAudioNoiseReduction? inputAudioNoiseReduction = default,
            double? speed = default,
            global::G.OneOf<global::G.RealtimeSessionCreateRequestTracingEnum?, global::G.RealtimeSessionCreateRequestTracingEnum2>? tracing = default,
            global::System.Collections.Generic.IList<global::G.RealtimeSessionCreateRequestTool>? tools = default,
            string? toolChoice = default,
            double? temperature = default,
            global::G.OneOf<int?, global::G.RealtimeSessionCreateRequestMaxResponseOutputTokens?>? maxResponseOutputTokens = default,
            global::G.RealtimeSessionCreateRequestClientSecret? clientSecret = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}