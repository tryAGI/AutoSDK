//HintName: G.Models.WebhookIssueCommentEditedIssueIssue1PerformedViaGithubApp.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
    /// </summary>
    public sealed partial class WebhookIssueCommentEditedIssueIssue1PerformedViaGithubApp
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The list of events for the GitHub app
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events")]
        public global::System.Collections.Generic.IList<global::G.WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent>? Events { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("external_url")]
        public string? ExternalUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the GitHub app
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// The name of the GitHub app
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner")]
        public global::G.WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppOwner? Owner { get; set; }

        /// <summary>
        /// The set of permissions for the GitHub app
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permissions")]
        public global::G.WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppPermissions? Permissions { get; set; }

        /// <summary>
        /// The slug name of the GitHub app
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssueCommentEditedIssueIssue1PerformedViaGithubApp" /> class.
        /// </summary>
        /// <param name="htmlUrl"></param>
        /// <param name="name">
        /// The name of the GitHub app
        /// </param>
        /// <param name="nodeId"></param>
        /// <param name="createdAt"></param>
        /// <param name="description"></param>
        /// <param name="events">
        /// The list of events for the GitHub app
        /// </param>
        /// <param name="externalUrl"></param>
        /// <param name="id">
        /// Unique identifier of the GitHub app
        /// </param>
        /// <param name="owner"></param>
        /// <param name="permissions">
        /// The set of permissions for the GitHub app
        /// </param>
        /// <param name="slug">
        /// The slug name of the GitHub app
        /// </param>
        /// <param name="updatedAt"></param>
        public WebhookIssueCommentEditedIssueIssue1PerformedViaGithubApp(
            string htmlUrl,
            string name,
            string nodeId,
            global::System.DateTime? createdAt,
            string? description,
            global::System.Collections.Generic.IList<global::G.WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppEvent>? events,
            string? externalUrl,
            int? id,
            global::G.WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppOwner? owner,
            global::G.WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppPermissions? permissions,
            string? slug,
            global::System.DateTime? updatedAt)
        {
            this.CreatedAt = createdAt;
            this.Description = description;
            this.Events = events;
            this.ExternalUrl = externalUrl;
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Owner = owner;
            this.Permissions = permissions;
            this.Slug = slug;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssueCommentEditedIssueIssue1PerformedViaGithubApp" /> class.
        /// </summary>
        public WebhookIssueCommentEditedIssueIssue1PerformedViaGithubApp()
        {
        }
    }
}