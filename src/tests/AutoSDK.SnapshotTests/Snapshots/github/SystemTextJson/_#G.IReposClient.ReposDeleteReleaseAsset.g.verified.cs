//HintName: G.IReposClient.ReposDeleteReleaseAsset.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Delete a release asset
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="assetId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ReposDeleteReleaseAssetAsync(
            string owner,
            string repo,
            int assetId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}