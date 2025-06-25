//HintName: G.Models.WebhookPullRequestReviewDismissedPullRequestRequestedTeam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Groups of organization members that gives permissions on specified repositories.
    /// </summary>
    public sealed partial class WebhookPullRequestReviewDismissedPullRequestRequestedTeam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Description of the team
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// Unique identifier of the team
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_url")]
        public string? MembersUrl { get; set; }

        /// <summary>
        /// Name of the team
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent")]
        public global::G.WebhookPullRequestReviewDismissedPullRequestRequestedTeamParent? Parent { get; set; }

        /// <summary>
        /// Permission that the team will have for its repositories
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        public string? Permission { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookPullRequestReviewDismissedPullRequestRequestedTeamPrivacyJsonConverter))]
        public global::G.WebhookPullRequestReviewDismissedPullRequestRequestedTeamPrivacy? Privacy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories_url")]
        public string? RepositoriesUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// URL for the team
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestReviewDismissedPullRequestRequestedTeam" /> class.
        /// </summary>
        /// <param name="deleted"></param>
        /// <param name="description">
        /// Description of the team
        /// </param>
        /// <param name="htmlUrl"></param>
        /// <param name="id">
        /// Unique identifier of the team
        /// </param>
        /// <param name="membersUrl"></param>
        /// <param name="name">
        /// Name of the team
        /// </param>
        /// <param name="nodeId"></param>
        /// <param name="parent"></param>
        /// <param name="permission">
        /// Permission that the team will have for its repositories
        /// </param>
        /// <param name="privacy"></param>
        /// <param name="repositoriesUrl"></param>
        /// <param name="slug"></param>
        /// <param name="url">
        /// URL for the team
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookPullRequestReviewDismissedPullRequestRequestedTeam(
            int id,
            string name,
            bool? deleted,
            string? description,
            string? htmlUrl,
            string? membersUrl,
            string? nodeId,
            global::G.WebhookPullRequestReviewDismissedPullRequestRequestedTeamParent? parent,
            string? permission,
            global::G.WebhookPullRequestReviewDismissedPullRequestRequestedTeamPrivacy? privacy,
            string? repositoriesUrl,
            string? slug,
            string? url)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Deleted = deleted;
            this.Description = description;
            this.HtmlUrl = htmlUrl;
            this.MembersUrl = membersUrl;
            this.NodeId = nodeId;
            this.Parent = parent;
            this.Permission = permission;
            this.Privacy = privacy;
            this.RepositoriesUrl = repositoriesUrl;
            this.Slug = slug;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestReviewDismissedPullRequestRequestedTeam" /> class.
        /// </summary>
        public WebhookPullRequestReviewDismissedPullRequestRequestedTeam()
        {
        }
    }
}