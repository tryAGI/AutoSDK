//HintName: G.Models.ReposUpdateBranchProtectionRequestRequiredPullRequestReviewsDismissalRestrictions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specify which users, teams, and apps can dismiss pull request reviews. Pass an empty `dismissal_restrictions` object to disable. User and team `dismissal_restrictions` are only available for organization-owned repositories. Omit this parameter for personal repositories.
    /// </summary>
    public sealed partial class ReposUpdateBranchProtectionRequestRequiredPullRequestReviewsDismissalRestrictions
    {
        /// <summary>
        /// The list of user `login`s with dismissal access
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        public global::System.Collections.Generic.IList<string>? Users { get; set; }

        /// <summary>
        /// The list of team `slug`s with dismissal access
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams")]
        public global::System.Collections.Generic.IList<string>? Teams { get; set; }

        /// <summary>
        /// The list of app `slug`s with dismissal access
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apps")]
        public global::System.Collections.Generic.IList<string>? Apps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateBranchProtectionRequestRequiredPullRequestReviewsDismissalRestrictions" /> class.
        /// </summary>
        /// <param name="users">
        /// The list of user `login`s with dismissal access
        /// </param>
        /// <param name="teams">
        /// The list of team `slug`s with dismissal access
        /// </param>
        /// <param name="apps">
        /// The list of app `slug`s with dismissal access
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ReposUpdateBranchProtectionRequestRequiredPullRequestReviewsDismissalRestrictions(
            global::System.Collections.Generic.IList<string>? users,
            global::System.Collections.Generic.IList<string>? teams,
            global::System.Collections.Generic.IList<string>? apps)
        {
            this.Users = users;
            this.Teams = teams;
            this.Apps = apps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateBranchProtectionRequestRequiredPullRequestReviewsDismissalRestrictions" /> class.
        /// </summary>
        public ReposUpdateBranchProtectionRequestRequiredPullRequestReviewsDismissalRestrictions()
        {
        }
    }
}