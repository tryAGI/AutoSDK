//HintName: G.Models.ProtectedBranchPullRequestReviewDismissalRestrictions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProtectedBranchPullRequestReviewDismissalRestrictions
    {
        /// <summary>
        /// The list of users with review dismissal access.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("users")]
        public global::System.Collections.Generic.IList<SimpleUser>? Users { get; set; }

        /// <summary>
        /// The list of teams with review dismissal access.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("teams")]
        public global::System.Collections.Generic.IList<Team>? Teams { get; set; }

        /// <summary>
        /// The list of apps with review dismissal access.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apps")]
        public global::System.Collections.Generic.IList<Integration>? Apps { get; set; }

        /// <summary>
        /// <br/>Example: "https://api.github.com/repos/the-org/an-org-repo/branches/master/protection/dismissal_restrictions"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// <br/>Example: "https://api.github.com/repos/the-org/an-org-repo/branches/master/protection/dismissal_restrictions/users"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("users_url")]
        public string? UsersUrl { get; set; }

        /// <summary>
        /// <br/>Example: "https://api.github.com/repos/the-org/an-org-repo/branches/master/protection/dismissal_restrictions/teams"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("teams_url")]
        public string? TeamsUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}