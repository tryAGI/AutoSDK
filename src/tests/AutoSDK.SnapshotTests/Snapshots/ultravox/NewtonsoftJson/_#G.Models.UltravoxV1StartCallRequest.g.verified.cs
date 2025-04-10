//HintName: G.Models.UltravoxV1StartCallRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A request to start a call.
    /// </summary>
    public sealed partial class UltravoxV1StartCallRequest
    {
        /// <summary>
        /// The system prompt provided to the model during generations.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("systemPrompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// The model temperature, between 0 and 1. Defaults to 0.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// The model used for generations. Defaults to fixie-ai/ultravox.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The ID (or name if unique) of the voice the agent should use for this call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice")]
        public string? Voice { get; set; }

        /// <summary>
        /// A voice not known to Ultravox Realtime that can nonetheless be used for this call.<br/>
        ///  Your account must have an API key set for the provider of the voice.<br/>
        ///  Either this or `voice` may be set, but not both.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("externalVoice")]
        public global::G.UltravoxV1ExternalVoice? ExternalVoice { get; set; }

        /// <summary>
        /// A BCP47 language code that may be used to guide speech recognition and synthesis.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("languageHint")]
        public string? LanguageHint { get; set; }

        /// <summary>
        /// The conversation history to start from for this call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("initialMessages")]
        public global::System.Collections.Generic.IList<global::G.UltravoxV1Message>? InitialMessages { get; set; }

        /// <summary>
        /// A timeout for joining the call. Defaults to 30 seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("joinTimeout")]
        public string? JoinTimeout { get; set; }

        /// <summary>
        /// The maximum duration of the call. Defaults to 1 hour.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxDuration")]
        public string? MaxDuration { get; set; }

        /// <summary>
        /// What the agent should say immediately before hanging up if the call's time limit is reached.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeExceededMessage")]
        public string? TimeExceededMessage { get; set; }

        /// <summary>
        /// Messages spoken by the agent when the user is inactive for the specified duration.<br/>
        ///  Durations are cumulative, so a message m &gt; 1 with duration 30s will be spoken 30 seconds after message m-1.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inactivityMessages")]
        public global::System.Collections.Generic.IList<global::G.UltravoxV1TimedMessage>? InactivityMessages { get; set; }

        /// <summary>
        /// The tools available to the agent for (the first stage of) this call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("selectedTools")]
        public global::System.Collections.Generic.IList<global::G.UltravoxV1SelectedTool>? SelectedTools { get; set; }

        /// <summary>
        /// The medium used for this call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("medium")]
        public global::G.UltravoxV1CallMedium? Medium { get; set; }

        /// <summary>
        /// Whether the call should be recorded.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recordingEnabled")]
        public bool? RecordingEnabled { get; set; }

        /// <summary>
        /// Who should talk first when the call starts. Typically set to FIRST_SPEAKER_USER for outgoing<br/>
        ///  calls and left as the default (FIRST_SPEAKER_AGENT) otherwise.<br/>
        ///  Deprecated. Prefer `firstSpeakerSettings`. If both are set, they must match.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("firstSpeaker")]
        public global::G.UltravoxV1StartCallRequestFirstSpeaker? FirstSpeaker { get; set; }

        /// <summary>
        /// Indicates whether a transcript is optional for the call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcriptOptional")]
        public bool? TranscriptOptional { get; set; }

        /// <summary>
        /// The medium to use for the call initially. May be altered by the client later.<br/>
        ///  Defaults to voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("initialOutputMedium")]
        public global::G.UltravoxV1StartCallRequestInitialOutputMedium? InitialOutputMedium { get; set; }

        /// <summary>
        /// VAD settings for the call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vadSettings")]
        public global::G.UltravoxV1VadSettings? VadSettings { get; set; }

        /// <summary>
        /// The settings for the initial message to get a conversation started.<br/>
        ///  Defaults to `agent: {}` which means the agent will start the conversation with an<br/>
        ///  (interruptible) greeting generated based on the system prompt and any initial messages.<br/>
        ///  (If first_speaker is set and this is not, first_speaker will be used instead.)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("firstSpeakerSettings")]
        public global::G.UltravoxV1FirstSpeakerSettings? FirstSpeakerSettings { get; set; }

        /// <summary>
        /// Experimental settings for the call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experimentalSettings")]
        public object? ExperimentalSettings { get; set; }

        /// <summary>
        /// Optional metadata key-value pairs to associate with the call. All values must be strings.<br/>
        ///  Keys may not start with "ultravox.", which is reserved for system-provided metadata.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// The initial state of the call stage which is readable/writable by tools.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("initialState")]
        public object? InitialState { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1StartCallRequest" /> class.
        /// </summary>
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
        public UltravoxV1StartCallRequest(
            string? systemPrompt,
            float? temperature,
            string? model,
            string? voice,
            global::G.UltravoxV1ExternalVoice? externalVoice,
            string? languageHint,
            global::System.Collections.Generic.IList<global::G.UltravoxV1Message>? initialMessages,
            string? joinTimeout,
            string? maxDuration,
            string? timeExceededMessage,
            global::System.Collections.Generic.IList<global::G.UltravoxV1TimedMessage>? inactivityMessages,
            global::System.Collections.Generic.IList<global::G.UltravoxV1SelectedTool>? selectedTools,
            global::G.UltravoxV1CallMedium? medium,
            bool? recordingEnabled,
            global::G.UltravoxV1StartCallRequestFirstSpeaker? firstSpeaker,
            bool? transcriptOptional,
            global::G.UltravoxV1StartCallRequestInitialOutputMedium? initialOutputMedium,
            global::G.UltravoxV1VadSettings? vadSettings,
            global::G.UltravoxV1FirstSpeakerSettings? firstSpeakerSettings,
            object? experimentalSettings,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            object? initialState)
        {
            this.SystemPrompt = systemPrompt;
            this.Temperature = temperature;
            this.Model = model;
            this.Voice = voice;
            this.ExternalVoice = externalVoice;
            this.LanguageHint = languageHint;
            this.InitialMessages = initialMessages;
            this.JoinTimeout = joinTimeout;
            this.MaxDuration = maxDuration;
            this.TimeExceededMessage = timeExceededMessage;
            this.InactivityMessages = inactivityMessages;
            this.SelectedTools = selectedTools;
            this.Medium = medium;
            this.RecordingEnabled = recordingEnabled;
            this.FirstSpeaker = firstSpeaker;
            this.TranscriptOptional = transcriptOptional;
            this.InitialOutputMedium = initialOutputMedium;
            this.VadSettings = vadSettings;
            this.FirstSpeakerSettings = firstSpeakerSettings;
            this.ExperimentalSettings = experimentalSettings;
            this.Metadata = metadata;
            this.InitialState = initialState;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1StartCallRequest" /> class.
        /// </summary>
        public UltravoxV1StartCallRequest()
        {
        }
    }
}