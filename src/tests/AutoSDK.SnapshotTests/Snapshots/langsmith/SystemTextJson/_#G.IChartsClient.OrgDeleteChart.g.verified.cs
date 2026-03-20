//HintName: G.IChartsClient.OrgDeleteChart.g.cs
#nullable enable

namespace G
{
    public partial interface IChartsClient
    {
        /// <summary>
        /// Org Delete Chart<br/>
        /// Delete a chart.
        /// </summary>
        /// <param name="chartId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> OrgDeleteChartAsync(
            global::System.Guid chartId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}