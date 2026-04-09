//HintName: G.IFineTunesClient.FineTunesDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IFineTunesClient
    {
        /// <summary>
        /// Delete a fine-tune
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task FineTunesDeleteAsync(
            global::G.FineTunesDeleteCartesiaVersion cartesiaVersion,
            string id,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}