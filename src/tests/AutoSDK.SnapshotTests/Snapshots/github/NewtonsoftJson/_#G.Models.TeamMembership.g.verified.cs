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
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// The role of the user in the team.<br/>
        /// Default Value: member<br/>
        /// Example: member
        /// </summary>
        /// <default>global::G.TeamMembershipRole.Member</default>
        /// <example>member</example>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TeamMembershipRole Role { get; set; } = default!;

        /// <summary>
        /// The state of the user's membership in the team.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TeamMembershipState State { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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