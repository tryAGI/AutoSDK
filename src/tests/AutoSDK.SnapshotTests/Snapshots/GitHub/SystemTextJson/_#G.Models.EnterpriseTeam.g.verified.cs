//HintName: G.Models.EnterpriseTeam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Group of enterprise owners and/or members
    /// </summary>
    public sealed partial class EnterpriseTeam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: disabled | all
        /// </summary>
        /// <example>disabled | all</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sync_to_organizations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SyncToOrganizations { get; set; }

        /// <summary>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public int? GroupId { get; set; }

        /// <summary>
        /// Example: https://github.com/enterprises/dc/teams/justice-league
        /// </summary>
        /// <example>https://github.com/enterprises/dc/teams/justice-league</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MembersUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseTeam" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="slug"></param>
        /// <param name="url"></param>
        /// <param name="syncToOrganizations">
        /// Example: disabled | all
        /// </param>
        /// <param name="groupId">
        /// Example: 1
        /// </param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/enterprises/dc/teams/justice-league
        /// </param>
        /// <param name="membersUrl"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public EnterpriseTeam(
            long id,
            string name,
            string slug,
            string url,
            string syncToOrganizations,
            string htmlUrl,
            string membersUrl,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            int? groupId)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.SyncToOrganizations = syncToOrganizations ?? throw new global::System.ArgumentNullException(nameof(syncToOrganizations));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.MembersUrl = membersUrl ?? throw new global::System.ArgumentNullException(nameof(membersUrl));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.GroupId = groupId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseTeam" /> class.
        /// </summary>
        public EnterpriseTeam()
        {
        }
    }
}