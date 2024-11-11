//HintName: G.Models.TeamMembership.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Team Membership
    /// </summary>
    public sealed partial class TeamMembership
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The role of the user in the team.<br/>
        /// Default Value: member<br/>
        /// Example: member
        /// </summary>
        /// <default>global::G.TeamMembershipRole.Member</default>
        /// <example>member</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TeamMembershipRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TeamMembershipRole Role { get; set; } = global::G.TeamMembershipRole.Member;

        /// <summary>
        /// The state of the user's membership in the team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TeamMembershipStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TeamMembershipState State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMembership" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="role">
        /// The role of the user in the team.<br/>
        /// Default Value: member<br/>
        /// Example: member
        /// </param>
        /// <param name="state">
        /// The state of the user's membership in the team.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TeamMembership(
            string url,
            global::G.TeamMembershipRole role,
            global::G.TeamMembershipState state)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Role = role;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMembership" /> class.
        /// </summary>
        public TeamMembership()
        {
        }
    }
}