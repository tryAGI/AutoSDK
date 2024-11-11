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
        /// The ID of the invite.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The payload used to create the invite.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::G.AuditLogInviteSentData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogInviteSent" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the invite.
        /// </param>
        /// <param name="data">
        /// The payload used to create the invite.
        /// </param>
        public AuditLogInviteSent(
            string? id,
            global::G.AuditLogInviteSentData? data)
        {
            this.Id = id;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogInviteSent" /> class.
        /// </summary>
        public AuditLogInviteSent()
        {
        }
    }
}