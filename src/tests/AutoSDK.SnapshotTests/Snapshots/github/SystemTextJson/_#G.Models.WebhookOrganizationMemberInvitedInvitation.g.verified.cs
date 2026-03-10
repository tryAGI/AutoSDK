//HintName: G.Models.WebhookOrganizationMemberInvitedInvitation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The invitation for the user or email if the action is `member_invited`.
    /// </summary>
    public sealed partial class WebhookOrganizationMemberInvitedInvitation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_at")]
        public global::System.DateTime? FailedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_reason")]
        public string? FailedReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invitation_teams_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InvitationTeamsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inviter")]
        public global::G.WebhookOrganizationMemberInvitedInvitationInviter? Inviter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("login")]
        public string? Login { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TeamCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invitation_source")]
        public string? InvitationSource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookOrganizationMemberInvitedInvitation" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="email"></param>
        /// <param name="failedAt"></param>
        /// <param name="failedReason"></param>
        /// <param name="id"></param>
        /// <param name="invitationTeamsUrl"></param>
        /// <param name="inviter"></param>
        /// <param name="login"></param>
        /// <param name="nodeId"></param>
        /// <param name="role"></param>
        /// <param name="teamCount"></param>
        /// <param name="invitationSource"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookOrganizationMemberInvitedInvitation(
            global::System.DateTime createdAt,
            double id,
            string invitationTeamsUrl,
            string nodeId,
            string role,
            double teamCount,
            string? email,
            global::System.DateTime? failedAt,
            string? failedReason,
            global::G.WebhookOrganizationMemberInvitedInvitationInviter? inviter,
            string? login,
            string? invitationSource)
        {
            this.CreatedAt = createdAt;
            this.Id = id;
            this.InvitationTeamsUrl = invitationTeamsUrl ?? throw new global::System.ArgumentNullException(nameof(invitationTeamsUrl));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
            this.TeamCount = teamCount;
            this.Email = email;
            this.FailedAt = failedAt;
            this.FailedReason = failedReason;
            this.Inviter = inviter;
            this.Login = login;
            this.InvitationSource = invitationSource;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookOrganizationMemberInvitedInvitation" /> class.
        /// </summary>
        public WebhookOrganizationMemberInvitedInvitation()
        {
        }
    }
}