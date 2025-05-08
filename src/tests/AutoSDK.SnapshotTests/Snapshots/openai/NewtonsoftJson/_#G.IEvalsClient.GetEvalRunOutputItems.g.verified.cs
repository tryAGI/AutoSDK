//HintName: G.IEvalsClient.GetEvalRunOutputItems.g.cs
#nullable enable

namespace G
{
    public partial interface IEvalsClient
    {
        /// <summary>
        /// Get a list of output items for an evaluation run.
        /// </summary>
        /// <param name="evalId"></param>
        /// <param name="runId"></param>
        /// <param name="after"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="status"></param>
        /// <param name="order">
        /// Default Value: asc
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EvalRunOutputItemList> GetEvalRunOutputItemsAsync(
            string evalId,
            string runId,
            string? after = default,
            int? limit = default,
            global::G.GetEvalRunOutputItemsStatus? status = default,
            global::G.GetEvalRunOutputItemsOrder? order = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}