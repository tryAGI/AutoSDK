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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("login", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Login { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Email { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public string Role { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failed_at")]
        public string? FailedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failed_reason")]
        public string? FailedReason { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inviter", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleUser? Inviter { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("team_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int TeamCount { get; set; } = default!;

        /// <summary>
        /// Example: "MDIyOk9yZ2FuaXphdGlvbkludml0YXRpb24x"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// Example: "https://api.github.com/organizations/16/invitations/1/teams"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("invitation_teams_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string InvitationTeamsUrl { get; set; } = default!;

        /// <summary>
        /// Example: "member"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("invitation_source")]
        public string? InvitationSource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}