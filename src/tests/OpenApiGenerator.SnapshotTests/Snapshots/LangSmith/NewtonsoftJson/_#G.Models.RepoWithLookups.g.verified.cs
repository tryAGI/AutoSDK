//HintName: G.Models.RepoWithLookups.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

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
        public global::System.AnyOf<string?, object?>? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("readme")]
        public global::System.AnyOf<string?, object?>? Readme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tenant_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string TenantId { get; set; } = default!;

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
        public global::System.AnyOf<string?, object?>? OriginalRepoId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("upstream_repo_id")]
        public global::System.AnyOf<string?, object?>? UpstreamRepoId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.AnyOf<string, object> Owner { get; set; } = default!;

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
        public global::System.AnyOf<bool, object?>? LikedByAuthUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_commit_hash")]
        public global::System.AnyOf<string?, object?>? LastCommitHash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_commits", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumCommits { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("original_repo_full_name")]
        public global::System.AnyOf<string?, object?>? OriginalRepoFullName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("upstream_repo_full_name")]
        public global::System.AnyOf<string?, object?>? UpstreamRepoFullName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}