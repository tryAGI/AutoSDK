//HintName: G.IDisplayAdsClient.GetDisplayAds.g.cs
#nullable enable

namespace G
{
    public partial interface IDisplayAdsClient
    {
        /// <summary>
        /// display ads<br/>
        /// This endpoint allows the client to retrieve a list of all display ads.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.DisplayAd>> GetDisplayAdsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}