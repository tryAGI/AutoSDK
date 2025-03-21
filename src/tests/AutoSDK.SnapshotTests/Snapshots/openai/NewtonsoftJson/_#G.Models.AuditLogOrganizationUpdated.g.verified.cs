//HintName: G.Models.AuditLogOrganizationUpdated.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The details for events with this `type`.
    /// </summary>
    public sealed partial class AuditLogOrganizationUpdated
    {
        /// <summary>
        /// The organization ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The payload used to update the organization settings.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("changes_requested")]
        public global::G.AuditLogOrganizationUpdatedChangesRequested? ChangesRequested { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogOrganizationUpdated" /> class.
        /// </summary>
        /// <param name="id">
        /// The organization ID.
        /// </param>
        /// <param name="changesRequested">
        /// The payload used to update the organization settings.
        /// </param>
        public AuditLogOrganizationUpdated(
            string? id,
            global::G.AuditLogOrganizationUpdatedChangesRequested? changesRequested)
        {
            this.Id = id;
            this.ChangesRequested = changesRequested;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogOrganizationUpdated" /> class.
        /// </summary>
        public AuditLogOrganizationUpdated()
        {
        }
    }
}