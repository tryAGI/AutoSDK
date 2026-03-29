//HintName: G.IAuditLogsClient.GetAuditLogs.g.cs
#nullable enable

namespace G
{
    public partial interface IAuditLogsClient
    {
        /// <summary>
        /// Get Audit Logs
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="organisationId"></param>
        /// <param name="method"></param>
        /// <param name="uri"></param>
        /// <param name="requestId"></param>
        /// <param name="userId"></param>
        /// <param name="userType"></param>
        /// <param name="workspaceId"></param>
        /// <param name="responseStatusCode"></param>
        /// <param name="resourceType"></param>
        /// <param name="action"></param>
        /// <param name="clientIp"></param>
        /// <param name="country"></param>
        /// <param name="currentPage"></param>
        /// <param name="pageSize"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AuditLogObjectList> GetAuditLogsAsync(
            string startTime,
            string endTime,
            string organisationId,
            global::G.GetAuditLogsMethod? method = default,
            string? uri = default,
            string? requestId = default,
            string? userId = default,
            global::G.GetAuditLogsUserType? userType = default,
            string? workspaceId = default,
            int? responseStatusCode = default,
            string? resourceType = default,
            string? action = default,
            string? clientIp = default,
            string? country = default,
            int? currentPage = default,
            int? pageSize = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}