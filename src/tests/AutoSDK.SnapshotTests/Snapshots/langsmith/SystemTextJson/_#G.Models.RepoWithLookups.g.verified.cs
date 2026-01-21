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
        [global::System.Text.Json.Serialization.JsonPropertyName("repo_handle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepoHandle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readme")]
        public string? Readme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid TenantId { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_public")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPublic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_archived")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsArchived { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_repo_id")]
        public global::System.Guid? OriginalRepoId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upstream_repo_id")]
        public global::System.Guid? UpstreamRepoId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FullName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_likes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumLikes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_downloads")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumDownloads { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_views")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumViews { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("liked_by_auth_user")]
        public bool? LikedByAuthUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_commit_hash")]
        public string? LastCommitHash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_commits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumCommits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_repo_full_name")]
        public string? OriginalRepoFullName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upstream_repo_full_name")]
        public string? UpstreamRepoFullName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_commit_manifest")]
        public global::G.CommitManifestResponse? LatestCommitManifest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        /// <param name="latestCommitManifest"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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