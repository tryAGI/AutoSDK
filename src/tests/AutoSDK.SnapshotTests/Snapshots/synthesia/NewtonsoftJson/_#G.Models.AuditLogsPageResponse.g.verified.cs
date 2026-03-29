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
        [global::Newtonsoft.Json.JsonProperty("events", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AuditLogEvent> Events { get; set; } = default!;

        /// <summary>
        /// Opaque cursor for fetching the next page. Pass as cursor parameter.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nextCursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Whether there are more events to fetch
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hasMore", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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