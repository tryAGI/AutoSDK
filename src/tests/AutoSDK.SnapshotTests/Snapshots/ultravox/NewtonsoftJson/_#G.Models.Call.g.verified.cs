//HintName: G.Models.Call.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Call
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("callId")]
        public global::System.Guid CallId { get; set; } = default!;

        /// <summary>
        /// The version of the client that joined this call.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("clientVersion")]
        public string? ClientVersion { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("created")]
        public global::System.DateTime Created { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("joined")]
        public global::System.DateTime? Joined { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ended")]
        public global::System.DateTime? Ended { get; set; }

        /// <summary>
        /// The reason the call ended.<br/>
        /// * `unjoined` - Client never joined<br/>
        /// * `hangup` - Client hung up<br/>
        /// * `agent_hangup` - Agent hung up<br/>
        /// * `timeout` - Call timed out<br/>
        /// * `connection_error` - Connection error<br/>
        /// * `system_error` - System error<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endReason")]
        public global::G.OneOf<global::G.EndReasonEnum?, global::G.NullEnum?>? EndReason { get; set; }

        /// <summary>
        /// Who was supposed to talk first when the call started. Typically set to FIRST_SPEAKER_USER for outgoing calls and left as the default (FIRST_SPEAKER_AGENT) otherwise.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("firstSpeaker")]
        public global::G.FirstSpeakerEnum FirstSpeaker { get; set; } = default!;

        /// <summary>
        /// Settings for the initial message to get the call started.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("firstSpeakerSettings", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UltravoxV1FirstSpeakerSettings FirstSpeakerSettings { get; set; } = default!;

        /// <summary>
        /// Messages spoken by the agent when the user is inactive for the specified duration. Durations are cumulative, so a message m &gt; 1 with duration 30s will be spoken 30 seconds after message m-1.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inactivityMessages")]
        public global::System.Collections.Generic.IList<global::G.UltravoxV1TimedMessage>? InactivityMessages { get; set; }

        /// <summary>
        /// The medium used initially by the agent. May later be changed by the client.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("initialOutputMedium")]
        public global::G.InitialOutputMediumEnum InitialOutputMedium { get; set; } = default!;

        /// <summary>
        /// Default Value: 30s
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("joinTimeout")]
        public string? JoinTimeout { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("joinUrl")]
        public string? JoinUrl { get; set; }

        /// <summary>
        /// BCP47 language code that may be used to guide speech recognition.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("languageHint")]
        public string? LanguageHint { get; set; }

        /// <summary>
        /// Default Value: 3600s
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxDuration")]
        public string? MaxDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("medium")]
        public global::G.UltravoxV1CallMedium? Medium { get; set; }

        /// <summary>
        /// Default Value: fixie-ai/ultravox
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recordingEnabled")]
        public bool? RecordingEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("systemPrompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeExceededMessage")]
        public string? TimeExceededMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice")]
        public string? Voice { get; set; }

        /// <summary>
        /// A voice not known to Ultravox Realtime that can nonetheless be used for a call.<br/>
        ///  Such voices are significantly less validated than normal voices and you'll be<br/>
        ///  responsible for your own TTS-related errors.<br/>
        ///  Exactly one field must be set.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("externalVoice")]
        public global::G.UltravoxV1ExternalVoice? ExternalVoice { get; set; }

        /// <summary>
        /// Indicates whether a transcript is optional for the call.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcriptOptional")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? TranscriptOptional { get; set; }

        /// <summary>
        /// The number of errors in this call.<br/>
        /// Default Value: 0<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("errorCount")]
        public int ErrorCount { get; set; } = default!;

        /// <summary>
        /// VAD settings for the call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vadSettings")]
        public global::G.UltravoxV1VadSettings? VadSettings { get; set; }

        /// <summary>
        /// A short summary of the call.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shortSummary")]
        public string? ShortSummary { get; set; }

        /// <summary>
        /// A summary of the call.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Experimental settings for the call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experimentalSettings", Required = global::Newtonsoft.Json.Required.Always)]
        public object ExperimentalSettings { get; set; } = default!;

        /// <summary>
        /// Optional metadata key-value pairs to associate with the call. All values must be strings.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string> Metadata { get; set; } = default!;

        /// <summary>
        /// The initial state of the call which is readable/writable by tools.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("initialState", Required = global::Newtonsoft.Json.Required.Always)]
        public object InitialState { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requestContext", Required = global::Newtonsoft.Json.Required.Always)]
        public object RequestContext { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Call" /> class.
        /// </summary>
        /// <param name="callId">
        /// Included only in responses
        /// </param>
        /// <param name="clientVersion">
        /// The version of the client that joined this call.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="created">
        /// Included only in responses
        /// </param>
        /// <param name="joined">
        /// Included only in responses
        /// </param>
        /// <param name="ended">
        /// Included only in responses
        /// </param>
        /// <param name="endReason">
        /// The reason the call ended.<br/>
        /// * `unjoined` - Client never joined<br/>
        /// * `hangup` - Client hung up<br/>
        /// * `agent_hangup` - Agent hung up<br/>
        /// * `timeout` - Call timed out<br/>
        /// * `connection_error` - Connection error<br/>
        /// * `system_error` - System error<br/>
        /// Included only in responses
        /// </param>
        /// <param name="firstSpeakerSettings">
        /// Settings for the initial message to get the call started.
        /// </param>
        /// <param name="inactivityMessages">
        /// Messages spoken by the agent when the user is inactive for the specified duration. Durations are cumulative, so a message m &gt; 1 with duration 30s will be spoken 30 seconds after message m-1.
        /// </param>
        /// <param name="initialOutputMedium">
        /// The medium used initially by the agent. May later be changed by the client.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="joinTimeout">
        /// Default Value: 30s
        /// </param>
        /// <param name="joinUrl">
        /// Included only in responses
        /// </param>
        /// <param name="languageHint">
        /// BCP47 language code that may be used to guide speech recognition.
        /// </param>
        /// <param name="maxDuration">
        /// Default Value: 3600s
        /// </param>
        /// <param name="medium"></param>
        /// <param name="model">
        /// Default Value: fixie-ai/ultravox
        /// </param>
        /// <param name="recordingEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="systemPrompt"></param>
        /// <param name="temperature">
        /// Default Value: 0
        /// </param>
        /// <param name="timeExceededMessage"></param>
        /// <param name="voice"></param>
        /// <param name="externalVoice">
        /// A voice not known to Ultravox Realtime that can nonetheless be used for a call.<br/>
        ///  Such voices are significantly less validated than normal voices and you'll be<br/>
        ///  responsible for your own TTS-related errors.<br/>
        ///  Exactly one field must be set.
        /// </param>
        /// <param name="errorCount">
        /// The number of errors in this call.<br/>
        /// Default Value: 0<br/>
        /// Included only in responses
        /// </param>
        /// <param name="vadSettings">
        /// VAD settings for the call.
        /// </param>
        /// <param name="shortSummary">
        /// A short summary of the call.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="summary">
        /// A summary of the call.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="experimentalSettings">
        /// Experimental settings for the call.
        /// </param>
        /// <param name="metadata">
        /// Optional metadata key-value pairs to associate with the call. All values must be strings.
        /// </param>
        /// <param name="initialState">
        /// The initial state of the call which is readable/writable by tools.
        /// </param>
        /// <param name="requestContext"></param>
        public Call(
            global::G.UltravoxV1FirstSpeakerSettings firstSpeakerSettings,
            object experimentalSettings,
            global::System.Collections.Generic.Dictionary<string, string> metadata,
            object initialState,
            object requestContext,
            string? clientVersion,
            global::System.DateTime? joined,
            global::System.DateTime? ended,
            global::G.OneOf<global::G.EndReasonEnum?, global::G.NullEnum?>? endReason,
            global::System.Collections.Generic.IList<global::G.UltravoxV1TimedMessage>? inactivityMessages,
            string? joinTimeout,
            string? joinUrl,
            string? languageHint,
            string? maxDuration,
            global::G.UltravoxV1CallMedium? medium,
            string? model,
            bool? recordingEnabled,
            string? systemPrompt,
            double? temperature,
            string? timeExceededMessage,
            string? voice,
            global::G.UltravoxV1ExternalVoice? externalVoice,
            global::G.UltravoxV1VadSettings? vadSettings,
            string? shortSummary,
            string? summary,
            global::System.Guid callId = default!,
            global::System.DateTime created = default!,
            global::G.InitialOutputMediumEnum initialOutputMedium = default!,
            int errorCount = default!)
        {
            this.FirstSpeakerSettings = firstSpeakerSettings ?? throw new global::System.ArgumentNullException(nameof(firstSpeakerSettings));
            this.ExperimentalSettings = experimentalSettings ?? throw new global::System.ArgumentNullException(nameof(experimentalSettings));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.InitialState = initialState ?? throw new global::System.ArgumentNullException(nameof(initialState));
            this.RequestContext = requestContext ?? throw new global::System.ArgumentNullException(nameof(requestContext));
            this.CallId = callId;
            this.ClientVersion = clientVersion;
            this.Created = created;
            this.Joined = joined;
            this.Ended = ended;
            this.EndReason = endReason;
            this.InactivityMessages = inactivityMessages;
            this.InitialOutputMedium = initialOutputMedium;
            this.JoinTimeout = joinTimeout;
            this.JoinUrl = joinUrl;
            this.LanguageHint = languageHint;
            this.MaxDuration = maxDuration;
            this.Medium = medium;
            this.Model = model;
            this.RecordingEnabled = recordingEnabled;
            this.SystemPrompt = systemPrompt;
            this.Temperature = temperature;
            this.TimeExceededMessage = timeExceededMessage;
            this.Voice = voice;
            this.ExternalVoice = externalVoice;
            this.ErrorCount = errorCount;
            this.VadSettings = vadSettings;
            this.ShortSummary = shortSummary;
            this.Summary = summary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Call" /> class.
        /// </summary>
        public Call()
        {
        }
    }
}