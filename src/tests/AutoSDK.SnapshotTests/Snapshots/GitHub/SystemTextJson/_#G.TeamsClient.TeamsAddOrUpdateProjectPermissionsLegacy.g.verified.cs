//HintName: G.TeamsClient.TeamsAddOrUpdateProjectPermissionsLegacy.g.cs

#nullable enable

namespace G
{
    public partial class TeamsClient
    {
        partial void PrepareTeamsAddOrUpdateProjectPermissionsLegacyArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int teamId,
            ref int projectId,
            global::G.TeamsAddOrUpdateProjectPermissionsLegacyRequest request);
        partial void PrepareTeamsAddOrUpdateProjectPermissionsLegacyRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int teamId,
            int projectId,
            global::G.TeamsAddOrUpdateProjectPermissionsLegacyRequest request);
        partial void ProcessTeamsAddOrUpdateProjectPermissionsLegacyResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Add or update team project permissions (Legacy)<br/>
        /// &gt; [!WARNING]<br/>
        /// &gt; **Deprecation notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Add or update team project permissions](https://docs.github.com/rest/teams/teams#add-or-update-team-project-permissions) endpoint.<br/>
        /// Adds an organization project to a team. To add a project to a team or update the team's permission on a project, the authenticated user must have `admin` permissions for the project. The project and team must be part of the same organization.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task TeamsAddOrUpdateProjectPermissionsLegacyAsync(
            int teamId,
            int projectId,
            global::G.TeamsAddOrUpdateProjectPermissionsLegacyRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareTeamsAddOrUpdateProjectPermissionsLegacyArguments(
                httpClient: HttpClient,
                teamId: ref teamId,
                projectId: ref projectId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/teams/{teamId}/projects/{projectId}",
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
            PrepareTeamsAddOrUpdateProjectPermissionsLegacyRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                teamId: teamId,
                projectId: projectId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessTeamsAddOrUpdateProjectPermissionsLegacyResponse(
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
        /// Add or update team project permissions (Legacy)<br/>
        /// &gt; [!WARNING]<br/>
        /// &gt; **Deprecation notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Add or update team project permissions](https://docs.github.com/rest/teams/teams#add-or-update-team-project-permissions) endpoint.<br/>
        /// Adds an organization project to a team. To add a project to a team or update the team's permission on a project, the authenticated user must have `admin` permissions for the project. The project and team must be part of the same organization.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="projectId"></param>
        /// <param name="permission">
        /// The permission to grant to the team for this project. Default: the team's `permission` attribute will be used to determine what permission to grant the team on this project. Note that, if you choose not to pass any parameters, you'll need to set `Content-Length` to zero when calling this endpoint. For more information, see "[HTTP method](https://docs.github.com/rest/guides/getting-started-with-the-rest-api#http-method)."
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task TeamsAddOrUpdateProjectPermissionsLegacyAsync(
            int teamId,
            int projectId,
            global::G.TeamsAddOrUpdateProjectPermissionsLegacyRequestPermission? permission = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.TeamsAddOrUpdateProjectPermissionsLegacyRequest
            {
                Permission = permission,
            };

            await TeamsAddOrUpdateProjectPermissionsLegacyAsync(
                teamId: teamId,
                projectId: projectId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}