//HintName: G.IRatingsClient.CreateRating.g.cs
#nullable enable

namespace G
{
    public partial interface IRatingsClient
    {
        /// <summary>
        /// Create a rating<br/>
        /// Create a new rating of agent message for specific chat
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="chatId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateRatingResponse> CreateRatingAsync(
            string agentId,
            string chatId,

            global::G.CreateRatingRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a rating<br/>
        /// Create a new rating of agent message for specific chat
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="chatId"></param>
        /// <param name="score">
        /// The rating score: positive for favorable, negative for unfavorable<br/>
        /// Example: 1
        /// </param>
        /// <param name="knowledgeId">
        /// The ID of the agent's knowledge
        /// </param>
        /// <param name="messageId">
        /// The ID of the message to rate
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateRatingResponse> CreateRatingAsync(
            string agentId,
            string chatId,
            double score,
            string knowledgeId,
            string? messageId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}