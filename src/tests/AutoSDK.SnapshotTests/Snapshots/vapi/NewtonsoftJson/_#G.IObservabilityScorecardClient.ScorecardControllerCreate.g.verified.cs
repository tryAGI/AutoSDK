//HintName: G.IObservabilityScorecardClient.ScorecardControllerCreate.g.cs
#nullable enable

namespace G
{
    public partial interface IObservabilityScorecardClient
    {
        /// <summary>
        /// Create Scorecard
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Scorecard> ScorecardControllerCreateAsync(

            global::G.CreateScorecardDTO request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Scorecard
        /// </summary>
        /// <param name="name">
        /// This is the name of the scorecard. It is only for user reference and will not be used for any evaluation.
        /// </param>
        /// <param name="description">
        /// This is the description of the scorecard. It is only for user reference and will not be used for any evaluation.
        /// </param>
        /// <param name="metrics">
        /// These are the metrics that will be used to evaluate the scorecard.<br/>
        /// Each metric will have a set of conditions and points that will be used to generate the score.
        /// </param>
        /// <param name="assistantIds">
        /// These are the assistant IDs that this scorecard is linked to.<br/>
        /// When linked to assistants, this scorecard will be available for evaluation during those assistants' calls.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Scorecard> ScorecardControllerCreateAsync(
            global::System.Collections.Generic.IList<global::G.ScorecardMetric> metrics,
            string? name = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? assistantIds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}