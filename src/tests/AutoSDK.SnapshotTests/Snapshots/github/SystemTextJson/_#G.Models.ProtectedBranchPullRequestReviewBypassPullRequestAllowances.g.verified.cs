//HintName: G.Models.ProtectedBranchPullRequestReviewBypassPullRequestAllowances.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Allow specific users, teams, or apps to bypass pull request requirements.
    /// </summary>
    public sealed partial class ProtectedBranchPullRequestReviewBypassPullRequestAllowances
    {
        /// <summary>
        /// The list of users allowed to bypass pull request requirements.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        public global::System.Collections.Generic.IList<global::G.SimpleUser>? Users { get; set; }

        /// <summary>
        /// The list of teams allowed to bypass pull request requirements.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams")]
        public global::System.Collections.Generic.IList<global::G.Team>? Teams { get; set; }

        /// <summary>
        /// The list of apps allowed to bypass pull request requirements.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apps")]
        public global::System.Collections.Generic.IList<global::G.Integration>? Apps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectedBranchPullRequestReviewBypassPullRequestAllowances" /> class.
        /// </summary>
        /// <param name="users">
        /// The list of users allowed to bypass pull request requirements.
        /// </param>
        /// <param name="teams">
        /// The list of teams allowed to bypass pull request requirements.
        /// </param>
        /// <param name="apps">
        /// The list of apps allowed to bypass pull request requirements.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProtectedBranchPullRequestReviewBypassPullRequestAllowances(
            global::System.Collections.Generic.IList<global::G.SimpleUser>? users,
            global::System.Collections.Generic.IList<global::G.Team>? teams,
            global::System.Collections.Generic.IList<global::G.Integration>? apps)
        {
            this.Users = users;
            this.Teams = teams;
            this.Apps = apps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectedBranchPullRequestReviewBypassPullRequestAllowances" /> class.
        /// </summary>
        public ProtectedBranchPullRequestReviewBypassPullRequestAllowances()
        {
        }
    }
}