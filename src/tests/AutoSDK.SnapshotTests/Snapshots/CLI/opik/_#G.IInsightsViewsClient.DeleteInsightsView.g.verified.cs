//HintName: G.IInsightsViewsClient.DeleteInsightsView.g.cs
#nullable enable

namespace G
{
    public partial interface IInsightsViewsClient
    {
        /// <summary>
        /// Delete insights view<br/>
        /// Delete insights view by id
        /// </summary>
        /// <param name="insightsViewId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteInsightsViewAsync(
            global::System.Guid insightsViewId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}