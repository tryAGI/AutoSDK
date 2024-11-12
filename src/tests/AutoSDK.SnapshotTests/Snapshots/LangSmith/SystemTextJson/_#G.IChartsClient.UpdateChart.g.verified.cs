//HintName: G.IChartsClient.UpdateChart.g.cs
#nullable enable

namespace G
{
    public partial interface IChartsClient
    {
        /// <summary>
        /// Update Chart<br/>
        /// Update a chart.
        /// </summary>
        /// <param name="chartId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CustomChartResponse> UpdateChartAsync(
            global::System.Guid chartId,
            global::G.CustomChartUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Chart<br/>
        /// Update a chart.
        /// </summary>
        /// <param name="chartId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="index"></param>
        /// <param name="chartType"></param>
        /// <param name="series"></param>
        /// <param name="sectionId"></param>
        /// <param name="metadata"></param>
        /// <param name="commonFilters"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CustomChartResponse> UpdateChartAsync(
            global::System.Guid chartId,
            global::G.AnyOf<string, global::G.Missing>? title = default,
            global::G.AnyOf<string, global::G.Missing>? description = default,
            global::G.AnyOf<int?, global::G.Missing>? index = default,
            global::G.AnyOf<global::G.CustomChartType?, global::G.Missing>? chartType = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.CustomChartSeriesUpdate>, global::G.Missing>? series = default,
            global::G.AnyOf<global::System.Guid?, global::G.Missing>? sectionId = default,
            global::G.AnyOf<object, global::G.Missing>? metadata = default,
            global::G.AnyOf<global::G.CustomChartSeriesFilters, global::G.Missing>? commonFilters = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}