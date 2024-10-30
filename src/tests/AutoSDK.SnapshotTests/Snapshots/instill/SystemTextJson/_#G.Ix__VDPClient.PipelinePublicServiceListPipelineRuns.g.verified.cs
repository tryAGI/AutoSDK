//HintName: G.Ix__VDPClient.PipelinePublicServiceListPipelineRuns.g.cs
#nullable enable

namespace G
{
    public partial interface Ix__VDPClient
    {
        /// <summary>
        /// List Pipeline Runs<br/>
        /// Returns a paginated list of runs for a given pipeline. When the requester<br/>
        /// is the owner of the pipeline, they will be able to all the pipeline runs,<br/>
        /// regardless the requester. Other requesters will only be able to see the<br/>
        /// runs requested by themselves.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListPipelineRunsResponse> PipelinePublicServiceListPipelineRunsAsync(
            string namespaceId,
            string pipelineId,
            int? page = default,
            int? pageSize = default,
            string? filter = default,
            string? orderBy = default,
            string? instillRequesterUid = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}