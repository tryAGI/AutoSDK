//HintName: G.Models.AuditLogUserUpdated.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The details for events with this `type`.
    /// </summary>
    public sealed partial class AuditLogUserUpdated
    {
        /// <summary>
        /// The payload used to update the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("changes_requested")]
        public global::G.AuditLogUserUpdatedChangesRequested? ChangesRequested { get; set; }

        /// <summary>
        /// The project ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogUserUpdated" /> class.
        /// </summary>
        /// <param name="changesRequested">
        /// The payload used to update the user.
        /// </param>
        /// <param name="id">
        /// The project ID.
        /// </param>
        public AuditLogUserUpdated(
            global::G.AuditLogUserUpdatedChangesRequested? changesRequested,
            string? id)
        {
            this.ChangesRequested = changesRequested;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogUserUpdated" /> class.
        /// </summary>
        public AuditLogUserUpdated()
        {
        }
    }
}