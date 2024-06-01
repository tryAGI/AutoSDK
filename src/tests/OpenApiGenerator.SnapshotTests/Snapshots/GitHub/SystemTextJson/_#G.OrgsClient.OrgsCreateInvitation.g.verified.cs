//HintName: G.OrgsClient.OrgsCreateInvitation.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        /// <summary>
        /// Create an organization invitation
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<OrganizationInvitation> OrgsCreateInvitationAsync(
            string org,
            OrgsCreateInvitationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/invitations", global::System.UriKind.RelativeOrAbsolute));
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
                global::System.Text.Json.JsonSerializer.Deserialize<OrganizationInvitation?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create an organization invitation
        /// </summary>
        /// <param name="org"></param>
        /// <param name="inviteeId"></param>
        /// <param name="email"></param>
        /// <param name="role"></param>
        /// <param name="teamIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<OrganizationInvitation> OrgsCreateInvitationAsync(
            string org,
            int inviteeId = default,
            string? email = default,
            OrgsCreateInvitationRequestRole? role = OrgsCreateInvitationRequestRole.DirectMember,
            global::System.Collections.Generic.IList<int>? teamIds = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new OrgsCreateInvitationRequest
            {
                InviteeId = inviteeId,
                Email = email,
                Role = role,
                TeamIds = teamIds,
            };

            return await OrgsCreateInvitationAsync(
                org: org,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}