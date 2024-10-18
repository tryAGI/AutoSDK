//HintName: G.CodeScanningClient.CodeScanningListAlertsForRepo.g.cs

#nullable enable

namespace G
{
    public partial class CodeScanningClient
    {
        partial void PrepareCodeScanningListAlertsForRepoArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref string? toolName,
            ref string? toolGuid,
            ref int? page,
            ref int? perPage,
            ref string? @ref,
            ref int? pr,
            ref global::G.CodeScanningListAlertsForRepoDirection? direction,
            ref string? before,
            ref string? after,
            ref global::G.CodeScanningListAlertsForRepoSort? sort,
            ref global::G.CodeScanningAlertStateQuery? state,
            ref global::G.CodeScanningAlertSeverity? severity);
        partial void PrepareCodeScanningListAlertsForRepoRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            string? toolName,
            string? toolGuid,
            int? page,
            int? perPage,
            string? @ref,
            int? pr,
            global::G.CodeScanningListAlertsForRepoDirection? direction,
            string? before,
            string? after,
            global::G.CodeScanningListAlertsForRepoSort? sort,
            global::G.CodeScanningAlertStateQuery? state,
            global::G.CodeScanningAlertSeverity? severity);
        partial void ProcessCodeScanningListAlertsForRepoResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCodeScanningListAlertsForRepoResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List code scanning alerts for a repository<br/>
        /// Lists code scanning alerts.<br/>
        /// The response includes a `most_recent_instance` object.<br/>
        /// This provides details of the most recent instance of this alert<br/>
        /// for the default branch (or for the specified Git reference if you used `ref` in the request).<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="toolName">
        /// The name of the tool used to generate the code scanning analysis.
        /// </param>
        /// <param name="toolGuid">
        /// The GUID of the tool used to generate the code scanning analysis, if provided in the uploaded SARIF data.
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="ref">
        /// The Git reference, formatted as `refs/pull/&lt;number&gt;/merge`, `refs/pull/&lt;number&gt;/head`,<br/>
        /// `refs/heads/&lt;branch name&gt;` or simply `&lt;branch name&gt;`.
        /// </param>
        /// <param name="pr"></param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="state">
        /// State of a code scanning alert.
        /// </param>
        /// <param name="severity">
        /// Severity of a code scanning alert.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.CodeScanningAlertItems>> CodeScanningListAlertsForRepoAsync(
            string owner,
            string repo,
            string? toolName = default,
            string? toolGuid = default,
            int? page = 1,
            int? perPage = 30,
            string? @ref = default,
            int? pr = default,
            global::G.CodeScanningListAlertsForRepoDirection? direction = global::G.CodeScanningListAlertsForRepoDirection.Desc,
            string? before = default,
            string? after = default,
            global::G.CodeScanningListAlertsForRepoSort? sort = global::G.CodeScanningListAlertsForRepoSort.Created,
            global::G.CodeScanningAlertStateQuery? state = default,
            global::G.CodeScanningAlertSeverity? severity = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareCodeScanningListAlertsForRepoArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                toolName: ref toolName,
                toolGuid: ref toolGuid,
                page: ref page,
                perPage: ref perPage,
                @ref: ref @ref,
                pr: ref pr,
                direction: ref direction,
                before: ref before,
                after: ref after,
                sort: ref sort,
                state: ref state,
                severity: ref severity);

            var directionValue = direction switch
            {
                global::G.CodeScanningListAlertsForRepoDirection.Asc => "asc",
                global::G.CodeScanningListAlertsForRepoDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var sortValue = sort switch
            {
                global::G.CodeScanningListAlertsForRepoSort.Created => "created",
                global::G.CodeScanningListAlertsForRepoSort.Updated => "updated",
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
                path: $"/repos/{owner}/{repo}/code-scanning/alerts",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("tool_name", toolName) 
                .AddOptionalParameter("tool_guid", toolGuid) 
                .AddOptionalParameter("page", page?.ToString()) 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                .AddOptionalParameter("ref", @ref) 
                .AddOptionalParameter("pr", pr?.ToString()) 
                .AddOptionalParameter("direction", directionValue?.ToString()) 
                .AddOptionalParameter("before", before) 
                .AddOptionalParameter("after", after) 
                .AddOptionalParameter("sort", sortValue?.ToString()) 
                .AddOptionalParameter("state", stateValue?.ToString()) 
                .AddOptionalParameter("severity", severityValue?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCodeScanningListAlertsForRepoRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                toolName: toolName,
                toolGuid: toolGuid,
                page: page,
                perPage: perPage,
                @ref: @ref,
                pr: pr,
                direction: direction,
                before: before,
                after: after,
                sort: sort,
                state: state,
                severity: severity);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCodeScanningListAlertsForRepoResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCodeScanningListAlertsForRepoResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.CodeScanningAlertItems>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}