//HintName: G.IPredictionsClient.PredictionCreateV2EntityProjectPredictionsPost.g.cs
#nullable enable

namespace G
{
    public partial interface IPredictionsClient
    {
        /// <summary>
        /// Prediction Create<br/>
        /// Create a prediction.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PredictionCreateRes> PredictionCreateV2EntityProjectPredictionsPostAsync(
            string entity,
            string project,

            global::G.PredictionCreateBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Prediction Create<br/>
        /// Create a prediction.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="model">
        /// The model reference (weave:// URI)
        /// </param>
        /// <param name="inputs">
        /// The inputs to the prediction
        /// </param>
        /// <param name="output">
        /// The output of the prediction
        /// </param>
        /// <param name="evaluationRunId">
        /// Optional evaluation run ID to link this prediction as a child call
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PredictionCreateRes> PredictionCreateV2EntityProjectPredictionsPostAsync(
            string entity,
            string project,
            string model,
            object inputs,
            object output,
            string? evaluationRunId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}