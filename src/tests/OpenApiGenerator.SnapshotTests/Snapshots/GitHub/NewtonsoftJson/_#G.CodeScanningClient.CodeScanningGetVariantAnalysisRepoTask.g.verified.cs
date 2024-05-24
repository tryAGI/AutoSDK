//HintName: G.CodeScanningClient.CodeScanningGetVariantAnalysisRepoTask.g.cs

#nullable enable

namespace G
{
    public partial class CodeScanningClient
    {
        /// <summary>
        /// Get the analysis status of a repository in a CodeQL variant analysis
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="codeqlVariantAnalysisId"></param>
        /// <param name="repoOwner"></param>
        /// <param name="repoName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<CodeScanningVariantAnalysisRepoTask> CodeScanningGetVariantAnalysisRepoTaskAsync(
            string owner,
            string repo,
            int codeqlVariantAnalysisId,
            string repoOwner,
            string repoName,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/code-scanning/codeql/variant-analyses/{codeqlVariantAnalysisId}/repos/{repoOwner}/{repoName}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<CodeScanningVariantAnalysisRepoTask>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }
    }
}