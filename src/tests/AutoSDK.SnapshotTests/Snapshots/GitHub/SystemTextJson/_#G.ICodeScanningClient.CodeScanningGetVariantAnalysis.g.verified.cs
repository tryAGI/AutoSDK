//HintName: G.ICodeScanningClient.CodeScanningGetVariantAnalysis.g.cs
#nullable enable

namespace G
{
    public partial interface ICodeScanningClient
    {
        /// <summary>
        /// Get the summary of a CodeQL variant analysis<br/>
        /// Gets the summary of a CodeQL variant analysis.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="codeqlVariantAnalysisId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CodeScanningVariantAnalysis> CodeScanningGetVariantAnalysisAsync(
            string owner,
            string repo,
            int codeqlVariantAnalysisId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}