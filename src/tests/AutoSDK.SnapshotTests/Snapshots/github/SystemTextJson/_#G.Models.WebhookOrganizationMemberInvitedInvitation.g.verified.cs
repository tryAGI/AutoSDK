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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? FailedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? FailedReason { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookOrganizationMemberInvitedInvitationInviter? Inviter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Login { get; set; }

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
            string? email,
            global::System.DateTime? failedAt,
            string? failedReason,
            double id,
            string invitationTeamsUrl,
            global::G.WebhookOrganizationMemberInvitedInvitationInviter? inviter,
            string? login,
            string nodeId,
            string role,
            double teamCount,
            string? invitationSource)
        {
            this.CreatedAt = createdAt;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.FailedAt = failedAt;
            this.FailedReason = failedReason ?? throw new global::System.ArgumentNullException(nameof(failedReason));
            this.Id = id;
            this.InvitationTeamsUrl = invitationTeamsUrl ?? throw new global::System.ArgumentNullException(nameof(invitationTeamsUrl));
            this.Inviter = inviter ?? throw new global::System.ArgumentNullException(nameof(inviter));
            this.Login = login ?? throw new global::System.ArgumentNullException(nameof(login));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
            this.TeamCount = teamCount;
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