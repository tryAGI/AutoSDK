//HintName: G.Models.AuditLogProjectArchived.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The details for events with this `type`.
    /// </summary>
    public sealed partial class AuditLogProjectArchived
    {
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
        /// Initializes a new instance of the <see cref="AuditLogProjectArchived" /> class.
        /// </summary>
        /// <param name="id">
        /// The project ID.
        /// </param>
        public AuditLogProjectArchived(
            string? id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogProjectArchived" /> class.
        /// </summary>
        public AuditLogProjectArchived()
        {
        }
    }
}