//HintName: G.IProjectsClient.GetProjectMetrics.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get Project Metrics<br/>
        /// Gets specified metrics for a project
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectMetricResponsePublic> GetProjectMetricsAsync(
            global::System.Guid id,

            global::G.ProjectMetricRequestPublic request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Project Metrics<br/>
        /// Gets specified metrics for a project
        /// </summary>
        /// <param name="id"></param>
        /// <param name="metricType"></param>
        /// <param name="interval"></param>
        /// <param name="intervalStart"></param>
        /// <param name="intervalEnd"></param>
        /// <param name="spanFilters"></param>
        /// <param name="traceFilters"></param>
        /// <param name="threadFilters"></param>
        /// <param name="breakdown"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectMetricResponsePublic> GetProjectMetricsAsync(
            global::System.Guid id,
            global::G.ProjectMetricRequestPublicMetricType? metricType = default,
            global::G.ProjectMetricRequestPublicInterval? interval = default,
            global::System.DateTime? intervalStart = default,
            global::System.DateTime? intervalEnd = default,
            global::System.Collections.Generic.IList<global::G.SpanFilterPublic>? spanFilters = default,
            global::System.Collections.Generic.IList<global::G.TraceFilterPublic>? traceFilters = default,
            global::System.Collections.Generic.IList<global::G.TraceThreadFilterPublic>? threadFilters = default,
            global::G.BreakdownConfigPublic? breakdown = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}