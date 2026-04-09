//HintName: G.IDatasetsClient.GetDatasetIdFetch.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Fetch dataset (GET form)<br/>
        /// Fetch the events in a dataset. Equivalent to the POST form of the same path, but with the parameters in the URL query rather than in the request body. For more complex queries, use the `POST /btql` endpoint.
        /// </summary>
        /// <param name="datasetId">
        /// Dataset id
        /// </param>
        /// <param name="limit">
        /// limit the number of traces fetched<br/>
        /// Fetch queries may be paginated if the total result size is expected to be large (e.g. project_logs which accumulate over a long time). Note that fetch queries only support pagination in descending time order (from latest to earliest `_xact_id`. Furthermore, later pages may return rows which showed up in earlier pages, except with an earlier `_xact_id`. This happens because pagination occurs over the whole version history of the event log. You will most likely want to exclude any such duplicate, outdated rows (by `id`) from your combined result set.<br/>
        /// The `limit` parameter controls the number of full traces to return. So you may end up with more individual rows than the specified limit if you are fetching events containing traces.
        /// </param>
        /// <param name="maxXactId">
        /// DEPRECATION NOTICE: The manually-constructed pagination cursor is deprecated in favor of the explicit 'cursor' returned by object fetch requests. Please prefer the 'cursor' argument going forwards.<br/>
        /// Together, `max_xact_id` and `max_root_span_id` form a pagination cursor<br/>
        /// Since a paginated fetch query returns results in order from latest to earliest, the cursor for the next page can be found as the row with the minimum (earliest) value of the tuple `(_xact_id, root_span_id)`. See the documentation of `limit` for an overview of paginating fetch queries.
        /// </param>
        /// <param name="maxRootSpanId">
        /// DEPRECATION NOTICE: The manually-constructed pagination cursor is deprecated in favor of the explicit 'cursor' returned by object fetch requests. Please prefer the 'cursor' argument going forwards.<br/>
        /// Together, `max_xact_id` and `max_root_span_id` form a pagination cursor<br/>
        /// Since a paginated fetch query returns results in order from latest to earliest, the cursor for the next page can be found as the row with the minimum (earliest) value of the tuple `(_xact_id, root_span_id)`. See the documentation of `limit` for an overview of paginating fetch queries.
        /// </param>
        /// <param name="version">
        /// Retrieve a snapshot of events from a past time<br/>
        /// The version id is essentially a filter on the latest event transaction id. You can use the `max_xact_id` returned by a past fetch as the version to reproduce that exact fetch.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FetchDatasetEventsResponse> GetDatasetIdFetchAsync(
            global::System.Guid datasetId,
            int? limit = default,
            string? maxXactId = default,
            string? maxRootSpanId = default,
            string? version = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}