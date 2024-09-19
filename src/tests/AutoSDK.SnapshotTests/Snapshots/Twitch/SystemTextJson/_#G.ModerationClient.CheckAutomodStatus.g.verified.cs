//HintName: G.ModerationClient.CheckAutomodStatus.g.cs

#nullable enable

namespace G
{
    public partial class ModerationClient
    {
        partial void PrepareCheckAutomodStatusArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string broadcasterId,
            global::G.CheckAutoModStatusBody request);
        partial void PrepareCheckAutomodStatusRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string broadcasterId,
            global::G.CheckAutoModStatusBody request);
        partial void ProcessCheckAutomodStatusResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCheckAutomodStatusResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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

            PrepareArguments(
                client: _httpClient);
            PrepareCheckAutomodStatusArguments(
                httpClient: _httpClient,
                broadcasterId: ref broadcasterId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/moderation/enforcements/status",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("broadcaster_id", broadcasterId) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCheckAutomodStatusRequest(
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
            ProcessCheckAutomodStatusResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCheckAutomodStatusResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.CheckAutoModStatusResponse?>(__content, JsonSerializerOptions) ??
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
        /// <param name="data">
        /// The list of messages to check. The list must contain at least one message and may contain up to a maximum of 100 messages.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CheckAutoModStatusResponse> CheckAutomodStatusAsync(
            string broadcasterId,
            global::System.Collections.Generic.IList<global::G.CheckAutoModStatusBodyDataItem> data,
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