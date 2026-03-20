//HintName: G.IAgentsPlatformClient.GetConvaiAgents.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsPlatformClient
    {

        /// <summary>
        /// List Agents<br/>
        /// Returns a list of your agents and their metadata.
        /// </summary>
        /// <param name="pageSize">
        /// How many Agents to return at maximum. Can not exceed 100, defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="search">
        /// Search by agents name.
        /// </param>
        /// <param name="archived">
        /// Filter agents by archived status<br/>
        /// Default Value: false
        /// </param>
        /// <param name="showOnlyOwnedAgents">
        /// If set to true, the endpoint will omit any agents that were shared with you by someone else and include only the ones you own<br/>
        /// Default Value: false
        /// </param>
        /// <param name="sortDirection">
        /// The direction to sort the results<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="sortBy">
        /// The field to sort the results by
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetAgentsPageResponseModel> GetConvaiAgentsAsync(
            int? pageSize = default,
            string? search = default,
            bool? archived = default,
            bool? showOnlyOwnedAgents = default,
            global::G.SortDirection? sortDirection = default,
            global::G.AgentSortBy? sortBy = default,
            string? cursor = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}