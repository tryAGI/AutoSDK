//HintName: G.Models.ReposUpdatePullRequestReviewProtectionRequestBypassPullRequestAllowances.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Allow specific users, teams, or apps to bypass pull request requirements.
    /// </summary>
    public sealed partial class ReposUpdatePullRequestReviewProtectionRequestBypassPullRequestAllowances
    {
        /// <summary>
        /// The list of user `login`s allowed to bypass pull request requirements.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("users")]
        public global::System.Collections.Generic.IList<string>? Users { get; set; }

        /// <summary>
        /// The list of team `slug`s allowed to bypass pull request requirements.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("teams")]
        public global::System.Collections.Generic.IList<string>? Teams { get; set; }

        /// <summary>
        /// The list of app `slug`s allowed to bypass pull request requirements.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apps")]
        public global::System.Collections.Generic.IList<string>? Apps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdatePullRequestReviewProtectionRequestBypassPullRequestAllowances" /> class.
        /// </summary>
        /// <param name="users">
        /// The list of user `login`s allowed to bypass pull request requirements.
        /// </param>
        /// <param name="teams">
        /// The list of team `slug`s allowed to bypass pull request requirements.
        /// </param>
        /// <param name="apps">
        /// The list of app `slug`s allowed to bypass pull request requirements.
        /// </param>
        public ReposUpdatePullRequestReviewProtectionRequestBypassPullRequestAllowances(
            global::System.Collections.Generic.IList<string>? users,
            global::System.Collections.Generic.IList<string>? teams,
            global::System.Collections.Generic.IList<string>? apps)
        {
            this.Users = users;
            this.Teams = teams;
            this.Apps = apps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdatePullRequestReviewProtectionRequestBypassPullRequestAllowances" /> class.
        /// </summary>
        public ReposUpdatePullRequestReviewProtectionRequestBypassPullRequestAllowances()
        {
        }
    }
}