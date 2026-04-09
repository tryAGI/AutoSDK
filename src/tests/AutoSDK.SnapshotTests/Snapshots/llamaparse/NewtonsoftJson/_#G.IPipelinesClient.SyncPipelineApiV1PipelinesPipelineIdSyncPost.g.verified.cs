//HintName: G.IPipelinesClient.SyncPipelineApiV1PipelinesPipelineIdSyncPost.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Sync Pipeline<br/>
        /// Trigger an incremental sync for a managed pipeline.<br/>
        /// Processes new and updated documents from data sources and<br/>
        /// files, then updates the index for retrieval.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Pipeline> SyncPipelineApiV1PipelinesPipelineIdSyncPostAsync(
            global::System.Guid pipelineId,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}