//HintName: G.IObjectsClient.ObjectsHead.g.cs
#nullable enable

namespace G
{
    public partial interface IObjectsClient
    {
        /// <summary>
        /// Check if object exists.<br/>
        /// Checks if an object exists in the system based on its UUID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task ObjectsHeadAsync(
            global::System.Guid id,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}