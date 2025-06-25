//HintName: G.IPredictionsClient.CreatePrediction.g.cs
#nullable enable

namespace G
{
    public partial interface IPredictionsClient
    {
        /// <summary>
        /// Create a Channel Points Prediction.<br/>
        /// Creates a Channel Points Prediction.<br/>
        /// With a Channel Points Prediction, the broadcaster poses a question and viewers try to predict the outcome. The prediction runs as soon as it’s created. The broadcaster may run only one prediction at a time.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:predictions** scope.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreatePredictionResponse> CreatePredictionAsync(
            global::G.CreatePredictionBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a Channel Points Prediction.<br/>
        /// Creates a Channel Points Prediction.<br/>
        /// With a Channel Points Prediction, the broadcaster poses a question and viewers try to predict the outcome. The prediction runs as soon as it’s created. The broadcaster may run only one prediction at a time.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:predictions** scope.
        /// </summary>
        /// <param name="broadcasterId">
        /// The ID of the broadcaster that’s running the prediction. This ID must match the user ID in the user access token.
        /// </param>
        /// <param name="title">
        /// The question that the broadcaster is asking. For example, _Will I finish this entire pizza?_ The title is limited to a maximum of 45 characters.
        /// </param>
        /// <param name="outcomes">
        /// The list of possible outcomes that the viewers may choose from. The list must contain a minimum of 2 choices and up to a maximum of 10 choices.
        /// </param>
        /// <param name="predictionWindow">
        /// The length of time (in seconds) that the prediction will run for. The minimum is 30 seconds and the maximum is 1800 seconds (30 minutes).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreatePredictionResponse> CreatePredictionAsync(
            string broadcasterId,
            string title,
            global::System.Collections.Generic.IList<global::G.CreatePredictionBodyOutcome> outcomes,
            int predictionWindow,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}