//HintName: G.IRunClient.MultipartIngestRuns.g.cs
#nullable enable

namespace G
{
    public partial interface IRunClient
    {
        /// <summary>
        /// Multipart Ingest Runs<br/>
        /// Batch ingest runs.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MultipartIngestRunsApiV1RunsMultipartPostResponse> MultipartIngestRunsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}