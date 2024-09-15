//HintName: G.IChatClient.SendChatAnnouncement.g.cs
#nullable enable

namespace G
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Sends an announcement to the broadcaster’s chat room.<br/>
        /// Sends an announcement to the broadcaster’s chat room.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderator:manage:announcements** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="moderatorId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task SendChatAnnouncementAsync(
            string broadcasterId,
            string moderatorId,
            global::G.SendChatAnnouncementBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Sends an announcement to the broadcaster’s chat room.<br/>
        /// Sends an announcement to the broadcaster’s chat room.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderator:manage:announcements** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="moderatorId"></param>
        /// <param name="message">
        /// The announcement to make in the broadcaster’s chat room. Announcements are limited to a maximum of 500 characters; announcements longer than 500 characters are truncated.
        /// </param>
        /// <param name="color">
        /// The color used to highlight the announcement. Possible case-sensitive values are:  <br/>
        ///   <br/>
        /// * blue<br/>
        /// * green<br/>
        /// * orange<br/>
        /// * purple<br/>
        /// * primary (default)<br/>
        ///   <br/>
        /// If `color` is set to _primary_ or is not set, the channel’s accent color is used to highlight the announcement (see **Profile Accent Color** under [profile settings](https://www.twitch.tv/settings/profile), **Channel and Videos**, and **Brand**).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task SendChatAnnouncementAsync(
            string broadcasterId,
            string moderatorId,
            string message,
            global::G.SendChatAnnouncementBodyColor? color = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}