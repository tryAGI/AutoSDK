//HintName: G.IEvalsClient.CancelEvalRun.g.cs
#nullable enable

namespace G
{
    public partial interface IEvalsClient
    {
        /// <summary>
        /// Cancel an ongoing evaluation run.
        /// </summary>
        /// <param name="evalId"></param>
        /// <param name="runId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EvalRun> CancelEvalRunAsync(
            string evalId,
            string runId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}