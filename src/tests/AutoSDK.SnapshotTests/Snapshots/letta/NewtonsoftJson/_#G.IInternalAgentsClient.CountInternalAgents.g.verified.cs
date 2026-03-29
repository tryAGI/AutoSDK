//HintName: G.IInternalAgentsClient.CountInternalAgents.g.cs
#nullable enable

namespace G
{
    public partial interface IInternalAgentsClient
    {
        /// <summary>
        /// Count Agents<br/>
        /// Get the total number of agents for a user, with option to exclude hidden agents.
        /// </summary>
        /// <param name="excludeHidden">
        /// If True, excludes hidden agents from the count. If False, includes all agents.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<int> CountInternalAgentsAsync(
            bool? excludeHidden = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}