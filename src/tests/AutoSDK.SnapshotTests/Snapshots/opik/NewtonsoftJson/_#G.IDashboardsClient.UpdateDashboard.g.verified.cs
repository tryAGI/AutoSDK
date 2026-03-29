//HintName: G.IDashboardsClient.UpdateDashboard.g.cs
#nullable enable

namespace G
{
    public partial interface IDashboardsClient
    {
        /// <summary>
        /// Update dashboard<br/>
        /// Update dashboard by id. Partial updates are supported - only provided fields will be updated.
        /// </summary>
        /// <param name="dashboardId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DashboardPublic> UpdateDashboardAsync(
            global::System.Guid dashboardId,

            global::G.DashboardUpdatePublic request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update dashboard<br/>
        /// Update dashboard by id. Partial updates are supported - only provided fields will be updated.
        /// </summary>
        /// <param name="dashboardId"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="description"></param>
        /// <param name="config"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DashboardPublic> UpdateDashboardAsync(
            global::System.Guid dashboardId,
            string? name = default,
            global::G.DashboardUpdatePublicType? type = default,
            string? description = default,
            global::G.JsonNodePublic? config = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}