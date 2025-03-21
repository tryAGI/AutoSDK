//HintName: G.Models.AuditLogUserAdded.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The details for events with this `type`.
    /// </summary>
    public sealed partial class AuditLogUserAdded
    {
        /// <summary>
        /// The payload used to add the user to the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::G.AuditLogUserAddedData? Data { get; set; }

        /// <summary>
        /// The user ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogUserAdded" /> class.
        /// </summary>
        /// <param name="data">
        /// The payload used to add the user to the project.
        /// </param>
        /// <param name="id">
        /// The user ID.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogUserAdded(
            global::G.AuditLogUserAddedData? data,
            string? id)
        {
            this.Data = data;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogUserAdded" /> class.
        /// </summary>
        public AuditLogUserAdded()
        {
        }
    }
}