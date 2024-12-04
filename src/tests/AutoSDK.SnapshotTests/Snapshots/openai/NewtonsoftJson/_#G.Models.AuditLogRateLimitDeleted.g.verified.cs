//HintName: G.Models.AuditLogRateLimitDeleted.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The details for events with this `type`.
    /// </summary>
    public sealed partial class AuditLogRateLimitDeleted
    {
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
        /// Initializes a new instance of the <see cref="AuditLogRateLimitDeleted" /> class.
        /// </summary>
        /// <param name="id">
        /// The rate limit ID
        /// </param>
        public AuditLogRateLimitDeleted(
            string? id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogRateLimitDeleted" /> class.
        /// </summary>
        public AuditLogRateLimitDeleted()
        {
        }
    }
}