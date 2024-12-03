//HintName: G.IApi.CancelPredictions.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Cancel a prediction
        /// </summary>
        /// <param name="predictionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CancelPredictionsAsync(
            string predictionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}