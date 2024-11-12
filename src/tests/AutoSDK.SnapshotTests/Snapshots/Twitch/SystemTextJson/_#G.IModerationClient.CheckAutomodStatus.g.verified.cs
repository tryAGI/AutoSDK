//HintName: G.IModerationClient.CheckAutomodStatus.g.cs
#nullable enable

namespace G
{
    public partial interface IModerationClient
    {
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
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CheckAutoModStatusResponse> CheckAutomodStatusAsync(
            string broadcasterId,
            global::G.CheckAutoModStatusBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

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
        global::System.Threading.Tasks.Task<global::G.CheckAutoModStatusResponse> CheckAutomodStatusAsync(
            string broadcasterId,
            global::System.Collections.Generic.IList<global::G.CheckAutoModStatusBodyDataItem> data,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}