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
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task UpdateChannelGuestStarSettingsAsync(
            string broadcasterId,
            global::G.UpdateChannelGuestStarSettingsBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpdateChannelGuestStarSettingsArguments(
                httpClient: HttpClient,
                broadcasterId: ref broadcasterId,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/guest_star/channel_settings",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("broadcaster_id", broadcasterId) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareUpdateChannelGuestStarSettingsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                broadcasterId: broadcasterId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUpdateChannelGuestStarSettingsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // 
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                if (ReadResponseAsString)
                {
                    __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    var __contentStream_400 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                }

                throw new global::G.ApiException(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                }
                catch (global::System.Exception __ex)
                {
                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                }
                catch (global::System.Exception __ex)
                {
                    throw new global::G.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }

        /// <summary>
        /// BETA Mutates the channel settings for configuration of the Guest Star feature for a particular host.<br/>
        /// BETA Mutates the channel settings for configuration of the Guest Star feature for a particular host.<br/>
        /// __Authorization:__<br/>
        /// * Query parameter `broadcaster_id` must match the `user_id` in the [User-Access token](https://dev.twitch.tv/docs/authentication#user-access-tokens)<br/>
        /// * Requires OAuth Scope: `channel:manage:guest_star`
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="isModeratorSendLiveEnabled">
        /// Flag determining if Guest Star moderators have access to control whether a guest is live once assigned to a slot.
        /// </param>
        /// <param name="slotCount">
        /// Number of slots the Guest Star call interface will allow the host to add to a call. Required to be between 1 and 6.
        /// </param>
        /// <param name="isBrowserSourceAudioEnabled">
        /// Flag determining if Browser Sources subscribed to sessions on this channel should output audio
        /// </param>
        /// <param name="groupLayout">
        /// This setting determines how the guests within a session should be laid out within the browser source. Can be one of the following values:   <br/>
        ///   <br/>
        /// * `TILED_LAYOUT`: All live guests are tiled within the browser source with the same size.<br/>
        /// * `SCREENSHARE_LAYOUT`: All live guests are tiled within the browser source with the same size. If there is an active screen share, it is sized larger than the other guests.<br/>
        /// * `HORIZONTAL_LAYOUT`: All live guests are arranged in a horizontal bar within the browser source<br/>
        /// * `VERTICAL_LAYOUT`: All live guests are arranged in a vertical bar within the browser source
        /// </param>
        /// <param name="regenerateBrowserSources">
        /// Flag determining if Guest Star should regenerate the auth token associated with the channel’s browser sources. Providing a true value for this will immediately invalidate all browser sources previously configured in your streaming software.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task UpdateChannelGuestStarSettingsAsync(
            string broadcasterId,
            bool? isModeratorSendLiveEnabled = default,
            int? slotCount = default,
            bool? isBrowserSourceAudioEnabled = default,
            global::G.UpdateChannelGuestStarSettingsBodyGroupLayout? groupLayout = default,
            bool? regenerateBrowserSources = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.UpdateChannelGuestStarSettingsBody
            {
                IsModeratorSendLiveEnabled = isModeratorSendLiveEnabled,
                SlotCount = slotCount,
                IsBrowserSourceAudioEnabled = isBrowserSourceAudioEnabled,
                GroupLayout = groupLayout,
                RegenerateBrowserSources = regenerateBrowserSources,
            };

            await UpdateChannelGuestStarSettingsAsync(
                broadcasterId: broadcasterId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}