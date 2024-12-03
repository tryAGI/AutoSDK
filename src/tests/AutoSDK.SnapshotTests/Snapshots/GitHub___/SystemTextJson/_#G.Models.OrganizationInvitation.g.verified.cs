//HintName: G.Models.OrganizationInvitation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Organization Invitation
    /// </summary>
    public sealed partial class OrganizationInvitation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Login { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_at")]
        public string? FailedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_reason")]
        public string? FailedReason { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inviter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SimpleUser Inviter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TeamCount { get; set; }

        /// <summary>
        /// Example: "MDIyOk9yZ2FuaXphdGlvbkludml0YXRpb24x"
        /// </summary>
        /// <example>"MDIyOk9yZ2FuaXphdGlvbkludml0YXRpb24x"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// Example: "https://api.github.com/organizations/16/invitations/1/teams"
        /// </summary>
        /// <example>"https://api.github.com/organizations/16/invitations/1/teams"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("invitation_teams_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InvitationTeamsUrl { get; set; }

        /// <summary>
        /// Example: "member"
        /// </summary>
        /// <example>"member"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("invitation_source")]
        public string? InvitationSource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationInvitation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="login"></param>
        /// <param name="email"></param>
        /// <param name="role"></param>
        /// <param name="createdAt"></param>
        /// <param name="failedAt"></param>
        /// <param name="failedReason"></param>
        /// <param name="inviter">
        /// A GitHub user.
        /// </param>
        /// <param name="teamCount"></param>
        /// <param name="nodeId">
        /// Example: "MDIyOk9yZ2FuaXphdGlvbkludml0YXRpb24x"
        /// </param>
        /// <param name="invitationTeamsUrl">
        /// Example: "https://api.github.com/organizations/16/invitations/1/teams"
        /// </param>
        /// <param name="invitationSource">
        /// Example: "member"
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public OrganizationInvitation(
            long id,
            string? login,
            string? email,
            string role,
            string createdAt,
            global::G.SimpleUser inviter,
            int teamCount,
            string nodeId,
            string invitationTeamsUrl,
            string? failedAt,
            string? failedReason,
            string? invitationSource)
        {
            this.Id = id;
            this.Login = login ?? throw new global::System.ArgumentNullException(nameof(login));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Inviter = inviter ?? throw new global::System.ArgumentNullException(nameof(inviter));
            this.TeamCount = teamCount;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.InvitationTeamsUrl = invitationTeamsUrl ?? throw new global::System.ArgumentNullException(nameof(invitationTeamsUrl));
            this.FailedAt = failedAt;
            this.FailedReason = failedReason;
            this.InvitationSource = invitationSource;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationInvitation" /> class.
        /// </summary>
        public OrganizationInvitation()
        {
        }
    }
}