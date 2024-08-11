//HintName: G.SecurityAdvisoriesClient.SecurityAdvisoriesListOrgRepositoryAdvisories.g.cs

#nullable enable

namespace G
{
    public partial class SecurityAdvisoriesClient
    {
        partial void PrepareSecurityAdvisoriesListOrgRepositoryAdvisoriesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref global::G.SecurityAdvisoriesListOrgRepositoryAdvisoriesDirection? direction,
            ref global::G.SecurityAdvisoriesListOrgRepositoryAdvisoriesSort? sort,
            ref string? before,
            ref string? after,
            ref int perPage,
            ref global::G.SecurityAdvisoriesListOrgRepositoryAdvisoriesState? state);
        partial void PrepareSecurityAdvisoriesListOrgRepositoryAdvisoriesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            global::G.SecurityAdvisoriesListOrgRepositoryAdvisoriesDirection? direction,
            global::G.SecurityAdvisoriesListOrgRepositoryAdvisoriesSort? sort,
            string? before,
            string? after,
            int perPage,
            global::G.SecurityAdvisoriesListOrgRepositoryAdvisoriesState? state);
        partial void ProcessSecurityAdvisoriesListOrgRepositoryAdvisoriesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSecurityAdvisoriesListOrgRepositoryAdvisoriesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List repository security advisories for an organization<br/>
        /// Lists repository security advisories for an organization.<br/>
        /// The authenticated user must be an owner or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `repository_advisories:write` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="state"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.RepositoryAdvisory>> SecurityAdvisoriesListOrgRepositoryAdvisoriesAsync(
            string org,
            global::G.SecurityAdvisoriesListOrgRepositoryAdvisoriesDirection? direction,
            global::G.SecurityAdvisoriesListOrgRepositoryAdvisoriesSort? sort,
            string? before,
            string? after,
            int perPage,
            global::G.SecurityAdvisoriesListOrgRepositoryAdvisoriesState? state,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareSecurityAdvisoriesListOrgRepositoryAdvisoriesArguments(
                httpClient: _httpClient,
                org: ref org,
                direction: ref direction,
                sort: ref sort,
                before: ref before,
                after: ref after,
                perPage: ref perPage,
                state: ref state);

            var directionValue = direction switch
            {
                global::G.SecurityAdvisoriesListOrgRepositoryAdvisoriesDirection.Asc => "asc",
                global::G.SecurityAdvisoriesListOrgRepositoryAdvisoriesDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var sortValue = sort switch
            {
                global::G.SecurityAdvisoriesListOrgRepositoryAdvisoriesSort.Created => "created",
                global::G.SecurityAdvisoriesListOrgRepositoryAdvisoriesSort.Updated => "updated",
                global::G.SecurityAdvisoriesListOrgRepositoryAdvisoriesSort.Published => "published",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var stateValue = state switch
            {
                global::G.SecurityAdvisoriesListOrgRepositoryAdvisoriesState.Triage => "triage",
                global::G.SecurityAdvisoriesListOrgRepositoryAdvisoriesState.Draft => "draft",
                global::G.SecurityAdvisoriesListOrgRepositoryAdvisoriesState.Published => "published",
                global::G.SecurityAdvisoriesListOrgRepositoryAdvisoriesState.Closed => "closed",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/orgs/{org}/security-advisories?direction={directionValue}&sort={sortValue}&before={before}&after={after}&per_page={perPage}&state={stateValue}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareSecurityAdvisoriesListOrgRepositoryAdvisoriesRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                direction: direction,
                sort: sort,
                before: before,
                after: after,
                perPage: perPage,
                state: state);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessSecurityAdvisoriesListOrgRepositoryAdvisoriesResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessSecurityAdvisoriesListOrgRepositoryAdvisoriesResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.RepositoryAdvisory>?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}