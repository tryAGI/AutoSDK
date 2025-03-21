//HintName: G.Models.AuditLogApiKeyUpdated.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The details for events with this `type`.
    /// </summary>
    public sealed partial class AuditLogApiKeyUpdated
    {
        /// <summary>
        /// The payload used to update the API key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("changes_requested")]
        public global::G.AuditLogApiKeyUpdatedChangesRequested? ChangesRequested { get; set; }

        /// <summary>
        /// The tracking ID of the API key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogApiKeyUpdated" /> class.
        /// </summary>
        /// <param name="changesRequested">
        /// The payload used to update the API key.
        /// </param>
        /// <param name="id">
        /// The tracking ID of the API key.
        /// </param>
        public AuditLogApiKeyUpdated(
            global::G.AuditLogApiKeyUpdatedChangesRequested? changesRequested,
            string? id)
        {
            this.ChangesRequested = changesRequested;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogApiKeyUpdated" /> class.
        /// </summary>
        public AuditLogApiKeyUpdated()
        {
        }
    }
}