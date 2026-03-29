//HintName: G.IDashboardsClient.GetDashboardById.g.cs
#nullable enable

namespace G
{
    public partial interface IDashboardsClient
    {
        /// <summary>
        /// Get dashboard by id<br/>
        /// Get dashboard by id
        /// </summary>
        /// <param name="dashboardId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DashboardPublic> GetDashboardByIdAsync(
            global::System.Guid dashboardId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}