//HintName: G.MembershipClient.UpdateOrganizationMembership.g.cs

#nullable enable

namespace G
{
    public partial class MembershipClient
    {
        partial void PrepareUpdateOrganizationMembershipArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string organizationId,
            ref string userId,
            ref string updateMask,
            global::G.OrganizationMembership request);
        partial void PrepareUpdateOrganizationMembershipRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string organizationId,
            string userId,
            string updateMask,
            global::G.OrganizationMembership request);
        partial void ProcessUpdateOrganizationMembershipResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateOrganizationMembershipResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Uppdate an organization membership<br/>
        /// Updates a user membership within an organization.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="userId"></param>
        /// <param name="updateMask"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UpdateOrganizationMembershipResponse> UpdateOrganizationMembershipAsync(
            string organizationId,
            string userId,
            string updateMask,
            global::G.OrganizationMembership request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateOrganizationMembershipArguments(
                httpClient: _httpClient,
                organizationId: ref organizationId,
                userId: ref userId,
                updateMask: ref updateMask,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v1beta/organizations/{organizationId}/memberships/{userId}?updateMask={updateMask}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateOrganizationMembershipRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                organizationId: organizationId,
                userId: userId,
                updateMask: updateMask,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUpdateOrganizationMembershipResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateOrganizationMembershipResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateOrganizationMembershipResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Uppdate an organization membership<br/>
        /// Updates a user membership within an organization.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="userId"></param>
        /// <param name="updateMask"></param>
        /// <param name="name">
        /// The resource name of the membership, which allows its access by<br/>
        /// organization and user ID.<br/>
        /// - Format: `organizations/{organization.id}/memberships/{user.id}`.
        /// </param>
        /// <param name="role">
        /// Role of the user in the organization.
        /// </param>
        /// <param name="state">
        /// State of the membership.
        /// </param>
        /// <param name="user">
        /// User information.
        /// </param>
        /// <param name="organization">
        /// Organization information.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UpdateOrganizationMembershipResponse> UpdateOrganizationMembershipAsync(
            string organizationId,
            string userId,
            string updateMask,
            string role,
            string? name = default,
            global::G.AllOf<global::G.MembershipState?>? state = default,
            global::G.AllOf<global::G.User9>? user = default,
            global::G.AllOf<global::G.Organization7>? organization = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.OrganizationMembership
            {
                Name = name,
                Role = role,
                State = state,
                User = user,
                Organization = organization,
            };

            return await UpdateOrganizationMembershipAsync(
                organizationId: organizationId,
                userId: userId,
                updateMask: updateMask,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}