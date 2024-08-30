//HintName: G.GuestStarClient.UpdateGuestStarSlotSettings.g.cs

#nullable enable

namespace G
{
    public partial class GuestStarClient
    {
        partial void PrepareUpdateGuestStarSlotSettingsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string broadcasterId,
            ref string moderatorId,
            ref string sessionId,
            ref string slotId,
            ref bool isAudioEnabled,
            ref bool isVideoEnabled,
            ref bool isLive,
            ref int volume);
        partial void PrepareUpdateGuestStarSlotSettingsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string broadcasterId,
            string moderatorId,
            string sessionId,
            string slotId,
            bool isAudioEnabled,
            bool isVideoEnabled,
            bool isLive,
            int volume);
        partial void ProcessUpdateGuestStarSlotSettingsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// BETA Allows a user to update slot settings for a particular guest within a Guest Star session.<br/>
        /// BETA Allows a user to update slot settings for a particular guest within a Guest Star session, such as allowing the user to share audio or video within the call as a host. These settings will be broadcasted to all subscribers which control their view of the guest in that slot. One or more of the optional parameters to this API can be specified at any time.<br/>
        /// __Authorization:__<br/>
        /// * Query parameter `moderator_id` must match the `user_id` in the [User-Access token](https://dev.twitch.tv/docs/authentication#user-access-tokens)<br/>
        /// * Requires OAuth Scope: `channel:manage:guest_star` or `moderator:manage:guest_star`
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="moderatorId"></param>
        /// <param name="sessionId"></param>
        /// <param name="slotId"></param>
        /// <param name="isAudioEnabled"></param>
        /// <param name="isVideoEnabled"></param>
        /// <param name="isLive"></param>
        /// <param name="volume"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task UpdateGuestStarSlotSettingsAsync(
            string broadcasterId,
            string moderatorId,
            string sessionId,
            string slotId,
            bool isAudioEnabled = default,
            bool isVideoEnabled = default,
            bool isLive = default,
            int volume = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareUpdateGuestStarSlotSettingsArguments(
                httpClient: _httpClient,
                broadcasterId: ref broadcasterId,
                moderatorId: ref moderatorId,
                sessionId: ref sessionId,
                slotId: ref slotId,
                isAudioEnabled: ref isAudioEnabled,
                isVideoEnabled: ref isVideoEnabled,
                isLive: ref isLive,
                volume: ref volume);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/guest_star/slot_settings?broadcaster_id={broadcasterId}&moderator_id={moderatorId}&session_id={sessionId}&slot_id={slotId}&is_audio_enabled={isAudioEnabled}&is_video_enabled={isVideoEnabled}&is_live={isLive}&volume={volume}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateGuestStarSlotSettingsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                broadcasterId: broadcasterId,
                moderatorId: moderatorId,
                sessionId: sessionId,
                slotId: slotId,
                isAudioEnabled: isAudioEnabled,
                isVideoEnabled: isVideoEnabled,
                isLive: isLive,
                volume: volume);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUpdateGuestStarSlotSettingsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }
    }
}