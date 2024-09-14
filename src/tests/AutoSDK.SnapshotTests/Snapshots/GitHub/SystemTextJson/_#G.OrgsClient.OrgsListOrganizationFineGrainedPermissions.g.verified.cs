//HintName: G.OrgsClient.OrgsListOrganizationFineGrainedPermissions.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        partial void PrepareOrgsListOrganizationFineGrainedPermissionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org);
        partial void PrepareOrgsListOrganizationFineGrainedPermissionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org);
        partial void ProcessOrgsListOrganizationFineGrainedPermissionsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOrgsListOrganizationFineGrainedPermissionsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List organization fine-grained permissions for an organization<br/>
        /// Lists the fine-grained permissions that can be used in custom organization roles for an organization. For more information, see "[Managing people's access to your organization with roles](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/about-custom-organization-roles)."<br/>
        /// To list the fine-grained permissions that can be used in custom repository roles for an organization, see "[List repository fine-grained permissions for an organization](https://docs.github.com/rest/orgs/organization-roles#list-repository-fine-grained-permissions-for-an-organization)."<br/>
        /// To use this endpoint, the authenticated user must be one of:<br/>
        /// - An administrator for the organization.<br/>
        /// - A user, or a user on a team, with the fine-grained permissions of `read_organization_custom_org_role` in the organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.OrganizationFineGrainedPermission>> OrgsListOrganizationFineGrainedPermissionsAsync(
            string org,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareOrgsListOrganizationFineGrainedPermissionsArguments(
                httpClient: _httpClient,
                org: ref org);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/orgs/{org}/organization-fine-grained-permissions", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareOrgsListOrganizationFineGrainedPermissionsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessOrgsListOrganizationFineGrainedPermissionsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessOrgsListOrganizationFineGrainedPermissionsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.OrganizationFineGrainedPermission>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}