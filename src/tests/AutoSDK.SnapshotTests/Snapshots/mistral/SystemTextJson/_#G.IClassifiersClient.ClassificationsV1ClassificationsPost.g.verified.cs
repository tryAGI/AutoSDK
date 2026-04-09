//HintName: G.IClassifiersClient.ClassificationsV1ClassificationsPost.g.cs
#nullable enable

namespace G
{
    public partial interface IClassifiersClient
    {
        /// <summary>
        /// Classifications
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ClassificationResponse> ClassificationsV1ClassificationsPostAsync(

            global::G.ClassificationRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Classifications
        /// </summary>
        /// <param name="model">
        /// ID of the model to use.
        /// </param>
        /// <param name="input">
        /// Text to classify.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ClassificationResponse> ClassificationsV1ClassificationsPostAsync(
            string model,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>> input,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}