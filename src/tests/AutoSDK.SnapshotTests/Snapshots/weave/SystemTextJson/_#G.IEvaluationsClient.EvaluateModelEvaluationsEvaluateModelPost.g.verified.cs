//HintName: G.IEvaluationsClient.EvaluateModelEvaluationsEvaluateModelPost.g.cs
#nullable enable

namespace G
{
    public partial interface IEvaluationsClient
    {
        /// <summary>
        /// Evaluate Model
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EvaluateModelRes> EvaluateModelEvaluationsEvaluateModelPostAsync(

            global::G.EvaluateModelReq request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Evaluate Model
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="evaluationRef"></param>
        /// <param name="modelRef"></param>
        /// <param name="wbUserId">
        /// Do not set directly. Server will automatically populate this field.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EvaluateModelRes> EvaluateModelEvaluationsEvaluateModelPostAsync(
            string projectId,
            string evaluationRef,
            string modelRef,
            string? wbUserId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}