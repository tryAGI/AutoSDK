//HintName: G.IExtensionsClient.SendExtensionChatMessage.g.cs
#nullable enable

namespace G
{
    public partial interface IExtensionsClient
    {
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
        global::System.Threading.Tasks.Task SendExtensionChatMessageAsync(
            string broadcasterId,
            global::G.SendExtensionChatMessageBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

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
        global::System.Threading.Tasks.Task SendExtensionChatMessageAsync(
            string broadcasterId,
            string text,
            string extensionId,
            string extensionVersion,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}