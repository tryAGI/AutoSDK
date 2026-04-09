//HintName: G.IDisplayAdsClient.PutDisplayAdsByIdUnpublish.g.cs
#nullable enable

namespace G
{
    public partial interface IDisplayAdsClient
    {
        /// <summary>
        /// unpublish<br/>
        /// This endpoint allows the client to remove a display ad from rotation by un-publishing it.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task PutDisplayAdsByIdUnpublishAsync(
            int id,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}