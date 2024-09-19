//HintName: G.DependabotClient.DependabotListAlertsForEnterprise.g.cs

#nullable enable

namespace G
{
    public partial class DependabotClient
    {
        partial void PrepareDependabotListAlertsForEnterpriseArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string enterprise,
            ref string? state,
            ref string? severity,
            ref string? ecosystem,
            ref string? package,
            ref global::G.DependabotListAlertsForEnterpriseScope? scope,
            ref global::G.DependabotListAlertsForEnterpriseSort? sort,
            ref global::G.DependabotListAlertsForEnterpriseDirection? direction,
            ref string? before,
            ref string? after,
            ref int? first,
            ref int? last,
            ref int? perPage);
        partial void PrepareDependabotListAlertsForEnterpriseRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string enterprise,
            string? state,
            string? severity,
            string? ecosystem,
            string? package,
            global::G.DependabotListAlertsForEnterpriseScope? scope,
            global::G.DependabotListAlertsForEnterpriseSort? sort,
            global::G.DependabotListAlertsForEnterpriseDirection? direction,
            string? before,
            string? after,
            int? first,
            int? last,
            int? perPage);
        partial void ProcessDependabotListAlertsForEnterpriseResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDependabotListAlertsForEnterpriseResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Dependabot alerts for an enterprise<br/>
        /// Lists Dependabot alerts for repositories that are owned by the specified enterprise.<br/>
        /// The authenticated user must be a member of the enterprise to use this endpoint.<br/>
        /// Alerts are only returned for organizations in the enterprise for which you are an organization owner or a security manager. For more information about security managers, see "[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization)."<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `security_events` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="state"></param>
        /// <param name="severity"></param>
        /// <param name="ecosystem"></param>
        /// <param name="package"></param>
        /// <param name="scope"></param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="first">
        /// Default Value: 30
        /// </param>
        /// <param name="last"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.DependabotAlertWithRepository>> DependabotListAlertsForEnterpriseAsync(
            string enterprise,
            string? state = default,
            string? severity = default,
            string? ecosystem = default,
            string? package = default,
            global::G.DependabotListAlertsForEnterpriseScope? scope = default,
            global::G.DependabotListAlertsForEnterpriseSort? sort = global::G.DependabotListAlertsForEnterpriseSort.Created,
            global::G.DependabotListAlertsForEnterpriseDirection? direction = global::G.DependabotListAlertsForEnterpriseDirection.Desc,
            string? before = default,
            string? after = default,
            int? first = 30,
            int? last = default,
            int? perPage = 30,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDependabotListAlertsForEnterpriseArguments(
                httpClient: _httpClient,
                enterprise: ref enterprise,
                state: ref state,
                severity: ref severity,
                ecosystem: ref ecosystem,
                package: ref package,
                scope: ref scope,
                sort: ref sort,
                direction: ref direction,
                before: ref before,
                after: ref after,
                first: ref first,
                last: ref last,
                perPage: ref perPage);

            var scopeValue = scope switch
            {
                global::G.DependabotListAlertsForEnterpriseScope.Development => "development",
                global::G.DependabotListAlertsForEnterpriseScope.Runtime => "runtime",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var sortValue = sort switch
            {
                global::G.DependabotListAlertsForEnterpriseSort.Created => "created",
                global::G.DependabotListAlertsForEnterpriseSort.Updated => "updated",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var directionValue = direction switch
            {
                global::G.DependabotListAlertsForEnterpriseDirection.Asc => "asc",
                global::G.DependabotListAlertsForEnterpriseDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: $"/enterprises/{enterprise}/dependabot/alerts",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("state", state) 
                .AddOptionalParameter("severity", severity) 
                .AddOptionalParameter("ecosystem", ecosystem) 
                .AddOptionalParameter("package", package) 
                .AddOptionalParameter("scope", scopeValue?.ToString()) 
                .AddOptionalParameter("sort", sortValue?.ToString()) 
                .AddOptionalParameter("direction", directionValue?.ToString()) 
                .AddOptionalParameter("before", before) 
                .AddOptionalParameter("after", after) 
                .AddOptionalParameter("first", first?.ToString()) 
                .AddOptionalParameter("last", last?.ToString()) 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDependabotListAlertsForEnterpriseRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                enterprise: enterprise,
                state: state,
                severity: severity,
                ecosystem: ecosystem,
                package: package,
                scope: scope,
                sort: sort,
                direction: direction,
                before: before,
                after: after,
                first: first,
                last: last,
                perPage: perPage);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDependabotListAlertsForEnterpriseResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDependabotListAlertsForEnterpriseResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.DependabotAlertWithRepository>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}