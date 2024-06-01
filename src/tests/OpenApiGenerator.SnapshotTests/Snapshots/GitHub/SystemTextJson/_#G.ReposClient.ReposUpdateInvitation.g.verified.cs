//HintName: G.ReposClient.ReposUpdateInvitation.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        /// <summary>
        /// Update a repository invitation
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="invitationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<RepositoryInvitation> ReposUpdateInvitationAsync(
            string owner,
            string repo,
            int invitationId,
            ReposUpdateInvitationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/invitations/{invitationId}", global::System.UriKind.RelativeOrAbsolute));
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
                global::System.Text.Json.JsonSerializer.Deserialize<RepositoryInvitation?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update a repository invitation
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="invitationId"></param>
        /// <param name="permissions"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<RepositoryInvitation> ReposUpdateInvitationAsync(
            string owner,
            string repo,
            int invitationId,
            ReposUpdateInvitationRequestPermissions? permissions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ReposUpdateInvitationRequest
            {
                Permissions = permissions,
            };

            return await ReposUpdateInvitationAsync(
                owner: owner,
                repo: repo,
                invitationId: invitationId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}