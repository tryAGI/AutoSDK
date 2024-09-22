//HintName: G.ICodeScanningClient.CodeScanningGetAlert.g.cs
#nullable enable

namespace G
{
    public partial interface ICodeScanningClient
    {
        /// <summary>
        /// Get a code scanning alert<br/>
        /// Gets a single code scanning alert.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="alertNumber">
        /// The security alert number.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CodeScanningAlert> CodeScanningGetAlertAsync(
            string owner,
            string repo,
            int alertNumber,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}