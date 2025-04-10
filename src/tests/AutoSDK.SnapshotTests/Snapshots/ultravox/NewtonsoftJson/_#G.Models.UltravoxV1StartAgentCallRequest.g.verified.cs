//HintName: G.Models.UltravoxV1StartAgentCallRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A request to start a call with an existing agent.
    /// </summary>
    public sealed partial class UltravoxV1StartAgentCallRequest
    {
        /// <summary>
        /// Context for filling any mustache templates for the call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("templateContext")]
        public object? TemplateContext { get; set; }

        /// <summary>
        /// The conversation history to start from for this call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("initialMessages")]
        public global::System.Collections.Generic.IList<global::G.UltravoxV1Message>? InitialMessages { get; set; }

        /// <summary>
        /// Optional metadata key-value pairs to associate with the call. All values must be strings.<br/>
        ///  Keys may not start with "ultravox.", which is reserved for system-provided metadata.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// The (overridden) medium used for this call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("medium")]
        public global::G.UltravoxV1CallMedium? Medium { get; set; }

        /// <summary>
        /// The (overridden) timeout for joining this call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("joinTimeout")]
        public string? JoinTimeout { get; set; }

        /// <summary>
        /// The (overridden) maximum duration of this call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxDuration")]
        public string? MaxDuration { get; set; }

        /// <summary>
        /// The (overridden) setting for whether the call should be recorded.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recordingEnabled")]
        public bool? RecordingEnabled { get; set; }

        /// <summary>
        /// The (overridden) medium initially used by the agent. May be altered by the client later.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("initialOutputMedium")]
        public global::G.UltravoxV1StartAgentCallRequestInitialOutputMedium? InitialOutputMedium { get; set; }

        /// <summary>
        /// The (overridden) settings for the initial message to get a conversation started.<br/>
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1StartAgentCallRequest" /> class.
        /// </summary>
        /// <param name="templateContext">
        /// Context for filling any mustache templates for the call.
        /// </param>
        /// <param name="initialMessages">
        /// The conversation history to start from for this call.
        /// </param>
        /// <param name="metadata">
        /// Optional metadata key-value pairs to associate with the call. All values must be strings.<br/>
        ///  Keys may not start with "ultravox.", which is reserved for system-provided metadata.
        /// </param>
        /// <param name="medium">
        /// The (overridden) medium used for this call.
        /// </param>
        /// <param name="joinTimeout">
        /// The (overridden) timeout for joining this call.
        /// </param>
        /// <param name="maxDuration">
        /// The (overridden) maximum duration of this call.
        /// </param>
        /// <param name="recordingEnabled">
        /// The (overridden) setting for whether the call should be recorded.
        /// </param>
        /// <param name="initialOutputMedium">
        /// The (overridden) medium initially used by the agent. May be altered by the client later.
        /// </param>
        /// <param name="firstSpeakerSettings">
        /// The (overridden) settings for the initial message to get a conversation started.<br/>
        ///  Defaults to `agent: {}` which means the agent will start the conversation with an<br/>
        ///  (interruptible) greeting generated based on the system prompt and any initial messages.<br/>
        ///  (If first_speaker is set and this is not, first_speaker will be used instead.)
        /// </param>
        /// <param name="experimentalSettings">
        /// Experimental settings for the call.
        /// </param>
        public UltravoxV1StartAgentCallRequest(
            object? templateContext,
            global::System.Collections.Generic.IList<global::G.UltravoxV1Message>? initialMessages,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::G.UltravoxV1CallMedium? medium,
            string? joinTimeout,
            string? maxDuration,
            bool? recordingEnabled,
            global::G.UltravoxV1StartAgentCallRequestInitialOutputMedium? initialOutputMedium,
            global::G.UltravoxV1FirstSpeakerSettings? firstSpeakerSettings,
            object? experimentalSettings)
        {
            this.TemplateContext = templateContext;
            this.InitialMessages = initialMessages;
            this.Metadata = metadata;
            this.Medium = medium;
            this.JoinTimeout = joinTimeout;
            this.MaxDuration = maxDuration;
            this.RecordingEnabled = recordingEnabled;
            this.InitialOutputMedium = initialOutputMedium;
            this.FirstSpeakerSettings = firstSpeakerSettings;
            this.ExperimentalSettings = experimentalSettings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1StartAgentCallRequest" /> class.
        /// </summary>
        public UltravoxV1StartAgentCallRequest()
        {
        }
    }
}