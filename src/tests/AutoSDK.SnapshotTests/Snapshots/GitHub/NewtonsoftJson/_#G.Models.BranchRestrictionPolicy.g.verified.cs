//HintName: G.Models.BranchRestrictionPolicy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Branch Restriction Policy
    /// </summary>
    public sealed partial class BranchRestrictionPolicy
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
        [global::Newtonsoft.Json.JsonProperty("apps_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string AppsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("users", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.BranchRestrictionPolicyUser> Users { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("teams", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.BranchRestrictionPolicyTeam> Teams { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apps", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.BranchRestrictionPolicyApp> Apps { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchRestrictionPolicy" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="usersUrl"></param>
        /// <param name="teamsUrl"></param>
        /// <param name="appsUrl"></param>
        /// <param name="users"></param>
        /// <param name="teams"></param>
        /// <param name="apps"></param>
        public BranchRestrictionPolicy(
            string url,
            string usersUrl,
            string teamsUrl,
            string appsUrl,
            global::System.Collections.Generic.IList<global::G.BranchRestrictionPolicyUser> users,
            global::System.Collections.Generic.IList<global::G.BranchRestrictionPolicyTeam> teams,
            global::System.Collections.Generic.IList<global::G.BranchRestrictionPolicyApp> apps)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.UsersUrl = usersUrl ?? throw new global::System.ArgumentNullException(nameof(usersUrl));
            this.TeamsUrl = teamsUrl ?? throw new global::System.ArgumentNullException(nameof(teamsUrl));
            this.AppsUrl = appsUrl ?? throw new global::System.ArgumentNullException(nameof(appsUrl));
            this.Users = users ?? throw new global::System.ArgumentNullException(nameof(users));
            this.Teams = teams ?? throw new global::System.ArgumentNullException(nameof(teams));
            this.Apps = apps ?? throw new global::System.ArgumentNullException(nameof(apps));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchRestrictionPolicy" /> class.
        /// </summary>
        public BranchRestrictionPolicy()
        {
        }
    }
}