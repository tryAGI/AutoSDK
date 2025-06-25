//HintName: G.IInteractionsClient.InteractionsRemoveRestrictionsForRepo.g.cs
#nullable enable

namespace G
{
    public partial interface IInteractionsClient
    {
        /// <summary>
        /// Remove interaction restrictions for a repository<br/>
        /// Removes all interaction restrictions from the given repository. You must have owner or admin access to remove restrictions. If the interaction limit is set for the user or organization that owns this repository, you will receive a `409 Conflict` response and will not be able to use this endpoint to change the interaction limit for a single repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task InteractionsRemoveRestrictionsForRepoAsync(
            string owner,
            string repo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}