//HintName: G.ActionsClient.ActionsEnableSelectedRepositoryGithubActionsOrganization.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        partial void PrepareActionsEnableSelectedRepositoryGithubActionsOrganizationArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref int repositoryId);
        partial void PrepareActionsEnableSelectedRepositoryGithubActionsOrganizationRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            int repositoryId);
        partial void ProcessActionsEnableSelectedRepositoryGithubActionsOrganizationResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Enable a selected repository for GitHub Actions in an organization<br/>
        /// Adds a repository to the list of selected repositories that are enabled for GitHub Actions in an organization. To use this endpoint, the organization permission policy for `enabled_repositories` must be must be configured to `selected`. For more information, see "[Set GitHub Actions permissions for an organization](#set-github-actions-permissions-for-an-organization)."<br/>
        /// OAuth tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="repositoryId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task ActionsEnableSelectedRepositoryGithubActionsOrganizationAsync(
            string org,
            int repositoryId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareActionsEnableSelectedRepositoryGithubActionsOrganizationArguments(
                httpClient: HttpClient,
                org: ref org,
                repositoryId: ref repositoryId);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/actions/permissions/repositories/{repositoryId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareActionsEnableSelectedRepositoryGithubActionsOrganizationRequest(
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
            ProcessActionsEnableSelectedRepositoryGithubActionsOrganizationResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::G.ApiException(
                    message: __response.ReasonPhrase ?? string.Empty,
                    innerException: __ex,
                    statusCode: __response.StatusCode)
                {
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
        }
    }
}