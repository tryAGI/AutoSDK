//HintName: G.ISecretScanningClient.SecretScanningListAlertsForRepo.g.cs
#nullable enable

namespace G
{
    public partial interface ISecretScanningClient
    {
        /// <summary>
        /// List secret scanning alerts for a repository<br/>
        /// Lists secret scanning alerts for an eligible repository, from newest to oldest.<br/>
        /// The authenticated user must be an administrator for the repository or for the organization that owns the repository to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `security_events` scope to use this endpoint. If this endpoint is only used with public repositories, the token can use the `public_repo` scope instead.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="state"></param>
        /// <param name="secretType"></param>
        /// <param name="resolution"></param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="validity"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.SecretScanningAlert>> SecretScanningListAlertsForRepoAsync(
            string owner,
            string repo,
            global::G.SecretScanningListAlertsForRepoState? state = default,
            string? secretType = default,
            string? resolution = default,
            global::G.SecretScanningListAlertsForRepoSort? sort = default,
            global::G.SecretScanningListAlertsForRepoDirection? direction = default,
            int? page = default,
            int? perPage = default,
            string? before = default,
            string? after = default,
            string? validity = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}