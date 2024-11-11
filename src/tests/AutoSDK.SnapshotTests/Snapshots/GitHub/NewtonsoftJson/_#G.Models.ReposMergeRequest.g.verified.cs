//HintName: G.Models.ReposMergeRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposMergeRequest
    {
        /// <summary>
        /// The name of the base branch that the head will be merged into.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base", Required = global::Newtonsoft.Json.Required.Always)]
        public string Base { get; set; } = default!;

        /// <summary>
        /// The head to merge. This can be a branch name or a commit SHA1.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head", Required = global::Newtonsoft.Json.Required.Always)]
        public string Head { get; set; } = default!;

        /// <summary>
        /// Commit message to use for the merge commit. If omitted, a default message will be used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_message")]
        public string? CommitMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposMergeRequest" /> class.
        /// </summary>
        /// <param name="base">
        /// The name of the base branch that the head will be merged into.
        /// </param>
        /// <param name="head">
        /// The head to merge. This can be a branch name or a commit SHA1.
        /// </param>
        /// <param name="commitMessage">
        /// Commit message to use for the merge commit. If omitted, a default message will be used.
        /// </param>
        public ReposMergeRequest(
            string @base,
            string head,
            string? commitMessage)
        {
            this.Base = @base ?? throw new global::System.ArgumentNullException(nameof(@base));
            this.Head = head ?? throw new global::System.ArgumentNullException(nameof(head));
            this.CommitMessage = commitMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposMergeRequest" /> class.
        /// </summary>
        public ReposMergeRequest()
        {
        }
    }
}