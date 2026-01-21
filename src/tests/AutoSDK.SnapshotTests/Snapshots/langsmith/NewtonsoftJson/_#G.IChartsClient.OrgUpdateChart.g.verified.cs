//HintName: G.IChartsClient.OrgUpdateChart.g.cs
#nullable enable

namespace G
{
    public partial interface IChartsClient
    {
        /// <summary>
        /// Org Update Chart<br/>
        /// Update a chart.
        /// </summary>
        /// <param name="chartId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CustomChartResponse> OrgUpdateChartAsync(
            global::System.Guid chartId,
            global::G.CustomChartUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Org Update Chart<br/>
        /// Update a chart.
        /// </summary>
        /// <param name="chartId"></param>
        /// <param name="title">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="description">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="index">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="chartType">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="series">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="sectionId">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="metadata">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="commonFilters">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CustomChartResponse> OrgUpdateChartAsync(
            global::System.Guid chartId,
            global::G.AnyOf<string, global::G.Missing>? title = default,
            global::G.AnyOf<string, global::G.Missing, object>? description = default,
            global::G.AnyOf<int?, global::G.Missing>? index = default,
            global::G.AnyOf<global::G.CustomChartType?, global::G.Missing>? chartType = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.CustomChartSeriesUpdate>, global::G.Missing>? series = default,
            global::G.AnyOf<global::System.Guid?, global::G.Missing>? sectionId = default,
            global::G.AnyOf<object, global::G.Missing, object>? metadata = default,
            global::G.AnyOf<global::G.CustomChartSeriesFilters2, global::G.Missing, object>? commonFilters = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}