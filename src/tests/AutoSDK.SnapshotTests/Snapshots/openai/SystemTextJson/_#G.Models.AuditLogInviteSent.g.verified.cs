//HintName: G.Models.AuditLogInviteSent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The details for events with this `type`.
    /// </summary>
    public sealed partial class AuditLogInviteSent
    {
        /// <summary>
        /// The payload used to create the invite.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::G.AuditLogInviteSentData? Data { get; set; }

        /// <summary>
        /// The ID of the invite.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogInviteSent" /> class.
        /// </summary>
        /// <param name="data">
        /// The payload used to create the invite.
        /// </param>
        /// <param name="id">
        /// The ID of the invite.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogInviteSent(
            global::G.AuditLogInviteSentData? data,
            string? id)
        {
            this.Data = data;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogInviteSent" /> class.
        /// </summary>
        public AuditLogInviteSent()
        {
        }
    }
}