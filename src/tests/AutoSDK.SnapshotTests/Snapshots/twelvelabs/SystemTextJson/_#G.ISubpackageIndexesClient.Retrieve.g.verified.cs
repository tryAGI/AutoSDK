//HintName: G.ISubpackageIndexesClient.Retrieve.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageIndexesClient
    {
        /// <summary>
        /// Retrieve an index<br/>
        /// This method retrieves details about the specified index.
        /// </summary>
        /// <param name="indexId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Index> RetrieveAsync(
            string indexId,
            string xApiKey,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}