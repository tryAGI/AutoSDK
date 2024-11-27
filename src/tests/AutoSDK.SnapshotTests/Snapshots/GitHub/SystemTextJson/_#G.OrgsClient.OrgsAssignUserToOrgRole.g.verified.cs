//HintName: G.OrgsClient.OrgsAssignUserToOrgRole.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        partial void PrepareOrgsAssignUserToOrgRoleArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref string username,
            ref int roleId);
        partial void PrepareOrgsAssignUserToOrgRoleRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            string username,
            int roleId);
        partial void ProcessOrgsAssignUserToOrgRoleResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Assign an organization role to a user<br/>
        /// Assigns an organization role to a member of an organization. For more information on organization roles, see "[Using organization roles](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/using-organization-roles)."<br/>
        /// The authenticated user must be an administrator for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="username"></param>
        /// <param name="roleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task OrgsAssignUserToOrgRoleAsync(
            string org,
            string username,
            int roleId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareOrgsAssignUserToOrgRoleArguments(
                httpClient: HttpClient,
                org: ref org,
                username: ref username,
                roleId: ref roleId);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/organization-roles/users/{username}/{roleId}",
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
            PrepareOrgsAssignUserToOrgRoleRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                username: username,
                roleId: roleId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessOrgsAssignUserToOrgRoleResponse(
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