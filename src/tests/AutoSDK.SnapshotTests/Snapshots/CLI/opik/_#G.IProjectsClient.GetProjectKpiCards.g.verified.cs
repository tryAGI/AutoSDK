//HintName: G.IProjectsClient.GetProjectKpiCards.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get Project KPI Cards<br/>
        /// Gets KPI card metrics for a project
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.KpiCardResponse> GetProjectKpiCardsAsync(
            global::System.Guid id,

            global::G.KpiCardRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Project KPI Cards<br/>
        /// Gets KPI card metrics for a project
        /// </summary>
        /// <param name="id"></param>
        /// <param name="entityType"></param>
        /// <param name="filters"></param>
        /// <param name="intervalStart"></param>
        /// <param name="intervalEnd"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.KpiCardResponse> GetProjectKpiCardsAsync(
            global::System.Guid id,
            global::G.KpiCardRequestEntityType entityType,
            global::System.DateTime intervalStart,
            global::System.DateTime intervalEnd,
            string? filters = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}