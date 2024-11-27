//HintName: G.ExtensionsClient.SendExtensionChatMessage.g.cs

#nullable enable

namespace G
{
    public partial class ExtensionsClient
    {
        partial void PrepareSendExtensionChatMessageArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string broadcasterId,
            global::G.SendExtensionChatMessageBody request);
        partial void PrepareSendExtensionChatMessageRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string broadcasterId,
            global::G.SendExtensionChatMessageBody request);
        partial void ProcessSendExtensionChatMessageResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Sends a message to the specified broadcaster’s chat room.<br/>
        /// Sends a message to the specified broadcaster’s chat room. The extension’s name is used as the username for the message in the chat room. To send a chat message, your extension must enable **Chat Capabilities** (under your extension’s **Capabilities** tab).<br/>
        /// **Rate Limits**: You may send a maximum of 12 messages per minute per channel.<br/>
        /// __Authorization:__<br/>
        /// Requires a signed JSON Web Token (JWT) created by an Extension Backend Service (EBS). For signing requirements, see [Signing the JWT](https://dev.twitch.tv/docs/extensions/building/#signing-the-jwt). The signed JWT must include the `role` and `user_id` fields (see [JWT Schema](https://dev.twitch.tv/docs/extensions/reference/#jwt-schema)). The `role` field must be set to _external_.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task SendExtensionChatMessageAsync(
            string broadcasterId,
            global::G.SendExtensionChatMessageBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareSendExtensionChatMessageArguments(
                httpClient: HttpClient,
                broadcasterId: ref broadcasterId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/extensions/chat",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("broadcaster_id", broadcasterId) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareSendExtensionChatMessageRequest(
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
            ProcessSendExtensionChatMessageResponse(
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

        /// <summary>
        /// Sends a message to the specified broadcaster’s chat room.<br/>
        /// Sends a message to the specified broadcaster’s chat room. The extension’s name is used as the username for the message in the chat room. To send a chat message, your extension must enable **Chat Capabilities** (under your extension’s **Capabilities** tab).<br/>
        /// **Rate Limits**: You may send a maximum of 12 messages per minute per channel.<br/>
        /// __Authorization:__<br/>
        /// Requires a signed JSON Web Token (JWT) created by an Extension Backend Service (EBS). For signing requirements, see [Signing the JWT](https://dev.twitch.tv/docs/extensions/building/#signing-the-jwt). The signed JWT must include the `role` and `user_id` fields (see [JWT Schema](https://dev.twitch.tv/docs/extensions/reference/#jwt-schema)). The `role` field must be set to _external_.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="text">
        /// The message. The message may contain a maximum of 280 characters.
        /// </param>
        /// <param name="extensionId">
        /// The ID of the extension that’s sending the chat message.
        /// </param>
        /// <param name="extensionVersion">
        /// The extension’s version number.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task SendExtensionChatMessageAsync(
            string broadcasterId,
            string text,
            string extensionId,
            string extensionVersion,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.SendExtensionChatMessageBody
            {
                Text = text,
                ExtensionId = extensionId,
                ExtensionVersion = extensionVersion,
            };

            await SendExtensionChatMessageAsync(
                broadcasterId: broadcasterId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}