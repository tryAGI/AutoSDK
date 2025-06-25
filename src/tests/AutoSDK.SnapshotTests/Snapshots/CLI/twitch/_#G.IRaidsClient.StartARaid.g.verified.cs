﻿//HintName: G.IRaidsClient.StartARaid.g.cs
#nullable enable

namespace G
{
    public partial interface IRaidsClient
    {
        /// <summary>
        /// Raid another channel by sending the broadcaster’s viewers to the targeted channel.<br/>
        /// Raid another channel by sending the broadcaster’s viewers to the targeted channel.<br/>
        /// When you call the API from a chat bot or extension, the Twitch UX pops up a window at the top of the chat room that identifies the number of viewers in the raid. The raid occurs when the broadcaster clicks **Raid Now** or after the 90-second countdown expires.<br/>
        /// To determine whether the raid successfully occurred, you must subscribe to the [Channel Raid](https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types#channelraid) event. For more information, see [Get notified when a raid begins](https://dev.twitch.tv/docs/api/raids#get-notified-when-a-raid-begins).<br/>
        /// To cancel a pending raid, use the [Cancel a raid](https://dev.twitch.tv/docs/api/reference#cancel-a-raid) endpoint.<br/>
        /// **Rate Limit**: The limit is 10 requests within a 10-minute window.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:raids** scope.
        /// </summary>
        /// <param name="fromBroadcasterId"></param>
        /// <param name="toBroadcasterId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.StartRaidResponse> StartARaidAsync(
            string? fromBroadcasterId = default,
            string? toBroadcasterId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}