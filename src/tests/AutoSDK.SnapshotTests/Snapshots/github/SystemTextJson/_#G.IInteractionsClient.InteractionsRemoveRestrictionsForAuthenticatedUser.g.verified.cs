//HintName: G.IInteractionsClient.InteractionsRemoveRestrictionsForAuthenticatedUser.g.cs
#nullable enable

namespace G
{
    public partial interface IInteractionsClient
    {
        /// <summary>
        /// Remove interaction restrictions from your public repositories<br/>
        /// Removes any interaction restrictions from your public repositories.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task InteractionsRemoveRestrictionsForAuthenticatedUserAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}