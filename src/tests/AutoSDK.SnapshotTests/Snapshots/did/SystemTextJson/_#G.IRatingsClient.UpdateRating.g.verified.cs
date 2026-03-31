//HintName: G.IRatingsClient.UpdateRating.g.cs
#nullable enable

namespace G
{
    public partial interface IRatingsClient
    {
        /// <summary>
        /// Update a rating<br/>
        /// Update a specific rating of agent message
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="chatId"></param>
        /// <param name="ratingId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateRatingResponse> UpdateRatingAsync(
            string agentId,
            string chatId,
            string ratingId,

            global::G.UpdateRatingRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a rating<br/>
        /// Update a specific rating of agent message
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="chatId"></param>
        /// <param name="ratingId"></param>
        /// <param name="score">
        /// The rating score: positive for favorable, negative for unfavorable<br/>
        /// Example: 1
        /// </param>
        /// <param name="requestAgentId">
        /// The ID of the agent
        /// </param>
        /// <param name="requestChatId">
        /// The ID of the chat containing the message
        /// </param>
        /// <param name="knowledgeId">
        /// The ID of the agent's knowledge
        /// </param>
        /// <param name="messageId">
        /// The ID of the message to rate
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateRatingResponse> UpdateRatingAsync(
            string agentId,
            string chatId,
            string ratingId,
            double? score = default,
            string? requestAgentId = default,
            string? requestChatId = default,
            string? knowledgeId = default,
            string? messageId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}