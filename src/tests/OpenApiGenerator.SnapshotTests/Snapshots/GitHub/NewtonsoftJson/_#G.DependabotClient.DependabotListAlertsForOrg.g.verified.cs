//HintName: G.DependabotClient.DependabotListAlertsForOrg.g.cs

#nullable enable

namespace G
{
    public partial class DependabotClient
    {
        partial void PrepareDependabotListAlertsForOrgArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref string state,
            ref string severity,
            ref string ecosystem,
            ref string package,
            ref global::G.DependabotListAlertsForOrgScope scope,
            ref global::G.DependabotListAlertsForOrgSort sort,
            ref global::G.DependabotListAlertsForOrgDirection direction,
            ref string before,
            ref string after,
            ref int first,
            ref int last,
            ref int perPage);
        partial void PrepareDependabotListAlertsForOrgRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            string state,
            string severity,
            string ecosystem,
            string package,
            global::G.DependabotListAlertsForOrgScope scope,
            global::G.DependabotListAlertsForOrgSort sort,
            global::G.DependabotListAlertsForOrgDirection direction,
            string before,
            string after,
            int first,
            int last,
            int perPage);
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
            string state,
            string severity,
            string ecosystem,
            string package,
            global::G.DependabotListAlertsForOrgScope scope,
            global::G.DependabotListAlertsForOrgSort sort,
            global::G.DependabotListAlertsForOrgDirection direction,
            string before,
            string after,
            int first,
            int last,
            int perPage,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDependabotListAlertsForOrgArguments(
                httpClient: _httpClient,
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
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/orgs/{org}/dependabot/alerts?state={state}&severity={severity}&ecosystem={ecosystem}&package={package}&scope={scopeValue}&sort={sortValue}&direction={directionValue}&before={before}&after={after}&first={first}&last={last}&per_page={perPage}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDependabotListAlertsForOrgRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
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

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDependabotListAlertsForOrgResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDependabotListAlertsForOrgResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.DependabotAlertWithRepository>?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}