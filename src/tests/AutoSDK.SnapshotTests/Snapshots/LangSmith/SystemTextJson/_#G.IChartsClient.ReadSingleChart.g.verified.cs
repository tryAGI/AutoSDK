//HintName: G.IChartsClient.ReadSingleChart.g.cs
#nullable enable

namespace G
{
    public partial interface IChartsClient
    {
        /// <summary>
        /// Read Single Chart<br/>
        /// Get a single chart by ID.
        /// </summary>
        /// <param name="chartId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SingleCustomChartResponse> ReadSingleChartAsync(
            global::System.Guid chartId,
            global::G.CustomChartsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Read Single Chart<br/>
        /// Get a single chart by ID.
        /// </summary>
        /// <param name="chartId"></param>
        /// <param name="timezone">
        /// Default Value: UTC
        /// </param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stride"></param>
        /// <param name="afterIndex"></param>
        /// <param name="tagValueId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SingleCustomChartResponse> ReadSingleChartAsync(
            global::System.Guid chartId,
            global::System.DateTime startTime,
            string? timezone = "UTC",
            global::G.AnyOf<global::System.DateTime?, object>? endTime = default,
            global::G.AllOf<global::G.TimedeltaInput>? stride = default,
            global::G.AnyOf<int?, object>? afterIndex = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? tagValueId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}