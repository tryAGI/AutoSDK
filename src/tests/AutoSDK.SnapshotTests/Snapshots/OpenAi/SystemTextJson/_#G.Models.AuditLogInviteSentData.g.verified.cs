//HintName: G.Models.AuditLogInviteSentData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The payload used to create the invite.
    /// </summary>
    public sealed partial class AuditLogInviteSentData
    {
        /// <summary>
        /// The email invited to the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// The role the email was invited to be. Is either `owner` or `member`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}