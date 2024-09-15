//HintName: G.ICharityClient.GetCharityCampaignDonations.g.cs
#nullable enable

namespace G
{
    public partial interface ICharityClient
    {
        /// <summary>
        /// Gets the list of donations that users have made to the broadcaster’s active charity campaign.<br/>
        /// Gets the list of donations that users have made to the broadcaster’s active charity campaign.<br/>
        /// To receive events as donations occur, subscribe to the [channel.charity\_campaign.donate](https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types#channelcharity%5Fcampaigndonate) subscription type.<br/>
        /// __Authorization:__<br/>
        /// Requires a user access token that includes the **channel:read:charity** scope.
        /// </summary>
        /// <param name="broadcasterId"></param>
        /// <param name="first"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetCharityCampaignDonationsResponse> GetCharityCampaignDonationsAsync(
            string broadcasterId,
            int first = default,
            string? after = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}