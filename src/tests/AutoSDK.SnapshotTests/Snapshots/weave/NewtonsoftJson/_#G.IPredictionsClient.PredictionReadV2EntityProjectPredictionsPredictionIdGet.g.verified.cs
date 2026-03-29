//HintName: G.IPredictionsClient.PredictionReadV2EntityProjectPredictionsPredictionIdGet.g.cs
#nullable enable

namespace G
{
    public partial interface IPredictionsClient
    {
        /// <summary>
        /// Prediction Read<br/>
        /// Read a prediction.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="predictionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PredictionReadRes> PredictionReadV2EntityProjectPredictionsPredictionIdGetAsync(
            string entity,
            string project,
            string predictionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}