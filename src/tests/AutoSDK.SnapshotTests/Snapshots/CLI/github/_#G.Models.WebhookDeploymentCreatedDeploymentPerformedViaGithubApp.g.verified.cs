//HintName: G.Models.WebhookDeploymentCreatedDeploymentPerformedViaGithubApp.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
    /// </summary>
    public sealed partial class WebhookDeploymentCreatedDeploymentPerformedViaGithubApp
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Description { get; set; }

        /// <summary>
        /// The list of events for the GitHub app
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<global::G.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent>? Events { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? ExternalUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// Unique identifier of the GitHub app
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? Id { get; set; }

        /// <summary>
        /// The name of the GitHub app
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppOwner? Owner { get; set; }

        /// <summary>
        /// The set of permissions for the GitHub app
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::G.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissions? Permissions { get; set; }

        /// <summary>
        /// The slug name of the GitHub app
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeploymentCreatedDeploymentPerformedViaGithubApp" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookDeploymentCreatedDeploymentPerformedViaGithubApp(
            global::System.DateTime? createdAt,
            string? description,
            string? externalUrl,
            string htmlUrl,
            int? id,
            string name,
            string nodeId,
            global::G.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppOwner? owner,
            global::System.DateTime? updatedAt,
            global::System.Collections.Generic.IList<global::G.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppEvent>? events,
            global::G.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissions? permissions,
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
            this.Permissions = permissions;
            this.Slug = slug;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeploymentCreatedDeploymentPerformedViaGithubApp" /> class.
        /// </summary>
        public WebhookDeploymentCreatedDeploymentPerformedViaGithubApp()
        {
        }
    }
}