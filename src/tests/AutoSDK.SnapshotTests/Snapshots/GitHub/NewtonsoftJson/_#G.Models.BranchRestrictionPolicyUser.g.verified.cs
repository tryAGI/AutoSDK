//HintName: G.Models.BranchRestrictionPolicyUser.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BranchRestrictionPolicyUser
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("login")]
        public string? Login { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public long? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatar_url")]
        public string? AvatarUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gravatar_id")]
        public string? GravatarId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("followers_url")]
        public string? FollowersUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("following_url")]
        public string? FollowingUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gists_url")]
        public string? GistsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("starred_url")]
        public string? StarredUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subscriptions_url")]
        public string? SubscriptionsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organizations_url")]
        public string? OrganizationsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repos_url")]
        public string? ReposUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events_url")]
        public string? EventsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("received_events_url")]
        public string? ReceivedEventsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("site_admin")]
        public bool? SiteAdmin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchRestrictionPolicyUser" /> class.
        /// </summary>
        /// <param name="login"></param>
        /// <param name="id"></param>
        /// <param name="nodeId"></param>
        /// <param name="avatarUrl"></param>
        /// <param name="gravatarId"></param>
        /// <param name="url"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="followersUrl"></param>
        /// <param name="followingUrl"></param>
        /// <param name="gistsUrl"></param>
        /// <param name="starredUrl"></param>
        /// <param name="subscriptionsUrl"></param>
        /// <param name="organizationsUrl"></param>
        /// <param name="reposUrl"></param>
        /// <param name="eventsUrl"></param>
        /// <param name="receivedEventsUrl"></param>
        /// <param name="type"></param>
        /// <param name="siteAdmin"></param>
        public BranchRestrictionPolicyUser(
            string? login,
            long? id,
            string? nodeId,
            string? avatarUrl,
            string? gravatarId,
            string? url,
            string? htmlUrl,
            string? followersUrl,
            string? followingUrl,
            string? gistsUrl,
            string? starredUrl,
            string? subscriptionsUrl,
            string? organizationsUrl,
            string? reposUrl,
            string? eventsUrl,
            string? receivedEventsUrl,
            string? type,
            bool? siteAdmin)
        {
            this.Login = login;
            this.Id = id;
            this.NodeId = nodeId;
            this.AvatarUrl = avatarUrl;
            this.GravatarId = gravatarId;
            this.Url = url;
            this.HtmlUrl = htmlUrl;
            this.FollowersUrl = followersUrl;
            this.FollowingUrl = followingUrl;
            this.GistsUrl = gistsUrl;
            this.StarredUrl = starredUrl;
            this.SubscriptionsUrl = subscriptionsUrl;
            this.OrganizationsUrl = organizationsUrl;
            this.ReposUrl = reposUrl;
            this.EventsUrl = eventsUrl;
            this.ReceivedEventsUrl = receivedEventsUrl;
            this.Type = type;
            this.SiteAdmin = siteAdmin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchRestrictionPolicyUser" /> class.
        /// </summary>
        public BranchRestrictionPolicyUser()
        {
        }
    }
}