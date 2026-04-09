//HintName: G.IApi.UpdateAgent.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Update an existing agent's latest draft version
        /// </summary>
        /// <param name="agentId">
        /// Example: 16b980523634a6dc504898cda492e939
        /// </param>
        /// <param name="version">
        /// Example: 1
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentResponse> UpdateAgentAsync(
            string agentId,

            global::G.AgentRequest request,
            int? version = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing agent's latest draft version
        /// </summary>
        /// <param name="agentId">
        /// Example: 16b980523634a6dc504898cda492e939
        /// </param>
        /// <param name="version">
        /// Example: 1
        /// </param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentResponse> UpdateAgentAsync(
            string agentId,
            int? version = default,
            global::G.ResponseEngine? responseEngine = default,
            string? agentName = default,
            string? versionDescription = default,
            string? voiceId = default,
            global::G.AgentRequestVoiceModel? voiceModel = default,
            global::System.Collections.Generic.IList<string>? fallbackVoiceIds = default,
            double? voiceTemperature = default,
            double? voiceSpeed = default,
            bool? enableDynamicVoiceSpeed = default,
            bool? enableDynamicResponsiveness = default,
            double? volume = default,
            global::G.AgentRequestVoiceEmotion? voiceEmotion = default,
            double? responsiveness = default,
            double? interruptionSensitivity = default,
            bool? enableBackchannel = default,
            double? backchannelFrequency = default,
            global::System.Collections.Generic.IList<string>? backchannelWords = default,
            double? reminderTriggerMs = default,
            int? reminderMaxCount = default,
            global::G.AgentRequestAmbientSound? ambientSound = default,
            double? ambientSoundVolume = default,
            global::G.AgentRequestLanguage? language = default,
            string? webhookUrl = default,
            global::System.Collections.Generic.IList<global::G.AgentRequestWebhookEvent>? webhookEvents = default,
            int? webhookTimeoutMs = default,
            global::System.Collections.Generic.IList<string>? boostedKeywords = default,
            global::G.AgentRequestDataStorageSetting? dataStorageSetting = default,
            int? dataStorageRetentionDays = default,
            bool? optInSignedUrl = default,
            int? signedUrlExpirationMs = default,
            global::System.Collections.Generic.IList<global::G.AgentRequestPronunciationDictionaryItem>? pronunciationDictionary = default,
            bool? normalizeForSpeech = default,
            int? endCallAfterSilenceMs = default,
            int? maxCallDurationMs = default,
            string? voicemailMessage = default,
            int? voicemailDetectionTimeoutMs = default,
            global::G.AgentRequestVoicemailOption? voicemailOption = default,
            global::G.AgentRequestIvrOption? ivrOption = default,
            global::System.Collections.Generic.IList<global::G.AnalysisData>? postCallAnalysisData = default,
            global::G.NullableLLMModel? postCallAnalysisModel = default,
            string? analysisSuccessfulPrompt = default,
            string? analysisSummaryPrompt = default,
            string? analysisUserSentimentPrompt = default,
            int? beginMessageDelayMs = default,
            int? ringDurationMs = default,
            global::G.AgentRequestSttMode? sttMode = default,
            global::G.AgentRequestCustomSttConfig? customSttConfig = default,
            global::G.AgentRequestVocabSpecialization? vocabSpecialization = default,
            bool? allowUserDtmf = default,
            global::G.AgentRequestUserDtmfOptions? userDtmfOptions = default,
            global::G.AgentRequestDenoisingMode? denoisingMode = default,
            global::G.PIIConfig? piiConfig = default,
            global::G.GuardrailConfig? guardrailConfig = default,
            bool? isPublic = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}