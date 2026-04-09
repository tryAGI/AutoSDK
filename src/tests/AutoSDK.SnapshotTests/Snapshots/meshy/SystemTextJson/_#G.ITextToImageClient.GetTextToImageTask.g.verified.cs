//HintName: G.ITextToImageClient.GetTextToImageTask.g.cs
#nullable enable

namespace G
{
    public partial interface ITextToImageClient
    {
        /// <summary>
        /// Retrieve a Text to Image task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TextToImageTask> GetTextToImageTaskAsync(
            string id,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}