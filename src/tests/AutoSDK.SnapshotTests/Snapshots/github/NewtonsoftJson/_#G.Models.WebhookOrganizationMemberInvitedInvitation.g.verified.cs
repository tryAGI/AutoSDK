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
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failed_at")]
        public global::System.DateTime? FailedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failed_reason")]
        public string? FailedReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public double Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("invitation_teams_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string InvitationTeamsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inviter")]
        public global::G.WebhookOrganizationMemberInvitedInvitationInviter? Inviter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("login")]
        public string? Login { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public string Role { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("team_count", Required = global::Newtonsoft.Json.Required.Always)]
        public double TeamCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("invitation_source")]
        public string? InvitationSource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookOrganizationMemberInvitedInvitation" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="invitationTeamsUrl"></param>
        /// <param name="nodeId"></param>
        /// <param name="role"></param>
        /// <param name="teamCount"></param>
        /// <param name="email"></param>
        /// <param name="failedAt"></param>
        /// <param name="failedReason"></param>
        /// <param name="inviter"></param>
        /// <param name="login"></param>
        /// <param name="invitationSource"></param>
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
            this.Email = email;
            this.FailedAt = failedAt;
            this.FailedReason = failedReason;
            this.Id = id;
            this.InvitationTeamsUrl = invitationTeamsUrl ?? throw new global::System.ArgumentNullException(nameof(invitationTeamsUrl));
            this.Inviter = inviter;
            this.Login = login;
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