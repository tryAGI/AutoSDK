//HintName: G.Models.RepoTagRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Fields to create a prompt tag
    /// </summary>
    public sealed partial class RepoTagRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tag_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string TagName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid CommitId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepoTagRequest" /> class.
        /// </summary>
        /// <param name="tagName"></param>
        /// <param name="commitId"></param>
        public RepoTagRequest(
            string tagName,
            global::System.Guid commitId)
        {
            this.TagName = tagName ?? throw new global::System.ArgumentNullException(nameof(tagName));
            this.CommitId = commitId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepoTagRequest" /> class.
        /// </summary>
        public RepoTagRequest()
        {
        }
    }
}