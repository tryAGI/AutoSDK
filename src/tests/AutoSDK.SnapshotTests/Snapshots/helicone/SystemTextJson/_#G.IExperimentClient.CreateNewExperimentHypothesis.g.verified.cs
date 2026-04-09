//HintName: G.IExperimentClient.CreateNewExperimentHypothesis.g.cs
#nullable enable

namespace G
{
    public partial interface IExperimentClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultHypothesisIdStringString> CreateNewExperimentHypothesisAsync(

            global::G.CreateNewExperimentHypothesisRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="status"></param>
        /// <param name="providerKeyId"></param>
        /// <param name="promptVersion"></param>
        /// <param name="model"></param>
        /// <param name="experimentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultHypothesisIdStringString> CreateNewExperimentHypothesisAsync(
            global::G.CreateNewExperimentHypothesisRequestStatus status,
            string providerKeyId,
            string promptVersion,
            string model,
            string experimentId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}