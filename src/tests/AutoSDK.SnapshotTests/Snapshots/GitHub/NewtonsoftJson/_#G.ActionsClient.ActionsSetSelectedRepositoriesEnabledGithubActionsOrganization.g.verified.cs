//HintName: G.ActionsClient.ActionsSetSelectedRepositoriesEnabledGithubActionsOrganization.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        partial void PrepareActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            global::G.ActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest request);
        partial void PrepareActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            global::G.ActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest request);
        partial void ProcessActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Set selected repositories enabled for GitHub Actions in an organization<br/>
        /// Replaces the list of selected repositories that are enabled for GitHub Actions in an organization. To use this endpoint, the organization permission policy for `enabled_repositories` must be configured to `selected`. For more information, see "[Set GitHub Actions permissions for an organization](#set-github-actions-permissions-for-an-organization)."<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationAsync(
            string org,
            global::G.ActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationArguments(
                httpClient: _httpClient,
                org: ref org,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/orgs/{org}/actions/permissions/repositories", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Set selected repositories enabled for GitHub Actions in an organization<br/>
        /// Replaces the list of selected repositories that are enabled for GitHub Actions in an organization. To use this endpoint, the organization permission policy for `enabled_repositories` must be configured to `selected`. For more information, see "[Set GitHub Actions permissions for an organization](#set-github-actions-permissions-for-an-organization)."<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="selectedRepositoryIds">
        /// List of repository IDs to enable for GitHub Actions.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationAsync(
            string org,
            global::System.Collections.Generic.IList<int> selectedRepositoryIds,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationRequest
            {
                SelectedRepositoryIds = selectedRepositoryIds,
            };

            await ActionsSetSelectedRepositoriesEnabledGithubActionsOrganizationAsync(
                org: org,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}