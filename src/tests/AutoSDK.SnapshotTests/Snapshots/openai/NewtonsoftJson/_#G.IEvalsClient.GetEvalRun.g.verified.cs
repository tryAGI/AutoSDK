//HintName: G.IEvalsClient.GetEvalRun.g.cs
#nullable enable

namespace G
{
    public partial interface IEvalsClient
    {
        /// <summary>
        /// Get an evaluation run by ID.
        /// </summary>
        /// <param name="evalId"></param>
        /// <param name="runId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EvalRun> GetEvalRunAsync(
            string evalId,
            string runId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}