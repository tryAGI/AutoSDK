//HintName: G.IRemeshClient.ListRemeshTasks.g.cs
#nullable enable

namespace G
{
    public partial interface IRemeshClient
    {
        /// <summary>
        /// List Remesh tasks
        /// </summary>
        /// <param name="pageNum">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 10
        /// </param>
        /// <param name="sortBy"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.RemeshTask>> ListRemeshTasksAsync(
            int? pageNum = default,
            int? pageSize = default,
            global::G.ListRemeshTasksSortBy? sortBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}