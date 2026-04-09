//HintName: G.IModelsClient.CreateBlob.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Create a blob from a file. Returns the server file path.
        /// </summary>
        /// <param name="digest"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateBlobAsync(
            string digest,

            byte[] request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}