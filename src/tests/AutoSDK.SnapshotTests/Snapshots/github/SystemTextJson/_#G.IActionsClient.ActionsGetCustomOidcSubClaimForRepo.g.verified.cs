//HintName: G.IActionsClient.ActionsGetCustomOidcSubClaimForRepo.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Get the customization template for an OIDC subject claim for a repository<br/>
        /// Gets the customization template for an OpenID Connect (OIDC) subject claim.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OidcCustomSubRepo> ActionsGetCustomOidcSubClaimForRepoAsync(
            string owner,
            string repo,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}