//HintName: G.IChatClient.SendAShoutout.g.cs
#nullable enable

namespace G
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Sends a Shoutout to the specified broadcaster.<br/>
        /// Sends a Shoutout to the specified broadcaster. Typically, you send Shoutouts when you or one of your moderators notice another broadcaster in your chat, the other broadcaster is coming up in conversation, or after they raid your broadcast.<br/>
        /// Twitch’s Shoutout feature is a great way for you to show support for other broadcasters and help them grow. Viewers who do not follow the other broadcaster will see a pop-up Follow button in your chat that they can click to follow the other broadcaster. [Learn More](https://help.twitch.tv/s/article/shoutouts)<br/>
        /// **Rate Limits** The broadcaster may send a Shoutout once every 2 minutes. They may send the same broadcaster a Shoutout once every 60 minutes.<br/>
        /// To receive notifications when a Shoutout is sent or received, subscribe to the [channel.shoutout.create](https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types#channelshoutoutcreate) and [channel.shoutout.receive](https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types#channelshoutoutreceive) subscription types. The **channel.shoutout.create** event includes cooldown periods that indicate when the broadcaster may send another Shoutout without exceeding the endpoint’s rate limit.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderator:manage:shoutouts** scope.
        /// </summary>
        /// <param name="fromBroadcasterId"></param>
        /// <param name="toBroadcasterId"></param>
        /// <param name="moderatorId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task SendAShoutoutAsync(
            string fromBroadcasterId,
            string toBroadcasterId,
            string moderatorId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}