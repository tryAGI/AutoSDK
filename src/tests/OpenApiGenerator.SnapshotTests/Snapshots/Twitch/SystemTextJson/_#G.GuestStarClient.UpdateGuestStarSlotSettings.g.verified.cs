//HintName: G.GuestStarClient.UpdateGuestStarSlotSettings.g.cs

#nullable enable

namespace G
{
    public partial class GuestStarClient
    {
        /// <summary>
        /// BETA Allows a user to update slot settings for a particular guest within a Guest Star session.
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
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/guest_star/slot_settings?broadcaster_id={broadcasterId}&moderator_id={moderatorId}&session_id={sessionId}&slot_id={slotId}&is_audio_enabled={isAudioEnabled}&is_video_enabled={isVideoEnabled}&is_live={isLive}&volume={volume}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}