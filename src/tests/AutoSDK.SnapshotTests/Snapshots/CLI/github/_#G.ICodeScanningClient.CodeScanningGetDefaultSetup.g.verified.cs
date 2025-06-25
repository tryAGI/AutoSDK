//HintName: G.ICodeScanningClient.CodeScanningGetDefaultSetup.g.cs
#nullable enable

namespace G
{
    public partial interface ICodeScanningClient
    {
        /// <summary>
        /// Get a code scanning default setup configuration<br/>
        /// Gets a code scanning default setup configuration.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CodeScanningDefaultSetup> CodeScanningGetDefaultSetupAsync(
            string owner,
            string repo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}