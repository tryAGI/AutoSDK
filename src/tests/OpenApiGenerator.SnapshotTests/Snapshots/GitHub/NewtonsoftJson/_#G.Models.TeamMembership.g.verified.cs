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
    }
}