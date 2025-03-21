//HintName: G.Models.AuditLogActorSession.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The session in which the audit logged action was performed.
    /// </summary>
    public sealed partial class AuditLogActorSession
    {
        /// <summary>
        /// The user who performed the audit logged action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::G.AuditLogActorUser? User { get; set; }

        /// <summary>
        /// The IP address from which the action was performed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ip_address")]
        public string? IpAddress { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogActorSession" /> class.
        /// </summary>
        /// <param name="user">
        /// The user who performed the audit logged action.
        /// </param>
        /// <param name="ipAddress">
        /// The IP address from which the action was performed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogActorSession(
            global::G.AuditLogActorUser? user,
            string? ipAddress)
        {
            this.User = user;
            this.IpAddress = ipAddress;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogActorSession" /> class.
        /// </summary>
        public AuditLogActorSession()
        {
        }
    }
}