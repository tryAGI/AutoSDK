//HintName: G.GuestStarClient.UpdateGuestStarSlot.g.cs

#nullable enable

namespace G
{
    public partial class GuestStarClient
    {
        partial void PrepareUpdateGuestStarSlotArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string broadcasterId,
            ref string moderatorId,
            ref string sessionId,
            ref string sourceSlotId,
            ref string destinationSlotId);
        partial void PrepareUpdateGuestStarSlotRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string broadcasterId,
            string moderatorId,
            string sessionId,
            string sourceSlotId,
            string destinationSlotId);
        partial void ProcessUpdateGuestStarSlotResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// BETA Allows a user to update the assigned slot for a particular user within the active Guest Star session.<br/>
        /// BETA Allows a user to update the assigned slot for a particular user within the active Guest Star session.<br/>
        /// __Authorization:__<br/>
        /// * Query parameter `moderator_id` must match the `user_id` in the [User-Access token](https://dev.twitch.tv/docs/authentication#user-access-tokens)<br/>
        /// * Requires OAuth Scope: `channel:manage:guest_star` or `moderator:manage:guest_star`
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="moderatorId"></param>
        /// <param name="sessionId"></param>
        /// <param name="sourceSlotId"></param>
        /// <param name="destinationSlotId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task UpdateGuestStarSlotAsync(
            string broadcasterId,
            string moderatorId,
            string sessionId,
            string sourceSlotId,
            string destinationSlotId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareUpdateGuestStarSlotArguments(
                httpClient: _httpClient,
                broadcasterId: ref broadcasterId,
                moderatorId: ref moderatorId,
                sessionId: ref sessionId,
                sourceSlotId: ref sourceSlotId,
                destinationSlotId: ref destinationSlotId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/guest_star/slot?broadcaster_id={broadcasterId}&moderator_id={moderatorId}&session_id={sessionId}&source_slot_id={sourceSlotId}&destination_slot_id={destinationSlotId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateGuestStarSlotRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                broadcasterId: broadcasterId,
                moderatorId: moderatorId,
                sessionId: sessionId,
                sourceSlotId: sourceSlotId,
                destinationSlotId: destinationSlotId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUpdateGuestStarSlotResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }
    }
}