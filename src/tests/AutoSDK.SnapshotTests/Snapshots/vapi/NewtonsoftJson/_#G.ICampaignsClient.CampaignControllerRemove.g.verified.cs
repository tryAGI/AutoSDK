//HintName: G.ICampaignsClient.CampaignControllerRemove.g.cs
#nullable enable

namespace G
{
    public partial interface ICampaignsClient
    {
        /// <summary>
        /// Delete Campaign
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Campaign> CampaignControllerRemoveAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}