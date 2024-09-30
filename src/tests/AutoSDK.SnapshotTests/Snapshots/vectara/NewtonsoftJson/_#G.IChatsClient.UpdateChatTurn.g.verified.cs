//HintName: G.IChatsClient.UpdateChatTurn.g.cs
#nullable enable

namespace G
{
    public partial interface IChatsClient
    {
        /// <summary>
        /// Update a turn<br/>
        /// Update a turn; used to disable or enable a chat.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="chatId"></param>
        /// <param name="turnId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Turn> UpdateChatTurnAsync(
            string chatId,
            string turnId,
            global::G.UpdateTurnRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a turn<br/>
        /// Update a turn; used to disable or enable a chat.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="chatId"></param>
        /// <param name="turnId"></param>
        /// <param name="enabled">
        /// Indicates whether to disable a turn. It will disable this turn and all subsequent turns.<br/>
        /// Enabling a turn is not implemented.<br/>
        /// Example: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Turn> UpdateChatTurnAsync(
            string chatId,
            string turnId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            bool? enabled = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}