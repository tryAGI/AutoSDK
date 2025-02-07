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
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UsersUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apps_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AppsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.BranchRestrictionPolicyUser> Users { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.BranchRestrictionPolicyTeam> Teams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.BranchRestrictionPolicyApp> Apps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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