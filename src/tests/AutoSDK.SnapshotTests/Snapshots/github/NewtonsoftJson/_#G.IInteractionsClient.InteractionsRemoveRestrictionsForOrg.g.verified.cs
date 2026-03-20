//HintName: G.IInteractionsClient.InteractionsRemoveRestrictionsForOrg.g.cs
#nullable enable

namespace G
{
    public partial interface IInteractionsClient
    {
        /// <summary>
        /// Remove interaction restrictions for an organization<br/>
        /// Removes all interaction restrictions from public repositories in the given organization. You must be an organization owner to remove restrictions.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task InteractionsRemoveRestrictionsForOrgAsync(
            string org,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}