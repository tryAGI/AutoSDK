//HintName: G.ICallsClient.CallsCreate.g.cs
#nullable enable

namespace G
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="enableGreetingPrompt">
        /// Default Value: true
        /// </param>
        /// <param name="priorCallId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Call> CallsCreateAsync(
            global::G.UltravoxV1StartCallRequest request,
            bool? enableGreetingPrompt = default,
            global::System.Guid? priorCallId = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="enableGreetingPrompt">
        /// Default Value: true
        /// </param>
        /// <param name="priorCallId"></param>
        /// <param name="systemPrompt">
        /// The system prompt provided to the model during generations.
        /// </param>
        /// <param name="temperature">
        /// The model temperature, between 0 and 1. Defaults to 0.
        /// </param>
        /// <param name="model">
        /// The model used for generations. Defaults to fixie-ai/ultravox.
        /// </param>
        /// <param name="voice">
        /// The ID (or name if unique) of the voice the agent should use for this call.
        /// </param>
        /// <param name="externalVoice">
        /// A voice not known to Ultravox Realtime that can nonetheless be used for this call.<br/>
        ///  Your account must have an API key set for the provider of the voice.<br/>
        ///  Either this or `voice` may be set, but not both.
        /// </param>
        /// <param name="languageHint">
        /// A BCP47 language code that may be used to guide speech recognition and synthesis.
        /// </param>
        /// <param name="initialMessages">
        /// The conversation history to start from for this call.
        /// </param>
        /// <param name="joinTimeout">
        /// A timeout for joining the call. Defaults to 30 seconds.
        /// </param>
        /// <param name="maxDuration">
        /// The maximum duration of the call. Defaults to 1 hour.
        /// </param>
        /// <param name="timeExceededMessage">
        /// What the agent should say immediately before hanging up if the call's time limit is reached.
        /// </param>
        /// <param name="inactivityMessages">
        /// Messages spoken by the agent when the user is inactive for the specified duration.<br/>
        ///  Durations are cumulative, so a message m &gt; 1 with duration 30s will be spoken 30 seconds after message m-1.
        /// </param>
        /// <param name="selectedTools">
        /// The tools available to the agent for (the first stage of) this call.
        /// </param>
        /// <param name="medium">
        /// The medium used for this call.
        /// </param>
        /// <param name="recordingEnabled">
        /// Whether the call should be recorded.
        /// </param>
        /// <param name="firstSpeaker">
        /// Who should talk first when the call starts. Typically set to FIRST_SPEAKER_USER for outgoing<br/>
        ///  calls and left as the default (FIRST_SPEAKER_AGENT) otherwise.<br/>
        ///  Deprecated. Prefer `firstSpeakerSettings`. If both are set, they must match.
        /// </param>
        /// <param name="transcriptOptional">
        /// Indicates whether a transcript is optional for the call.
        /// </param>
        /// <param name="initialOutputMedium">
        /// The medium to use for the call initially. May be altered by the client later.<br/>
        ///  Defaults to voice.
        /// </param>
        /// <param name="vadSettings">
        /// VAD settings for the call.
        /// </param>
        /// <param name="firstSpeakerSettings">
        /// The settings for the initial message to get a conversation started.<br/>
        ///  Defaults to `agent: {}` which means the agent will start the conversation with an<br/>
        ///  (interruptible) greeting generated based on the system prompt and any initial messages.<br/>
        ///  (If first_speaker is set and this is not, first_speaker will be used instead.)
        /// </param>
        /// <param name="experimentalSettings">
        /// Experimental settings for the call.
        /// </param>
        /// <param name="metadata">
        /// Optional metadata key-value pairs to associate with the call. All values must be strings.<br/>
        ///  Keys may not start with "ultravox.", which is reserved for system-provided metadata.
        /// </param>
        /// <param name="initialState">
        /// The initial state of the call stage which is readable/writable by tools.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Call> CallsCreateAsync(
            bool? enableGreetingPrompt = default,
            global::System.Guid? priorCallId = default,
            string? systemPrompt = default,
            float? temperature = default,
            string? model = default,
            string? voice = default,
            global::G.UltravoxV1ExternalVoice? externalVoice = default,
            string? languageHint = default,
            global::System.Collections.Generic.IList<global::G.UltravoxV1Message>? initialMessages = default,
            string? joinTimeout = default,
            string? maxDuration = default,
            string? timeExceededMessage = default,
            global::System.Collections.Generic.IList<global::G.UltravoxV1TimedMessage>? inactivityMessages = default,
            global::System.Collections.Generic.IList<global::G.UltravoxV1SelectedTool>? selectedTools = default,
            global::G.UltravoxV1CallMedium? medium = default,
            bool? recordingEnabled = default,
            global::G.UltravoxV1StartCallRequestFirstSpeaker? firstSpeaker = default,
            bool? transcriptOptional = default,
            global::G.UltravoxV1StartCallRequestInitialOutputMedium? initialOutputMedium = default,
            global::G.UltravoxV1VadSettings? vadSettings = default,
            global::G.UltravoxV1FirstSpeakerSettings? firstSpeakerSettings = default,
            object? experimentalSettings = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            object? initialState = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}