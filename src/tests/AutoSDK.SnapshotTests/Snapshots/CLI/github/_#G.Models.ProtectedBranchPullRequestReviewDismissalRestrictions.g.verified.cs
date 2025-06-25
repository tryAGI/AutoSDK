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
        public global::System.Collections.Generic.IList<global::G.SimpleUser>? Users { get; set; }

        /// <summary>
        /// The list of teams with review dismissal access.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams")]
        public global::System.Collections.Generic.IList<global::G.Team>? Teams { get; set; }

        /// <summary>
        /// The list of apps with review dismissal access.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apps")]
        public global::System.Collections.Generic.IList<global::G.Integration>? Apps { get; set; }

        /// <summary>
        /// Example: "https://api.github.com/repos/the-org/an-org-repo/branches/master/protection/dismissal_restrictions"
        /// </summary>
        /// <example>"https://api.github.com/repos/the-org/an-org-repo/branches/master/protection/dismissal_restrictions"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Example: "https://api.github.com/repos/the-org/an-org-repo/branches/master/protection/dismissal_restrictions/users"
        /// </summary>
        /// <example>"https://api.github.com/repos/the-org/an-org-repo/branches/master/protection/dismissal_restrictions/users"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("users_url")]
        public string? UsersUrl { get; set; }

        /// <summary>
        /// Example: "https://api.github.com/repos/the-org/an-org-repo/branches/master/protection/dismissal_restrictions/teams"
        /// </summary>
        /// <example>"https://api.github.com/repos/the-org/an-org-repo/branches/master/protection/dismissal_restrictions/teams"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams_url")]
        public string? TeamsUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectedBranchPullRequestReviewDismissalRestrictions" /> class.
        /// </summary>
        /// <param name="users">
        /// The list of users with review dismissal access.
        /// </param>
        /// <param name="teams">
        /// The list of teams with review dismissal access.
        /// </param>
        /// <param name="apps">
        /// The list of apps with review dismissal access.
        /// </param>
        /// <param name="url">
        /// Example: "https://api.github.com/repos/the-org/an-org-repo/branches/master/protection/dismissal_restrictions"
        /// </param>
        /// <param name="usersUrl">
        /// Example: "https://api.github.com/repos/the-org/an-org-repo/branches/master/protection/dismissal_restrictions/users"
        /// </param>
        /// <param name="teamsUrl">
        /// Example: "https://api.github.com/repos/the-org/an-org-repo/branches/master/protection/dismissal_restrictions/teams"
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProtectedBranchPullRequestReviewDismissalRestrictions(
            global::System.Collections.Generic.IList<global::G.SimpleUser>? users,
            global::System.Collections.Generic.IList<global::G.Team>? teams,
            global::System.Collections.Generic.IList<global::G.Integration>? apps,
            string? url,
            string? usersUrl,
            string? teamsUrl)
        {
            this.Users = users;
            this.Teams = teams;
            this.Apps = apps;
            this.Url = url;
            this.UsersUrl = usersUrl;
            this.TeamsUrl = teamsUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectedBranchPullRequestReviewDismissalRestrictions" /> class.
        /// </summary>
        public ProtectedBranchPullRequestReviewDismissalRestrictions()
        {
        }
    }
}