//HintName: G.GuestStarClient.UpdateChannelGuestStarSettings.g.cs

#nullable enable

namespace G
{
    public partial class GuestStarClient
    {
        partial void PrepareUpdateChannelGuestStarSettingsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string broadcasterId,
            global::G.UpdateChannelGuestStarSettingsBody request);
        partial void PrepareUpdateChannelGuestStarSettingsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string broadcasterId,
            global::G.UpdateChannelGuestStarSettingsBody request);
        partial void ProcessUpdateChannelGuestStarSettingsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

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

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateChannelGuestStarSettingsArguments(
                httpClient: _httpClient,
                broadcasterId: ref broadcasterId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/guest_star/channel_settings?broadcaster_id={broadcasterId}", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateChannelGuestStarSettingsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                broadcasterId: broadcasterId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUpdateChannelGuestStarSettingsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
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