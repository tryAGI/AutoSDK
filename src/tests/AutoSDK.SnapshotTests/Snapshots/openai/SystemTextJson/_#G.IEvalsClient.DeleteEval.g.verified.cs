//HintName: G.IEvalsClient.DeleteEval.g.cs
#nullable enable

namespace G
{
    public partial interface IEvalsClient
    {
        /// <summary>
        /// Delete an evaluation.
        /// </summary>
        /// <param name="evalId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteEvalResponse> DeleteEvalAsync(
            string evalId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}