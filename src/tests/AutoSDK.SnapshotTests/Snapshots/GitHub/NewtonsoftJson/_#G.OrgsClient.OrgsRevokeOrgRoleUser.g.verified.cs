//HintName: G.OrgsClient.OrgsRevokeOrgRoleUser.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        partial void PrepareOrgsRevokeOrgRoleUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref string username,
            ref int roleId);
        partial void PrepareOrgsRevokeOrgRoleUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            string username,
            int roleId);
        partial void ProcessOrgsRevokeOrgRoleUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Remove an organization role from a user<br/>
        /// Remove an organization role from a user. For more information on organization roles, see "[Using organization roles](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/using-organization-roles)."<br/>
        /// The authenticated user must be an administrator for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="username"></param>
        /// <param name="roleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task OrgsRevokeOrgRoleUserAsync(
            string org,
            string username,
            int roleId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareOrgsRevokeOrgRoleUserArguments(
                httpClient: HttpClient,
                org: ref org,
                username: ref username,
                roleId: ref roleId);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/organization-roles/users/{username}/{roleId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareOrgsRevokeOrgRoleUserRequest(
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
            ProcessOrgsRevokeOrgRoleUserResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            __response.EnsureSuccessStatusCode();
        }
    }
}