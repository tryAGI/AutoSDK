//HintName: G.IChartsClient.DeleteChart.g.cs
#nullable enable

namespace G
{
    public partial interface IChartsClient
    {
        /// <summary>
        /// Delete Chart<br/>
        /// Delete a chart.
        /// </summary>
        /// <param name="chartId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteChartAsync(
            global::System.Guid chartId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}