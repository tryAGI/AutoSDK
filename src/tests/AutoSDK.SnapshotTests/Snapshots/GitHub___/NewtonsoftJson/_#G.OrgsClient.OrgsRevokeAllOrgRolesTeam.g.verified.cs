//HintName: G.OrgsClient.OrgsRevokeAllOrgRolesTeam.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        partial void PrepareOrgsRevokeAllOrgRolesTeamArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref string teamSlug);
        partial void PrepareOrgsRevokeAllOrgRolesTeamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            string teamSlug);
        partial void ProcessOrgsRevokeAllOrgRolesTeamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Remove all organization roles for a team<br/>
        /// Removes all assigned organization roles from a team. For more information on organization roles, see "[Using organization roles](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/using-organization-roles)."<br/>
        /// The authenticated user must be an administrator for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="teamSlug"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task OrgsRevokeAllOrgRolesTeamAsync(
            string org,
            string teamSlug,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareOrgsRevokeAllOrgRolesTeamArguments(
                httpClient: HttpClient,
                org: ref org,
                teamSlug: ref teamSlug);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/organization-roles/teams/{teamSlug}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareOrgsRevokeAllOrgRolesTeamRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                teamSlug: teamSlug);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessOrgsRevokeAllOrgRolesTeamResponse(
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