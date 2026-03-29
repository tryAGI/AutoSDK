//HintName: G.Models.Invite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Invite
    {
        /// <summary>
        /// Example: invite
        /// </summary>
        /// <example>invite</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.InviteRole2JsonConverter))]
        public global::G.InviteRole2? Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accepted_at")]
        public global::System.DateTime? AcceptedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.InviteStatusJsonConverter))]
        public global::G.InviteStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invited_by")]
        public global::System.Guid? InvitedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Invite" /> class.
        /// </summary>
        /// <param name="object">
        /// Example: invite
        /// </param>
        /// <param name="id"></param>
        /// <param name="email"></param>
        /// <param name="role"></param>
        /// <param name="createdAt"></param>
        /// <param name="expiresAt"></param>
        /// <param name="acceptedAt"></param>
        /// <param name="status"></param>
        /// <param name="invitedBy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Invite(
            string? @object,
            global::System.Guid? id,
            string? email,
            global::G.InviteRole2? role,
            global::System.DateTime? createdAt,
            global::System.DateTime? expiresAt,
            global::System.DateTime? acceptedAt,
            global::G.InviteStatus? status,
            global::System.Guid? invitedBy)
        {
            this.Object = @object;
            this.Id = id;
            this.Email = email;
            this.Role = role;
            this.CreatedAt = createdAt;
            this.ExpiresAt = expiresAt;
            this.AcceptedAt = acceptedAt;
            this.Status = status;
            this.InvitedBy = invitedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Invite" /> class.
        /// </summary>
        public Invite()
        {
        }
    }
}