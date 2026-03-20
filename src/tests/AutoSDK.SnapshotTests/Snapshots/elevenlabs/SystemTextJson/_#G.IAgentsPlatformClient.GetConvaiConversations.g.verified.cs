//HintName: G.IAgentsPlatformClient.GetConvaiConversations.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Get Conversations<br/>
        /// Get all conversations of agents that user owns. With option to restrict to a specific agent.
        /// </summary>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="agentId">
        /// The id of the agent you're taking the action on.
        /// </param>
        /// <param name="callSuccessful">
        /// The result of the success evaluation
        /// </param>
        /// <param name="callStartBeforeUnix">
        /// Unix timestamp (in seconds) to filter conversations up to this start date.
        /// </param>
        /// <param name="callStartAfterUnix">
        /// Unix timestamp (in seconds) to filter conversations after to this start date.
        /// </param>
        /// <param name="callDurationMinSecs">
        /// Minimum call duration in seconds.
        /// </param>
        /// <param name="callDurationMaxSecs">
        /// Maximum call duration in seconds.
        /// </param>
        /// <param name="ratingMax">
        /// Maximum overall rating (1-5).
        /// </param>
        /// <param name="ratingMin">
        /// Minimum overall rating (1-5).
        /// </param>
        /// <param name="hasFeedbackComment">
        /// Filter conversations with user feedback comments.
        /// </param>
        /// <param name="userId">
        /// Filter conversations by the user ID who initiated them.
        /// </param>
        /// <param name="evaluationParams">
        /// Evaluation filters. Repeat param. Format: criteria_id:result. Example: eval=value_framing:success
        /// </param>
        /// <param name="dataCollectionParams">
        /// Data collection filters. Repeat param. Format: id:op:value where op is one of eq|neq|gt|gte|lt|lte|in|exists|missing. For in, pipe-delimit values.
        /// </param>
        /// <param name="toolNames">
        /// Filter conversations by tool names used during the call.
        /// </param>
        /// <param name="mainLanguages">
        /// Filter conversations by detected main language (language code).
        /// </param>
        /// <param name="pageSize">
        /// How many conversations to return at maximum. Can not exceed 100, defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="summaryMode">
        /// Whether to include transcript summaries in the response.<br/>
        /// Default Value: exclude
        /// </param>
        /// <param name="search">
        /// Full-text or fuzzy search over transcript messages
        /// </param>
        /// <param name="conversationInitiationSource"></param>
        /// <param name="branchId">
        /// Filter conversations by branch ID.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetConversationsPageResponseModel> GetConvaiConversationsAsync(
            string? cursor = default,
            string? agentId = default,
            global::G.EvaluationSuccessResult? callSuccessful = default,
            int? callStartBeforeUnix = default,
            int? callStartAfterUnix = default,
            int? callDurationMinSecs = default,
            int? callDurationMaxSecs = default,
            int? ratingMax = default,
            int? ratingMin = default,
            bool? hasFeedbackComment = default,
            string? userId = default,
            global::System.Collections.Generic.IList<string>? evaluationParams = default,
            global::System.Collections.Generic.IList<string>? dataCollectionParams = default,
            global::System.Collections.Generic.IList<string>? toolNames = default,
            global::System.Collections.Generic.IList<string>? mainLanguages = default,
            int? pageSize = default,
            global::G.GetConversationHistoriesRouteSummaryMode? summaryMode = default,
            string? search = default,
            global::G.ConversationInitiationSource? conversationInitiationSource = default,
            string? branchId = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}