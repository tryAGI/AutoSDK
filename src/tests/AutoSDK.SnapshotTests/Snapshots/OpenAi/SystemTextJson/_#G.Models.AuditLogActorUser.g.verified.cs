//HintName: G.Models.AuditLogActorUser.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The user who performed the audit logged action.
    /// </summary>
    public sealed partial class AuditLogActorUser
    {
        /// <summary>
        /// The user id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The user email.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}