//HintName: G.Models.BranchRestrictionPolicyAppsOwner.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BranchRestrictionPolicyAppsOwner
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
        public int Id { get; set; }

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
        /// <br/>Example: ""
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gravatar_id")]
        public string? GravatarId { get; set; }

        /// <summary>
        /// <br/>Example: "https://github.com/testorg-ea8ec76d71c3af4b"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// <br/>Example: "https://api.github.com/users/testorg-ea8ec76d71c3af4b/followers"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("followers_url")]
        public string? FollowersUrl { get; set; }

        /// <summary>
        /// <br/>Example: "https://api.github.com/users/testorg-ea8ec76d71c3af4b/following{/other_user}"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("following_url")]
        public string? FollowingUrl { get; set; }

        /// <summary>
        /// <br/>Example: "https://api.github.com/users/testorg-ea8ec76d71c3af4b/gists{/gist_id}"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gists_url")]
        public string? GistsUrl { get; set; }

        /// <summary>
        /// <br/>Example: "https://api.github.com/users/testorg-ea8ec76d71c3af4b/starred{/owner}{/repo}"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("starred_url")]
        public string? StarredUrl { get; set; }

        /// <summary>
        /// <br/>Example: "https://api.github.com/users/testorg-ea8ec76d71c3af4b/subscriptions"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptions_url")]
        public string? SubscriptionsUrl { get; set; }

        /// <summary>
        /// <br/>Example: "https://api.github.com/users/testorg-ea8ec76d71c3af4b/orgs"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizations_url")]
        public string? OrganizationsUrl { get; set; }

        /// <summary>
        /// <br/>Example: "https://api.github.com/users/testorg-ea8ec76d71c3af4b/received_events"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("received_events_url")]
        public string? ReceivedEventsUrl { get; set; }

        /// <summary>
        /// <br/>Example: "Organization"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// <br/>Example: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("site_admin")]
        public bool SiteAdmin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}