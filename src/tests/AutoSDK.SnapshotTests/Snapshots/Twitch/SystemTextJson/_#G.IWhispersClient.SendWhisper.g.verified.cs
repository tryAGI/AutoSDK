//HintName: G.IWhispersClient.SendWhisper.g.cs
#nullable enable

namespace G
{
    public partial interface IWhispersClient
    {
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
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task SendWhisperAsync(
            string fromUserId,
            string toUserId,
            global::G.SendWhisperBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

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
        global::System.Threading.Tasks.Task SendWhisperAsync(
            string fromUserId,
            string toUserId,
            string message,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}