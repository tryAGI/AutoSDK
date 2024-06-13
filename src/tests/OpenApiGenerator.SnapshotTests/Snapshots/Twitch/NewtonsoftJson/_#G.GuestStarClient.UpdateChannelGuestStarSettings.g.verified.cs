//HintName: G.GuestStarClient.UpdateChannelGuestStarSettings.g.cs

#nullable enable

namespace G
{
    public partial class GuestStarClient
    {
        /// <summary>
        /// BETA Mutates the channel settings for configuration of the Guest Star feature for a particular host.<br/>
        /// BETA Mutates the channel settings for configuration of the Guest Star feature for a particular host.<br/>
        /// __Authorization:__<br/>
        /// * Query parameter `broadcaster_id` must match the `user_id` in the [User-Access token](https://dev.twitch.tv/docs/authentication#user-access-tokens)<br/>
        /// * Requires OAuth Scope: `channel:manage:guest_star`
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task UpdateChannelGuestStarSettingsAsync(
            string broadcasterId,
            global::G.UpdateChannelGuestStarSettingsBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/guest_star/channel_settings?broadcaster_id={broadcasterId}", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// BETA Mutates the channel settings for configuration of the Guest Star feature for a particular host.<br/>
        /// BETA Mutates the channel settings for configuration of the Guest Star feature for a particular host.<br/>
        /// __Authorization:__<br/>
        /// * Query parameter `broadcaster_id` must match the `user_id` in the [User-Access token](https://dev.twitch.tv/docs/authentication#user-access-tokens)<br/>
        /// * Requires OAuth Scope: `channel:manage:guest_star`
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="isModeratorSendLiveEnabled"></param>
        /// <param name="slotCount"></param>
        /// <param name="isBrowserSourceAudioEnabled"></param>
        /// <param name="groupLayout"></param>
        /// <param name="regenerateBrowserSources"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task UpdateChannelGuestStarSettingsAsync(
            string broadcasterId,
            bool isModeratorSendLiveEnabled = default,
            int slotCount = default,
            bool isBrowserSourceAudioEnabled = default,
            global::G.UpdateChannelGuestStarSettingsBodyGroupLayout? groupLayout = default,
            bool regenerateBrowserSources = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.UpdateChannelGuestStarSettingsBody
            {
                IsModeratorSendLiveEnabled = isModeratorSendLiveEnabled,
                SlotCount = slotCount,
                IsBrowserSourceAudioEnabled = isBrowserSourceAudioEnabled,
                GroupLayout = groupLayout,
                RegenerateBrowserSources = regenerateBrowserSources,
            };

            await UpdateChannelGuestStarSettingsAsync(
                broadcasterId: broadcasterId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}