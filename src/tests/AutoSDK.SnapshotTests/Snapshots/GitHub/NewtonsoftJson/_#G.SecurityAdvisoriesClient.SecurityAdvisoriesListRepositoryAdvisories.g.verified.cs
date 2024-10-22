//HintName: G.SecurityAdvisoriesClient.SecurityAdvisoriesListRepositoryAdvisories.g.cs

#nullable enable

namespace G
{
    public partial class SecurityAdvisoriesClient
    {
        partial void PrepareSecurityAdvisoriesListRepositoryAdvisoriesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref global::G.SecurityAdvisoriesListRepositoryAdvisoriesDirection? direction,
            ref global::G.SecurityAdvisoriesListRepositoryAdvisoriesSort? sort,
            ref string? before,
            ref string? after,
            ref int? perPage,
            ref global::G.SecurityAdvisoriesListRepositoryAdvisoriesState? state);
        partial void PrepareSecurityAdvisoriesListRepositoryAdvisoriesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            global::G.SecurityAdvisoriesListRepositoryAdvisoriesDirection? direction,
            global::G.SecurityAdvisoriesListRepositoryAdvisoriesSort? sort,
            string? before,
            string? after,
            int? perPage,
            global::G.SecurityAdvisoriesListRepositoryAdvisoriesState? state);
        partial void ProcessSecurityAdvisoriesListRepositoryAdvisoriesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSecurityAdvisoriesListRepositoryAdvisoriesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List repository security advisories<br/>
        /// Lists security advisories in a repository.<br/>
        /// The authenticated user can access unpublished security advisories from a repository if they are a security manager or administrator of that repository, or if they are a collaborator on any security advisory.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `repository_advisories:read` scope to to get a published security advisory in a private repository, or any unpublished security advisory that the authenticated user has access to.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
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
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.RepositoryAdvisory>> SecurityAdvisoriesListRepositoryAdvisoriesAsync(
            string owner,
            string repo,
            global::G.SecurityAdvisoriesListRepositoryAdvisoriesDirection? direction = global::G.SecurityAdvisoriesListRepositoryAdvisoriesDirection.Desc,
            global::G.SecurityAdvisoriesListRepositoryAdvisoriesSort? sort = global::G.SecurityAdvisoriesListRepositoryAdvisoriesSort.Created,
            string? before = default,
            string? after = default,
            int? perPage = 30,
            global::G.SecurityAdvisoriesListRepositoryAdvisoriesState? state = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareSecurityAdvisoriesListRepositoryAdvisoriesArguments(
                httpClient: HttpClient,
                owner: ref owner,
                repo: ref repo,
                direction: ref direction,
                sort: ref sort,
                before: ref before,
                after: ref after,
                perPage: ref perPage,
                state: ref state);

            var directionValue = direction switch
            {
                global::G.SecurityAdvisoriesListRepositoryAdvisoriesDirection.Asc => "asc",
                global::G.SecurityAdvisoriesListRepositoryAdvisoriesDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var sortValue = sort switch
            {
                global::G.SecurityAdvisoriesListRepositoryAdvisoriesSort.Created => "created",
                global::G.SecurityAdvisoriesListRepositoryAdvisoriesSort.Updated => "updated",
                global::G.SecurityAdvisoriesListRepositoryAdvisoriesSort.Published => "published",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var stateValue = state switch
            {
                global::G.SecurityAdvisoriesListRepositoryAdvisoriesState.Triage => "triage",
                global::G.SecurityAdvisoriesListRepositoryAdvisoriesState.Draft => "draft",
                global::G.SecurityAdvisoriesListRepositoryAdvisoriesState.Published => "published",
                global::G.SecurityAdvisoriesListRepositoryAdvisoriesState.Closed => "closed",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/security-advisories",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("direction", directionValue?.ToString()) 
                .AddOptionalParameter("sort", sortValue?.ToString()) 
                .AddOptionalParameter("before", before) 
                .AddOptionalParameter("after", after) 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                .AddOptionalParameter("state", stateValue?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareSecurityAdvisoriesListRepositoryAdvisoriesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                owner: owner,
                repo: repo,
                direction: direction,
                sort: sort,
                before: before,
                after: after,
                perPage: perPage,
                state: state);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessSecurityAdvisoriesListRepositoryAdvisoriesResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessSecurityAdvisoriesListRepositoryAdvisoriesResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.RepositoryAdvisory>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}