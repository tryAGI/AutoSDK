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
        /// Lock the repositories being migrated at the start of the migration<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lock_repositories")]
        public bool? LockRepositories { get; set; }

        /// <summary>
        /// Indicates whether metadata should be excluded and only git source should be included for the migration.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_metadata")]
        public bool? ExcludeMetadata { get; set; }

        /// <summary>
        /// Indicates whether the repository git data should be excluded from the migration.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_git_data")]
        public bool? ExcludeGitData { get; set; }

        /// <summary>
        /// Do not include attachments in the migration<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_attachments")]
        public bool? ExcludeAttachments { get; set; }

        /// <summary>
        /// Do not include releases in the migration<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_releases")]
        public bool? ExcludeReleases { get; set; }

        /// <summary>
        /// Indicates whether projects owned by the organization or users should be excluded.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_owner_projects")]
        public bool? ExcludeOwnerProjects { get; set; }

        /// <summary>
        /// Indicates whether this should only include organization metadata (repositories array should be empty and will ignore other flags).<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_metadata_only")]
        public bool? OrgMetadataOnly { get; set; }

        /// <summary>
        /// Exclude attributes from the API response to improve performance<br/>
        /// Example: [repositories]
        /// </summary>
        /// <example>[repositories]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude")]
        public global::System.Collections.Generic.IList<global::G.MigrationsStartForAuthenticatedUserRequestExcludeItem>? Exclude { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Repositories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationsStartForAuthenticatedUserRequest" /> class.
        /// </summary>
        /// <param name="lockRepositories">
        /// Lock the repositories being migrated at the start of the migration<br/>
        /// Example: true
        /// </param>
        /// <param name="excludeMetadata">
        /// Indicates whether metadata should be excluded and only git source should be included for the migration.<br/>
        /// Example: true
        /// </param>
        /// <param name="excludeGitData">
        /// Indicates whether the repository git data should be excluded from the migration.<br/>
        /// Example: true
        /// </param>
        /// <param name="excludeAttachments">
        /// Do not include attachments in the migration<br/>
        /// Example: true
        /// </param>
        /// <param name="excludeReleases">
        /// Do not include releases in the migration<br/>
        /// Example: true
        /// </param>
        /// <param name="excludeOwnerProjects">
        /// Indicates whether projects owned by the organization or users should be excluded.<br/>
        /// Example: true
        /// </param>
        /// <param name="orgMetadataOnly">
        /// Indicates whether this should only include organization metadata (repositories array should be empty and will ignore other flags).<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="exclude">
        /// Exclude attributes from the API response to improve performance<br/>
        /// Example: [repositories]
        /// </param>
        /// <param name="repositories"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MigrationsStartForAuthenticatedUserRequest(
            global::System.Collections.Generic.IList<string> repositories,
            bool? lockRepositories,
            bool? excludeMetadata,
            bool? excludeGitData,
            bool? excludeAttachments,
            bool? excludeReleases,
            bool? excludeOwnerProjects,
            bool? orgMetadataOnly,
            global::System.Collections.Generic.IList<global::G.MigrationsStartForAuthenticatedUserRequestExcludeItem>? exclude)
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
        /// Initializes a new instance of the <see cref="MigrationsStartForAuthenticatedUserRequest" /> class.
        /// </summary>
        public MigrationsStartForAuthenticatedUserRequest()
        {
        }
    }
}