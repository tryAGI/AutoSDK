//HintName: G.IDisplayAdsClient.PutDisplayAdsById.g.cs
#nullable enable

namespace G
{
    public partial interface IDisplayAdsClient
    {
        /// <summary>
        /// display ads<br/>
        /// This endpoint allows the client to update the attributes of a single display ad, via its id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> PutDisplayAdsByIdAsync(
            int id,

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// display ads<br/>
        /// This endpoint allows the client to update the attributes of a single display ad, via its id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> PutDisplayAdsByIdAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}