//HintName: G.IInsightsViewsClient.FindInsightsViews.g.cs
#nullable enable

namespace G
{
    public partial interface IInsightsViewsClient
    {
        /// <summary>
        /// Find insights views<br/>
        /// Find insights views in a workspace
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="name">
        /// Filter insights views by name (partial match, case insensitive)
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="sorting"></param>
        /// <param name="filters"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DashboardPagePublic> FindInsightsViewsAsync(
            int? page = default,
            int? size = default,
            string? name = default,
            global::System.Guid? projectId = default,
            string? sorting = default,
            string? filters = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}