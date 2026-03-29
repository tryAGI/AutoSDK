//HintName: G.IObservationsClient.ObservationsGetMany.g.cs
#nullable enable

namespace G
{
    public partial interface IObservationsClient
    {
        /// <summary>
        /// Get a list of observations with cursor-based pagination and flexible field selection.<br/>
        /// ## Cursor-based Pagination<br/>
        /// This endpoint uses cursor-based pagination for efficient traversal of large datasets.<br/>
        /// The cursor is returned in the response metadata and should be passed in subsequent requests<br/>
        /// to retrieve the next page of results.<br/>
        /// ## Field Selection<br/>
        /// Use the `fields` parameter to control which observation fields are returned:<br/>
        /// - `core` - Always included: id, traceId, startTime, endTime, projectId, parentObservationId, type<br/>
        /// - `basic` - name, level, statusMessage, version, environment, bookmarked, public, userId, sessionId<br/>
        /// - `time` - completionStartTime, createdAt, updatedAt<br/>
        /// - `io` - input, output<br/>
        /// - `metadata` - metadata (truncated to 200 chars by default, use `expandMetadata` to get full values)<br/>
        /// - `model` - providedModelName, internalModelId, modelParameters<br/>
        /// - `usage` - usageDetails, costDetails, totalCost<br/>
        /// - `prompt` - promptId, promptName, promptVersion<br/>
        /// - `metrics` - latency, timeToFirstToken<br/>
        /// If not specified, `core` and `basic` field groups are returned.<br/>
        /// ## Filters<br/>
        /// Multiple filtering options are available via query parameters or the structured `filter` parameter.<br/>
        /// When using the `filter` parameter, it takes precedence over individual query parameter filters.
        /// </summary>
        /// <param name="fields"></param>
        /// <param name="expandMetadata"></param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="parseIoAsJson"></param>
        /// <param name="name"></param>
        /// <param name="userId"></param>
        /// <param name="type"></param>
        /// <param name="traceId"></param>
        /// <param name="level"></param>
        /// <param name="parentObservationId"></param>
        /// <param name="environment"></param>
        /// <param name="fromStartTime"></param>
        /// <param name="toStartTime"></param>
        /// <param name="version"></param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ObservationsV2Response> ObservationsGetManyAsync(
            string? fields = default,
            string? expandMetadata = default,
            int? limit = default,
            string? cursor = default,
            bool? parseIoAsJson = default,
            string? name = default,
            string? userId = default,
            string? type = default,
            string? traceId = default,
            global::G.ObservationLevel? level = default,
            string? parentObservationId = default,
            global::System.Collections.Generic.IList<string>? environment = default,
            global::System.DateTime? fromStartTime = default,
            global::System.DateTime? toStartTime = default,
            string? version = default,
            string? filter = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}