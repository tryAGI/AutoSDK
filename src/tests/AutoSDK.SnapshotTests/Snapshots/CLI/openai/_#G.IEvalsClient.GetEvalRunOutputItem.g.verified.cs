//HintName: G.IEvalsClient.GetEvalRunOutputItem.g.cs
#nullable enable

namespace G
{
    public partial interface IEvalsClient
    {
        /// <summary>
        /// Get an evaluation run output item by ID.
        /// </summary>
        /// <param name="evalId"></param>
        /// <param name="runId"></param>
        /// <param name="outputItemId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EvalRunOutputItem> GetEvalRunOutputItemAsync(
            string evalId,
            string runId,
            string outputItemId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}