//HintName: G.Models.RepoUpdateTagRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Fields to update a prompt tag
    /// </summary>
    public sealed partial class RepoUpdateTagRequest
    {
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
        /// Initializes a new instance of the <see cref="RepoUpdateTagRequest" /> class.
        /// </summary>
        /// <param name="commitId"></param>
        public RepoUpdateTagRequest(
            global::System.Guid commitId)
        {
            this.CommitId = commitId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepoUpdateTagRequest" /> class.
        /// </summary>
        public RepoUpdateTagRequest()
        {
        }
    }
}