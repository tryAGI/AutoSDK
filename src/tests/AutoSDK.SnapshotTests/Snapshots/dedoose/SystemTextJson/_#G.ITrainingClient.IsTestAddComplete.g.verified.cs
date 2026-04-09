//HintName: G.ITrainingClient.IsTestAddComplete.g.cs
#nullable enable

namespace G
{
    public partial interface ITrainingClient
    {
        /// <summary>
        /// IsTestAddComplete<br/>
        /// IsTestAddComplete
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<bool> IsTestAddCompleteAsync(

            global::G.IsTestAddCompleteRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// IsTestAddComplete<br/>
        /// IsTestAddComplete
        /// </summary>
        /// <param name="addTestWorkerId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<bool> IsTestAddCompleteAsync(
            string addTestWorkerId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}