//HintName: G.ActionsClient.ActionsSetGithubActionsDefaultWorkflowPermissionsOrganization.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        partial void PrepareActionsSetGithubActionsDefaultWorkflowPermissionsOrganizationArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            global::G.ActionsSetDefaultWorkflowPermissions request);
        partial void PrepareActionsSetGithubActionsDefaultWorkflowPermissionsOrganizationRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            global::G.ActionsSetDefaultWorkflowPermissions request);
        partial void ProcessActionsSetGithubActionsDefaultWorkflowPermissionsOrganizationResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Set default workflow permissions for an organization<br/>
        /// Sets the default workflow permissions granted to the `GITHUB_TOKEN` when running workflows in an organization, and sets if GitHub Actions<br/>
        /// can submit approving pull request reviews. For more information, see<br/>
        /// "[Setting the permissions of the GITHUB_TOKEN for your organization](https://docs.github.com/organizations/managing-organization-settings/disabling-or-limiting-github-actions-for-your-organization#setting-the-permissions-of-the-github_token-for-your-organization)."<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task ActionsSetGithubActionsDefaultWorkflowPermissionsOrganizationAsync(
            string org,
            global::G.ActionsSetDefaultWorkflowPermissions request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareActionsSetGithubActionsDefaultWorkflowPermissionsOrganizationArguments(
                httpClient: HttpClient,
                org: ref org,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/actions/permissions/workflow",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareActionsSetGithubActionsDefaultWorkflowPermissionsOrganizationRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessActionsSetGithubActionsDefaultWorkflowPermissionsOrganizationResponse(
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

        /// <summary>
        /// Set default workflow permissions for an organization<br/>
        /// Sets the default workflow permissions granted to the `GITHUB_TOKEN` when running workflows in an organization, and sets if GitHub Actions<br/>
        /// can submit approving pull request reviews. For more information, see<br/>
        /// "[Setting the permissions of the GITHUB_TOKEN for your organization](https://docs.github.com/organizations/managing-organization-settings/disabling-or-limiting-github-actions-for-your-organization#setting-the-permissions-of-the-github_token-for-your-organization)."<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="defaultWorkflowPermissions">
        /// The default workflow permissions granted to the GITHUB_TOKEN when running workflows.
        /// </param>
        /// <param name="canApprovePullRequestReviews">
        /// Whether GitHub Actions can approve pull requests. Enabling this can be a security risk.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ActionsSetGithubActionsDefaultWorkflowPermissionsOrganizationAsync(
            string org,
            global::G.ActionsDefaultWorkflowPermissions? defaultWorkflowPermissions = default,
            bool? canApprovePullRequestReviews = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.ActionsSetDefaultWorkflowPermissions
            {
                DefaultWorkflowPermissions = defaultWorkflowPermissions,
                CanApprovePullRequestReviews = canApprovePullRequestReviews,
            };

            await ActionsSetGithubActionsDefaultWorkflowPermissionsOrganizationAsync(
                org: org,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}