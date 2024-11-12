//HintName: G.ICharityClient.GetCharityCampaign.g.cs
#nullable enable

namespace G
{
    public partial interface ICharityClient
    {
        /// <summary>
        /// Gets information about the broadcaster’s active charity campaign.<br/>
        /// Gets information about the charity campaign that a broadcaster is running. For example, the campaign’s fundraising goal and the current amount of donations.<br/>
        /// To receive events when progress is made towards the campaign’s goal or the broadcaster changes the fundraising goal, subscribe to the [channel.charity\_campaign.progress](https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types#channelcharity%5Fcampaignprogress) subscription type.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:read:charity** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetCharityCampaignResponse> GetCharityCampaignAsync(
            string broadcasterId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}