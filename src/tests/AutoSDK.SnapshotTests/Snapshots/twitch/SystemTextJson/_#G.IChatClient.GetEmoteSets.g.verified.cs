//HintName: G.IChatClient.GetEmoteSets.g.cs
#nullable enable

namespace G
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Gets emotes for one or more specified emote sets.<br/>
        /// Gets emotes for one or more specified emote sets.<br/>
        /// An emote set groups emotes that have a similar context. For example, Twitch places all the subscriber emotes that a broadcaster uploads for their channel in the same emote set.<br/>
        /// [Learn More](https://dev.twitch.tv/docs/irc/emotes)<br/>
        /// __Authorization:__<br/>
        /// Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens) or [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens).
        /// </summary>
        /// <param name="emoteSetId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetEmoteSetsResponse> GetEmoteSetsAsync(
            global::System.Collections.Generic.IList<string> emoteSetId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}