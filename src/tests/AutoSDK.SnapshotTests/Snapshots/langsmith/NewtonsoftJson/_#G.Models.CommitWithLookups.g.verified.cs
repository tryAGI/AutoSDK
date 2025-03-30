//HintName: G.Models.CommitWithLookups.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// All database fields for commits, plus helpful computed fields and user info<br/>
    /// for private prompts.
    /// </summary>
    public sealed partial class CommitWithLookups
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manifest", Required = global::Newtonsoft.Json.Required.Always)]
        public object Manifest { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repo_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid RepoId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent_id")]
        public global::System.Guid? ParentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_hash", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommitHash { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("example_run_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> ExampleRunIds { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_downloads", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumDownloads { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_views", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumViews { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent_commit_hash")]
        public string? ParentCommitHash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("full_name")]
        public string? FullName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitWithLookups" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="manifest"></param>
        /// <param name="repoId"></param>
        /// <param name="parentId"></param>
        /// <param name="commitHash"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="exampleRunIds"></param>
        /// <param name="numDownloads"></param>
        /// <param name="numViews"></param>
        /// <param name="parentCommitHash"></param>
        /// <param name="fullName"></param>
        public CommitWithLookups(
            global::System.Guid id,
            object manifest,
            global::System.Guid repoId,
            string commitHash,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.Collections.Generic.IList<global::System.Guid> exampleRunIds,
            int numDownloads,
            int numViews,
            global::System.Guid? parentId,
            string? parentCommitHash,
            string? fullName)
        {
            this.Id = id;
            this.Manifest = manifest ?? throw new global::System.ArgumentNullException(nameof(manifest));
            this.RepoId = repoId;
            this.CommitHash = commitHash ?? throw new global::System.ArgumentNullException(nameof(commitHash));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ExampleRunIds = exampleRunIds ?? throw new global::System.ArgumentNullException(nameof(exampleRunIds));
            this.NumDownloads = numDownloads;
            this.NumViews = numViews;
            this.ParentId = parentId;
            this.ParentCommitHash = parentCommitHash;
            this.FullName = fullName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitWithLookups" /> class.
        /// </summary>
        public CommitWithLookups()
        {
        }
    }
}