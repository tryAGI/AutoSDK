//HintName: G.Models.FetchEventsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FetchEventsRequest
    {
        /// <summary>
        /// limit the number of traces fetched<br/>
        /// Fetch queries may be paginated if the total result size is expected to be large (e.g. project_logs which accumulate over a long time). Note that fetch queries only support pagination in descending time order (from latest to earliest `_xact_id`. Furthermore, later pages may return rows which showed up in earlier pages, except with an earlier `_xact_id`. This happens because pagination occurs over the whole version history of the event log. You will most likely want to exclude any such duplicate, outdated rows (by `id`) from your combined result set.<br/>
        /// The `limit` parameter controls the number of full traces to return. So you may end up with more individual rows than the specified limit if you are fetching events containing traces.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// An opaque string to be used as a cursor for the next page of results, in order from latest to earliest.<br/>
        /// The string can be obtained directly from the `cursor` property of the previous fetch query
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// DEPRECATION NOTICE: The manually-constructed pagination cursor is deprecated in favor of the explicit 'cursor' returned by object fetch requests. Please prefer the 'cursor' argument going forwards.<br/>
        /// Together, `max_xact_id` and `max_root_span_id` form a pagination cursor<br/>
        /// Since a paginated fetch query returns results in order from latest to earliest, the cursor for the next page can be found as the row with the minimum (earliest) value of the tuple `(_xact_id, root_span_id)`. See the documentation of `limit` for an overview of paginating fetch queries.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_xact_id")]
        public string? MaxXactId { get; set; }

        /// <summary>
        /// DEPRECATION NOTICE: The manually-constructed pagination cursor is deprecated in favor of the explicit 'cursor' returned by object fetch requests. Please prefer the 'cursor' argument going forwards.<br/>
        /// Together, `max_xact_id` and `max_root_span_id` form a pagination cursor<br/>
        /// Since a paginated fetch query returns results in order from latest to earliest, the cursor for the next page can be found as the row with the minimum (earliest) value of the tuple `(_xact_id, root_span_id)`. See the documentation of `limit` for an overview of paginating fetch queries.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_root_span_id")]
        public string? MaxRootSpanId { get; set; }

        /// <summary>
        /// Retrieve a snapshot of events from a past time<br/>
        /// The version id is essentially a filter on the latest event transaction id. You can use the `max_xact_id` returned by a past fetch as the version to reproduce that exact fetch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FetchEventsRequest" /> class.
        /// </summary>
        /// <param name="limit">
        /// limit the number of traces fetched<br/>
        /// Fetch queries may be paginated if the total result size is expected to be large (e.g. project_logs which accumulate over a long time). Note that fetch queries only support pagination in descending time order (from latest to earliest `_xact_id`. Furthermore, later pages may return rows which showed up in earlier pages, except with an earlier `_xact_id`. This happens because pagination occurs over the whole version history of the event log. You will most likely want to exclude any such duplicate, outdated rows (by `id`) from your combined result set.<br/>
        /// The `limit` parameter controls the number of full traces to return. So you may end up with more individual rows than the specified limit if you are fetching events containing traces.
        /// </param>
        /// <param name="cursor">
        /// An opaque string to be used as a cursor for the next page of results, in order from latest to earliest.<br/>
        /// The string can be obtained directly from the `cursor` property of the previous fetch query
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
        public FetchEventsRequest(
            int? limit,
            string? cursor,
            string? maxXactId,
            string? maxRootSpanId,
            string? version)
        {
            this.Limit = limit;
            this.Cursor = cursor;
            this.MaxXactId = maxXactId;
            this.MaxRootSpanId = maxRootSpanId;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FetchEventsRequest" /> class.
        /// </summary>
        public FetchEventsRequest()
        {
        }
    }
}