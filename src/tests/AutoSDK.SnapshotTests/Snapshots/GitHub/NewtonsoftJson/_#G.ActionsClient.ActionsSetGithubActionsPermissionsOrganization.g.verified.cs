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
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task ActionsSetGithubActionsPermissionsOrganizationAsync(
            string org,
            global::G.ActionsSetGithubActionsPermissionsOrganizationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareActionsSetGithubActionsPermissionsOrganizationArguments(
                httpClient: HttpClient,
                org: ref org,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/actions/permissions",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareActionsSetGithubActionsPermissionsOrganizationRequest(
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
            ProcessActionsSetGithubActionsPermissionsOrganizationResponse(
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
            global::G.EnabledRepositories enabledRepositories,
            global::G.AllowedActions? allowedActions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.ActionsSetGithubActionsPermissionsOrganizationRequest
            {
                EnabledRepositories = enabledRepositories,
                AllowedActions = allowedActions,
            };

            await ActionsSetGithubActionsPermissionsOrganizationAsync(
                org: org,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}