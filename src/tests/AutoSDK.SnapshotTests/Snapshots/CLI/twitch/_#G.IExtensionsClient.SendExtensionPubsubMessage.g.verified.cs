//HintName: G.IExtensionsClient.SendExtensionPubsubMessage.g.cs
#nullable enable

namespace G
{
    public partial interface IExtensionsClient
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
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task SendExtensionPubsubMessageAsync(
            global::G.SendExtensionPubSubMessageBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

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
        /// <param name="target">
        /// The target of the message. Possible values are:  <br/>
        ///   <br/>
        /// * broadcast<br/>
        /// * global<br/>
        /// * whisper-&lt;user-id&gt;<br/>
        ///   <br/>
        /// If `is_global_broadcast` is **true**, you must set this field to global. The broadcast and global values are mutually exclusive; specify only one of them.
        /// </param>
        /// <param name="broadcasterId">
        /// The ID of the broadcaster to send the message to. Don’t include this field if `is_global_broadcast` is set to **true**.
        /// </param>
        /// <param name="isGlobalBroadcast">
        /// A Boolean value that determines whether the message should be sent to all channels where your extension is active. Set to **true** if the message should be sent to all channels. The default is **false**.
        /// </param>
        /// <param name="message">
        /// The message to send. The message can be a plain-text string or a string-encoded JSON object. The message is limited to a maximum of 5 KB.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task SendExtensionPubsubMessageAsync(
            global::System.Collections.Generic.IList<global::G.SendExtensionPubSubMessageBodyTargetItem> target,
            string broadcasterId,
            string message,
            bool? isGlobalBroadcast = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}