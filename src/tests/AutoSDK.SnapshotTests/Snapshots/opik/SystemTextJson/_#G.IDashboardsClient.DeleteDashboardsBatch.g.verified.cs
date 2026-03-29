//HintName: G.IDashboardsClient.DeleteDashboardsBatch.g.cs
#nullable enable

namespace G
{
    public partial interface IDashboardsClient
    {
        /// <summary>
        /// Delete dashboards<br/>
        /// Delete dashboards batch
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteDashboardsBatchAsync(

            global::G.BatchDelete request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete dashboards<br/>
        /// Delete dashboards batch
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DeleteDashboardsBatchAsync(
            global::System.Collections.Generic.IList<global::System.Guid> ids,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}