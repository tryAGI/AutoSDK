//HintName: G.OrgsClient.OrgsPatchCustomOrganizationRole.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        /// <summary>
        /// Update a custom organization role
        /// </summary>
        /// <param name="org"></param>
        /// <param name="roleId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<OrganizationRole> OrgsPatchCustomOrganizationRoleAsync(
            string org,
            int roleId,
            OrgsPatchCustomOrganizationRoleRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/organization-roles/{roleId}", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<OrganizationRole?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update a custom organization role
        /// </summary>
        /// <param name="org"></param>
        /// <param name="roleId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="permissions"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<OrganizationRole> OrgsPatchCustomOrganizationRoleAsync(
            string org,
            int roleId,
            string? name = default,
            string? description = default,
            global::System.Collections.Generic.IList<string?>? permissions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new OrgsPatchCustomOrganizationRoleRequest
            {
                Name = name,
                Description = description,
                Permissions = permissions,
            };

            return await OrgsPatchCustomOrganizationRoleAsync(
                org: org,
                roleId: roleId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}