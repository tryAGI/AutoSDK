//HintName: G.Ix__ModelClient.ModelPublicServiceListModelRunsByRequester.g.cs
#nullable enable

namespace G
{
    public partial interface Ix__ModelClient
    {
        /// <summary>
        /// List Model Runs of a Namespace (user or organization)<br/>
        /// Returns a paginated list of runs for 1 or more models. This is mainly used by dashboard.<br/>
        /// The requester can view all the runs by the requester across different models.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="page"></param>
        /// <param name="orderBy"></param>
        /// <param name="filter"></param>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        /// <param name="requesterId"></param>
        /// <param name="instillRequesterUid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListModelRunsByRequesterResponse> ModelPublicServiceListModelRunsByRequesterAsync(
            string requesterId,
            int? pageSize = default,
            int? page = default,
            string? orderBy = default,
            string? filter = default,
            global::System.DateTime? start = default,
            global::System.DateTime? stop = default,
            string? instillRequesterUid = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}