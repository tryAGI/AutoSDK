//HintName: G.IVdpClient.PipelinePublicServiceListComponentRuns.g.cs
#nullable enable

namespace G
{
    public partial interface IVdpClient
    {
        /// <summary>
        /// List Component runs<br/>
        /// Returns the information of each component execution within a pipeline run.
        /// </summary>
        /// <param name="pipelineRunId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <param name="view"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListComponentRunsResponse> PipelinePublicServiceListComponentRunsAsync(
            string pipelineRunId,
            int? page = default,
            int? pageSize = default,
            string? filter = default,
            string? orderBy = default,
            global::G.PipelinePublicServiceListComponentRunsView? view = default,
            string? instillRequesterUid = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}