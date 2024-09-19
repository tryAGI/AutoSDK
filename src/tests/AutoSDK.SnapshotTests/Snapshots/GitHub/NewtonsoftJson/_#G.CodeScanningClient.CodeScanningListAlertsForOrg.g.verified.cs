//HintName: G.CodeScanningClient.CodeScanningListAlertsForOrg.g.cs

#nullable enable

namespace G
{
    public partial class CodeScanningClient
    {
        partial void PrepareCodeScanningListAlertsForOrgArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref string? toolName,
            ref string? toolGuid,
            ref string? before,
            ref string? after,
            ref int? page,
            ref int? perPage,
            ref global::G.CodeScanningListAlertsForOrgDirection? direction,
            ref global::G.CodeScanningAlertStateQuery? state,
            ref global::G.CodeScanningListAlertsForOrgSort? sort,
            ref global::G.CodeScanningAlertSeverity? severity);
        partial void PrepareCodeScanningListAlertsForOrgRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            string? toolName,
            string? toolGuid,
            string? before,
            string? after,
            int? page,
            int? perPage,
            global::G.CodeScanningListAlertsForOrgDirection? direction,
            global::G.CodeScanningAlertStateQuery? state,
            global::G.CodeScanningListAlertsForOrgSort? sort,
            global::G.CodeScanningAlertSeverity? severity);
        partial void ProcessCodeScanningListAlertsForOrgResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCodeScanningListAlertsForOrgResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List code scanning alerts for an organization<br/>
        /// Lists code scanning alerts for the default branch for all eligible repositories in an organization. Eligible repositories are repositories that are owned by organizations that you own or for which you are a security manager. For more information, see "[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization)."<br/>
        /// The authenticated user must be an owner or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `security_events` or `repo`s cope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="toolName">
        /// The name of the tool used to generate the code scanning analysis.
        /// </param>
        /// <param name="toolGuid">
        /// The GUID of the tool used to generate the code scanning analysis, if provided in the uploaded SARIF data.
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="state">
        /// State of a code scanning alert.
        /// </param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="severity">
        /// Severity of a code scanning alert.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.CodeScanningOrganizationAlertItems>> CodeScanningListAlertsForOrgAsync(
            string org,
            string? toolName = default,
            string? toolGuid = default,
            string? before = default,
            string? after = default,
            int? page = 1,
            int? perPage = 30,
            global::G.CodeScanningListAlertsForOrgDirection? direction = global::G.CodeScanningListAlertsForOrgDirection.Desc,
            global::G.CodeScanningAlertStateQuery? state = default,
            global::G.CodeScanningListAlertsForOrgSort? sort = global::G.CodeScanningListAlertsForOrgSort.Created,
            global::G.CodeScanningAlertSeverity? severity = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareCodeScanningListAlertsForOrgArguments(
                httpClient: _httpClient,
                org: ref org,
                toolName: ref toolName,
                toolGuid: ref toolGuid,
                before: ref before,
                after: ref after,
                page: ref page,
                perPage: ref perPage,
                direction: ref direction,
                state: ref state,
                sort: ref sort,
                severity: ref severity);

            var directionValue = direction switch
            {
                global::G.CodeScanningListAlertsForOrgDirection.Asc => "asc",
                global::G.CodeScanningListAlertsForOrgDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var stateValue = state switch
            {
                global::G.CodeScanningAlertStateQuery.Open => "open",
                global::G.CodeScanningAlertStateQuery.Closed => "closed",
                global::G.CodeScanningAlertStateQuery.Dismissed => "dismissed",
                global::G.CodeScanningAlertStateQuery.Fixed => "fixed",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var sortValue = sort switch
            {
                global::G.CodeScanningListAlertsForOrgSort.Created => "created",
                global::G.CodeScanningListAlertsForOrgSort.Updated => "updated",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var severityValue = severity switch
            {
                global::G.CodeScanningAlertSeverity.Critical => "critical",
                global::G.CodeScanningAlertSeverity.High => "high",
                global::G.CodeScanningAlertSeverity.Medium => "medium",
                global::G.CodeScanningAlertSeverity.Low => "low",
                global::G.CodeScanningAlertSeverity.Warning => "warning",
                global::G.CodeScanningAlertSeverity.Note => "note",
                global::G.CodeScanningAlertSeverity.Error => "error",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/code-scanning/alerts",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("tool_name", toolName) 
                .AddOptionalParameter("tool_guid", toolGuid) 
                .AddOptionalParameter("before", before) 
                .AddOptionalParameter("after", after) 
                .AddOptionalParameter("page", page?.ToString()) 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                .AddOptionalParameter("direction", directionValue?.ToString()) 
                .AddOptionalParameter("state", stateValue?.ToString()) 
                .AddOptionalParameter("sort", sortValue?.ToString()) 
                .AddOptionalParameter("severity", severityValue?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCodeScanningListAlertsForOrgRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                toolName: toolName,
                toolGuid: toolGuid,
                before: before,
                after: after,
                page: page,
                perPage: perPage,
                direction: direction,
                state: state,
                sort: sort,
                severity: severity);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCodeScanningListAlertsForOrgResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCodeScanningListAlertsForOrgResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.CodeScanningOrganizationAlertItems>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}