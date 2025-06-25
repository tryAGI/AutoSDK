//HintName: G.Models.BranchRestrictionPolicyTeam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BranchRestrictionPolicyTeam
    {
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
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy")]
        public string? Privacy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notification_setting")]
        public string? NotificationSetting { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        public string? Permission { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_url")]
        public string? MembersUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories_url")]
        public string? RepositoriesUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent")]
        public string? Parent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchRestrictionPolicyTeam" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nodeId"></param>
        /// <param name="url"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="name"></param>
        /// <param name="slug"></param>
        /// <param name="description"></param>
        /// <param name="privacy"></param>
        /// <param name="notificationSetting"></param>
        /// <param name="permission"></param>
        /// <param name="membersUrl"></param>
        /// <param name="repositoriesUrl"></param>
        /// <param name="parent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BranchRestrictionPolicyTeam(
            int? id,
            string? nodeId,
            string? url,
            string? htmlUrl,
            string? name,
            string? slug,
            string? description,
            string? privacy,
            string? notificationSetting,
            string? permission,
            string? membersUrl,
            string? repositoriesUrl,
            string? parent)
        {
            this.Id = id;
            this.NodeId = nodeId;
            this.Url = url;
            this.HtmlUrl = htmlUrl;
            this.Name = name;
            this.Slug = slug;
            this.Description = description;
            this.Privacy = privacy;
            this.NotificationSetting = notificationSetting;
            this.Permission = permission;
            this.MembersUrl = membersUrl;
            this.RepositoriesUrl = repositoriesUrl;
            this.Parent = parent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchRestrictionPolicyTeam" /> class.
        /// </summary>
        public BranchRestrictionPolicyTeam()
        {
        }
    }
}