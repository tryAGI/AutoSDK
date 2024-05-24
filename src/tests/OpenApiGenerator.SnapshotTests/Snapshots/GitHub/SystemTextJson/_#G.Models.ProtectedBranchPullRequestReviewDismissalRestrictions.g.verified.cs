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
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        public global::System.Collections.Generic.IList<SimpleUser>? Users { get; set; }

        /// <summary>
        /// The list of teams with review dismissal access.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams")]
        public global::System.Collections.Generic.IList<Team>? Teams { get; set; }

        /// <summary>
        /// The list of apps with review dismissal access.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apps")]
        public global::System.Collections.Generic.IList<Integration>? Apps { get; set; }

        /// <summary>
        /// <br/>Example: "https://api.github.com/repos/the-org/an-org-repo/branches/master/protection/dismissal_restrictions"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// <br/>Example: "https://api.github.com/repos/the-org/an-org-repo/branches/master/protection/dismissal_restrictions/users"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users_url")]
        public string? UsersUrl { get; set; }

        /// <summary>
        /// <br/>Example: "https://api.github.com/repos/the-org/an-org-repo/branches/master/protection/dismissal_restrictions/teams"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams_url")]
        public string? TeamsUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}