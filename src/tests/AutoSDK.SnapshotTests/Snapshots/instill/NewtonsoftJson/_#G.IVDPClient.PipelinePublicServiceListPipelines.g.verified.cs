//HintName: G.IVDPClient.PipelinePublicServiceListPipelines.g.cs
#nullable enable

namespace G
{
    public partial interface IVDPClient
    {
        /// <summary>
        /// List accessible pipelines<br/>
        /// Returns a paginated list of pipelines that are visible to the requester.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="view"></param>
        /// <param name="filter"></param>
        /// <param name="showDeleted"></param>
        /// <param name="visibility"></param>
        /// <param name="orderBy"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListPipelinesResponse> PipelinePublicServiceListPipelinesAsync(
            int? pageSize = default,
            string? pageToken = default,
            global::G.PipelinePublicServiceListPipelinesView? view = default,
            string? filter = default,
            bool? showDeleted = default,
            global::G.PipelinePublicServiceListPipelinesVisibility? visibility = default,
            string? orderBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}