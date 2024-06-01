//HintName: G.CodeScanningClient.CodeScanningListRecentAnalyses.g.cs

#nullable enable

namespace G
{
    public partial class CodeScanningClient
    {
        /// <summary>
        /// List code scanning analyses for a repository
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="toolName"></param>
        /// <param name="toolGuid"></param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <param name="@ref"></param>
        /// <param name="sarifId"></param>
        /// <param name="direction"></param>
        /// <param name="sort"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<CodeScanningAnalysis>> CodeScanningListRecentAnalysesAsync(
            string owner,
            string repo,
            string toolName,
            string? toolGuid,
            int page,
            int perPage,
            string @ref,
            string sarifId,
            CodeScanningListRecentAnalysesDirection direction,
            CodeScanningListRecentAnalysesSort sort,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/code-scanning/analyses?tool_name={toolName}&tool_guid={toolGuid}&page={page}&per_page={perPage}&ref={@ref}&sarif_id={sarifId}&direction={direction}&sort={sort}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<CodeScanningAnalysis>?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}