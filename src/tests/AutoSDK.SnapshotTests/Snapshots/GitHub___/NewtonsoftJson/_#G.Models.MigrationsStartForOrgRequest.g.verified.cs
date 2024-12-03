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
        /// Indicates whether repositories should be locked (to prevent manipulation) while migrating data.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("lock_repositories")]
        public bool? LockRepositories { get; set; }

        /// <summary>
        /// Indicates whether metadata should be excluded and only git source should be included for the migration.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude_metadata")]
        public bool? ExcludeMetadata { get; set; }

        /// <summary>
        /// Indicates whether the repository git data should be excluded from the migration.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude_git_data")]
        public bool? ExcludeGitData { get; set; }

        /// <summary>
        /// Indicates whether attachments should be excluded from the migration (to reduce migration archive file size).<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("exclude_attachments")]
        public bool? ExcludeAttachments { get; set; }

        /// <summary>
        /// Indicates whether releases should be excluded from the migration (to reduce migration archive file size).<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("exclude_releases")]
        public bool? ExcludeReleases { get; set; }

        /// <summary>
        /// Indicates whether projects owned by the organization or users should be excluded. from the migration.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("exclude_owner_projects")]
        public bool? ExcludeOwnerProjects { get; set; }

        /// <summary>
        /// Indicates whether this should only include organization metadata (repositories array should be empty and will ignore other flags).<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("org_metadata_only")]
        public bool? OrgMetadataOnly { get; set; }

        /// <summary>
        /// Exclude related items from being returned in the response in order to improve performance of the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude")]
        public global::System.Collections.Generic.IList<global::G.MigrationsStartForOrgRequestExcludeItem>? Exclude { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationsStartForOrgRequest" /> class.
        /// </summary>
        /// <param name="repositories">
        /// A list of arrays indicating which repositories should be migrated.
        /// </param>
        /// <param name="lockRepositories">
        /// Indicates whether repositories should be locked (to prevent manipulation) while migrating data.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="excludeMetadata">
        /// Indicates whether metadata should be excluded and only git source should be included for the migration.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="excludeGitData">
        /// Indicates whether the repository git data should be excluded from the migration.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="excludeAttachments">
        /// Indicates whether attachments should be excluded from the migration (to reduce migration archive file size).<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="excludeReleases">
        /// Indicates whether releases should be excluded from the migration (to reduce migration archive file size).<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="excludeOwnerProjects">
        /// Indicates whether projects owned by the organization or users should be excluded. from the migration.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="orgMetadataOnly">
        /// Indicates whether this should only include organization metadata (repositories array should be empty and will ignore other flags).<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="exclude">
        /// Exclude related items from being returned in the response in order to improve performance of the request.
        /// </param>
        public MigrationsStartForOrgRequest(
            global::System.Collections.Generic.IList<string> repositories,
            bool? lockRepositories,
            bool? excludeMetadata,
            bool? excludeGitData,
            bool? excludeAttachments,
            bool? excludeReleases,
            bool? excludeOwnerProjects,
            bool? orgMetadataOnly,
            global::System.Collections.Generic.IList<global::G.MigrationsStartForOrgRequestExcludeItem>? exclude)
        {
            this.Repositories = repositories ?? throw new global::System.ArgumentNullException(nameof(repositories));
            this.LockRepositories = lockRepositories;
            this.ExcludeMetadata = excludeMetadata;
            this.ExcludeGitData = excludeGitData;
            this.ExcludeAttachments = excludeAttachments;
            this.ExcludeReleases = excludeReleases;
            this.ExcludeOwnerProjects = excludeOwnerProjects;
            this.OrgMetadataOnly = orgMetadataOnly;
            this.Exclude = exclude;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationsStartForOrgRequest" /> class.
        /// </summary>
        public MigrationsStartForOrgRequest()
        {
        }
    }
}