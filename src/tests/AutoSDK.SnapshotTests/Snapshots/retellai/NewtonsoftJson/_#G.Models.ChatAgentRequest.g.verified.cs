//HintName: G.Models.ChatAgentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatAgentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_engine")]
        public global::G.ResponseEngine? ResponseEngine { get; set; }

        /// <summary>
        /// The name of the chat agent. Only used for your own reference.<br/>
        /// Example: Jarvis
        /// </summary>
        /// <example>Jarvis</example>
        [global::Newtonsoft.Json.JsonProperty("agent_name")]
        public string? AgentName { get; set; }

        /// <summary>
        /// Message to display when the chat is automatically closed.<br/>
        /// Example: Thank you for chatting. The conversation has ended.
        /// </summary>
        /// <example>Thank you for chatting. The conversation has ended.</example>
        [global::Newtonsoft.Json.JsonProperty("auto_close_message")]
        public string? AutoCloseMessage { get; set; }

        /// <summary>
        /// If users stay silent for a period after agent speech, end the chat. The minimum value allowed is 120,000 ms (2 minutes). The maximum value allowed is 259,200,000 ms (72 hours). By default, this is set to 3,600,000 (1 hour).<br/>
        /// Example: 3600000
        /// </summary>
        /// <example>3600000</example>
        [global::Newtonsoft.Json.JsonProperty("end_chat_after_silence_ms")]
        public int? EndChatAfterSilenceMs { get; set; }

        /// <summary>
        /// Specifies what language (and dialect) the chat will operate in. For instance, selecting `en-GB` optimizes for British English. If unset, will use default value `en-US`. Select `multi` for multilingual support, currently this supports Spanish and English.<br/>
        /// Example: en-US
        /// </summary>
        /// <example>en-US</example>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public global::G.ChatAgentRequestLanguage? Language { get; set; }

        /// <summary>
        /// The webhook for agent to listen to chat events. See what events it would get at [webhook doc](/features/webhook). If set, will binds webhook events for this agent to the specified url, and will ignore the account level webhook for this agent. Set to `null` to remove webhook url from this agent.<br/>
        /// Example: https://webhook-url-here
        /// </summary>
        /// <example>https://webhook-url-here</example>
        [global::Newtonsoft.Json.JsonProperty("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Which webhook events this agent should receive. If not set, defaults to chat_started, chat_ended, chat_analyzed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook_events")]
        public global::System.Collections.Generic.IList<global::G.ChatAgentRequestWebhookEvent>? WebhookEvents { get; set; }

        /// <summary>
        /// The timeout for the webhook in milliseconds. If not set, default value of 10000 will apply.<br/>
        /// Example: 10000
        /// </summary>
        /// <example>10000</example>
        [global::Newtonsoft.Json.JsonProperty("webhook_timeout_ms")]
        public int? WebhookTimeoutMs { get; set; }

        /// <summary>
        /// Controls what data is stored for this agent. "everything" stores all data including transcripts and recordings. "everything_except_pii" stores data but excludes PII when possible based on PII configuration. "basic_attributes_only" stores only basic metadata. If not set, defaults to "everything".<br/>
        /// Example: everything
        /// </summary>
        /// <example>everything</example>
        [global::Newtonsoft.Json.JsonProperty("data_storage_setting")]
        public global::G.ChatAgentRequestDataStorageSetting? DataStorageSetting { get; set; }

        /// <summary>
        /// Number of days to retain call/chat data before automatic deletion. Must be between 1 and 730 days. If not set, data is retained forever (no automatic deletion).<br/>
        /// Example: 30
        /// </summary>
        /// <example>30</example>
        [global::Newtonsoft.Json.JsonProperty("data_storage_retention_days")]
        public int? DataStorageRetentionDays { get; set; }

        /// <summary>
        /// Whether this agent opts in to signed url for public log. If not set, default value of false will apply.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("opt_in_signed_url")]
        public bool? OptInSignedUrl { get; set; }

        /// <summary>
        /// The expiration time for the signed url in milliseconds. Only applicable when opt_in_signed_url is true. If not set, default value of 86400000 (24 hours) will apply.<br/>
        /// Example: 86400000
        /// </summary>
        /// <example>86400000</example>
        [global::Newtonsoft.Json.JsonProperty("signed_url_expiration_ms")]
        public int? SignedUrlExpirationMs { get; set; }

        /// <summary>
        /// Post chat analysis data to extract from the chat. This data will augment the pre-defined variables extracted in the chat analysis. This will be available after the chat ends.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("post_chat_analysis_data")]
        public global::System.Collections.Generic.IList<global::G.AnalysisData>? PostChatAnalysisData { get; set; }

        /// <summary>
        /// Available LLM models for agents.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("post_chat_analysis_model")]
        public global::G.NullableLLMModel? PostChatAnalysisModel { get; set; }

        /// <summary>
        /// The prompt to use for post call analysis to evaluate whether the call is successful. Set to null to use the default prompt.<br/>
        /// Example: The agent finished the task and the call was complete without being cutoff.
        /// </summary>
        /// <example>The agent finished the task and the call was complete without being cutoff.</example>
        [global::Newtonsoft.Json.JsonProperty("analysis_successful_prompt")]
        public string? AnalysisSuccessfulPrompt { get; set; }

        /// <summary>
        /// The prompt to use for post call analysis to summarize the call. Set to null to use the default prompt.<br/>
        /// Example: Summarize the call in a few sentences.
        /// </summary>
        /// <example>Summarize the call in a few sentences.</example>
        [global::Newtonsoft.Json.JsonProperty("analysis_summary_prompt")]
        public string? AnalysisSummaryPrompt { get; set; }

        /// <summary>
        /// Prompt to guide how the post chat analysis should evaluate user sentiment. When unset, the default system prompt is used. Set to null to use the default prompt.<br/>
        /// Example: Evaluate the user's sentiment based on their tone and satisfaction level.
        /// </summary>
        /// <example>Evaluate the user's sentiment based on their tone and satisfaction level.</example>
        [global::Newtonsoft.Json.JsonProperty("analysis_user_sentiment_prompt")]
        public string? AnalysisUserSentimentPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pii_config")]
        public global::G.PIIConfig? PiiConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("guardrail_config")]
        public global::G.GuardrailConfig? GuardrailConfig { get; set; }

        /// <summary>
        /// Whether the agent is public. When set to true, the agent is available for public agent preview link.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("is_public")]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatAgentRequest" /> class.
        /// </summary>
        /// <param name="responseEngine"></param>
        /// <param name="agentName">
        /// The name of the chat agent. Only used for your own reference.<br/>
        /// Example: Jarvis
        /// </param>
        /// <param name="autoCloseMessage">
        /// Message to display when the chat is automatically closed.<br/>
        /// Example: Thank you for chatting. The conversation has ended.
        /// </param>
        /// <param name="endChatAfterSilenceMs">
        /// If users stay silent for a period after agent speech, end the chat. The minimum value allowed is 120,000 ms (2 minutes). The maximum value allowed is 259,200,000 ms (72 hours). By default, this is set to 3,600,000 (1 hour).<br/>
        /// Example: 3600000
        /// </param>
        /// <param name="language">
        /// Specifies what language (and dialect) the chat will operate in. For instance, selecting `en-GB` optimizes for British English. If unset, will use default value `en-US`. Select `multi` for multilingual support, currently this supports Spanish and English.<br/>
        /// Example: en-US
        /// </param>
        /// <param name="webhookUrl">
        /// The webhook for agent to listen to chat events. See what events it would get at [webhook doc](/features/webhook). If set, will binds webhook events for this agent to the specified url, and will ignore the account level webhook for this agent. Set to `null` to remove webhook url from this agent.<br/>
        /// Example: https://webhook-url-here
        /// </param>
        /// <param name="webhookEvents">
        /// Which webhook events this agent should receive. If not set, defaults to chat_started, chat_ended, chat_analyzed.
        /// </param>
        /// <param name="webhookTimeoutMs">
        /// The timeout for the webhook in milliseconds. If not set, default value of 10000 will apply.<br/>
        /// Example: 10000
        /// </param>
        /// <param name="dataStorageSetting">
        /// Controls what data is stored for this agent. "everything" stores all data including transcripts and recordings. "everything_except_pii" stores data but excludes PII when possible based on PII configuration. "basic_attributes_only" stores only basic metadata. If not set, defaults to "everything".<br/>
        /// Example: everything
        /// </param>
        /// <param name="dataStorageRetentionDays">
        /// Number of days to retain call/chat data before automatic deletion. Must be between 1 and 730 days. If not set, data is retained forever (no automatic deletion).<br/>
        /// Example: 30
        /// </param>
        /// <param name="optInSignedUrl">
        /// Whether this agent opts in to signed url for public log. If not set, default value of false will apply.<br/>
        /// Example: true
        /// </param>
        /// <param name="signedUrlExpirationMs">
        /// The expiration time for the signed url in milliseconds. Only applicable when opt_in_signed_url is true. If not set, default value of 86400000 (24 hours) will apply.<br/>
        /// Example: 86400000
        /// </param>
        /// <param name="postChatAnalysisData">
        /// Post chat analysis data to extract from the chat. This data will augment the pre-defined variables extracted in the chat analysis. This will be available after the chat ends.
        /// </param>
        /// <param name="postChatAnalysisModel">
        /// Available LLM models for agents.
        /// </param>
        /// <param name="analysisSuccessfulPrompt">
        /// The prompt to use for post call analysis to evaluate whether the call is successful. Set to null to use the default prompt.<br/>
        /// Example: The agent finished the task and the call was complete without being cutoff.
        /// </param>
        /// <param name="analysisSummaryPrompt">
        /// The prompt to use for post call analysis to summarize the call. Set to null to use the default prompt.<br/>
        /// Example: Summarize the call in a few sentences.
        /// </param>
        /// <param name="analysisUserSentimentPrompt">
        /// Prompt to guide how the post chat analysis should evaluate user sentiment. When unset, the default system prompt is used. Set to null to use the default prompt.<br/>
        /// Example: Evaluate the user's sentiment based on their tone and satisfaction level.
        /// </param>
        /// <param name="piiConfig"></param>
        /// <param name="guardrailConfig"></param>
        /// <param name="isPublic">
        /// Whether the agent is public. When set to true, the agent is available for public agent preview link.<br/>
        /// Example: false
        /// </param>
        public ChatAgentRequest(
            global::G.ResponseEngine? responseEngine,
            string? agentName,
            string? autoCloseMessage,
            int? endChatAfterSilenceMs,
            global::G.ChatAgentRequestLanguage? language,
            string? webhookUrl,
            global::System.Collections.Generic.IList<global::G.ChatAgentRequestWebhookEvent>? webhookEvents,
            int? webhookTimeoutMs,
            global::G.ChatAgentRequestDataStorageSetting? dataStorageSetting,
            int? dataStorageRetentionDays,
            bool? optInSignedUrl,
            int? signedUrlExpirationMs,
            global::System.Collections.Generic.IList<global::G.AnalysisData>? postChatAnalysisData,
            global::G.NullableLLMModel? postChatAnalysisModel,
            string? analysisSuccessfulPrompt,
            string? analysisSummaryPrompt,
            string? analysisUserSentimentPrompt,
            global::G.PIIConfig? piiConfig,
            global::G.GuardrailConfig? guardrailConfig,
            bool? isPublic)
        {
            this.ResponseEngine = responseEngine;
            this.AgentName = agentName;
            this.AutoCloseMessage = autoCloseMessage;
            this.EndChatAfterSilenceMs = endChatAfterSilenceMs;
            this.Language = language;
            this.WebhookUrl = webhookUrl;
            this.WebhookEvents = webhookEvents;
            this.WebhookTimeoutMs = webhookTimeoutMs;
            this.DataStorageSetting = dataStorageSetting;
            this.DataStorageRetentionDays = dataStorageRetentionDays;
            this.OptInSignedUrl = optInSignedUrl;
            this.SignedUrlExpirationMs = signedUrlExpirationMs;
            this.PostChatAnalysisData = postChatAnalysisData;
            this.PostChatAnalysisModel = postChatAnalysisModel;
            this.AnalysisSuccessfulPrompt = analysisSuccessfulPrompt;
            this.AnalysisSummaryPrompt = analysisSummaryPrompt;
            this.AnalysisUserSentimentPrompt = analysisUserSentimentPrompt;
            this.PiiConfig = piiConfig;
            this.GuardrailConfig = guardrailConfig;
            this.IsPublic = isPublic;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatAgentRequest" /> class.
        /// </summary>
        public ChatAgentRequest()
        {
        }
    }
}