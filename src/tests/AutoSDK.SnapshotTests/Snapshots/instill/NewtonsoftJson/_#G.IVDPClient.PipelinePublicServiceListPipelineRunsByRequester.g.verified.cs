//HintName: G.IVDPClient.PipelinePublicServiceListPipelineRunsByRequester.g.cs
#nullable enable

namespace G
{
    public partial interface IVDPClient
    {
        /// <summary>
        /// List Pipeline Runs of a Namespace (user or organization)<br/>
        /// Returns a paginated list of runs for 1 or more pipelines. This is mainly used by dashboard.<br/>
        /// The requester can view all the runs by the requester across different pipelines.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        /// <param name="requesterId"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListPipelineRunsByRequesterResponse> PipelinePublicServiceListPipelineRunsByRequesterAsync(
            string requesterId,
            int? page = default,
            int? pageSize = default,
            string? filter = default,
            string? orderBy = default,
            global::System.DateTime? start = default,
            global::System.DateTime? stop = default,
            string? instillRequesterUid = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}