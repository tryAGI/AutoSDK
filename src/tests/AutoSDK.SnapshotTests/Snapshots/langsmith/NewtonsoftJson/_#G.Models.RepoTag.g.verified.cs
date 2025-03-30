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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repo_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid RepoId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid CommitId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_hash", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommitHash { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tag_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string TagName { get; set; } = default!;

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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