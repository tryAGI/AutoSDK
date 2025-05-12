//HintName: G.IRunClient.DeleteRuns.g.cs
#nullable enable

namespace G
{
    public partial interface IRunClient
    {
        /// <summary>
        /// Delete Runs<br/>
        /// Delete specific runs.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteRunsAsync(
            global::G.BodyDeleteRunsApiV1RunsDeletePost request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete Runs<br/>
        /// Delete specific runs.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="traceIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteRunsAsync(
            global::System.Guid sessionId,
            global::System.Collections.Generic.IList<global::System.Guid> traceIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}