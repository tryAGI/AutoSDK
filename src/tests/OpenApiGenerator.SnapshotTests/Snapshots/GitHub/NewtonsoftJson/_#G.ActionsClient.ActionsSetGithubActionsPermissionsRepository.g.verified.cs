//HintName: G.ActionsClient.ActionsSetGithubActionsPermissionsRepository.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        partial void PrepareActionsSetGithubActionsPermissionsRepositoryArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            global::G.ActionsSetGithubActionsPermissionsRepositoryRequest request);
        partial void PrepareActionsSetGithubActionsPermissionsRepositoryRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            global::G.ActionsSetGithubActionsPermissionsRepositoryRequest request);
        partial void ProcessActionsSetGithubActionsPermissionsRepositoryResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Set GitHub Actions permissions for a repository<br/>
        /// Sets the GitHub Actions permissions policy for enabling GitHub Actions and allowed actions and reusable workflows in the repository.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ActionsSetGithubActionsPermissionsRepositoryAsync(
            string owner,
            string repo,
            global::G.ActionsSetGithubActionsPermissionsRepositoryRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareActionsSetGithubActionsPermissionsRepositoryArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/actions/permissions", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareActionsSetGithubActionsPermissionsRepositoryRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessActionsSetGithubActionsPermissionsRepositoryResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Set GitHub Actions permissions for a repository<br/>
        /// Sets the GitHub Actions permissions policy for enabling GitHub Actions and allowed actions and reusable workflows in the repository.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="enabled">
        /// Whether GitHub Actions is enabled on the repository.
        /// </param>
        /// <param name="allowedActions">
        /// The permissions policy that controls the actions and reusable workflows that are allowed to run.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ActionsSetGithubActionsPermissionsRepositoryAsync(
            string owner,
            string repo,
            bool enabled,
            global::G.AllowedActions? allowedActions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ActionsSetGithubActionsPermissionsRepositoryRequest
            {
                Enabled = enabled,
                AllowedActions = allowedActions,
            };

            await ActionsSetGithubActionsPermissionsRepositoryAsync(
                owner: owner,
                repo: repo,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}