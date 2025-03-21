//HintName: G.Models.AuditLogRateLimitUpdated.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The details for events with this `type`.
    /// </summary>
    public sealed partial class AuditLogRateLimitUpdated
    {
        /// <summary>
        /// The payload used to update the rate limits.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("changes_requested")]
        public global::G.AuditLogRateLimitUpdatedChangesRequested? ChangesRequested { get; set; }

        /// <summary>
        /// The rate limit ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogRateLimitUpdated" /> class.
        /// </summary>
        /// <param name="changesRequested">
        /// The payload used to update the rate limits.
        /// </param>
        /// <param name="id">
        /// The rate limit ID
        /// </param>
        public AuditLogRateLimitUpdated(
            global::G.AuditLogRateLimitUpdatedChangesRequested? changesRequested,
            string? id)
        {
            this.ChangesRequested = changesRequested;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogRateLimitUpdated" /> class.
        /// </summary>
        public AuditLogRateLimitUpdated()
        {
        }
    }
}