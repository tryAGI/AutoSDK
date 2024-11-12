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
            ref bool? isAudioEnabled,
            ref bool? isVideoEnabled,
            ref bool? isLive,
            ref int? volume);
        partial void PrepareUpdateGuestStarSlotSettingsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string broadcasterId,
            string moderatorId,
            string sessionId,
            string slotId,
            bool? isAudioEnabled,
            bool? isVideoEnabled,
            bool? isLive,
            int? volume);
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
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task UpdateGuestStarSlotSettingsAsync(
            string broadcasterId,
            string moderatorId,
            string sessionId,
            string slotId,
            bool? isAudioEnabled = default,
            bool? isVideoEnabled = default,
            bool? isLive = default,
            int? volume = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareUpdateGuestStarSlotSettingsArguments(
                httpClient: HttpClient,
                broadcasterId: ref broadcasterId,
                moderatorId: ref moderatorId,
                sessionId: ref sessionId,
                slotId: ref slotId,
                isAudioEnabled: ref isAudioEnabled,
                isVideoEnabled: ref isVideoEnabled,
                isLive: ref isLive,
                volume: ref volume);

            var __pathBuilder = new PathBuilder(
                path: "/guest_star/slot_settings",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("broadcaster_id", broadcasterId) 
                .AddRequiredParameter("moderator_id", moderatorId) 
                .AddRequiredParameter("session_id", sessionId) 
                .AddRequiredParameter("slot_id", slotId) 
                .AddOptionalParameter("is_audio_enabled", isAudioEnabled?.ToString()) 
                .AddOptionalParameter("is_video_enabled", isVideoEnabled?.ToString()) 
                .AddOptionalParameter("is_live", isLive?.ToString()) 
                .AddOptionalParameter("volume", volume?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareUpdateGuestStarSlotSettingsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                broadcasterId: broadcasterId,
                moderatorId: moderatorId,
                sessionId: sessionId,
                slotId: slotId,
                isAudioEnabled: isAudioEnabled,
                isVideoEnabled: isVideoEnabled,
                isLive: isLive,
                volume: volume);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUpdateGuestStarSlotSettingsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
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
}