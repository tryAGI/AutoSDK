//HintName: G.ExtensionsClient.SendExtensionPubsubMessage.g.cs

#nullable enable

namespace G
{
    public partial class ExtensionsClient
    {
        /// <summary>
        /// Sends a message to one or more viewers.<br/>
        /// Sends a message to one or more viewers. You can send messages to a specific channel or to all channels where your extension is active. This endpoint uses the same mechanism as the [send](https://dev.twitch.tv/docs/extensions/reference#send) JavaScript helper function used to send messages.<br/>
        /// **Rate Limits**: You may send a maximum of 100 messages per minute per combination of extension client ID and broadcaster ID.<br/>
        /// __Authorization:__<br/>
        /// Requires a signed JSON Web Token (JWT) created by an Extension Backend Service (EBS). For signing requirements, see [Signing the JWT](https://dev.twitch.tv/docs/extensions/building/#signing-the-jwt). The signed JWT must include the `role`, `user_id`, and `exp` fields (see [JWT Schema](https://dev.twitch.tv/docs/extensions/reference/#jwt-schema)) along with the `channel_id` and `pubsub_perms` fields. The `role` field must be set to _external_.<br/>
        /// To send the message to a specific channel, set the `channel_id` field in the JWT to the channel’s ID and set the `pubsub_perms.send` array to _broadcast_.<br/>
        /// ```<br/>
        /// {<br/>
        ///   "exp": 1503343947,<br/>
        ///   "user_id": "27419011",<br/>
        ///   "role": "external",<br/>
        ///   "channel_id": "27419011",<br/>
        ///   "pubsub_perms": {<br/>
        ///     "send":[<br/>
        ///       "broadcast"<br/>
        ///     ]<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// To send the message to all channels on which your extension is active, set the `channel_id` field to _all_ and set the `pubsub_perms.send` array to _global_.<br/>
        /// ```<br/>
        /// {<br/>
        ///   "exp": 1503343947,<br/>
        ///   "user_id": "27419011",<br/>
        ///   "role": "external",<br/>
        ///   "channel_id": "all",<br/>
        ///   "pubsub_perms": {<br/>
        ///     "send":[<br/>
        ///       "global"<br/>
        ///     ]<br/>
        ///   }<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task SendExtensionPubsubMessageAsync(
            global::G.SendExtensionPubSubMessageBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.GetLeftPart(global::System.UriPartial.Authority) + "/extensions/pubsub", global::System.UriKind.RelativeOrAbsolute));
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
        }

        /// <summary>
        /// Sends a message to one or more viewers.<br/>
        /// Sends a message to one or more viewers. You can send messages to a specific channel or to all channels where your extension is active. This endpoint uses the same mechanism as the [send](https://dev.twitch.tv/docs/extensions/reference#send) JavaScript helper function used to send messages.<br/>
        /// **Rate Limits**: You may send a maximum of 100 messages per minute per combination of extension client ID and broadcaster ID.<br/>
        /// __Authorization:__<br/>
        /// Requires a signed JSON Web Token (JWT) created by an Extension Backend Service (EBS). For signing requirements, see [Signing the JWT](https://dev.twitch.tv/docs/extensions/building/#signing-the-jwt). The signed JWT must include the `role`, `user_id`, and `exp` fields (see [JWT Schema](https://dev.twitch.tv/docs/extensions/reference/#jwt-schema)) along with the `channel_id` and `pubsub_perms` fields. The `role` field must be set to _external_.<br/>
        /// To send the message to a specific channel, set the `channel_id` field in the JWT to the channel’s ID and set the `pubsub_perms.send` array to _broadcast_.<br/>
        /// ```<br/>
        /// {<br/>
        ///   "exp": 1503343947,<br/>
        ///   "user_id": "27419011",<br/>
        ///   "role": "external",<br/>
        ///   "channel_id": "27419011",<br/>
        ///   "pubsub_perms": {<br/>
        ///     "send":[<br/>
        ///       "broadcast"<br/>
        ///     ]<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// To send the message to all channels on which your extension is active, set the `channel_id` field to _all_ and set the `pubsub_perms.send` array to _global_.<br/>
        /// ```<br/>
        /// {<br/>
        ///   "exp": 1503343947,<br/>
        ///   "user_id": "27419011",<br/>
        ///   "role": "external",<br/>
        ///   "channel_id": "all",<br/>
        ///   "pubsub_perms": {<br/>
        ///     "send":[<br/>
        ///       "global"<br/>
        ///     ]<br/>
        ///   }<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="target"></param>
        /// <param name="broadcasterId"></param>
        /// <param name="isGlobalBroadcast"></param>
        /// <param name="message"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task SendExtensionPubsubMessageAsync(
            global::System.Collections.Generic.IList<global::G.SendExtensionPubSubMessageBodyTarget> target,
            string broadcasterId,
            string message,
            bool isGlobalBroadcast = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.SendExtensionPubSubMessageBody
            {
                Target = target,
                BroadcasterId = broadcasterId,
                IsGlobalBroadcast = isGlobalBroadcast,
                Message = message,
            };

            await SendExtensionPubsubMessageAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}