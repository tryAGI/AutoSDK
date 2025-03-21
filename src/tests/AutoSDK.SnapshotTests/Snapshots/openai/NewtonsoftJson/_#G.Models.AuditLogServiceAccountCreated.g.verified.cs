//HintName: G.Models.AuditLogServiceAccountCreated.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The details for events with this `type`.
    /// </summary>
    public sealed partial class AuditLogServiceAccountCreated
    {
        /// <summary>
        /// The payload used to create the service account.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::G.AuditLogServiceAccountCreatedData? Data { get; set; }

        /// <summary>
        /// The service account ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogServiceAccountCreated" /> class.
        /// </summary>
        /// <param name="data">
        /// The payload used to create the service account.
        /// </param>
        /// <param name="id">
        /// The service account ID.
        /// </param>
        public AuditLogServiceAccountCreated(
            global::G.AuditLogServiceAccountCreatedData? data,
            string? id)
        {
            this.Data = data;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogServiceAccountCreated" /> class.
        /// </summary>
        public AuditLogServiceAccountCreated()
        {
        }
    }
}