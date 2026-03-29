//HintName: G.IEvalClient.EvalControllerGetRun.g.cs
#nullable enable

namespace G
{
    public partial interface IEvalClient
    {
        /// <summary>
        /// Get Eval Run
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EvalRun> EvalControllerGetRunAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}