//HintName: G.GuestStarClient.GetGuestStarInvites.g.cs

#nullable enable

namespace G
{
    public partial class GuestStarClient
    {
        /// <summary>
        /// BETA Provides the caller with a list of pending invites to a Guest Star session.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="moderatorId"></param>
        /// <param name="sessionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<GetGuestStarInvitesResponse> GetGuestStarInvitesAsync(
            string broadcasterId,
            string moderatorId,
            string sessionId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/guest_star/invites?broadcaster_id={broadcasterId}&moderator_id={moderatorId}&session_id={sessionId}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<GetGuestStarInvitesResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}