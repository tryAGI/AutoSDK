//HintName: G.Models.WebhookCheckSuiteRequestedCheckSuiteApp.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
    /// </summary>
    public sealed partial class WebhookCheckSuiteRequestedCheckSuiteApp
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Description { get; set; } = default!;

        /// <summary>
        /// The list of events for the GitHub app
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events")]
        public global::System.Collections.Generic.IList<global::G.WebhookCheckSuiteRequestedCheckSuiteAppEvent>? Events { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("external_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string? ExternalUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the GitHub app
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int? Id { get; set; } = default!;

        /// <summary>
        /// Client ID of the GitHub app
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("client_id")]
        public string? ClientId { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("owner", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteAppOwner? Owner { get; set; } = default!;

        /// <summary>
        /// The set of permissions for the GitHub app
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permissions")]
        public global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissions? Permissions { get; set; }

        /// <summary>
        /// The slug name of the GitHub app
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCheckSuiteRequestedCheckSuiteApp" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="description"></param>
        /// <param name="events">
        /// The list of events for the GitHub app
        /// </param>
        /// <param name="externalUrl"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="id">
        /// Unique identifier of the GitHub app
        /// </param>
        /// <param name="clientId">
        /// Client ID of the GitHub app
        /// </param>
        /// <param name="name">
        /// The name of the GitHub app
        /// </param>
        /// <param name="nodeId"></param>
        /// <param name="owner"></param>
        /// <param name="permissions">
        /// The set of permissions for the GitHub app
        /// </param>
        /// <param name="slug">
        /// The slug name of the GitHub app
        /// </param>
        /// <param name="updatedAt"></param>
        public WebhookCheckSuiteRequestedCheckSuiteApp(
            global::System.DateTime? createdAt,
            string? description,
            string? externalUrl,
            string htmlUrl,
            int? id,
            string name,
            string nodeId,
            global::G.WebhookCheckSuiteRequestedCheckSuiteAppOwner? owner,
            global::System.DateTime? updatedAt,
            global::System.Collections.Generic.IList<global::G.WebhookCheckSuiteRequestedCheckSuiteAppEvent>? events,
            string? clientId,
            global::G.WebhookCheckSuiteRequestedCheckSuiteAppPermissions? permissions,
            string? slug)
        {
            this.CreatedAt = createdAt;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.ExternalUrl = externalUrl ?? throw new global::System.ArgumentNullException(nameof(externalUrl));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.UpdatedAt = updatedAt;
            this.Events = events;
            this.ClientId = clientId;
            this.Permissions = permissions;
            this.Slug = slug;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCheckSuiteRequestedCheckSuiteApp" /> class.
        /// </summary>
        public WebhookCheckSuiteRequestedCheckSuiteApp()
        {
        }
    }
}