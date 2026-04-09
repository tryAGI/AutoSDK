//HintName: G.IPredictionsClient.PredictionListV2EntityProjectPredictionsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IPredictionsClient
    {
        /// <summary>
        /// Prediction List<br/>
        /// List predictions.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="evaluationRunId">
        /// Filter by evaluation run ID
        /// </param>
        /// <param name="limit">
        /// Maximum number of predictions to return
        /// </param>
        /// <param name="offset">
        /// Number of predictions to skip
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::G.PredictionReadRes> PredictionListV2EntityProjectPredictionsGetAsync(
            string entity,
            string project,
            string? evaluationRunId = default,
            int? limit = default,
            int? offset = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}