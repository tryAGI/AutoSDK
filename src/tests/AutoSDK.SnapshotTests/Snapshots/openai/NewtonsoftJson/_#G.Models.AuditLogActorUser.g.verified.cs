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
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The user email.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogActorUser" /> class.
        /// </summary>
        /// <param name="id">
        /// The user id.
        /// </param>
        /// <param name="email">
        /// The user email.
        /// </param>
        public AuditLogActorUser(
            string? id,
            string? email)
        {
            this.Id = id;
            this.Email = email;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogActorUser" /> class.
        /// </summary>
        public AuditLogActorUser()
        {
        }
    }
}