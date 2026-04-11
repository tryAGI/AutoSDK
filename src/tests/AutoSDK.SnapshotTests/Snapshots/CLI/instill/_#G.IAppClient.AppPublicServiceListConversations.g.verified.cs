//HintName: G.IAppClient.AppPublicServiceListConversations.g.cs
#nullable enable

namespace G
{
    public partial interface IAppClient
    {
        /// <summary>
        /// List conversations<br/>
        /// Returns a paginated list of conversations.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="appId"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="conversationUid"></param>
        /// <param name="conversationId"></param>
        /// <param name="ifAll"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListConversationsResponse> AppPublicServiceListConversationsAsync(
            string namespaceId,
            string appId,
            int? pageSize = default,
            string? pageToken = default,
            string? conversationUid = default,
            string? conversationId = default,
            bool? ifAll = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}