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
        public async global::System.Threading.Tasks.Task CodeScanningListRecentAnalysesAsync(
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
            var directionValue = direction switch
            {
                CodeScanningListRecentAnalysesDirection.Asc => "asc",
                CodeScanningListRecentAnalysesDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var sortValue = sort switch
            {
                CodeScanningListRecentAnalysesSort.Created => "created",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/code-scanning/analyses?tool_name={toolName}&tool_guid={toolGuid}&page={page}&per_page={perPage}&ref={@ref}&sarif_id={sarifId}&direction={directionValue}&sort={sortValue}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}