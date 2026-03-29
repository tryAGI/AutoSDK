//HintName: G.IAgentClient.UpsertThreadMessage.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultInAppThreadString> UpsertThreadMessageAsync(
            string sessionId,

            global::G.UpsertThreadMessageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="metadata"></param>
        /// <param name="messages"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultInAppThreadString> UpsertThreadMessageAsync(
            string sessionId,
            global::G.UpsertThreadMessageRequestMetadata metadata,
            global::System.Collections.Generic.IList<object> messages,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}