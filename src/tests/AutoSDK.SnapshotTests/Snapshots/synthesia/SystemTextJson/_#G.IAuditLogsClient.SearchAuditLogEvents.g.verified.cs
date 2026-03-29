//HintName: G.IAuditLogsClient.SearchAuditLogEvents.g.cs
#nullable enable

namespace G
{
    public partial interface IAuditLogsClient
    {
        /// <summary>
        /// Search audit log events (Advanced)<br/>
        /// Advanced search endpoint for audit log events with complex filter criteria.<br/>
        /// **For most use cases, use GET /v2/auditLogs/events instead.**<br/>
        /// Use this endpoint when:<br/>
        /// - Filtering by 50+ actions or actors<br/>
        /// - Complex query logic (future enhancement)<br/>
        /// - Programmatic access requiring JSON request bodies<br/>
        /// Exactly one of workspaceId or organizationId must be provided.<br/>
        /// Supports filtering by date range (Unix timestamps), multiple actions, multiple actor IDs, and target ID.<br/>
        /// Any combination of filters can be applied together.<br/>
        /// Example request body for January 2024 user login events:<br/>
        /// {<br/>
        ///   "workspaceId": "12345678-1234-1234-1234-123456789abc",<br/>
        ///   "actions": ["user.authentication.login"],<br/>
        ///   "startDate": 1704067200,<br/>
        ///   "endDate": 1706745599<br/>
        /// }<br/>
        /// This endpoint is rate-limited and usage is tracked against your API quota.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AuditLogsPageResponse> SearchAuditLogEventsAsync(

            global::G.AuditLogsQueryRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search audit log events (Advanced)<br/>
        /// Advanced search endpoint for audit log events with complex filter criteria.<br/>
        /// **For most use cases, use GET /v2/auditLogs/events instead.**<br/>
        /// Use this endpoint when:<br/>
        /// - Filtering by 50+ actions or actors<br/>
        /// - Complex query logic (future enhancement)<br/>
        /// - Programmatic access requiring JSON request bodies<br/>
        /// Exactly one of workspaceId or organizationId must be provided.<br/>
        /// Supports filtering by date range (Unix timestamps), multiple actions, multiple actor IDs, and target ID.<br/>
        /// Any combination of filters can be applied together.<br/>
        /// Example request body for January 2024 user login events:<br/>
        /// {<br/>
        ///   "workspaceId": "12345678-1234-1234-1234-123456789abc",<br/>
        ///   "actions": ["user.authentication.login"],<br/>
        ///   "startDate": 1704067200,<br/>
        ///   "endDate": 1706745599<br/>
        /// }<br/>
        /// This endpoint is rate-limited and usage is tracked against your API quota.
        /// </summary>
        /// <param name="workspaceId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="organizationId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="startDate">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="endDate">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="actions">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="actorIds">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="targetId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cursor">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AuditLogsPageResponse> SearchAuditLogEventsAsync(
            global::System.Guid? workspaceId = default,
            global::System.Guid? organizationId = default,
            int? startDate = default,
            int? endDate = default,
            global::System.Collections.Generic.IList<string>? actions = default,
            global::System.Collections.Generic.IList<string>? actorIds = default,
            string? targetId = default,
            string? cursor = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}