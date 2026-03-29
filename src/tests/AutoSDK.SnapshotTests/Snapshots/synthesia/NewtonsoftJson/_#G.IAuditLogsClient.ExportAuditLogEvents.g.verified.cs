//HintName: G.IAuditLogsClient.ExportAuditLogEvents.g.cs
#nullable enable

namespace G
{
    public partial interface IAuditLogsClient
    {
        /// <summary>
        /// Export audit log events as CSV<br/>
        /// Export audit log events for a workspace or organization as a CSV file.<br/>
        /// Exactly one of workspaceId or organizationId must be provided.<br/>
        /// Supports the same filtering options as the query endpoints:<br/>
        /// - Date range (Unix timestamps)<br/>
        /// - Multiple actions<br/>
        /// - Multiple actor IDs<br/>
        /// - Target ID<br/>
        /// **Export limits:**<br/>
        /// - Maximum 10,000 events per export<br/>
        /// - If more events match the filters, the export will be truncated<br/>
        /// - Truncated exports include "_TRUNCATED" in the filename<br/>
        /// **Example requests:**<br/>
        /// - Export all events for an organization:<br/>
        ///   {"organizationId": "12345678-1234-1234-1234-123456789abc"}<br/>
        /// - Export filtered events:<br/>
        ///   {"organizationId": "12345678-1234-1234-1234-123456789abc",<br/>
        ///    "startDate": 1704067200, "endDate": 1735689599,<br/>
        ///    "actions": ["billing.credits.consumed", "video.created"]}<br/>
        /// - Export by workspace with filters:<br/>
        ///   {"workspaceId": "12345678-1234-1234-1234-123456789abc",<br/>
        ///    "actorIds": ["user-123", "user-456"]}<br/>
        /// This endpoint is rate-limited and usage is tracked against your API quota.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> ExportAuditLogEventsAsync(

            global::G.AuditLogsExportRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export audit log events as CSV<br/>
        /// Export audit log events for a workspace or organization as a CSV file.<br/>
        /// Exactly one of workspaceId or organizationId must be provided.<br/>
        /// Supports the same filtering options as the query endpoints:<br/>
        /// - Date range (Unix timestamps)<br/>
        /// - Multiple actions<br/>
        /// - Multiple actor IDs<br/>
        /// - Target ID<br/>
        /// **Export limits:**<br/>
        /// - Maximum 10,000 events per export<br/>
        /// - If more events match the filters, the export will be truncated<br/>
        /// - Truncated exports include "_TRUNCATED" in the filename<br/>
        /// **Example requests:**<br/>
        /// - Export all events for an organization:<br/>
        ///   {"organizationId": "12345678-1234-1234-1234-123456789abc"}<br/>
        /// - Export filtered events:<br/>
        ///   {"organizationId": "12345678-1234-1234-1234-123456789abc",<br/>
        ///    "startDate": 1704067200, "endDate": 1735689599,<br/>
        ///    "actions": ["billing.credits.consumed", "video.created"]}<br/>
        /// - Export by workspace with filters:<br/>
        ///   {"workspaceId": "12345678-1234-1234-1234-123456789abc",<br/>
        ///    "actorIds": ["user-123", "user-456"]}<br/>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> ExportAuditLogEventsAsync(
            global::System.Guid? workspaceId = default,
            global::System.Guid? organizationId = default,
            int? startDate = default,
            int? endDate = default,
            global::System.Collections.Generic.IList<string>? actions = default,
            global::System.Collections.Generic.IList<string>? actorIds = default,
            string? targetId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}