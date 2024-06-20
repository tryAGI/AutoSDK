//HintName: G.ModerationClient.BanUser.g.cs

#nullable enable

namespace G
{
    public partial class ModerationClient
    {
        /// <summary>
        /// Bans a user from participating in a broadcaster’s chat room or puts them in a timeout.<br/>
        /// Bans a user from participating in the specified broadcaster’s chat room or puts them in a timeout.<br/>
        /// For information about banning or putting users in a timeout, see [Ban a User](https://help.twitch.tv/s/article/how-to-manage-harassment-in-chat#TheBanFeature) and [Timeout a User](https://help.twitch.tv/s/article/how-to-manage-harassment-in-chat#TheTimeoutFeature).<br/>
        /// If the user is currently in a timeout, you can call this endpoint to change the duration of the timeout or ban them altogether. If the user is currently banned, you cannot call this method to put them in a timeout instead.<br/>
        /// To remove a ban or end a timeout, see [Unban user](https://dev.twitch.tv/docs/api/reference#unban-user).<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderator:manage:banned\_users** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="moderatorId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.BanUserResponse> BanUserAsync(
            string broadcasterId,
            string moderatorId,
            global::G.BanUserBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/moderation/bans?broadcaster_id={broadcasterId}&moderator_id={moderatorId}", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.BanUserResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Bans a user from participating in a broadcaster’s chat room or puts them in a timeout.<br/>
        /// Bans a user from participating in the specified broadcaster’s chat room or puts them in a timeout.<br/>
        /// For information about banning or putting users in a timeout, see [Ban a User](https://help.twitch.tv/s/article/how-to-manage-harassment-in-chat#TheBanFeature) and [Timeout a User](https://help.twitch.tv/s/article/how-to-manage-harassment-in-chat#TheTimeoutFeature).<br/>
        /// If the user is currently in a timeout, you can call this endpoint to change the duration of the timeout or ban them altogether. If the user is currently banned, you cannot call this method to put them in a timeout instead.<br/>
        /// To remove a ban or end a timeout, see [Unban user](https://dev.twitch.tv/docs/api/reference#unban-user).<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderator:manage:banned\_users** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="moderatorId"></param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.BanUserResponse> BanUserAsync(
            string broadcasterId,
            string moderatorId,
            global::G.BanUserBodyData data,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.BanUserBody
            {
                Data = data,
            };

            return await BanUserAsync(
                broadcasterId: broadcasterId,
                moderatorId: moderatorId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}