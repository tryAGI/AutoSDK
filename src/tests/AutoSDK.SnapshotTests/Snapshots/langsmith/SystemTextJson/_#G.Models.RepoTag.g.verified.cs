//HintName: G.Models.RepoTag.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Fields for a prompt tag
    /// </summary>
    public sealed partial class RepoTag
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RepoId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid CommitId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_hash")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommitHash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TagName { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepoTag" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="repoId"></param>
        /// <param name="commitId"></param>
        /// <param name="commitHash"></param>
        /// <param name="tagName"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepoTag(
            global::System.Guid id,
            global::System.Guid repoId,
            global::System.Guid commitId,
            string commitHash,
            string tagName,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt)
        {
            this.Id = id;
            this.RepoId = repoId;
            this.CommitId = commitId;
            this.CommitHash = commitHash ?? throw new global::System.ArgumentNullException(nameof(commitHash));
            this.TagName = tagName ?? throw new global::System.ArgumentNullException(nameof(tagName));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepoTag" /> class.
        /// </summary>
        public RepoTag()
        {
        }
    }
}