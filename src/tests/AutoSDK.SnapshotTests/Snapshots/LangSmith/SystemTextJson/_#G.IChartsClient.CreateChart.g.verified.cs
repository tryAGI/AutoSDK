//HintName: G.IChartsClient.CreateChart.g.cs
#nullable enable

namespace G
{
    public partial interface IChartsClient
    {
        /// <summary>
        /// Create Chart<br/>
        /// Create a new chart.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CustomChartResponse> CreateChartAsync(
            global::G.CustomChartCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Chart<br/>
        /// Create a new chart.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="index"></param>
        /// <param name="chartType">
        /// Enum for custom chart types.
        /// </param>
        /// <param name="series"></param>
        /// <param name="sectionId"></param>
        /// <param name="metadata"></param>
        /// <param name="commonFilters"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CustomChartResponse> CreateChartAsync(
            string title,
            global::G.CustomChartType chartType,
            global::System.Collections.Generic.IList<global::G.CustomChartSeriesCreate> series,
            global::G.AnyOf<string, object>? description = default,
            global::G.AnyOf<int?, object>? index = default,
            global::G.AnyOf<global::System.Guid?, object>? sectionId = default,
            global::G.AnyOf<object, object>? metadata = default,
            global::G.AnyOf<global::G.CustomChartSeriesFilters, object>? commonFilters = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}