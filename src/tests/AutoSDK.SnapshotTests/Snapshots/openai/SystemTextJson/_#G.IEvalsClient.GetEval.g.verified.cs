//HintName: G.IEvalsClient.GetEval.g.cs
#nullable enable

namespace G
{
    public partial interface IEvalsClient
    {
        /// <summary>
        /// Get an evaluation by ID.
        /// </summary>
        /// <param name="evalId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Eval> GetEvalAsync(
            string evalId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}