//HintName: G.Models.AuditLogsPageResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Paginated response for audit logs listing.<br/>
    /// Used for both INTERNAL and PUBLIC APIs<br/>
    /// INTERNAL API: POST /auditLogs/events<br/>
    /// PUBLIC API: POST /v2/auditLogs/events
    /// </summary>
    public sealed partial class AuditLogsPageResponse
    {
        /// <summary>
        /// List of audit log events
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AuditLogEvent> Events { get; set; }

        /// <summary>
        /// Opaque cursor for fetching the next page. Pass as cursor parameter.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextCursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Whether there are more events to fetch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasMore")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogsPageResponse" /> class.
        /// </summary>
        /// <param name="events">
        /// List of audit log events
        /// </param>
        /// <param name="hasMore">
        /// Whether there are more events to fetch
        /// </param>
        /// <param name="nextCursor">
        /// Opaque cursor for fetching the next page. Pass as cursor parameter.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogsPageResponse(
            global::System.Collections.Generic.IList<global::G.AuditLogEvent> events,
            bool hasMore,
            string? nextCursor)
        {
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
            this.NextCursor = nextCursor;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogsPageResponse" /> class.
        /// </summary>
        public AuditLogsPageResponse()
        {
        }
    }
}