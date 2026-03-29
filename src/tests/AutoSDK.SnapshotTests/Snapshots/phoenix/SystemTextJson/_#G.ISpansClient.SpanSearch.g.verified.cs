//HintName: G.ISpansClient.SpanSearch.g.cs
#nullable enable

namespace G
{
    public partial interface ISpansClient
    {
        /// <summary>
        /// Search spans with simple filters (no DSL)<br/>
        /// Return spans within a project filtered by time range. Supports cursor-based pagination.
        /// </summary>
        /// <param name="projectIdentifier">
        /// The project identifier: either project ID or project name. If using a project name, it cannot contain slash (/), question mark (?), or pound sign (#) characters.
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor (Span Global ID)
        /// </param>
        /// <param name="limit">
        /// Maximum number of spans to return<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="startTime">
        /// Inclusive lower bound time
        /// </param>
        /// <param name="endTime">
        /// Exclusive upper bound time
        /// </param>
        /// <param name="traceId">
        /// Filter by one or more trace IDs
        /// </param>
        /// <param name="parentId">
        /// Filter by parent span ID. Use "null" to get root spans only.
        /// </param>
        /// <param name="name">
        /// Filter by span name(s)
        /// </param>
        /// <param name="statusCode">
        /// Filter by status code(s). Values: OK, ERROR, UNSET
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OtlpSpansResponseBody> SpanSearchAsync(
            string projectIdentifier,
            string? cursor = default,
            int? limit = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            global::System.Collections.Generic.IList<string>? traceId = default,
            string? parentId = default,
            global::System.Collections.Generic.IList<string>? name = default,
            global::System.Collections.Generic.IList<string>? statusCode = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}