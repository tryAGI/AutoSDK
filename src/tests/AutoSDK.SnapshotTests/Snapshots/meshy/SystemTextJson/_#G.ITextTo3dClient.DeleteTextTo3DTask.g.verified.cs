//HintName: G.ITextTo3dClient.DeleteTextTo3DTask.g.cs
#nullable enable

namespace G
{
    public partial interface ITextTo3dClient
    {
        /// <summary>
        /// Delete a Text to 3D task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteTextTo3DTaskAsync(
            string id,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}