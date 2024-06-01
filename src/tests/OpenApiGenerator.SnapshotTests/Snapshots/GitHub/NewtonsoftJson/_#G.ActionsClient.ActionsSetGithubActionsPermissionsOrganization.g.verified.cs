//HintName: G.ActionsClient.ActionsSetGithubActionsPermissionsOrganization.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        /// <summary>
        /// Set GitHub Actions permissions for an organization
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ActionsSetGithubActionsPermissionsOrganizationAsync(
            string org,
            ActionsSetGithubActionsPermissionsOrganizationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/actions/permissions", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Set GitHub Actions permissions for an organization
        /// </summary>
        /// <param name="org"></param>
        /// <param name="enabledRepositories"></param>
        /// <param name="allowedActions"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ActionsSetGithubActionsPermissionsOrganizationAsync(
            string org,
            ActionsSetGithubActionsPermissionsOrganizationRequestEnabledRepositories enabledRepositories,
            ActionsSetGithubActionsPermissionsOrganizationRequestAllowedActions? allowedActions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ActionsSetGithubActionsPermissionsOrganizationRequest
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