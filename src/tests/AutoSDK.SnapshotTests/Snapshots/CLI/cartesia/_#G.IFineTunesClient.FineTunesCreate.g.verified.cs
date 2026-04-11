//HintName: G.IFineTunesClient.FineTunesCreate.g.cs
#nullable enable

namespace G
{
    public partial interface IFineTunesClient
    {
        /// <summary>
        /// Create a new fine-tune
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FineTune> FineTunesCreateAsync(
            global::G.FineTunesCreateCartesiaVersion cartesiaVersion,

            global::G.CreateFineTuneRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new fine-tune
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="name">
        /// Name for the new fine-tune
        /// </param>
        /// <param name="description">
        /// Description for the fine-tune
        /// </param>
        /// <param name="language">
        /// Language code for the fine-tune
        /// </param>
        /// <param name="modelId">
        /// Base model ID to fine-tune from
        /// </param>
        /// <param name="dataset">
        /// Dataset ID containing training files
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FineTune> FineTunesCreateAsync(
            global::G.FineTunesCreateCartesiaVersion cartesiaVersion,
            string name,
            string description,
            string language,
            string modelId,
            string dataset,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}