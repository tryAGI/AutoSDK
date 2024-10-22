//HintName: G.ActionsClient.ActionsDisableSelectedRepositoryGithubActionsOrganization.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        partial void PrepareActionsDisableSelectedRepositoryGithubActionsOrganizationArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref int repositoryId);
        partial void PrepareActionsDisableSelectedRepositoryGithubActionsOrganizationRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            int repositoryId);
        partial void ProcessActionsDisableSelectedRepositoryGithubActionsOrganizationResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Disable a selected repository for GitHub Actions in an organization<br/>
        /// Removes a repository from the list of selected repositories that are enabled for GitHub Actions in an organization. To use this endpoint, the organization permission policy for `enabled_repositories` must be configured to `selected`. For more information, see "[Set GitHub Actions permissions for an organization](#set-github-actions-permissions-for-an-organization)."<br/>
        /// OAuth tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="repositoryId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ActionsDisableSelectedRepositoryGithubActionsOrganizationAsync(
            string org,
            int repositoryId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareActionsDisableSelectedRepositoryGithubActionsOrganizationArguments(
                httpClient: HttpClient,
                org: ref org,
                repositoryId: ref repositoryId);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/actions/permissions/repositories/{repositoryId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareActionsDisableSelectedRepositoryGithubActionsOrganizationRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                repositoryId: repositoryId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessActionsDisableSelectedRepositoryGithubActionsOrganizationResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            __response.EnsureSuccessStatusCode();
        }
    }
}