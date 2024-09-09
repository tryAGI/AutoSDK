//HintName: G.WhispersClient.SendWhisper.g.cs

#nullable enable

namespace G
{
    public partial class WhispersClient
    {
        partial void PrepareSendWhisperArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string fromUserId,
            ref string toUserId,
            global::G.SendWhisperBody request);
        partial void PrepareSendWhisperRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string fromUserId,
            string toUserId,
            global::G.SendWhisperBody request);
        partial void ProcessSendWhisperResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Sends a whisper message to the specified user.<br/>
        /// Sends a whisper message to the specified user.<br/>
        /// NOTE: The user sending the whisper must have a verified phone number (see the **Phone Number** setting in your [Security and Privacy](https://www.twitch.tv/settings/security) settings).<br/>
        /// NOTE: The API may silently drop whispers that it suspects of violating Twitch policies. (The API does not indicate that it dropped the whisper; it returns a 204 status code as if it succeeded.)<br/>
        /// **Rate Limits**: You may whisper to a maximum of 40 unique recipients per day. Within the per day limit, you may whisper a maximum of 3 whispers per second and a maximum of 100 whispers per minute.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **user:manage:whispers** scope.
        /// </summary>
        /// <param name="fromUserId"></param>
        /// <param name="toUserId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task SendWhisperAsync(
            string fromUserId,
            string toUserId,
            global::G.SendWhisperBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareSendWhisperArguments(
                httpClient: _httpClient,
                fromUserId: ref fromUserId,
                toUserId: ref toUserId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/whispers?from_user_id={fromUserId}&to_user_id={toUserId}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareSendWhisperRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                fromUserId: fromUserId,
                toUserId: toUserId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessSendWhisperResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Sends a whisper message to the specified user.<br/>
        /// Sends a whisper message to the specified user.<br/>
        /// NOTE: The user sending the whisper must have a verified phone number (see the **Phone Number** setting in your [Security and Privacy](https://www.twitch.tv/settings/security) settings).<br/>
        /// NOTE: The API may silently drop whispers that it suspects of violating Twitch policies. (The API does not indicate that it dropped the whisper; it returns a 204 status code as if it succeeded.)<br/>
        /// **Rate Limits**: You may whisper to a maximum of 40 unique recipients per day. Within the per day limit, you may whisper a maximum of 3 whispers per second and a maximum of 100 whispers per minute.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **user:manage:whispers** scope.
        /// </summary>
        /// <param name="fromUserId"></param>
        /// <param name="toUserId"></param>
        /// <param name="message">
        /// The whisper message to send. The message must not be empty.  <br/>
        ///   <br/>
        /// The maximum message lengths are:  <br/>
        ///   <br/>
        /// * 500 characters if the user you're sending the message to hasn't whispered you before.<br/>
        /// * 10,000 characters if the user you're sending the message to has whispered you before.<br/>
        ///   <br/>
        /// Messages that exceed the maximum length are truncated.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task SendWhisperAsync(
            string fromUserId,
            string toUserId,
            string message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.SendWhisperBody
            {
                Message = message,
            };

            await SendWhisperAsync(
                fromUserId: fromUserId,
                toUserId: toUserId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}