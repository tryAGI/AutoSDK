//HintName: G.Models.Migration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A migration.
    /// </summary>
    public sealed partial class Migration
    {
        /// <summary>
        /// Example: 79
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? Owner { get; set; } = default!;

        /// <summary>
        /// Example: 0b989ba4-242f-11e5-81e1-c7b6966d2516
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("guid", Required = global::Newtonsoft.Json.Required.Always)]
        public string Guid { get; set; } = default!;

        /// <summary>
        /// Example: pending
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public string State { get; set; } = default!;

        /// <summary>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lock_repositories", Required = global::Newtonsoft.Json.Required.Always)]
        public bool LockRepositories { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude_metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ExcludeMetadata { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude_git_data", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ExcludeGitData { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude_attachments", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ExcludeAttachments { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude_releases", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ExcludeReleases { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude_owner_projects", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ExcludeOwnerProjects { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("org_metadata_only", Required = global::Newtonsoft.Json.Required.Always)]
        public bool OrgMetadataOnly { get; set; } = default!;

        /// <summary>
        /// The repositories included in the migration. Only returned for export migrations.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repositories", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Repository> Repositories { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/orgs/octo-org/migrations/79
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("archive_url")]
        public string? ArchiveUrl { get; set; }

        /// <summary>
        /// Exclude related items from being returned in the response in order to improve performance of the request. The array can include any of: `"repositories"`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude")]
        public global::System.Collections.Generic.IList<string?>? Exclude { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}