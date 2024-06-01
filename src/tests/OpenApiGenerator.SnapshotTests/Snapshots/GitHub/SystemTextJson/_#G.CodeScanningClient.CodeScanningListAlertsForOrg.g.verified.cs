//HintName: G.CodeScanningClient.CodeScanningListAlertsForOrg.g.cs

#nullable enable

namespace G
{
    public partial class CodeScanningClient
    {
        /// <summary>
        /// List code scanning alerts for an organization
        /// </summary>
        /// <param name="org"></param>
        /// <param name="toolName"></param>
        /// <param name="toolGuid"></param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <param name="direction"></param>
        /// <param name="state"></param>
        /// <param name="sort"></param>
        /// <param name="severity"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<CodeScanningOrganizationAlertItems>> CodeScanningListAlertsForOrgAsync(
            string org,
            string toolName,
            string? toolGuid,
            string before,
            string after,
            int page,
            int perPage,
            CodeScanningListAlertsForOrgDirection direction,
            CodeScanningListAlertsForOrgState state,
            CodeScanningListAlertsForOrgSort sort,
            CodeScanningListAlertsForOrgSeverity severity,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/code-scanning/alerts?tool_name={toolName}&tool_guid={toolGuid}&before={before}&after={after}&page={page}&per_page={perPage}&direction={direction}&state={state}&sort={sort}&severity={severity}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<CodeScanningOrganizationAlertItems>?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}