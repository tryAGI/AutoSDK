//HintName: G.Models.AuditLogProjectCreated.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The details for events with this `type`.
    /// </summary>
    public sealed partial class AuditLogProjectCreated
    {
        /// <summary>
        /// The project ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The payload used to create the project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::G.AuditLogProjectCreatedData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogProjectCreated" /> class.
        /// </summary>
        /// <param name="id">
        /// The project ID.
        /// </param>
        /// <param name="data">
        /// The payload used to create the project.
        /// </param>
        public AuditLogProjectCreated(
            string? id,
            global::G.AuditLogProjectCreatedData? data)
        {
            this.Id = id;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogProjectCreated" /> class.
        /// </summary>
        public AuditLogProjectCreated()
        {
        }
    }
}