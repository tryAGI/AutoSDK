//HintName: G.IRunClient.BatchIngestRuns.g.cs
#nullable enable

namespace G
{
    public partial interface IRunClient
    {
        /// <summary>
        /// Batch Ingest Runs<br/>
        /// Batch ingest runs.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> BatchIngestRunsAsync(
            global::G.BatchIngestRunsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Batch Ingest Runs<br/>
        /// Batch ingest runs.
        /// </summary>
        /// <param name="post"></param>
        /// <param name="patch"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> BatchIngestRunsAsync(
            global::System.Collections.Generic.IList<global::G.BatchIngestRunsRequestPostItem>? post = default,
            global::System.Collections.Generic.IList<global::G.BatchIngestRunsRequestPatchItem>? patch = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}