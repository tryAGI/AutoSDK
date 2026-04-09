//HintName: G.ISubpackageAssetsClient.Delete.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageAssetsClient
    {
        /// <summary>
        /// Delete an asset<br/>
        /// This method deletes the specified asset. This action cannot be undone.
        /// </summary>
        /// <param name="assetId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AssetsDeleteResponse204> DeleteAsync(
            string assetId,
            string xApiKey,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}