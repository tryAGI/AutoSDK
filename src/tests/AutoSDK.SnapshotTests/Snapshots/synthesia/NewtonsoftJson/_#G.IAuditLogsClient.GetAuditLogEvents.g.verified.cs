//HintName: G.IAuditLogsClient.GetAuditLogEvents.g.cs
#nullable enable

namespace G
{
    public partial interface IAuditLogsClient
    {
        /// <summary>
        /// Query audit log events<br/>
        /// Retrieve paginated audit log events for a workspace or an organization.<br/>
        /// Exactly one of workspaceId or organizationId must be provided.<br/>
        /// Supports filtering by date range (Unix timestamps), multiple actions, multiple actor IDs, and target ID.<br/>
        /// Any combination of filters can be applied together.<br/>
        /// **Array parameters use comma-separated values:**<br/>
        /// - Multiple actions: `?actions=billing.credits.consumed,dubbing.project.created`<br/>
        /// - Multiple actors: `?actorIds=user-123,user-456`<br/>
        /// Example queries:<br/>
        /// - Latest events: `GET /v2/auditLogs/events?workspaceId=12345678-1234-1234-1234-123456789abc&amp;limit=50`<br/>
        /// - Filtered by action and date:<br/>
        ///   `GET /v2/auditLogs/events?workspaceId=12345678-1234-1234-1234-123456789abc`<br/>
        ///   `&amp;actions=billing.credits.consumed&amp;startDate=1704067200&amp;endDate=1706745599`<br/>
        /// - Multiple filters:<br/>
        ///   `GET /v2/auditLogs/events?workspaceId=12345678-1234-1234-1234-123456789abc`<br/>
        ///   `&amp;actions=billing.credits.consumed,dubbing.project.created&amp;actorIds=user-123,user-456`<br/>
        /// This endpoint is rate-limited and usage is tracked against your API quota.
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="organizationId"></param>
        /// <param name="actions"></param>
        /// <param name="actorIds"></param>
        /// <param name="targetId"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AuditLogsPageResponse> GetAuditLogEventsAsync(
            global::System.Guid? workspaceId = default,
            global::System.Guid? organizationId = default,
            string? actions = default,
            string? actorIds = default,
            string? targetId = default,
            int? startDate = default,
            int? endDate = default,
            string? cursor = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}