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
        /// The payload used to create the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::G.AuditLogProjectCreatedData? Data { get; set; }

        /// <summary>
        /// The project ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogProjectCreated" /> class.
        /// </summary>
        /// <param name="data">
        /// The payload used to create the project.
        /// </param>
        /// <param name="id">
        /// The project ID.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogProjectCreated(
            global::G.AuditLogProjectCreatedData? data,
            string? id)
        {
            this.Data = data;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogProjectCreated" /> class.
        /// </summary>
        public AuditLogProjectCreated()
        {
        }
    }
}