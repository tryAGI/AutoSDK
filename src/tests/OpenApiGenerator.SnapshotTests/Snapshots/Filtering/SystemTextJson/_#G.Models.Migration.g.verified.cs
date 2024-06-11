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
        /// <br/>Example: 79
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NullableSimpleUser? Owner { get; set; }

        /// <summary>
        /// <br/>Example: 0b989ba4-242f-11e5-81e1-c7b6966d2516
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Guid { get; set; }

        /// <summary>
        /// <br/>Example: pending
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string State { get; set; }

        /// <summary>
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lock_repositories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool LockRepositories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ExcludeMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_git_data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ExcludeGitData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_attachments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ExcludeAttachments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_releases")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ExcludeReleases { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_owner_projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ExcludeOwnerProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_metadata_only")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool OrgMetadataOnly { get; set; }

        /// <summary>
        /// The repositories included in the migration. Only returned for export migrations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Repository> Repositories { get; set; }

        /// <summary>
        /// <br/>Example: https://api.github.com/orgs/octo-org/migrations/79
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archive_url")]
        public string? ArchiveUrl { get; set; }

        /// <summary>
        /// Exclude related items from being returned in the response in order to improve performance of the request. The array can include any of: `"repositories"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude")]
        public global::System.Collections.Generic.IList<string?>? Exclude { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}