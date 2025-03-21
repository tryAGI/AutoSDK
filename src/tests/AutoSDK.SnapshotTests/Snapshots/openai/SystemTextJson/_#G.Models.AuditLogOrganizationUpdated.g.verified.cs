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
        /// The payload used to update the organization settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changes_requested")]
        public global::G.AuditLogOrganizationUpdatedChangesRequested? ChangesRequested { get; set; }

        /// <summary>
        /// The organization ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogOrganizationUpdated" /> class.
        /// </summary>
        /// <param name="changesRequested">
        /// The payload used to update the organization settings.
        /// </param>
        /// <param name="id">
        /// The organization ID.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogOrganizationUpdated(
            global::G.AuditLogOrganizationUpdatedChangesRequested? changesRequested,
            string? id)
        {
            this.ChangesRequested = changesRequested;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogOrganizationUpdated" /> class.
        /// </summary>
        public AuditLogOrganizationUpdated()
        {
        }
    }
}