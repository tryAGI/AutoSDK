//HintName: G.IWorkspacesClient.GetMetric.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Get metric daily data<br/>
        /// Get metric daily data
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.WorkspaceMetricResponse> GetMetricAsync(

            global::G.WorkspaceMetricsSummaryRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get metric daily data<br/>
        /// Get metric daily data
        /// </summary>
        /// <param name="projectIds"></param>
        /// <param name="intervalStart"></param>
        /// <param name="intervalEnd"></param>
        /// <param name="startBeforeEnd"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.WorkspaceMetricResponse> GetMetricAsync(
            global::System.DateTime intervalStart,
            global::System.DateTime intervalEnd,
            global::System.Collections.Generic.IList<global::System.Guid>? projectIds = default,
            bool? startBeforeEnd = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}