//HintName: G.Models.UltravoxV1CallTemplate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A CallTemplate that can be used to create Ultravox calls with shared properties.
    /// </summary>
    public sealed partial class UltravoxV1CallTemplate
    {
        /// <summary>
        /// The name of the call template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// When the call template was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// When the call template was last modified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated")]
        public global::System.DateTime? Updated { get; set; }

        /// <summary>
        /// The medium used for calls by default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("medium")]
        public global::G.UltravoxV1CallMedium? Medium { get; set; }

        /// <summary>
        /// The medium initially used for calls by default. Defaults to voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initialOutputMedium")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UltravoxV1CallTemplateInitialOutputMediumJsonConverter))]
        public global::G.UltravoxV1CallTemplateInitialOutputMedium? InitialOutputMedium { get; set; }

        /// <summary>
        /// A default timeout for joining calls. Defaults to 30 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("joinTimeout")]
        public string? JoinTimeout { get; set; }

        /// <summary>
        /// The default maximum duration of calls. Defaults to 1 hour.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxDuration")]
        public string? MaxDuration { get; set; }

        /// <summary>
        /// The default voice activity detection settings for calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vadSettings")]
        public global::G.UltravoxV1VadSettings? VadSettings { get; set; }

        /// <summary>
        /// Whether calls are recorded by default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recordingEnabled")]
        public bool? RecordingEnabled { get; set; }

        /// <summary>
        /// The default settings for the initial message to get a conversation started for calls.<br/>
        ///  Defaults to `agent: {}` which means the agent will start the conversation with an<br/>
        ///  (interruptible) greeting generated based on the system prompt and any initial messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstSpeakerSettings")]
        public global::G.UltravoxV1FirstSpeakerSettings? FirstSpeakerSettings { get; set; }

        /// <summary>
        /// The system prompt used for generations.<br/>
        ///  If multiple stages are defined for the call, this will be used only for stages without their own systemPrompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("systemPrompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// The model temperature, between 0 and 1. Defaults to 0.<br/>
        ///  If multiple stages are defined for the call, this will be used only for stages without their own temperature.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// The model used for generations. Defaults to fixie-ai/ultravox.<br/>
        ///  If multiple stages are defined for the call, this will be used only for stages without their own model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The name or ID of the voice the agent should use for this call.<br/>
        ///  If multiple stages are defined for the call, this will be used only for stages without their own voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        public string? Voice { get; set; }

        /// <summary>
        /// A BCP47 language code that may be used to guide speech recognition and synthesis.<br/>
        ///  If multiple stages are defined for the call, this will be used only for stages without their own languageHint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languageHint")]
        public string? LanguageHint { get; set; }

        /// <summary>
        /// What the agent should say immediately before hanging up if the call's time limit is reached.<br/>
        ///  If multiple stages are defined for the call, this will be used only for stages without their own timeExceededMessage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeExceededMessage")]
        public string? TimeExceededMessage { get; set; }

        /// <summary>
        /// Messages spoken by the agent when the user is inactive for the specified duration.<br/>
        ///  Durations are cumulative, so a message m &gt; 1 with duration 30s will be spoken 30 seconds after message m-1.<br/>
        ///  If multiple stages are defined for the call, this will be used only for stages without their own inactivityMessages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inactivityMessages")]
        public global::System.Collections.Generic.IList<global::G.UltravoxV1TimedMessage>? InactivityMessages { get; set; }

        /// <summary>
        /// The tools available to the agent for this call.<br/>
        ///  The following fields are treated as templates when converting to a CallTool.<br/>
        ///    * description<br/>
        ///    * static_parameters.value<br/>
        ///    * http.auth_headers.value<br/>
        ///    * http.auth_query_params.value<br/>
        ///  If multiple stages are defined for the call, this will be used only for stages without their own selectedTools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selectedTools")]
        public global::System.Collections.Generic.IList<global::G.UltravoxV1SelectedTool>? SelectedTools { get; set; }

        /// <summary>
        /// JSON schema for the variables used in string templates. If unset, a default schema will<br/>
        ///  be created from the variables used in the string templates.<br/>
        ///  Call creation requests must provide context adhering to this schema.<br/>
        ///  The follow fields are treated as templates:<br/>
        ///    * system_prompt<br/>
        ///    * language_hint<br/>
        ///    * time_exceeded_message<br/>
        ///    * inactivity_messages.message<br/>
        ///    * selected_tools.description<br/>
        ///    * selected_tools.static_parameters.value<br/>
        ///    * selected_tools.http.auth_headers.value<br/>
        ///    * selected_tools.http.auth_query_params.value<br/>
        ///  If multiple stages are defined for the call, each must define its own context schema (or use the generated one).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextSchema")]
        public object? ContextSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CallTemplate" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the call template.
        /// </param>
        /// <param name="created">
        /// When the call template was created.
        /// </param>
        /// <param name="updated">
        /// When the call template was last modified.
        /// </param>
        /// <param name="medium">
        /// The medium used for calls by default.
        /// </param>
        /// <param name="initialOutputMedium">
        /// The medium initially used for calls by default. Defaults to voice.
        /// </param>
        /// <param name="joinTimeout">
        /// A default timeout for joining calls. Defaults to 30 seconds.
        /// </param>
        /// <param name="maxDuration">
        /// The default maximum duration of calls. Defaults to 1 hour.
        /// </param>
        /// <param name="vadSettings">
        /// The default voice activity detection settings for calls.
        /// </param>
        /// <param name="recordingEnabled">
        /// Whether calls are recorded by default.
        /// </param>
        /// <param name="firstSpeakerSettings">
        /// The default settings for the initial message to get a conversation started for calls.<br/>
        ///  Defaults to `agent: {}` which means the agent will start the conversation with an<br/>
        ///  (interruptible) greeting generated based on the system prompt and any initial messages.
        /// </param>
        /// <param name="systemPrompt">
        /// The system prompt used for generations.<br/>
        ///  If multiple stages are defined for the call, this will be used only for stages without their own systemPrompt.
        /// </param>
        /// <param name="temperature">
        /// The model temperature, between 0 and 1. Defaults to 0.<br/>
        ///  If multiple stages are defined for the call, this will be used only for stages without their own temperature.
        /// </param>
        /// <param name="model">
        /// The model used for generations. Defaults to fixie-ai/ultravox.<br/>
        ///  If multiple stages are defined for the call, this will be used only for stages without their own model.
        /// </param>
        /// <param name="voice">
        /// The name or ID of the voice the agent should use for this call.<br/>
        ///  If multiple stages are defined for the call, this will be used only for stages without their own voice.
        /// </param>
        /// <param name="languageHint">
        /// A BCP47 language code that may be used to guide speech recognition and synthesis.<br/>
        ///  If multiple stages are defined for the call, this will be used only for stages without their own languageHint.
        /// </param>
        /// <param name="timeExceededMessage">
        /// What the agent should say immediately before hanging up if the call's time limit is reached.<br/>
        ///  If multiple stages are defined for the call, this will be used only for stages without their own timeExceededMessage.
        /// </param>
        /// <param name="inactivityMessages">
        /// Messages spoken by the agent when the user is inactive for the specified duration.<br/>
        ///  Durations are cumulative, so a message m &gt; 1 with duration 30s will be spoken 30 seconds after message m-1.<br/>
        ///  If multiple stages are defined for the call, this will be used only for stages without their own inactivityMessages.
        /// </param>
        /// <param name="selectedTools">
        /// The tools available to the agent for this call.<br/>
        ///  The following fields are treated as templates when converting to a CallTool.<br/>
        ///    * description<br/>
        ///    * static_parameters.value<br/>
        ///    * http.auth_headers.value<br/>
        ///    * http.auth_query_params.value<br/>
        ///  If multiple stages are defined for the call, this will be used only for stages without their own selectedTools.
        /// </param>
        /// <param name="contextSchema">
        /// JSON schema for the variables used in string templates. If unset, a default schema will<br/>
        ///  be created from the variables used in the string templates.<br/>
        ///  Call creation requests must provide context adhering to this schema.<br/>
        ///  The follow fields are treated as templates:<br/>
        ///    * system_prompt<br/>
        ///    * language_hint<br/>
        ///    * time_exceeded_message<br/>
        ///    * inactivity_messages.message<br/>
        ///    * selected_tools.description<br/>
        ///    * selected_tools.static_parameters.value<br/>
        ///    * selected_tools.http.auth_headers.value<br/>
        ///    * selected_tools.http.auth_query_params.value<br/>
        ///  If multiple stages are defined for the call, each must define its own context schema (or use the generated one).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1CallTemplate(
            string? name,
            global::System.DateTime? created,
            global::System.DateTime? updated,
            global::G.UltravoxV1CallMedium? medium,
            global::G.UltravoxV1CallTemplateInitialOutputMedium? initialOutputMedium,
            string? joinTimeout,
            string? maxDuration,
            global::G.UltravoxV1VadSettings? vadSettings,
            bool? recordingEnabled,
            global::G.UltravoxV1FirstSpeakerSettings? firstSpeakerSettings,
            string? systemPrompt,
            float? temperature,
            string? model,
            string? voice,
            string? languageHint,
            string? timeExceededMessage,
            global::System.Collections.Generic.IList<global::G.UltravoxV1TimedMessage>? inactivityMessages,
            global::System.Collections.Generic.IList<global::G.UltravoxV1SelectedTool>? selectedTools,
            object? contextSchema)
        {
            this.Name = name;
            this.Created = created;
            this.Updated = updated;
            this.Medium = medium;
            this.InitialOutputMedium = initialOutputMedium;
            this.JoinTimeout = joinTimeout;
            this.MaxDuration = maxDuration;
            this.VadSettings = vadSettings;
            this.RecordingEnabled = recordingEnabled;
            this.FirstSpeakerSettings = firstSpeakerSettings;
            this.SystemPrompt = systemPrompt;
            this.Temperature = temperature;
            this.Model = model;
            this.Voice = voice;
            this.LanguageHint = languageHint;
            this.TimeExceededMessage = timeExceededMessage;
            this.InactivityMessages = inactivityMessages;
            this.SelectedTools = selectedTools;
            this.ContextSchema = contextSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CallTemplate" /> class.
        /// </summary>
        public UltravoxV1CallTemplate()
        {
        }
    }
}