//HintName: G.IPredictionsClient.PredictionDeleteV2EntityProjectPredictionsDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IPredictionsClient
    {
        /// <summary>
        /// Prediction Delete<br/>
        /// Delete predictions.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="predictionIds">
        /// List of prediction IDs to delete
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PredictionDeleteRes> PredictionDeleteV2EntityProjectPredictionsDeleteAsync(
            string entity,
            string project,
            global::System.Collections.Generic.IList<string> predictionIds,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}