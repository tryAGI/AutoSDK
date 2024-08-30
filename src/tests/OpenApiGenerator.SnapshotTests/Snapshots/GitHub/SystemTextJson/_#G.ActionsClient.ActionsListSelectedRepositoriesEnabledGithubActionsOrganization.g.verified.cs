//HintName: G.ActionsClient.ActionsListSelectedRepositoriesEnabledGithubActionsOrganization.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        partial void PrepareActionsListSelectedRepositoriesEnabledGithubActionsOrganizationArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref int perPage,
            ref int page);
        partial void PrepareActionsListSelectedRepositoriesEnabledGithubActionsOrganizationRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            int perPage,
            int page);
        partial void ProcessActionsListSelectedRepositoriesEnabledGithubActionsOrganizationResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessActionsListSelectedRepositoriesEnabledGithubActionsOrganizationResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List selected repositories enabled for GitHub Actions in an organization<br/>
        /// Lists the selected repositories that are enabled for GitHub Actions in an organization. To use this endpoint, the organization permission policy for `enabled_repositories` must be configured to `selected`. For more information, see "[Set GitHub Actions permissions for an organization](#set-github-actions-permissions-for-an-organization)."<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ActionsListSelectedRepositoriesEnabledGithubActionsOrganizationResponse> ActionsListSelectedRepositoriesEnabledGithubActionsOrganizationAsync(
            string org,
            int perPage = 30,
            int page = 1,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareActionsListSelectedRepositoriesEnabledGithubActionsOrganizationArguments(
                httpClient: _httpClient,
                org: ref org,
                perPage: ref perPage,
                page: ref page);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/orgs/{org}/actions/permissions/repositories?per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareActionsListSelectedRepositoriesEnabledGithubActionsOrganizationRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                perPage: perPage,
                page: page);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessActionsListSelectedRepositoriesEnabledGithubActionsOrganizationResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessActionsListSelectedRepositoriesEnabledGithubActionsOrganizationResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.ActionsListSelectedRepositoriesEnabledGithubActionsOrganizationResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}