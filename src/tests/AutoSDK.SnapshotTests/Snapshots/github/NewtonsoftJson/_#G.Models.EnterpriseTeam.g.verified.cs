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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public long Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string Slug { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: disabled | all
        /// </summary>
        /// <example>disabled | all</example>
        [global::Newtonsoft.Json.JsonProperty("sync_to_organizations", Required = global::Newtonsoft.Json.Required.Always)]
        public string SyncToOrganizations { get; set; } = default!;

        /// <summary>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("group_id")]
        public int? GroupId { get; set; }

        /// <summary>
        /// Example: https://github.com/enterprises/dc/teams/justice-league
        /// </summary>
        /// <example>https://github.com/enterprises/dc/teams/justice-league</example>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("members_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string MembersUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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