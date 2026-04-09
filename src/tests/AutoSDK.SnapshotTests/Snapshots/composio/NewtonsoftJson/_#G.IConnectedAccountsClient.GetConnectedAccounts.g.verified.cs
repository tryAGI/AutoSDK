//HintName: G.IConnectedAccountsClient.GetConnectedAccounts.g.cs
#nullable enable

namespace G
{
    public partial interface IConnectedAccountsClient
    {
        /// <summary>
        /// List connected accounts with optional filters<br/>
        /// Retrieves all connected accounts for your project. Connected accounts represent authenticated user connections to external services (e.g., a user's Gmail account, Slack workspace). Filter by toolkit, status, user ID, or auth config to find specific connections.
        /// </summary>
        /// <param name="toolkitSlugs">
        /// The toolkit slugs of the connected accounts
        /// </param>
        /// <param name="statuses">
        /// The status of the connected account
        /// </param>
        /// <param name="cursor">
        /// The cursor to paginate through the connected accounts
        /// </param>
        /// <param name="limit">
        /// The limit of the connected accounts to return
        /// </param>
        /// <param name="userIds">
        /// The user ids of the connected accounts
        /// </param>
        /// <param name="authConfigIds">
        /// The auth config ids of the connected accounts
        /// </param>
        /// <param name="connectedAccountIds">
        /// The connected account ids to filter by
        /// </param>
        /// <param name="orderBy">
        /// The order by of the connected accounts<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="orderDirection">
        /// The order direction of the connected accounts<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetConnectedAccountsResponse> GetConnectedAccountsAsync(
            global::System.Collections.Generic.IList<string>? toolkitSlugs = default,
            global::System.Collections.Generic.IList<global::G.GetConnectedAccountsStatuse>? statuses = default,
            string? cursor = default,
            double? limit = default,
            global::System.Collections.Generic.IList<string>? userIds = default,
            global::System.Collections.Generic.IList<string>? authConfigIds = default,
            global::System.Collections.Generic.IList<string>? connectedAccountIds = default,
            global::G.GetConnectedAccountsOrderBy? orderBy = default,
            global::G.GetConnectedAccountsOrderDirection? orderDirection = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}