//HintName: G.Models.PullsMergeRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PullsMergeRequest
    {
        /// <summary>
        /// Title for the automatic commit message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_title")]
        public string? CommitTitle { get; set; }

        /// <summary>
        /// Extra detail to append to automatic commit message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_message")]
        public string? CommitMessage { get; set; }

        /// <summary>
        /// SHA that pull request head must match to allow merge.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sha")]
        public string? Sha { get; set; }

        /// <summary>
        /// The merge method to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merge_method")]
        public global::G.PullsMergeRequestMergeMethod? MergeMethod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullsMergeRequest" /> class.
        /// </summary>
        /// <param name="commitTitle">
        /// Title for the automatic commit message.
        /// </param>
        /// <param name="commitMessage">
        /// Extra detail to append to automatic commit message.
        /// </param>
        /// <param name="sha">
        /// SHA that pull request head must match to allow merge.
        /// </param>
        /// <param name="mergeMethod">
        /// The merge method to use.
        /// </param>
        public PullsMergeRequest(
            string? commitTitle,
            string? commitMessage,
            string? sha,
            global::G.PullsMergeRequestMergeMethod? mergeMethod)
        {
            this.CommitTitle = commitTitle;
            this.CommitMessage = commitMessage;
            this.Sha = sha;
            this.MergeMethod = mergeMethod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullsMergeRequest" /> class.
        /// </summary>
        public PullsMergeRequest()
        {
        }
    }
}