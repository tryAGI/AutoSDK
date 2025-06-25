//HintName: G.Models.BranchRestrictionPolicyAppOwner.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BranchRestrictionPolicyAppOwner
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("login")]
        public string? Login { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repos_url")]
        public string? ReposUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events_url")]
        public string? EventsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hooks_url")]
        public string? HooksUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues_url")]
        public string? IssuesUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_url")]
        public string? MembersUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_members_url")]
        public string? PublicMembersUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_url")]
        public string? AvatarUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Example: ""
        /// </summary>
        /// <example>""</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("gravatar_id")]
        public string? GravatarId { get; set; }

        /// <summary>
        /// Example: "https://github.com/testorg-ea8ec76d71c3af4b"
        /// </summary>
        /// <example>"https://github.com/testorg-ea8ec76d71c3af4b"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// Example: "https://api.github.com/users/testorg-ea8ec76d71c3af4b/followers"
        /// </summary>
        /// <example>"https://api.github.com/users/testorg-ea8ec76d71c3af4b/followers"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("followers_url")]
        public string? FollowersUrl { get; set; }

        /// <summary>
        /// Example: "https://api.github.com/users/testorg-ea8ec76d71c3af4b/following{/other_user}"
        /// </summary>
        /// <example>"https://api.github.com/users/testorg-ea8ec76d71c3af4b/following{/other_user}"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("following_url")]
        public string? FollowingUrl { get; set; }

        /// <summary>
        /// Example: "https://api.github.com/users/testorg-ea8ec76d71c3af4b/gists{/gist_id}"
        /// </summary>
        /// <example>"https://api.github.com/users/testorg-ea8ec76d71c3af4b/gists{/gist_id}"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("gists_url")]
        public string? GistsUrl { get; set; }

        /// <summary>
        /// Example: "https://api.github.com/users/testorg-ea8ec76d71c3af4b/starred{/owner}{/repo}"
        /// </summary>
        /// <example>"https://api.github.com/users/testorg-ea8ec76d71c3af4b/starred{/owner}{/repo}"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("starred_url")]
        public string? StarredUrl { get; set; }

        /// <summary>
        /// Example: "https://api.github.com/users/testorg-ea8ec76d71c3af4b/subscriptions"
        /// </summary>
        /// <example>"https://api.github.com/users/testorg-ea8ec76d71c3af4b/subscriptions"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptions_url")]
        public string? SubscriptionsUrl { get; set; }

        /// <summary>
        /// Example: "https://api.github.com/users/testorg-ea8ec76d71c3af4b/orgs"
        /// </summary>
        /// <example>"https://api.github.com/users/testorg-ea8ec76d71c3af4b/orgs"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizations_url")]
        public string? OrganizationsUrl { get; set; }

        /// <summary>
        /// Example: "https://api.github.com/users/testorg-ea8ec76d71c3af4b/received_events"
        /// </summary>
        /// <example>"https://api.github.com/users/testorg-ea8ec76d71c3af4b/received_events"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("received_events_url")]
        public string? ReceivedEventsUrl { get; set; }

        /// <summary>
        /// Example: "Organization"
        /// </summary>
        /// <example>"Organization"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("site_admin")]
        public bool? SiteAdmin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchRestrictionPolicyAppOwner" /> class.
        /// </summary>
        /// <param name="login"></param>
        /// <param name="id"></param>
        /// <param name="nodeId"></param>
        /// <param name="url"></param>
        /// <param name="reposUrl"></param>
        /// <param name="eventsUrl"></param>
        /// <param name="hooksUrl"></param>
        /// <param name="issuesUrl"></param>
        /// <param name="membersUrl"></param>
        /// <param name="publicMembersUrl"></param>
        /// <param name="avatarUrl"></param>
        /// <param name="description"></param>
        /// <param name="gravatarId">
        /// Example: ""
        /// </param>
        /// <param name="htmlUrl">
        /// Example: "https://github.com/testorg-ea8ec76d71c3af4b"
        /// </param>
        /// <param name="followersUrl">
        /// Example: "https://api.github.com/users/testorg-ea8ec76d71c3af4b/followers"
        /// </param>
        /// <param name="followingUrl">
        /// Example: "https://api.github.com/users/testorg-ea8ec76d71c3af4b/following{/other_user}"
        /// </param>
        /// <param name="gistsUrl">
        /// Example: "https://api.github.com/users/testorg-ea8ec76d71c3af4b/gists{/gist_id}"
        /// </param>
        /// <param name="starredUrl">
        /// Example: "https://api.github.com/users/testorg-ea8ec76d71c3af4b/starred{/owner}{/repo}"
        /// </param>
        /// <param name="subscriptionsUrl">
        /// Example: "https://api.github.com/users/testorg-ea8ec76d71c3af4b/subscriptions"
        /// </param>
        /// <param name="organizationsUrl">
        /// Example: "https://api.github.com/users/testorg-ea8ec76d71c3af4b/orgs"
        /// </param>
        /// <param name="receivedEventsUrl">
        /// Example: "https://api.github.com/users/testorg-ea8ec76d71c3af4b/received_events"
        /// </param>
        /// <param name="type">
        /// Example: "Organization"
        /// </param>
        /// <param name="siteAdmin">
        /// Example: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BranchRestrictionPolicyAppOwner(
            string? login,
            int? id,
            string? nodeId,
            string? url,
            string? reposUrl,
            string? eventsUrl,
            string? hooksUrl,
            string? issuesUrl,
            string? membersUrl,
            string? publicMembersUrl,
            string? avatarUrl,
            string? description,
            string? gravatarId,
            string? htmlUrl,
            string? followersUrl,
            string? followingUrl,
            string? gistsUrl,
            string? starredUrl,
            string? subscriptionsUrl,
            string? organizationsUrl,
            string? receivedEventsUrl,
            string? type,
            bool? siteAdmin)
        {
            this.Login = login;
            this.Id = id;
            this.NodeId = nodeId;
            this.Url = url;
            this.ReposUrl = reposUrl;
            this.EventsUrl = eventsUrl;
            this.HooksUrl = hooksUrl;
            this.IssuesUrl = issuesUrl;
            this.MembersUrl = membersUrl;
            this.PublicMembersUrl = publicMembersUrl;
            this.AvatarUrl = avatarUrl;
            this.Description = description;
            this.GravatarId = gravatarId;
            this.HtmlUrl = htmlUrl;
            this.FollowersUrl = followersUrl;
            this.FollowingUrl = followingUrl;
            this.GistsUrl = gistsUrl;
            this.StarredUrl = starredUrl;
            this.SubscriptionsUrl = subscriptionsUrl;
            this.OrganizationsUrl = organizationsUrl;
            this.ReceivedEventsUrl = receivedEventsUrl;
            this.Type = type;
            this.SiteAdmin = siteAdmin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchRestrictionPolicyAppOwner" /> class.
        /// </summary>
        public BranchRestrictionPolicyAppOwner()
        {
        }
    }
}