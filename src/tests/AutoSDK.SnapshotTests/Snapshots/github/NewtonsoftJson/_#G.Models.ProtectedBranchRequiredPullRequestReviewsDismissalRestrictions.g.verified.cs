﻿//HintName: G.Models.ProtectedBranchRequiredPullRequestReviewsDismissalRestrictions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProtectedBranchRequiredPullRequestReviewsDismissalRestrictions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("users_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string UsersUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("teams_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string TeamsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("users", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SimpleUser> Users { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("teams", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Team> Teams { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apps")]
        public global::System.Collections.Generic.IList<global::G.Integration>? Apps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectedBranchRequiredPullRequestReviewsDismissalRestrictions" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="usersUrl"></param>
        /// <param name="teamsUrl"></param>
        /// <param name="users"></param>
        /// <param name="teams"></param>
        /// <param name="apps"></param>
        public ProtectedBranchRequiredPullRequestReviewsDismissalRestrictions(
            string url,
            string usersUrl,
            string teamsUrl,
            global::System.Collections.Generic.IList<global::G.SimpleUser> users,
            global::System.Collections.Generic.IList<global::G.Team> teams,
            global::System.Collections.Generic.IList<global::G.Integration>? apps)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.UsersUrl = usersUrl ?? throw new global::System.ArgumentNullException(nameof(usersUrl));
            this.TeamsUrl = teamsUrl ?? throw new global::System.ArgumentNullException(nameof(teamsUrl));
            this.Users = users ?? throw new global::System.ArgumentNullException(nameof(users));
            this.Teams = teams ?? throw new global::System.ArgumentNullException(nameof(teams));
            this.Apps = apps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectedBranchRequiredPullRequestReviewsDismissalRestrictions" /> class.
        /// </summary>
        public ProtectedBranchRequiredPullRequestReviewsDismissalRestrictions()
        {
        }
    }
}