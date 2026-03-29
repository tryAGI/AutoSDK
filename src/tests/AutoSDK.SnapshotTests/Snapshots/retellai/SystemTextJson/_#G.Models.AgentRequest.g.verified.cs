//HintName: G.Models.AgentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_engine")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseEngineJsonConverter))]
        public global::G.ResponseEngine? ResponseEngine { get; set; }

        /// <summary>
        /// The name of the agent. Only used for your own reference.<br/>
        /// Example: Jarvis
        /// </summary>
        /// <example>Jarvis</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_name")]
        public string? AgentName { get; set; }

        /// <summary>
        /// Optional description of the agent version. Used for your own reference and documentation.<br/>
        /// Example: Customer support agent for handling product inquiries
        /// </summary>
        /// <example>Customer support agent for handling product inquiries</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_description")]
        public string? VersionDescription { get; set; }

        /// <summary>
        /// Unique voice id used for the agent. Find list of available voices and their preview in Dashboard.<br/>
        /// Example: retell-Cimo
        /// </summary>
        /// <example>retell-Cimo</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Select the voice model used for the selected voice. Each provider has a set of available voice models. Set to null to remove voice model selection, and default ones will apply. Check out dashboard for more details of each voice model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentRequestVoiceModelJsonConverter))]
        public global::G.AgentRequestVoiceModel? VoiceModel { get; set; }

        /// <summary>
        /// When TTS provider for the selected voice is experiencing outages, we would use fallback voices listed here for the agent. Voice id and the fallback voice ids must be from different TTS providers. The system would go through the list in order, if the first one in the list is also having outage, it would use the next one. Set to null to remove voice fallback for the agent.<br/>
        /// Example: [cartesia-Cimo, minimax-Cimo]
        /// </summary>
        /// <example>[cartesia-Cimo, minimax-Cimo]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback_voice_ids")]
        public global::System.Collections.Generic.IList<string>? FallbackVoiceIds { get; set; }

        /// <summary>
        /// Controls how stable the voice is. Value ranging from [0,2]. Lower value means more stable, and higher value means more variant speech generation. Check the dashboard to see what provider supports this feature. If unset, default value 1 will apply.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_temperature")]
        public double? VoiceTemperature { get; set; }

        /// <summary>
        /// Controls speed of voice. Value ranging from [0.5,2]. Lower value means slower speech, while higher value means faster speech rate. If unset, default value 1 will apply.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_speed")]
        public double? VoiceSpeed { get; set; }

        /// <summary>
        /// If set to true, will enable dynamic voice speed adjustment based on the user's speech rate and conversation context. If unset, default value false will apply.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_dynamic_voice_speed")]
        public bool? EnableDynamicVoiceSpeed { get; set; }

        /// <summary>
        /// If set to true, the agent will dynamically adjust how quickly it responds based on the user's speech rate and past turn-taking behavior in the call. If unset, default value false will apply.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_dynamic_responsiveness")]
        public bool? EnableDynamicResponsiveness { get; set; }

        /// <summary>
        /// If set, will control the volume of the agent. Value ranging from [0,2]. Lower value means quieter agent speech, while higher value means louder agent speech. If unset, default value 1 will apply.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume")]
        public double? Volume { get; set; }

        /// <summary>
        /// Controls the emotional tone of the agent's voice. Currently supported for Cartesia and Minimax TTS providers. If unset, no emotion will be used.<br/>
        /// Example: calm
        /// </summary>
        /// <example>calm</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_emotion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentRequestVoiceEmotionJsonConverter))]
        public global::G.AgentRequestVoiceEmotion? VoiceEmotion { get; set; }

        /// <summary>
        /// Controls how responsive is the agent. Value ranging from [0,1]. Lower value means less responsive agent (wait more, respond slower), while higher value means faster exchanges (respond when it can). If unset, default value 1 will apply.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("responsiveness")]
        public double? Responsiveness { get; set; }

        /// <summary>
        /// Controls how sensitive the agent is to user interruptions. Value ranging from [0,1]. Lower value means it will take longer / more words for user to interrupt agent, while higher value means it's easier for user to interrupt agent. If unset, default value 1 will apply. When this is set to 0, agent would never be interrupted.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("interruption_sensitivity")]
        public double? InterruptionSensitivity { get; set; }

        /// <summary>
        /// Controls whether the agent would backchannel (agent interjects the speaker with phrases like "yeah", "uh-huh" to signify interest and engagement). Backchannel when enabled tends to show up more in longer user utterances. If not set, agent will not backchannel.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_backchannel")]
        public bool? EnableBackchannel { get; set; }

        /// <summary>
        /// Only applicable when enable_backchannel is true. Controls how often the agent would backchannel when a backchannel is possible. Value ranging from [0,1]. Lower value means less frequent backchannel, while higher value means more frequent backchannel. If unset, default value 0.8 will apply.<br/>
        /// Example: 0.9
        /// </summary>
        /// <example>0.9</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("backchannel_frequency")]
        public double? BackchannelFrequency { get; set; }

        /// <summary>
        /// Only applicable when enable_backchannel is true. A list of words that the agent would use as backchannel. If not set, default backchannel words will apply. Check out [backchannel default words](/agent/interaction-configuration#backchannel) for more details. Note that certain voices do not work too well with certain words, so it's recommended to experiment before adding any words.<br/>
        /// Example: [yeah, uh-huh]
        /// </summary>
        /// <example>[yeah, uh-huh]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("backchannel_words")]
        public global::System.Collections.Generic.IList<string>? BackchannelWords { get; set; }

        /// <summary>
        /// If set (in milliseconds), will trigger a reminder to the agent to speak if the user has been silent for the specified duration after some agent speech. Must be a positive number. If unset, default value of 10000 ms (10 s) will apply.<br/>
        /// Example: 10000
        /// </summary>
        /// <example>10000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reminder_trigger_ms")]
        public double? ReminderTriggerMs { get; set; }

        /// <summary>
        /// If set, controls how many times agent would remind user when user is unresponsive. Must be a non negative integer. If unset, default value of 1 will apply (remind once). Set to 0 to disable agent from reminding.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reminder_max_count")]
        public int? ReminderMaxCount { get; set; }

        /// <summary>
        /// If set, will add ambient environment sound to the call to make experience more realistic. Currently supports the following options:<br/>
        /// - `coffee-shop`: Coffee shop ambience with people chatting in background. [Listen to Ambience](https://retell-utils-public.s3.us-west-2.amazonaws.com/coffee-shop.wav)<br/>
        /// - `convention-hall`: Convention hall ambience, with some echo and people chatting in background. [Listen to Ambience](https://retell-utils-public.s3.us-west-2.amazonaws.com/convention-hall.wav)<br/>
        /// - `summer-outdoor`: Summer outdoor ambience with cicada chirping. [Listen to Ambience](https://retell-utils-public.s3.us-west-2.amazonaws.com/summer-outdoor.wav)<br/>
        /// - `mountain-outdoor`: Mountain outdoor ambience with birds singing. [Listen to Ambience](https://retell-utils-public.s3.us-west-2.amazonaws.com/mountain-outdoor.wav)<br/>
        /// - `static-noise`: Constant static noise. [Listen to Ambience](https://retell-utils-public.s3.us-west-2.amazonaws.com/static-noise.wav)<br/>
        /// - `call-center`: Call center work noise. [Listen to Ambience](https://retell-utils-public.s3.us-west-2.amazonaws.com/call-center.wav)<br/>
        /// Set to `null` to remove ambient sound from this agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ambient_sound")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentRequestAmbientSoundJsonConverter))]
        public global::G.AgentRequestAmbientSound? AmbientSound { get; set; }

        /// <summary>
        /// If set, will control the volume of the ambient sound. Value ranging from [0,2]. Lower value means quieter ambient sound, while higher value means louder ambient sound. If unset, default value 1 will apply.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ambient_sound_volume")]
        public double? AmbientSoundVolume { get; set; }

        /// <summary>
        /// Specifies what language (and dialect) the speech recognition will operate in. For instance, selecting `en-GB` optimizes speech recognition for British English. If unset, will use default value `en-US`. Select `multi` for multilingual support.<br/>
        /// Example: en-US
        /// </summary>
        /// <example>en-US</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentRequestLanguageJsonConverter))]
        public global::G.AgentRequestLanguage? Language { get; set; }

        /// <summary>
        /// The webhook for agent to listen to call events. See what events it would get at [webhook doc](/features/webhook). If set, will binds webhook events for this agent to the specified url, and will ignore the account level webhook for this agent. Set to `null` to remove webhook url from this agent.<br/>
        /// Example: https://webhook-url-here
        /// </summary>
        /// <example>https://webhook-url-here</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Which webhook events this agent should receive. If not set, defaults to call_started, call_ended, call_analyzed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_events")]
        public global::System.Collections.Generic.IList<global::G.AgentRequestWebhookEvent>? WebhookEvents { get; set; }

        /// <summary>
        /// The timeout for the webhook in milliseconds. If not set, default value of 10000 will apply.<br/>
        /// Example: 10000
        /// </summary>
        /// <example>10000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_timeout_ms")]
        public int? WebhookTimeoutMs { get; set; }

        /// <summary>
        /// Provide a customized list of keywords to bias the transcriber model, so that these words are more likely to get transcribed. Commonly used for names, brands, street, etc.<br/>
        /// Example: [retell, kroger]
        /// </summary>
        /// <example>[retell, kroger]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("boosted_keywords")]
        public global::System.Collections.Generic.IList<string>? BoostedKeywords { get; set; }

        /// <summary>
        /// Granular setting to manage how Retell stores sensitive data (transcripts, recordings, logs, etc.).<br/>
        /// This replaces the deprecated `opt_out_sensitive_data_storage` field.<br/>
        /// - `everything`: Store all data including transcripts, recordings, and logs.<br/>
        /// - `everything_except_pii`: Store data without PII when PII is detected.<br/>
        /// - `basic_attributes_only`: Store only basic attributes; no transcripts/recordings/logs.<br/>
        /// If not set, default value of "everything" will apply.<br/>
        /// Example: everything
        /// </summary>
        /// <example>everything</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_storage_setting")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentRequestDataStorageSettingJsonConverter))]
        public global::G.AgentRequestDataStorageSetting? DataStorageSetting { get; set; }

        /// <summary>
        /// Number of days to retain call/chat data before automatic deletion. Must be between 1 and 730 days. If not set, data is retained forever (no automatic deletion).<br/>
        /// Example: 30
        /// </summary>
        /// <example>30</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_storage_retention_days")]
        public int? DataStorageRetentionDays { get; set; }

        /// <summary>
        /// Whether this agent opts in for signed URLs for public logs and recordings. When enabled, the generated URLs will include security signatures that restrict access and automatically expire after 24 hours.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("opt_in_signed_url")]
        public bool? OptInSignedUrl { get; set; }

        /// <summary>
        /// The expiration time for the signed url in milliseconds. Only applicable when opt_in_signed_url is true. If not set, default value of 86400000 (24 hours) will apply.<br/>
        /// Example: 86400000
        /// </summary>
        /// <example>86400000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("signed_url_expiration_ms")]
        public int? SignedUrlExpirationMs { get; set; }

        /// <summary>
        /// A list of words / phrases and their pronunciation to be used to guide the audio synthesize for consistent pronunciation. Check the dashboard to see what provider supports this feature. Set to null to remove pronunciation dictionary from this agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciation_dictionary")]
        public global::System.Collections.Generic.IList<global::G.AgentRequestPronunciationDictionaryItem>? PronunciationDictionary { get; set; }

        /// <summary>
        /// If set to true, will normalize the some part of text (number, currency, date, etc) to spoken to its spoken form for more consistent speech synthesis (sometimes the voice synthesize system itself might read these wrong with the raw text). For example, it will convert "Call my number 2137112342 on Jul 5th, 2024 for the $24.12 payment" to "Call my number two one three seven one one two three four two on july fifth, twenty twenty four for the twenty four dollars twelve cents payment" before starting audio generation.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalize_for_speech")]
        public bool? NormalizeForSpeech { get; set; }

        /// <summary>
        /// If users stay silent for a period after agent speech, end the call. The minimum value allowed is 10,000 ms (10 s). By default, this is set to 600000 (10 min).<br/>
        /// Example: 600000
        /// </summary>
        /// <example>600000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_call_after_silence_ms")]
        public int? EndCallAfterSilenceMs { get; set; }

        /// <summary>
        /// Maximum allowed length for the call, will force end the call if reached. The minimum value allowed is 60,000 ms (1 min), and maximum value allowed is 7,200,000 (2 hours). By default, this is set to 3,600,000 (1 hour).<br/>
        /// Example: 3600000
        /// </summary>
        /// <example>3600000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_call_duration_ms")]
        public int? MaxCallDurationMs { get; set; }

        /// <summary>
        /// The message to be played when the call enters a voicemail. Note that this feature is only available for phone calls. If you want to hangup after hitting voicemail, set this to empty string.<br/>
        /// Example: Hi, please give us a callback.
        /// </summary>
        /// <example>Hi, please give us a callback.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voicemail_message")]
        public string? VoicemailMessage { get; set; }

        /// <summary>
        /// Configures when to stop running voicemail detection, as it becomes unlikely to hit voicemail after a couple minutes, and keep running it will only have negative impact. The minimum value allowed is 5,000 ms (5 s), and maximum value allowed is 180,000 (3 minutes). By default, this is set to 30,000 (30 s).<br/>
        /// Example: 30000
        /// </summary>
        /// <example>30000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voicemail_detection_timeout_ms")]
        public int? VoicemailDetectionTimeoutMs { get; set; }

        /// <summary>
        /// If this option is set, the call will try to detect voicemail in the first 3 minutes of the call. Actions defined (hangup, or leave a message) will be applied when the voicemail is detected. Set this to null to disable voicemail detection.<br/>
        /// Example: {"action":{"type":"static_text","text":"Please give us a callback tomorrow at 10am."}}
        /// </summary>
        /// <example>{"action":{"type":"static_text","text":"Please give us a callback tomorrow at 10am."}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voicemail_option")]
        public global::G.AgentRequestVoicemailOption? VoicemailOption { get; set; }

        /// <summary>
        /// If this option is set, the call will try to detect IVR in the first 3 minutes of the call. Actions defined will be applied when the IVR is detected. Set this to null to disable IVR detection.<br/>
        /// Example: {"action":{"type":"hangup"}}
        /// </summary>
        /// <example>{"action":{"type":"hangup"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ivr_option")]
        public global::G.AgentRequestIvrOption? IvrOption { get; set; }

        /// <summary>
        /// Post call analysis data to extract from the call. This data will augment the pre-defined variables extracted in the call analysis. This will be available after the call ends.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("post_call_analysis_data")]
        public global::System.Collections.Generic.IList<global::G.AnalysisData>? PostCallAnalysisData { get; set; }

        /// <summary>
        /// Available LLM models for agents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("post_call_analysis_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.NullableLLMModelJsonConverter))]
        public global::G.NullableLLMModel? PostCallAnalysisModel { get; set; }

        /// <summary>
        /// Prompt to determine whether the post call or chat analysis should mark the interaction as successful. Set to null to use the default prompt.<br/>
        /// Example: The agent finished the task and the call was complete without being cutoff.
        /// </summary>
        /// <example>The agent finished the task and the call was complete without being cutoff.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis_successful_prompt")]
        public string? AnalysisSuccessfulPrompt { get; set; }

        /// <summary>
        /// Prompt to guide how the post call or chat analysis summary should be generated. When unset, the default system prompt is used. Set to null to use the default prompt.<br/>
        /// Example: Summarize the outcome of the conversation in two sentences.
        /// </summary>
        /// <example>Summarize the outcome of the conversation in two sentences.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis_summary_prompt")]
        public string? AnalysisSummaryPrompt { get; set; }

        /// <summary>
        /// Prompt to guide how the post call or chat analysis should evaluate user sentiment. When unset, the default system prompt is used. Set to null to use the default prompt.<br/>
        /// Example: Evaluate the user's sentiment based on their tone and satisfaction level.
        /// </summary>
        /// <example>Evaluate the user's sentiment based on their tone and satisfaction level.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis_user_sentiment_prompt")]
        public string? AnalysisUserSentimentPrompt { get; set; }

        /// <summary>
        /// If set, will delay the first message by the specified amount of milliseconds, so that it gives user more time to prepare to take the call. Valid range is [0, 5000]. If not set or set to 0, agent will speak immediately. Only applicable when agent speaks first.<br/>
        /// Example: 1000
        /// </summary>
        /// <example>1000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("begin_message_delay_ms")]
        public int? BeginMessageDelayMs { get; set; }

        /// <summary>
        /// If set, the phone ringing will last for the specified amount of milliseconds. This applies for both outbound call ringtime, and call transfer ringtime. Default to 30000 (30 s). Valid range is [5000, 300000].<br/>
        /// Example: 30000
        /// </summary>
        /// <example>30000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ring_duration_ms")]
        public int? RingDurationMs { get; set; }

        /// <summary>
        /// If set, determines whether speech to text should focus on latency or accuracy. Default to fast mode. When set to custom, custom_stt_config must be provided.<br/>
        /// Example: fast
        /// </summary>
        /// <example>fast</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("stt_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentRequestSttModeJsonConverter))]
        public global::G.AgentRequestSttMode? SttMode { get; set; }

        /// <summary>
        /// Custom STT configuration. Only used when stt_mode is set to custom.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_stt_config")]
        public global::G.AgentRequestCustomSttConfig? CustomSttConfig { get; set; }

        /// <summary>
        /// If set, determines the vocabulary set to use for transcription. This setting only applies for English agents, for non English agent, this setting is a no-op. Default to general.<br/>
        /// Example: general
        /// </summary>
        /// <example>general</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("vocab_specialization")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentRequestVocabSpecializationJsonConverter))]
        public global::G.AgentRequestVocabSpecialization? VocabSpecialization { get; set; }

        /// <summary>
        /// If set to true, DTMF input will be accepted and processed. If false, any DTMF input will be ignored. Default to true.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_user_dtmf")]
        public bool? AllowUserDtmf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_dtmf_options")]
        public global::G.AgentRequestUserDtmfOptions? UserDtmfOptions { get; set; }

        /// <summary>
        /// If set, determines what denoising mode to use. Use "no-denoise" to bypass all audio denoising. Default to noise-cancellation.<br/>
        /// Example: noise-cancellation
        /// </summary>
        /// <example>noise-cancellation</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("denoising_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentRequestDenoisingModeJsonConverter))]
        public global::G.AgentRequestDenoisingMode? DenoisingMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pii_config")]
        public global::G.PIIConfig? PiiConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrail_config")]
        public global::G.GuardrailConfig? GuardrailConfig { get; set; }

        /// <summary>
        /// Whether the agent is public. When set to true, the agent is available for public agent preview link.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_public")]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRequest" /> class.
        /// </summary>
        /// <param name="responseEngine"></param>
        /// <param name="agentName">
        /// The name of the agent. Only used for your own reference.<br/>
        /// Example: Jarvis
        /// </param>
        /// <param name="versionDescription">
        /// Optional description of the agent version. Used for your own reference and documentation.<br/>
        /// Example: Customer support agent for handling product inquiries
        /// </param>
        /// <param name="voiceId">
        /// Unique voice id used for the agent. Find list of available voices and their preview in Dashboard.<br/>
        /// Example: retell-Cimo
        /// </param>
        /// <param name="voiceModel">
        /// Select the voice model used for the selected voice. Each provider has a set of available voice models. Set to null to remove voice model selection, and default ones will apply. Check out dashboard for more details of each voice model.
        /// </param>
        /// <param name="fallbackVoiceIds">
        /// When TTS provider for the selected voice is experiencing outages, we would use fallback voices listed here for the agent. Voice id and the fallback voice ids must be from different TTS providers. The system would go through the list in order, if the first one in the list is also having outage, it would use the next one. Set to null to remove voice fallback for the agent.<br/>
        /// Example: [cartesia-Cimo, minimax-Cimo]
        /// </param>
        /// <param name="voiceTemperature">
        /// Controls how stable the voice is. Value ranging from [0,2]. Lower value means more stable, and higher value means more variant speech generation. Check the dashboard to see what provider supports this feature. If unset, default value 1 will apply.<br/>
        /// Example: 1
        /// </param>
        /// <param name="voiceSpeed">
        /// Controls speed of voice. Value ranging from [0.5,2]. Lower value means slower speech, while higher value means faster speech rate. If unset, default value 1 will apply.<br/>
        /// Example: 1
        /// </param>
        /// <param name="enableDynamicVoiceSpeed">
        /// If set to true, will enable dynamic voice speed adjustment based on the user's speech rate and conversation context. If unset, default value false will apply.<br/>
        /// Example: true
        /// </param>
        /// <param name="enableDynamicResponsiveness">
        /// If set to true, the agent will dynamically adjust how quickly it responds based on the user's speech rate and past turn-taking behavior in the call. If unset, default value false will apply.<br/>
        /// Example: true
        /// </param>
        /// <param name="volume">
        /// If set, will control the volume of the agent. Value ranging from [0,2]. Lower value means quieter agent speech, while higher value means louder agent speech. If unset, default value 1 will apply.<br/>
        /// Example: 1
        /// </param>
        /// <param name="voiceEmotion">
        /// Controls the emotional tone of the agent's voice. Currently supported for Cartesia and Minimax TTS providers. If unset, no emotion will be used.<br/>
        /// Example: calm
        /// </param>
        /// <param name="responsiveness">
        /// Controls how responsive is the agent. Value ranging from [0,1]. Lower value means less responsive agent (wait more, respond slower), while higher value means faster exchanges (respond when it can). If unset, default value 1 will apply.<br/>
        /// Example: 1
        /// </param>
        /// <param name="interruptionSensitivity">
        /// Controls how sensitive the agent is to user interruptions. Value ranging from [0,1]. Lower value means it will take longer / more words for user to interrupt agent, while higher value means it's easier for user to interrupt agent. If unset, default value 1 will apply. When this is set to 0, agent would never be interrupted.<br/>
        /// Example: 1
        /// </param>
        /// <param name="enableBackchannel">
        /// Controls whether the agent would backchannel (agent interjects the speaker with phrases like "yeah", "uh-huh" to signify interest and engagement). Backchannel when enabled tends to show up more in longer user utterances. If not set, agent will not backchannel.<br/>
        /// Example: true
        /// </param>
        /// <param name="backchannelFrequency">
        /// Only applicable when enable_backchannel is true. Controls how often the agent would backchannel when a backchannel is possible. Value ranging from [0,1]. Lower value means less frequent backchannel, while higher value means more frequent backchannel. If unset, default value 0.8 will apply.<br/>
        /// Example: 0.9
        /// </param>
        /// <param name="backchannelWords">
        /// Only applicable when enable_backchannel is true. A list of words that the agent would use as backchannel. If not set, default backchannel words will apply. Check out [backchannel default words](/agent/interaction-configuration#backchannel) for more details. Note that certain voices do not work too well with certain words, so it's recommended to experiment before adding any words.<br/>
        /// Example: [yeah, uh-huh]
        /// </param>
        /// <param name="reminderTriggerMs">
        /// If set (in milliseconds), will trigger a reminder to the agent to speak if the user has been silent for the specified duration after some agent speech. Must be a positive number. If unset, default value of 10000 ms (10 s) will apply.<br/>
        /// Example: 10000
        /// </param>
        /// <param name="reminderMaxCount">
        /// If set, controls how many times agent would remind user when user is unresponsive. Must be a non negative integer. If unset, default value of 1 will apply (remind once). Set to 0 to disable agent from reminding.<br/>
        /// Example: 2
        /// </param>
        /// <param name="ambientSound">
        /// If set, will add ambient environment sound to the call to make experience more realistic. Currently supports the following options:<br/>
        /// - `coffee-shop`: Coffee shop ambience with people chatting in background. [Listen to Ambience](https://retell-utils-public.s3.us-west-2.amazonaws.com/coffee-shop.wav)<br/>
        /// - `convention-hall`: Convention hall ambience, with some echo and people chatting in background. [Listen to Ambience](https://retell-utils-public.s3.us-west-2.amazonaws.com/convention-hall.wav)<br/>
        /// - `summer-outdoor`: Summer outdoor ambience with cicada chirping. [Listen to Ambience](https://retell-utils-public.s3.us-west-2.amazonaws.com/summer-outdoor.wav)<br/>
        /// - `mountain-outdoor`: Mountain outdoor ambience with birds singing. [Listen to Ambience](https://retell-utils-public.s3.us-west-2.amazonaws.com/mountain-outdoor.wav)<br/>
        /// - `static-noise`: Constant static noise. [Listen to Ambience](https://retell-utils-public.s3.us-west-2.amazonaws.com/static-noise.wav)<br/>
        /// - `call-center`: Call center work noise. [Listen to Ambience](https://retell-utils-public.s3.us-west-2.amazonaws.com/call-center.wav)<br/>
        /// Set to `null` to remove ambient sound from this agent.
        /// </param>
        /// <param name="ambientSoundVolume">
        /// If set, will control the volume of the ambient sound. Value ranging from [0,2]. Lower value means quieter ambient sound, while higher value means louder ambient sound. If unset, default value 1 will apply.<br/>
        /// Example: 1
        /// </param>
        /// <param name="language">
        /// Specifies what language (and dialect) the speech recognition will operate in. For instance, selecting `en-GB` optimizes speech recognition for British English. If unset, will use default value `en-US`. Select `multi` for multilingual support.<br/>
        /// Example: en-US
        /// </param>
        /// <param name="webhookUrl">
        /// The webhook for agent to listen to call events. See what events it would get at [webhook doc](/features/webhook). If set, will binds webhook events for this agent to the specified url, and will ignore the account level webhook for this agent. Set to `null` to remove webhook url from this agent.<br/>
        /// Example: https://webhook-url-here
        /// </param>
        /// <param name="webhookEvents">
        /// Which webhook events this agent should receive. If not set, defaults to call_started, call_ended, call_analyzed.
        /// </param>
        /// <param name="webhookTimeoutMs">
        /// The timeout for the webhook in milliseconds. If not set, default value of 10000 will apply.<br/>
        /// Example: 10000
        /// </param>
        /// <param name="boostedKeywords">
        /// Provide a customized list of keywords to bias the transcriber model, so that these words are more likely to get transcribed. Commonly used for names, brands, street, etc.<br/>
        /// Example: [retell, kroger]
        /// </param>
        /// <param name="dataStorageSetting">
        /// Granular setting to manage how Retell stores sensitive data (transcripts, recordings, logs, etc.).<br/>
        /// This replaces the deprecated `opt_out_sensitive_data_storage` field.<br/>
        /// - `everything`: Store all data including transcripts, recordings, and logs.<br/>
        /// - `everything_except_pii`: Store data without PII when PII is detected.<br/>
        /// - `basic_attributes_only`: Store only basic attributes; no transcripts/recordings/logs.<br/>
        /// If not set, default value of "everything" will apply.<br/>
        /// Example: everything
        /// </param>
        /// <param name="dataStorageRetentionDays">
        /// Number of days to retain call/chat data before automatic deletion. Must be between 1 and 730 days. If not set, data is retained forever (no automatic deletion).<br/>
        /// Example: 30
        /// </param>
        /// <param name="optInSignedUrl">
        /// Whether this agent opts in for signed URLs for public logs and recordings. When enabled, the generated URLs will include security signatures that restrict access and automatically expire after 24 hours.<br/>
        /// Example: true
        /// </param>
        /// <param name="signedUrlExpirationMs">
        /// The expiration time for the signed url in milliseconds. Only applicable when opt_in_signed_url is true. If not set, default value of 86400000 (24 hours) will apply.<br/>
        /// Example: 86400000
        /// </param>
        /// <param name="pronunciationDictionary">
        /// A list of words / phrases and their pronunciation to be used to guide the audio synthesize for consistent pronunciation. Check the dashboard to see what provider supports this feature. Set to null to remove pronunciation dictionary from this agent.
        /// </param>
        /// <param name="normalizeForSpeech">
        /// If set to true, will normalize the some part of text (number, currency, date, etc) to spoken to its spoken form for more consistent speech synthesis (sometimes the voice synthesize system itself might read these wrong with the raw text). For example, it will convert "Call my number 2137112342 on Jul 5th, 2024 for the $24.12 payment" to "Call my number two one three seven one one two three four two on july fifth, twenty twenty four for the twenty four dollars twelve cents payment" before starting audio generation.<br/>
        /// Example: true
        /// </param>
        /// <param name="endCallAfterSilenceMs">
        /// If users stay silent for a period after agent speech, end the call. The minimum value allowed is 10,000 ms (10 s). By default, this is set to 600000 (10 min).<br/>
        /// Example: 600000
        /// </param>
        /// <param name="maxCallDurationMs">
        /// Maximum allowed length for the call, will force end the call if reached. The minimum value allowed is 60,000 ms (1 min), and maximum value allowed is 7,200,000 (2 hours). By default, this is set to 3,600,000 (1 hour).<br/>
        /// Example: 3600000
        /// </param>
        /// <param name="voicemailMessage">
        /// The message to be played when the call enters a voicemail. Note that this feature is only available for phone calls. If you want to hangup after hitting voicemail, set this to empty string.<br/>
        /// Example: Hi, please give us a callback.
        /// </param>
        /// <param name="voicemailDetectionTimeoutMs">
        /// Configures when to stop running voicemail detection, as it becomes unlikely to hit voicemail after a couple minutes, and keep running it will only have negative impact. The minimum value allowed is 5,000 ms (5 s), and maximum value allowed is 180,000 (3 minutes). By default, this is set to 30,000 (30 s).<br/>
        /// Example: 30000
        /// </param>
        /// <param name="voicemailOption">
        /// If this option is set, the call will try to detect voicemail in the first 3 minutes of the call. Actions defined (hangup, or leave a message) will be applied when the voicemail is detected. Set this to null to disable voicemail detection.<br/>
        /// Example: {"action":{"type":"static_text","text":"Please give us a callback tomorrow at 10am."}}
        /// </param>
        /// <param name="ivrOption">
        /// If this option is set, the call will try to detect IVR in the first 3 minutes of the call. Actions defined will be applied when the IVR is detected. Set this to null to disable IVR detection.<br/>
        /// Example: {"action":{"type":"hangup"}}
        /// </param>
        /// <param name="postCallAnalysisData">
        /// Post call analysis data to extract from the call. This data will augment the pre-defined variables extracted in the call analysis. This will be available after the call ends.
        /// </param>
        /// <param name="postCallAnalysisModel">
        /// Available LLM models for agents.
        /// </param>
        /// <param name="analysisSuccessfulPrompt">
        /// Prompt to determine whether the post call or chat analysis should mark the interaction as successful. Set to null to use the default prompt.<br/>
        /// Example: The agent finished the task and the call was complete without being cutoff.
        /// </param>
        /// <param name="analysisSummaryPrompt">
        /// Prompt to guide how the post call or chat analysis summary should be generated. When unset, the default system prompt is used. Set to null to use the default prompt.<br/>
        /// Example: Summarize the outcome of the conversation in two sentences.
        /// </param>
        /// <param name="analysisUserSentimentPrompt">
        /// Prompt to guide how the post call or chat analysis should evaluate user sentiment. When unset, the default system prompt is used. Set to null to use the default prompt.<br/>
        /// Example: Evaluate the user's sentiment based on their tone and satisfaction level.
        /// </param>
        /// <param name="beginMessageDelayMs">
        /// If set, will delay the first message by the specified amount of milliseconds, so that it gives user more time to prepare to take the call. Valid range is [0, 5000]. If not set or set to 0, agent will speak immediately. Only applicable when agent speaks first.<br/>
        /// Example: 1000
        /// </param>
        /// <param name="ringDurationMs">
        /// If set, the phone ringing will last for the specified amount of milliseconds. This applies for both outbound call ringtime, and call transfer ringtime. Default to 30000 (30 s). Valid range is [5000, 300000].<br/>
        /// Example: 30000
        /// </param>
        /// <param name="sttMode">
        /// If set, determines whether speech to text should focus on latency or accuracy. Default to fast mode. When set to custom, custom_stt_config must be provided.<br/>
        /// Example: fast
        /// </param>
        /// <param name="customSttConfig">
        /// Custom STT configuration. Only used when stt_mode is set to custom.
        /// </param>
        /// <param name="vocabSpecialization">
        /// If set, determines the vocabulary set to use for transcription. This setting only applies for English agents, for non English agent, this setting is a no-op. Default to general.<br/>
        /// Example: general
        /// </param>
        /// <param name="allowUserDtmf">
        /// If set to true, DTMF input will be accepted and processed. If false, any DTMF input will be ignored. Default to true.<br/>
        /// Example: true
        /// </param>
        /// <param name="userDtmfOptions"></param>
        /// <param name="denoisingMode">
        /// If set, determines what denoising mode to use. Use "no-denoise" to bypass all audio denoising. Default to noise-cancellation.<br/>
        /// Example: noise-cancellation
        /// </param>
        /// <param name="piiConfig"></param>
        /// <param name="guardrailConfig"></param>
        /// <param name="isPublic">
        /// Whether the agent is public. When set to true, the agent is available for public agent preview link.<br/>
        /// Example: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRequest(
            global::G.ResponseEngine? responseEngine,
            string? agentName,
            string? versionDescription,
            string? voiceId,
            global::G.AgentRequestVoiceModel? voiceModel,
            global::System.Collections.Generic.IList<string>? fallbackVoiceIds,
            double? voiceTemperature,
            double? voiceSpeed,
            bool? enableDynamicVoiceSpeed,
            bool? enableDynamicResponsiveness,
            double? volume,
            global::G.AgentRequestVoiceEmotion? voiceEmotion,
            double? responsiveness,
            double? interruptionSensitivity,
            bool? enableBackchannel,
            double? backchannelFrequency,
            global::System.Collections.Generic.IList<string>? backchannelWords,
            double? reminderTriggerMs,
            int? reminderMaxCount,
            global::G.AgentRequestAmbientSound? ambientSound,
            double? ambientSoundVolume,
            global::G.AgentRequestLanguage? language,
            string? webhookUrl,
            global::System.Collections.Generic.IList<global::G.AgentRequestWebhookEvent>? webhookEvents,
            int? webhookTimeoutMs,
            global::System.Collections.Generic.IList<string>? boostedKeywords,
            global::G.AgentRequestDataStorageSetting? dataStorageSetting,
            int? dataStorageRetentionDays,
            bool? optInSignedUrl,
            int? signedUrlExpirationMs,
            global::System.Collections.Generic.IList<global::G.AgentRequestPronunciationDictionaryItem>? pronunciationDictionary,
            bool? normalizeForSpeech,
            int? endCallAfterSilenceMs,
            int? maxCallDurationMs,
            string? voicemailMessage,
            int? voicemailDetectionTimeoutMs,
            global::G.AgentRequestVoicemailOption? voicemailOption,
            global::G.AgentRequestIvrOption? ivrOption,
            global::System.Collections.Generic.IList<global::G.AnalysisData>? postCallAnalysisData,
            global::G.NullableLLMModel? postCallAnalysisModel,
            string? analysisSuccessfulPrompt,
            string? analysisSummaryPrompt,
            string? analysisUserSentimentPrompt,
            int? beginMessageDelayMs,
            int? ringDurationMs,
            global::G.AgentRequestSttMode? sttMode,
            global::G.AgentRequestCustomSttConfig? customSttConfig,
            global::G.AgentRequestVocabSpecialization? vocabSpecialization,
            bool? allowUserDtmf,
            global::G.AgentRequestUserDtmfOptions? userDtmfOptions,
            global::G.AgentRequestDenoisingMode? denoisingMode,
            global::G.PIIConfig? piiConfig,
            global::G.GuardrailConfig? guardrailConfig,
            bool? isPublic)
        {
            this.ResponseEngine = responseEngine;
            this.AgentName = agentName;
            this.VersionDescription = versionDescription;
            this.VoiceId = voiceId;
            this.VoiceModel = voiceModel;
            this.FallbackVoiceIds = fallbackVoiceIds;
            this.VoiceTemperature = voiceTemperature;
            this.VoiceSpeed = voiceSpeed;
            this.EnableDynamicVoiceSpeed = enableDynamicVoiceSpeed;
            this.EnableDynamicResponsiveness = enableDynamicResponsiveness;
            this.Volume = volume;
            this.VoiceEmotion = voiceEmotion;
            this.Responsiveness = responsiveness;
            this.InterruptionSensitivity = interruptionSensitivity;
            this.EnableBackchannel = enableBackchannel;
            this.BackchannelFrequency = backchannelFrequency;
            this.BackchannelWords = backchannelWords;
            this.ReminderTriggerMs = reminderTriggerMs;
            this.ReminderMaxCount = reminderMaxCount;
            this.AmbientSound = ambientSound;
            this.AmbientSoundVolume = ambientSoundVolume;
            this.Language = language;
            this.WebhookUrl = webhookUrl;
            this.WebhookEvents = webhookEvents;
            this.WebhookTimeoutMs = webhookTimeoutMs;
            this.BoostedKeywords = boostedKeywords;
            this.DataStorageSetting = dataStorageSetting;
            this.DataStorageRetentionDays = dataStorageRetentionDays;
            this.OptInSignedUrl = optInSignedUrl;
            this.SignedUrlExpirationMs = signedUrlExpirationMs;
            this.PronunciationDictionary = pronunciationDictionary;
            this.NormalizeForSpeech = normalizeForSpeech;
            this.EndCallAfterSilenceMs = endCallAfterSilenceMs;
            this.MaxCallDurationMs = maxCallDurationMs;
            this.VoicemailMessage = voicemailMessage;
            this.VoicemailDetectionTimeoutMs = voicemailDetectionTimeoutMs;
            this.VoicemailOption = voicemailOption;
            this.IvrOption = ivrOption;
            this.PostCallAnalysisData = postCallAnalysisData;
            this.PostCallAnalysisModel = postCallAnalysisModel;
            this.AnalysisSuccessfulPrompt = analysisSuccessfulPrompt;
            this.AnalysisSummaryPrompt = analysisSummaryPrompt;
            this.AnalysisUserSentimentPrompt = analysisUserSentimentPrompt;
            this.BeginMessageDelayMs = beginMessageDelayMs;
            this.RingDurationMs = ringDurationMs;
            this.SttMode = sttMode;
            this.CustomSttConfig = customSttConfig;
            this.VocabSpecialization = vocabSpecialization;
            this.AllowUserDtmf = allowUserDtmf;
            this.UserDtmfOptions = userDtmfOptions;
            this.DenoisingMode = denoisingMode;
            this.PiiConfig = piiConfig;
            this.GuardrailConfig = guardrailConfig;
            this.IsPublic = isPublic;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRequest" /> class.
        /// </summary>
        public AgentRequest()
        {
        }
    }
}