//HintName: G.IAgentsPlatformClient.GetConvaiAgentsByAgentIdBranches.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsPlatformClient
    {

        /// <summary>
        /// List Agent Branches<br/>
        /// Returns a list of branches an agent has
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="includeArchived">
        /// Whether archived branches should be included<br/>
        /// Default Value: false
        /// </param>
        /// <param name="limit">
        /// How many results at most should be returned<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListResponseAgentBranchSummary> GetConvaiAgentsByAgentIdBranchesAsync(
            string agentId,
            bool? includeArchived = default,
            int? limit = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}