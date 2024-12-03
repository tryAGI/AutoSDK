//HintName: G.Models.AuditLogServiceAccountUpdated.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The details for events with this `type`.
    /// </summary>
    public sealed partial class AuditLogServiceAccountUpdated
    {
        /// <summary>
        /// The service account ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The payload used to updated the service account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changes_requested")]
        public global::G.AuditLogServiceAccountUpdatedChangesRequested? ChangesRequested { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogServiceAccountUpdated" /> class.
        /// </summary>
        /// <param name="id">
        /// The service account ID.
        /// </param>
        /// <param name="changesRequested">
        /// The payload used to updated the service account.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AuditLogServiceAccountUpdated(
            string? id,
            global::G.AuditLogServiceAccountUpdatedChangesRequested? changesRequested)
        {
            this.Id = id;
            this.ChangesRequested = changesRequested;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogServiceAccountUpdated" /> class.
        /// </summary>
        public AuditLogServiceAccountUpdated()
        {
        }
    }
}