//HintName: G.IPredictionsClient.EndPrediction.g.cs
#nullable enable

namespace G
{
    public partial interface IPredictionsClient
    {
        /// <summary>
        /// Locks, resolves, or cancels a Channel Points Prediction.<br/>
        /// Locks, resolves, or cancels a Channel Points Prediction.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:predictions** scope.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EndPredictionResponse> EndPredictionAsync(
            global::G.EndPredictionBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Locks, resolves, or cancels a Channel Points Prediction.<br/>
        /// Locks, resolves, or cancels a Channel Points Prediction.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:predictions** scope.
        /// </summary>
        /// <param name="broadcasterId">
        /// The ID of the broadcaster that’s running the prediction. This ID must match the user ID in the user access token.
        /// </param>
        /// <param name="id">
        /// The ID of the prediction to update.
        /// </param>
        /// <param name="status">
        /// The status to set the prediction to. Possible case-sensitive values are:  <br/>
        ///   <br/>
        /// * RESOLVED — The winning outcome is determined and the Channel Points are distributed to the viewers who predicted the correct outcome.<br/>
        /// * CANCELED — The broadcaster is canceling the prediction and sending refunds to the participants.<br/>
        /// * LOCKED — The broadcaster is locking the prediction, which means viewers may no longer make predictions.<br/>
        ///   <br/>
        /// The broadcaster can update an active prediction to LOCKED, RESOLVED, or CANCELED; and update a locked prediction to RESOLVED or CANCELED.  <br/>
        ///   <br/>
        /// The broadcaster has up to 24 hours after the prediction window closes to resolve the prediction. If not, Twitch sets the status to CANCELED and returns the points.
        /// </param>
        /// <param name="winningOutcomeId">
        /// The ID of the winning outcome. You must set this parameter if you set `status` to RESOLVED.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EndPredictionResponse> EndPredictionAsync(
            string broadcasterId,
            string id,
            global::G.EndPredictionBodyStatus status,
            string? winningOutcomeId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}