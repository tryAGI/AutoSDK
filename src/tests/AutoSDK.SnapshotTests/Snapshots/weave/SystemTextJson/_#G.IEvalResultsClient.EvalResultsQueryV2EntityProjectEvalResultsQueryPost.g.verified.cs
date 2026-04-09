//HintName: G.IEvalResultsClient.EvalResultsQueryV2EntityProjectEvalResultsQueryPost.g.cs
#nullable enable

namespace G
{
    public partial interface IEvalResultsClient
    {
        /// <summary>
        /// Eval Results Query<br/>
        /// Read grouped evaluation result rows for one or more evaluations.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EvalResultsQueryRes> EvalResultsQueryV2EntityProjectEvalResultsQueryPostAsync(
            string entity,
            string project,

            global::G.EvalResultsQueryBody request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Eval Results Query<br/>
        /// Read grouped evaluation result rows for one or more evaluations.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="evaluationCallIds">
        /// Evaluation root call IDs to include.
        /// </param>
        /// <param name="evaluationRunIds">
        /// Alias for evaluation call IDs from the Evaluation Runs API.
        /// </param>
        /// <param name="requireIntersection">
        /// When true, only include rows present in all requested evaluations.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeRawDataRows">
        /// When true, populate raw_data_row on each result row. Inline rows are returned as their dict value; dataset-referenced rows are returned as the ref string unless resolve_row_refs is also true.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="resolveRowRefs">
        /// When true (requires include_raw_data_rows=True), resolve dataset-row reference strings to actual row data via a table lookup. When false, dataset-row refs are returned as-is.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeRows">
        /// When true, include grouped row/trial data in `rows` and compute `total_rows` for the requested row-level view.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="includeSummary">
        /// When true, include aggregated scorer/evaluation summary data in `summary`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="summaryRequireIntersection">
        /// Optional intersection behavior for the summary section. When null, the value of `require_intersection` is used.
        /// </param>
        /// <param name="limit">
        /// Optional row-level page size applied after grouping and intersection.
        /// </param>
        /// <param name="offset">
        /// Optional row-level page offset applied after grouping and intersection.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EvalResultsQueryRes> EvalResultsQueryV2EntityProjectEvalResultsQueryPostAsync(
            string entity,
            string project,
            global::System.Collections.Generic.IList<string>? evaluationCallIds = default,
            global::System.Collections.Generic.IList<string>? evaluationRunIds = default,
            bool? requireIntersection = default,
            bool? includeRawDataRows = default,
            bool? resolveRowRefs = default,
            bool? includeRows = default,
            bool? includeSummary = default,
            bool? summaryRequireIntersection = default,
            int? limit = default,
            int? offset = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}