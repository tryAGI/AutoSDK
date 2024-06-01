//HintName: G.CodeScanningClient.CodeScanningListAlertsForRepo.g.cs

#nullable enable

namespace G
{
    public partial class CodeScanningClient
    {
        /// <summary>
        /// List code scanning alerts for a repository
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="toolName"></param>
        /// <param name="toolGuid"></param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <param name="@ref"></param>
        /// <param name="direction"></param>
        /// <param name="sort"></param>
        /// <param name="state"></param>
        /// <param name="severity"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<CodeScanningAlertItems>> CodeScanningListAlertsForRepoAsync(
            string owner,
            string repo,
            string toolName,
            string? toolGuid,
            int page,
            int perPage,
            string @ref,
            CodeScanningListAlertsForRepoDirection direction,
            CodeScanningListAlertsForRepoSort sort,
            CodeScanningListAlertsForRepoState state,
            CodeScanningListAlertsForRepoSeverity severity,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/code-scanning/alerts?tool_name={toolName}&tool_guid={toolGuid}&page={page}&per_page={perPage}&ref={@ref}&direction={direction}&sort={sort}&state={state}&severity={severity}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<CodeScanningAlertItems>?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}