//HintName: G.IAuditLogsClient.ListAuditLogs.g.cs
#nullable enable

namespace G
{
    public partial interface IAuditLogsClient
    {
        /// <summary>
        /// List user actions and configuration changes within this organization.
        /// </summary>
        /// <param name="effectiveAt"></param>
        /// <param name="projectIds"></param>
        /// <param name="eventTypes"></param>
        /// <param name="actorIds"></param>
        /// <param name="actorEmails"></param>
        /// <param name="resourceIds"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListAuditLogsResponse> ListAuditLogsAsync(
            global::G.ListAuditLogsEffectiveAt? effectiveAt = default,
            global::System.Collections.Generic.IList<string>? projectIds = default,
            global::System.Collections.Generic.IList<global::G.AuditLogEventType>? eventTypes = default,
            global::System.Collections.Generic.IList<string>? actorIds = default,
            global::System.Collections.Generic.IList<string>? actorEmails = default,
            global::System.Collections.Generic.IList<string>? resourceIds = default,
            int limit = 20,
            string? after = default,
            string? before = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}