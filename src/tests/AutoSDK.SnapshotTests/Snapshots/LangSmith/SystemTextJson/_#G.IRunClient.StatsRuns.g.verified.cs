//HintName: G.IRunClient.StatsRuns.g.cs
#nullable enable

namespace G
{
    public partial interface IRunClient
    {
        /// <summary>
        /// Stats Runs<br/>
        /// Get all runs by query in body payload.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RunStats> StatsRunsAsync(
            global::G.FilterQueryParamsForRunSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Stats Runs<br/>
        /// Get all runs by query in body payload.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="trace"></param>
        /// <param name="parentRun"></param>
        /// <param name="runType"></param>
        /// <param name="session"></param>
        /// <param name="referenceExample"></param>
        /// <param name="executionOrder"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="error"></param>
        /// <param name="query"></param>
        /// <param name="filter"></param>
        /// <param name="traceFilter"></param>
        /// <param name="treeFilter"></param>
        /// <param name="isRoot"></param>
        /// <param name="dataSourceType"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RunStats> StatsRunsAsync(
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? id = default,
            global::G.AnyOf<global::System.Guid?, object>? trace = default,
            global::G.AnyOf<global::System.Guid?, object>? parentRun = default,
            global::G.AnyOf<global::G.RunTypeEnum?, object>? runType = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? session = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? referenceExample = default,
            global::G.AnyOf<int?, object>? executionOrder = default,
            global::G.AnyOf<global::System.DateTime?, object>? startTime = default,
            global::G.AnyOf<global::System.DateTime?, object>? endTime = default,
            global::G.AnyOf<bool?, object>? error = default,
            global::G.AnyOf<string, object>? query = default,
            global::G.AnyOf<string, object>? filter = default,
            global::G.AnyOf<string, object>? traceFilter = default,
            global::G.AnyOf<string, object>? treeFilter = default,
            global::G.AnyOf<bool?, object>? isRoot = default,
            global::G.AnyOf<global::G.RunsFilterDataSourceTypeEnum?, object>? dataSourceType = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}