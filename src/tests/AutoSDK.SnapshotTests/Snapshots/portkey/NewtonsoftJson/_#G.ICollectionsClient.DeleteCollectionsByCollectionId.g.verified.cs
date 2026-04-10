//HintName: G.ICollectionsClient.DeleteCollectionsByCollectionId.g.cs
#nullable enable

namespace G
{
    public partial interface ICollectionsClient
    {
        /// <summary>
        /// Delete collection<br/>
        /// Deletes a collection
        /// </summary>
        /// <param name="collectionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteCollectionsByCollectionIdAsync(
            string collectionId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete collection<br/>
        /// Deletes a collection
        /// </summary>
        /// <param name="collectionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<string>> DeleteCollectionsByCollectionIdAsResponseAsync(
            string collectionId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}