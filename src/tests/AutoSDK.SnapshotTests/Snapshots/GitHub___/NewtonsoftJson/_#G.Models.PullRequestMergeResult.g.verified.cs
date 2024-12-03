//HintName: G.Models.PullRequestMergeResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Pull Request Merge Result
    /// </summary>
    public sealed partial class PullRequestMergeResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string Sha { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merged", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Merged { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestMergeResult" /> class.
        /// </summary>
        /// <param name="sha"></param>
        /// <param name="merged"></param>
        /// <param name="message"></param>
        public PullRequestMergeResult(
            string sha,
            bool merged,
            string message)
        {
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.Merged = merged;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestMergeResult" /> class.
        /// </summary>
        public PullRequestMergeResult()
        {
        }
    }
}