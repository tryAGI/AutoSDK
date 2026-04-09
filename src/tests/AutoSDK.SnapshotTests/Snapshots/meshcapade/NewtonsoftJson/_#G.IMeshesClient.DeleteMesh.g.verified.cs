//HintName: G.IMeshesClient.DeleteMesh.g.cs
#nullable enable

namespace G
{
    public partial interface IMeshesClient
    {
        /// <summary>
        /// Delete mesh
        /// </summary>
        /// <param name="assetID"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteMeshAsync(
            global::System.Guid assetID,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}