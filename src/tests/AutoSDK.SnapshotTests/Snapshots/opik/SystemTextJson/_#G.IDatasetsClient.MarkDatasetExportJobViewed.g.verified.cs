//HintName: G.IDatasetsClient.MarkDatasetExportJobViewed.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Mark dataset export job as viewed<br/>
        /// Marks a dataset export job as viewed by setting the viewed_at timestamp. This is used to track that a user has seen a failed job's error message. This operation is idempotent.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task MarkDatasetExportJobViewedAsync(
            global::System.Guid jobId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}