//HintName: G.Models.MigrationsStartForAuthenticatedUserRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MigrationsStartForAuthenticatedUserRequest
    {
        /// <summary>
        /// Lock the repositories being migrated at the start of the migration
        /// <br/>Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lock_repositories")]
        public bool LockRepositories { get; set; }

        /// <summary>
        /// Indicates whether metadata should be excluded and only git source should be included for the migration.
        /// <br/>Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude_metadata")]
        public bool ExcludeMetadata { get; set; }

        /// <summary>
        /// Indicates whether the repository git data should be excluded from the migration.
        /// <br/>Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude_git_data")]
        public bool ExcludeGitData { get; set; }

        /// <summary>
        /// Do not include attachments in the migration
        /// <br/>Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude_attachments")]
        public bool ExcludeAttachments { get; set; }

        /// <summary>
        /// Do not include releases in the migration
        /// <br/>Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude_releases")]
        public bool ExcludeReleases { get; set; }

        /// <summary>
        /// Indicates whether projects owned by the organization or users should be excluded.
        /// <br/>Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude_owner_projects")]
        public bool ExcludeOwnerProjects { get; set; }

        /// <summary>
        /// Indicates whether this should only include organization metadata (repositories array should be empty and will ignore other flags).
        /// <br/>Default Value: false
        /// <br/>Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("org_metadata_only")]
        public bool OrgMetadataOnly { get; set; } = false;

        /// <summary>
        /// Exclude attributes from the API response to improve performance
        /// <br/>Example: [repositories]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude")]
        public global::System.Collections.Generic.IList<MigrationsStartForAuthenticatedUserRequestExclude?>? Exclude { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repositories", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Repositories { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}