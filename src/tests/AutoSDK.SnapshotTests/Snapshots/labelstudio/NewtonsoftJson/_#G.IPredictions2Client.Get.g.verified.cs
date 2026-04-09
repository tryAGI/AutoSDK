//HintName: G.IPredictions2Client.Get.g.cs
#nullable enable

namespace G
{
    public partial interface IPredictions2Client
    {
        /// <summary>
        /// Get prediction details<br/>
        /// Get details about a specific prediction by its ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Prediction> GetAsync(
            int id,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}