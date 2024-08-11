//HintName: G.ActionsClient.ActionsSetGithubActionsDefaultWorkflowPermissionsRepository.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        partial void PrepareActionsSetGithubActionsDefaultWorkflowPermissionsRepositoryArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            global::G.ActionsSetDefaultWorkflowPermissions request);
        partial void PrepareActionsSetGithubActionsDefaultWorkflowPermissionsRepositoryRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            global::G.ActionsSetDefaultWorkflowPermissions request);
        partial void ProcessActionsSetGithubActionsDefaultWorkflowPermissionsRepositoryResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Set default workflow permissions for a repository<br/>
        /// Sets the default workflow permissions granted to the `GITHUB_TOKEN` when running workflows in a repository, and sets if GitHub Actions<br/>
        /// can submit approving pull request reviews.<br/>
        /// For more information, see "[Setting the permissions of the GITHUB_TOKEN for your repository](https://docs.github.com/repositories/managing-your-repositorys-settings-and-features/enabling-features-for-your-repository/managing-github-actions-settings-for-a-repository#setting-the-permissions-of-the-github_token-for-your-repository)."<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ActionsSetGithubActionsDefaultWorkflowPermissionsRepositoryAsync(
            string owner,
            string repo,
            global::G.ActionsSetDefaultWorkflowPermissions request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareActionsSetGithubActionsDefaultWorkflowPermissionsRepositoryArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/actions/permissions/workflow", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareActionsSetGithubActionsDefaultWorkflowPermissionsRepositoryRequest(
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
            ProcessActionsSetGithubActionsDefaultWorkflowPermissionsRepositoryResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Set default workflow permissions for a repository<br/>
        /// Sets the default workflow permissions granted to the `GITHUB_TOKEN` when running workflows in a repository, and sets if GitHub Actions<br/>
        /// can submit approving pull request reviews.<br/>
        /// For more information, see "[Setting the permissions of the GITHUB_TOKEN for your repository](https://docs.github.com/repositories/managing-your-repositorys-settings-and-features/enabling-features-for-your-repository/managing-github-actions-settings-for-a-repository#setting-the-permissions-of-the-github_token-for-your-repository)."<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="defaultWorkflowPermissions">
        /// The default workflow permissions granted to the GITHUB_TOKEN when running workflows.
        /// </param>
        /// <param name="canApprovePullRequestReviews">
        /// Whether GitHub Actions can approve pull requests. Enabling this can be a security risk.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ActionsSetGithubActionsDefaultWorkflowPermissionsRepositoryAsync(
            string owner,
            string repo,
            global::G.ActionsDefaultWorkflowPermissions? defaultWorkflowPermissions = default,
            bool canApprovePullRequestReviews = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ActionsSetDefaultWorkflowPermissions
            {
                DefaultWorkflowPermissions = defaultWorkflowPermissions,
                CanApprovePullRequestReviews = canApprovePullRequestReviews,
            };

            await ActionsSetGithubActionsDefaultWorkflowPermissionsRepositoryAsync(
                owner: owner,
                repo: repo,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}