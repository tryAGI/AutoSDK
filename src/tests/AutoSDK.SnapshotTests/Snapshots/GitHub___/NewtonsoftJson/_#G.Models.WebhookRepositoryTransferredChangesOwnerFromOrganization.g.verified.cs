//HintName: G.Models.WebhookRepositoryTransferredChangesOwnerFromOrganization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRepositoryTransferredChangesOwnerFromOrganization
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatar_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string AvatarUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hooks_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HooksUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("issues_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string IssuesUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("login", Required = global::Newtonsoft.Json.Required.Always)]
        public string Login { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("members_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string MembersUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public_members_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PublicMembersUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repos_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ReposUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryTransferredChangesOwnerFromOrganization" /> class.
        /// </summary>
        /// <param name="avatarUrl"></param>
        /// <param name="description"></param>
        /// <param name="eventsUrl"></param>
        /// <param name="hooksUrl"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="id"></param>
        /// <param name="issuesUrl"></param>
        /// <param name="login"></param>
        /// <param name="membersUrl"></param>
        /// <param name="nodeId"></param>
        /// <param name="publicMembersUrl"></param>
        /// <param name="reposUrl"></param>
        /// <param name="url"></param>
        public WebhookRepositoryTransferredChangesOwnerFromOrganization(
            string avatarUrl,
            string? description,
            string eventsUrl,
            string hooksUrl,
            int id,
            string issuesUrl,
            string login,
            string membersUrl,
            string nodeId,
            string publicMembersUrl,
            string reposUrl,
            string url,
            string? htmlUrl)
        {
            this.AvatarUrl = avatarUrl ?? throw new global::System.ArgumentNullException(nameof(avatarUrl));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.EventsUrl = eventsUrl ?? throw new global::System.ArgumentNullException(nameof(eventsUrl));
            this.HooksUrl = hooksUrl ?? throw new global::System.ArgumentNullException(nameof(hooksUrl));
            this.Id = id;
            this.IssuesUrl = issuesUrl ?? throw new global::System.ArgumentNullException(nameof(issuesUrl));
            this.Login = login ?? throw new global::System.ArgumentNullException(nameof(login));
            this.MembersUrl = membersUrl ?? throw new global::System.ArgumentNullException(nameof(membersUrl));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.PublicMembersUrl = publicMembersUrl ?? throw new global::System.ArgumentNullException(nameof(publicMembersUrl));
            this.ReposUrl = reposUrl ?? throw new global::System.ArgumentNullException(nameof(reposUrl));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.HtmlUrl = htmlUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryTransferredChangesOwnerFromOrganization" /> class.
        /// </summary>
        public WebhookRepositoryTransferredChangesOwnerFromOrganization()
        {
        }
    }
}