//HintName: G.IApi.UpdateChatAgent.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Update an existing chat agent
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
        global::System.Threading.Tasks.Task<global::G.ChatAgentResponse> UpdateChatAgentAsync(
            string agentId,

            global::G.ChatAgentRequest request,
            int? version = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing chat agent
        /// </summary>
        /// <param name="agentId">
        /// Example: 16b980523634a6dc504898cda492e939
        /// </param>
        /// <param name="version">
        /// Example: 1
        /// </param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChatAgentResponse> UpdateChatAgentAsync(
            string agentId,
            int? version = default,
            global::G.ResponseEngine? responseEngine = default,
            string? agentName = default,
            string? autoCloseMessage = default,
            int? endChatAfterSilenceMs = default,
            global::G.ChatAgentRequestLanguage? language = default,
            string? webhookUrl = default,
            global::System.Collections.Generic.IList<global::G.ChatAgentRequestWebhookEvent>? webhookEvents = default,
            int? webhookTimeoutMs = default,
            global::G.ChatAgentRequestDataStorageSetting? dataStorageSetting = default,
            int? dataStorageRetentionDays = default,
            bool? optInSignedUrl = default,
            int? signedUrlExpirationMs = default,
            global::System.Collections.Generic.IList<global::G.AnalysisData>? postChatAnalysisData = default,
            global::G.NullableLLMModel? postChatAnalysisModel = default,
            string? analysisSuccessfulPrompt = default,
            string? analysisSummaryPrompt = default,
            string? analysisUserSentimentPrompt = default,
            global::G.PIIConfig? piiConfig = default,
            global::G.GuardrailConfig? guardrailConfig = default,
            bool? isPublic = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}