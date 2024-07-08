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
        partial void ProcessUpdateGuestStarSlotSettingsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
            bool isAudioEnabled,
            bool isVideoEnabled,
            bool isLive,
            int volume,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/guest_star/slot_settings?broadcaster_id={broadcasterId}&moderator_id={moderatorId}&session_id={sessionId}&slot_id={slotId}&is_audio_enabled={isAudioEnabled}&is_video_enabled={isVideoEnabled}&is_live={isLive}&volume={volume}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}