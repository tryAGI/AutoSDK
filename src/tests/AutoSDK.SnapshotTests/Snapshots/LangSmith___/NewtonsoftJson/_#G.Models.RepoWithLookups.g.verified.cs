//HintName: G.Models.RepoWithLookups.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// All database fields for repos, plus helpful computed fields.
    /// </summary>
    public sealed partial class RepoWithLookups
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repo_handle", Required = global::Newtonsoft.Json.Required.Always)]
        public string RepoHandle { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("readme")]
        public string? Readme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tenant_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid TenantId { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("is_public", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsPublic { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_archived", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsArchived { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Tags { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("original_repo_id")]
        public global::System.Guid? OriginalRepoId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("upstream_repo_id")]
        public global::System.Guid? UpstreamRepoId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Owner { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("full_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string FullName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_likes", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumLikes { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("liked_by_auth_user")]
        public bool? LikedByAuthUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_commit_hash")]
        public string? LastCommitHash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_commits", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumCommits { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("original_repo_full_name")]
        public string? OriginalRepoFullName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("upstream_repo_full_name")]
        public string? UpstreamRepoFullName { get; set; }

        /// <summary>
        /// Response model for get_commit_manifest.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latest_commit_manifest")]
        public global::G.CommitManifestResponse? LatestCommitManifest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepoWithLookups" /> class.
        /// </summary>
        /// <param name="repoHandle"></param>
        /// <param name="description"></param>
        /// <param name="readme"></param>
        /// <param name="id"></param>
        /// <param name="tenantId"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="isPublic"></param>
        /// <param name="isArchived"></param>
        /// <param name="tags"></param>
        /// <param name="originalRepoId"></param>
        /// <param name="upstreamRepoId"></param>
        /// <param name="owner"></param>
        /// <param name="fullName"></param>
        /// <param name="numLikes"></param>
        /// <param name="numDownloads"></param>
        /// <param name="numViews"></param>
        /// <param name="likedByAuthUser"></param>
        /// <param name="lastCommitHash"></param>
        /// <param name="numCommits"></param>
        /// <param name="originalRepoFullName"></param>
        /// <param name="upstreamRepoFullName"></param>
        /// <param name="latestCommitManifest">
        /// Response model for get_commit_manifest.
        /// </param>
        public RepoWithLookups(
            string repoHandle,
            global::System.Guid id,
            global::System.Guid tenantId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            bool isPublic,
            bool isArchived,
            global::System.Collections.Generic.IList<string> tags,
            string? owner,
            string fullName,
            int numLikes,
            int numDownloads,
            int numViews,
            int numCommits,
            string? description,
            string? readme,
            global::System.Guid? originalRepoId,
            global::System.Guid? upstreamRepoId,
            bool? likedByAuthUser,
            string? lastCommitHash,
            string? originalRepoFullName,
            string? upstreamRepoFullName,
            global::G.CommitManifestResponse? latestCommitManifest)
        {
            this.RepoHandle = repoHandle ?? throw new global::System.ArgumentNullException(nameof(repoHandle));
            this.Id = id;
            this.TenantId = tenantId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.IsPublic = isPublic;
            this.IsArchived = isArchived;
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.FullName = fullName ?? throw new global::System.ArgumentNullException(nameof(fullName));
            this.NumLikes = numLikes;
            this.NumDownloads = numDownloads;
            this.NumViews = numViews;
            this.NumCommits = numCommits;
            this.Description = description;
            this.Readme = readme;
            this.OriginalRepoId = originalRepoId;
            this.UpstreamRepoId = upstreamRepoId;
            this.LikedByAuthUser = likedByAuthUser;
            this.LastCommitHash = lastCommitHash;
            this.OriginalRepoFullName = originalRepoFullName;
            this.UpstreamRepoFullName = upstreamRepoFullName;
            this.LatestCommitManifest = latestCommitManifest;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepoWithLookups" /> class.
        /// </summary>
        public RepoWithLookups()
        {
        }
    }
}