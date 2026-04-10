//HintName: G.IChatGroupsClient.ListChatGroups.g.cs
#nullable enable

namespace G
{
    public partial interface IChatGroupsClient
    {
        /// <summary>
        /// List chat groups
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="ascendingOrder"></param>
        /// <param name="configId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ReturnPagedChatGroups> ListChatGroupsAsync(
            int? pageNumber = default,
            int? pageSize = default,
            bool? ascendingOrder = default,
            string? configId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}