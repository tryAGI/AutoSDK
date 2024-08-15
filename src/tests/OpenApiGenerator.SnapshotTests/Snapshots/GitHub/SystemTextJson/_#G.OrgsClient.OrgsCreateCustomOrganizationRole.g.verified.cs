//HintName: G.OrgsClient.OrgsCreateCustomOrganizationRole.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        partial void PrepareOrgsCreateCustomOrganizationRoleArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            global::G.OrgsCreateCustomOrganizationRoleRequest request);
        partial void PrepareOrgsCreateCustomOrganizationRoleRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            global::G.OrgsCreateCustomOrganizationRoleRequest request);
        partial void ProcessOrgsCreateCustomOrganizationRoleResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOrgsCreateCustomOrganizationRoleResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a custom organization role<br/>
        /// Creates a custom organization role that can be assigned to users and teams, granting them specific permissions over the organization. For more information on custom organization roles, see "[Managing people's access to your organization with roles](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/about-custom-organization-roles)."<br/>
        /// To use this endpoint, the authenticated user must be one of:<br/>
        /// - An administrator for the organization.<br/>
        /// - A user, or a user on a team, with the fine-grained permissions of `write_organization_custom_org_role` in the organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OrganizationRole> OrgsCreateCustomOrganizationRoleAsync(
            string org,
            global::G.OrgsCreateCustomOrganizationRoleRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareOrgsCreateCustomOrganizationRoleArguments(
                httpClient: _httpClient,
                org: ref org,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/orgs/{org}/organization-roles", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareOrgsCreateCustomOrganizationRoleRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessOrgsCreateCustomOrganizationRoleResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessOrgsCreateCustomOrganizationRoleResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.OrganizationRole?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a custom organization role<br/>
        /// Creates a custom organization role that can be assigned to users and teams, granting them specific permissions over the organization. For more information on custom organization roles, see "[Managing people's access to your organization with roles](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/about-custom-organization-roles)."<br/>
        /// To use this endpoint, the authenticated user must be one of:<br/>
        /// - An administrator for the organization.<br/>
        /// - A user, or a user on a team, with the fine-grained permissions of `write_organization_custom_org_role` in the organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="name">
        /// The name of the custom role.
        /// </param>
        /// <param name="description">
        /// A short description about the intended usage of this role or what permissions it grants.
        /// </param>
        /// <param name="permissions">
        /// A list of additional permissions included in this role.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OrganizationRole> OrgsCreateCustomOrganizationRoleAsync(
            string org,
            string name,
            global::System.Collections.Generic.IList<string> permissions,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.OrgsCreateCustomOrganizationRoleRequest
            {
                Name = name,
                Description = description,
                Permissions = permissions,
            };

            return await OrgsCreateCustomOrganizationRoleAsync(
                org: org,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}