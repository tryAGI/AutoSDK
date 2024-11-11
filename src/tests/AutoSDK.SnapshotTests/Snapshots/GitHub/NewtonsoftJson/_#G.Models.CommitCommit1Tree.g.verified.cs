//HintName: G.Models.CommitCommit1Tree.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CommitCommit1Tree
    {
        /// <summary>
        /// Example: 827efc6d56897b048c772eb4087f854f46256132
        /// </summary>
        /// <example>827efc6d56897b048c772eb4087f854f46256132</example>
        [global::Newtonsoft.Json.JsonProperty("sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string Sha { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/tree/827efc6d56897b048c772eb4087f854f46256132
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/tree/827efc6d56897b048c772eb4087f854f46256132</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitCommit1Tree" /> class.
        /// </summary>
        /// <param name="sha">
        /// Example: 827efc6d56897b048c772eb4087f854f46256132
        /// </param>
        /// <param name="url">
        /// Example: https://api.github.com/repos/octocat/Hello-World/tree/827efc6d56897b048c772eb4087f854f46256132
        /// </param>
        public CommitCommit1Tree(
            string sha,
            string url)
        {
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitCommit1Tree" /> class.
        /// </summary>
        public CommitCommit1Tree()
        {
        }
    }
}