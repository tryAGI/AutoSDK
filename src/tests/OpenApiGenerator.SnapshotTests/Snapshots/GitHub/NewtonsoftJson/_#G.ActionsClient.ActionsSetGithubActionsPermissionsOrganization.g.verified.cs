//HintName: G.ActionsClient.ActionsSetGithubActionsPermissionsOrganization.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        partial void PrepareActionsSetGithubActionsPermissionsOrganizationArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            global::G.ActionsSetGithubActionsPermissionsOrganizationRequest request);
        partial void PrepareActionsSetGithubActionsPermissionsOrganizationRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            global::G.ActionsSetGithubActionsPermissionsOrganizationRequest request);
        partial void ProcessActionsSetGithubActionsPermissionsOrganizationResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Set GitHub Actions permissions for an organization<br/>
        /// Sets the GitHub Actions permissions policy for repositories and allowed actions and reusable workflows in an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ActionsSetGithubActionsPermissionsOrganizationAsync(
            string org,
            global::G.ActionsSetGithubActionsPermissionsOrganizationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareActionsSetGithubActionsPermissionsOrganizationArguments(
                httpClient: _httpClient,
                org: ref org,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/orgs/{org}/actions/permissions", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareActionsSetGithubActionsPermissionsOrganizationRequest(
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
            ProcessActionsSetGithubActionsPermissionsOrganizationResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Set GitHub Actions permissions for an organization<br/>
        /// Sets the GitHub Actions permissions policy for repositories and allowed actions and reusable workflows in an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="enabledRepositories">
        /// The policy that controls the repositories in the organization that are allowed to run GitHub Actions.
        /// </param>
        /// <param name="allowedActions">
        /// The permissions policy that controls the actions and reusable workflows that are allowed to run.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ActionsSetGithubActionsPermissionsOrganizationAsync(
            string org,
            global::G.EnabledRepositories? enabledRepositories,
            global::G.AllowedActions? allowedActions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ActionsSetGithubActionsPermissionsOrganizationRequest
            {
                EnabledRepositories = enabledRepositories,
                AllowedActions = allowedActions,
            };

            await ActionsSetGithubActionsPermissionsOrganizationAsync(
                org: org,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}