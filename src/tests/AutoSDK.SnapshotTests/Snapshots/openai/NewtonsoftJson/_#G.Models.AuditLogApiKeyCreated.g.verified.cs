//HintName: G.Models.AuditLogApiKeyCreated.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The details for events with this `type`.
    /// </summary>
    public sealed partial class AuditLogApiKeyCreated
    {
        /// <summary>
        /// The tracking ID of the API key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The payload used to create the API key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::G.AuditLogApiKeyCreatedData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogApiKeyCreated" /> class.
        /// </summary>
        /// <param name="id">
        /// The tracking ID of the API key.
        /// </param>
        /// <param name="data">
        /// The payload used to create the API key.
        /// </param>
        public AuditLogApiKeyCreated(
            string? id,
            global::G.AuditLogApiKeyCreatedData? data)
        {
            this.Id = id;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogApiKeyCreated" /> class.
        /// </summary>
        public AuditLogApiKeyCreated()
        {
        }
    }
}