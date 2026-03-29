//HintName: G.IPredictionsClient.PredictionFinishV2EntityProjectPredictionsPredictionIdFinishPost.g.cs
#nullable enable

namespace G
{
    public partial interface IPredictionsClient
    {
        /// <summary>
        /// Prediction Finish<br/>
        /// Finish a prediction.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="predictionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PredictionFinishRes> PredictionFinishV2EntityProjectPredictionsPredictionIdFinishPostAsync(
            string entity,
            string project,
            string predictionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}