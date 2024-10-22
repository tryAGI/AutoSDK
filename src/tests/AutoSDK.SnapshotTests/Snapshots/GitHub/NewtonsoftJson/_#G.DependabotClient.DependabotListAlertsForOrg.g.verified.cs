//HintName: G.DependabotClient.DependabotListAlertsForOrg.g.cs

#nullable enable

namespace G
{
    public partial class DependabotClient
    {
        partial void PrepareDependabotListAlertsForOrgArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref string? state,
            ref string? severity,
            ref string? ecosystem,
            ref string? package,
            ref global::G.DependabotListAlertsForOrgScope? scope,
            ref global::G.DependabotListAlertsForOrgSort? sort,
            ref global::G.DependabotListAlertsForOrgDirection? direction,
            ref string? before,
            ref string? after,
            ref int? first,
            ref int? last,
            ref int? perPage);
        partial void PrepareDependabotListAlertsForOrgRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            string? state,
            string? severity,
            string? ecosystem,
            string? package,
            global::G.DependabotListAlertsForOrgScope? scope,
            global::G.DependabotListAlertsForOrgSort? sort,
            global::G.DependabotListAlertsForOrgDirection? direction,
            string? before,
            string? after,
            int? first,
            int? last,
            int? perPage);
        partial void ProcessDependabotListAlertsForOrgResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDependabotListAlertsForOrgResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Dependabot alerts for an organization<br/>
        /// Lists Dependabot alerts for an organization.<br/>
        /// The authenticated user must be an owner or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint. If this endpoint is only used with public repositories, the token can use the `public_repo` scope instead.
        /// </summary>
        /// <param name="org"></param>
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
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.DependabotAlertWithRepository>> DependabotListAlertsForOrgAsync(
            string org,
            string? state = default,
            string? severity = default,
            string? ecosystem = default,
            string? package = default,
            global::G.DependabotListAlertsForOrgScope? scope = default,
            global::G.DependabotListAlertsForOrgSort? sort = global::G.DependabotListAlertsForOrgSort.Created,
            global::G.DependabotListAlertsForOrgDirection? direction = global::G.DependabotListAlertsForOrgDirection.Desc,
            string? before = default,
            string? after = default,
            int? first = 30,
            int? last = default,
            int? perPage = 30,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareDependabotListAlertsForOrgArguments(
                httpClient: HttpClient,
                org: ref org,
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
                global::G.DependabotListAlertsForOrgScope.Development => "development",
                global::G.DependabotListAlertsForOrgScope.Runtime => "runtime",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var sortValue = sort switch
            {
                global::G.DependabotListAlertsForOrgSort.Created => "created",
                global::G.DependabotListAlertsForOrgSort.Updated => "updated",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var directionValue = direction switch
            {
                global::G.DependabotListAlertsForOrgDirection.Asc => "asc",
                global::G.DependabotListAlertsForOrgDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/dependabot/alerts",
                baseUri: HttpClient.BaseAddress); 
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
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareDependabotListAlertsForOrgRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
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

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessDependabotListAlertsForOrgResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessDependabotListAlertsForOrgResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.DependabotAlertWithRepository>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}