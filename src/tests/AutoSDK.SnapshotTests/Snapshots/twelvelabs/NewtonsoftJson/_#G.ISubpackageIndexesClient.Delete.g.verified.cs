//HintName: G.ISubpackageIndexesClient.Delete.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageIndexesClient
    {
        /// <summary>
        /// Delete an index<br/>
        /// This method deletes the specified index and all the videos within it. This action cannot be undone.
        /// </summary>
        /// <param name="indexId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.IndexesDeleteResponse204> DeleteAsync(
            string indexId,
            string xApiKey,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}