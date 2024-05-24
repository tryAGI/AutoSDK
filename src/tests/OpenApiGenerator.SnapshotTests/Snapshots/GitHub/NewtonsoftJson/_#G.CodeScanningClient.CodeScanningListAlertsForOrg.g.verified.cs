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
        public async global::System.Threading.Tasks.Task CodeScanningListAlertsForOrgAsync(
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
            var directionValue = direction switch
            {
                CodeScanningListAlertsForOrgDirection.Asc => "asc",
                CodeScanningListAlertsForOrgDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var stateValue = state switch
            {
                CodeScanningListAlertsForOrgState.Open => "open",
                CodeScanningListAlertsForOrgState.Closed => "closed",
                CodeScanningListAlertsForOrgState.Dismissed => "dismissed",
                CodeScanningListAlertsForOrgState.Fixed => "fixed",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var sortValue = sort switch
            {
                CodeScanningListAlertsForOrgSort.Created => "created",
                CodeScanningListAlertsForOrgSort.Updated => "updated",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var severityValue = severity switch
            {
                CodeScanningListAlertsForOrgSeverity.Critical => "critical",
                CodeScanningListAlertsForOrgSeverity.High => "high",
                CodeScanningListAlertsForOrgSeverity.Medium => "medium",
                CodeScanningListAlertsForOrgSeverity.Low => "low",
                CodeScanningListAlertsForOrgSeverity.Warning => "warning",
                CodeScanningListAlertsForOrgSeverity.Note => "note",
                CodeScanningListAlertsForOrgSeverity.Error => "error",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/code-scanning/alerts?tool_name={toolName}&tool_guid={toolGuid}&before={before}&after={after}&page={page}&per_page={perPage}&direction={directionValue}&state={stateValue}&sort={sortValue}&severity={severityValue}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}