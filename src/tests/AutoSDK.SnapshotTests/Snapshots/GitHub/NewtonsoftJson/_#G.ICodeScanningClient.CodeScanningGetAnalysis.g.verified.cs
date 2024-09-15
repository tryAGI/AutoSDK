//HintName: G.ICodeScanningClient.CodeScanningGetAnalysis.g.cs
#nullable enable

namespace G
{
    public partial interface ICodeScanningClient
    {
        /// <summary>
        /// Get a code scanning analysis for a repository<br/>
        /// Gets a specified code scanning analysis for a repository.<br/>
        /// The default JSON response contains fields that describe the analysis.<br/>
        /// This includes the Git reference and commit SHA to which the analysis relates,<br/>
        /// the datetime of the analysis, the name of the code scanning tool,<br/>
        /// and the number of alerts.<br/>
        /// The `rules_count` field in the default response give the number of rules<br/>
        /// that were run in the analysis.<br/>
        /// For very old analyses this data is not available,<br/>
        /// and `0` is returned in this field.<br/>
        /// This endpoint supports the following custom media types. For more information, see "[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types)."<br/>
        /// - **`application/sarif+json`**: Instead of returning a summary of the analysis, this endpoint returns a subset of the analysis data that was uploaded. The data is formatted as [SARIF version 2.1.0](https://docs.oasis-open.org/sarif/sarif/v2.1.0/cs01/sarif-v2.1.0-cs01.html). It also returns additional data such as the `github/alertNumber` and `github/alertUrl` properties.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="analysisId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CodeScanningAnalysis> CodeScanningGetAnalysisAsync(
            string owner,
            string repo,
            int analysisId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}