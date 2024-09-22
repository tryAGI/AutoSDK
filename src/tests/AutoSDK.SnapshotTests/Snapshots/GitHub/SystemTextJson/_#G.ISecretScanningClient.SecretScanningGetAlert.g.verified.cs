//HintName: G.ISecretScanningClient.SecretScanningGetAlert.g.cs
#nullable enable

namespace G
{
    public partial interface ISecretScanningClient
    {
        /// <summary>
        /// Get a secret scanning alert<br/>
        /// Gets a single secret scanning alert detected in an eligible repository.<br/>
        /// The authenticated user must be an administrator for the repository or for the organization that owns the repository to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `security_events` scope to use this endpoint. If this endpoint is only used with public repositories, the token can use the `public_repo` scope instead.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="alertNumber">
        /// The security alert number.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SecretScanningAlert> SecretScanningGetAlertAsync(
            string owner,
            string repo,
            int alertNumber,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}