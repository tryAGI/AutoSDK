//HintName: G.ModerationClient.CheckAutomodStatus.g.cs

#nullable enable

namespace G
{
    public partial class ModerationClient
    {
        /// <summary>
        /// Checks whether AutoMod would flag the specified message for review.<br/>
        /// Checks whether AutoMod would flag the specified message for review.<br/>
        /// AutoMod is a moderation tool that holds inappropriate or harassing chat messages for moderators to review. Moderators approve or deny the messages that AutoMod flags; only approved messages are released to chat. AutoMod detects misspellings and evasive language automatically. For information about AutoMod, see [How to Use AutoMod](https://help.twitch.tv/s/article/how-to-use-automod).<br/>
        /// **Rate Limits**: Rates are limited per channel based on the account type rather than per access token.<br/>
        /// | Account type | Limit per minute | Limit per hour |<br/>
        /// | - | - | - |<br/>
        /// | Normal | 5 | 50 |<br/>
        /// | Affiliate | 10 | 100 |<br/>
        /// | Partner | 30 | 300 |<br/>
        /// The above limits are in addition to the standard [Twitch API rate limits](https://dev.twitch.tv/docs/api/guide#twitch-rate-limits). The rate limit headers in the response represent the Twitch rate limits and not the above limits.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderation:read** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CheckAutoModStatusResponse> CheckAutomodStatusAsync(
            string broadcasterId,
            global::G.CheckAutoModStatusBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/moderation/enforcements/status?broadcaster_id={broadcasterId}", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.CheckAutoModStatusResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Checks whether AutoMod would flag the specified message for review.<br/>
        /// Checks whether AutoMod would flag the specified message for review.<br/>
        /// AutoMod is a moderation tool that holds inappropriate or harassing chat messages for moderators to review. Moderators approve or deny the messages that AutoMod flags; only approved messages are released to chat. AutoMod detects misspellings and evasive language automatically. For information about AutoMod, see [How to Use AutoMod](https://help.twitch.tv/s/article/how-to-use-automod).<br/>
        /// **Rate Limits**: Rates are limited per channel based on the account type rather than per access token.<br/>
        /// | Account type | Limit per minute | Limit per hour |<br/>
        /// | - | - | - |<br/>
        /// | Normal | 5 | 50 |<br/>
        /// | Affiliate | 10 | 100 |<br/>
        /// | Partner | 30 | 300 |<br/>
        /// The above limits are in addition to the standard [Twitch API rate limits](https://dev.twitch.tv/docs/api/guide#twitch-rate-limits). The rate limit headers in the response represent the Twitch rate limits and not the above limits.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderation:read** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CheckAutoModStatusResponse> CheckAutomodStatusAsync(
            string broadcasterId,
            global::System.Collections.Generic.IList<global::G.CheckAutoModStatusBodyData> data,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.CheckAutoModStatusBody
            {
                Data = data,
            };

            return await CheckAutomodStatusAsync(
                broadcasterId: broadcasterId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}