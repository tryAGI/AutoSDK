//HintName: G.Models.MigrationsStartForOrgRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MigrationsStartForOrgRequest
    {
        /// <summary>
        /// A list of arrays indicating which repositories should be migrated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repositories", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Repositories { get; set; } = default!;

        /// <summary>
        /// Indicates whether repositories should be locked (to prevent manipulation) while migrating data.
        /// <br/>Default Value: false
        /// <br/>Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lock_repositories")]
        public bool LockRepositories { get; set; } = false;

        /// <summary>
        /// Indicates whether metadata should be excluded and only git source should be included for the migration.
        /// <br/>Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude_metadata")]
        public bool ExcludeMetadata { get; set; } = false;

        /// <summary>
        /// Indicates whether the repository git data should be excluded from the migration.
        /// <br/>Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude_git_data")]
        public bool ExcludeGitData { get; set; } = false;

        /// <summary>
        /// Indicates whether attachments should be excluded from the migration (to reduce migration archive file size).
        /// <br/>Default Value: false
        /// <br/>Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude_attachments")]
        public bool ExcludeAttachments { get; set; } = false;

        /// <summary>
        /// Indicates whether releases should be excluded from the migration (to reduce migration archive file size).
        /// <br/>Default Value: false
        /// <br/>Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude_releases")]
        public bool ExcludeReleases { get; set; } = false;

        /// <summary>
        /// Indicates whether projects owned by the organization or users should be excluded. from the migration.
        /// <br/>Default Value: false
        /// <br/>Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude_owner_projects")]
        public bool ExcludeOwnerProjects { get; set; } = false;

        /// <summary>
        /// Indicates whether this should only include organization metadata (repositories array should be empty and will ignore other flags).
        /// <br/>Default Value: false
        /// <br/>Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("org_metadata_only")]
        public bool OrgMetadataOnly { get; set; } = false;

        /// <summary>
        /// Exclude related items from being returned in the response in order to improve performance of the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude")]
        public global::System.Collections.Generic.IList<global::G.MigrationsStartForOrgRequestExclude?>? Exclude { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}