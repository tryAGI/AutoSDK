//HintName: G.IEvalsClient.GetEvalRuns.g.cs
#nullable enable

namespace G
{
    public partial interface IEvalsClient
    {
        /// <summary>
        /// Get a list of runs for an evaluation.
        /// </summary>
        /// <param name="evalId"></param>
        /// <param name="after"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// Default Value: asc
        /// </param>
        /// <param name="status"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EvalRunList> GetEvalRunsAsync(
            string evalId,
            string? after = default,
            int? limit = default,
            global::G.GetEvalRunsOrder? order = default,
            global::G.GetEvalRunsStatus? status = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}