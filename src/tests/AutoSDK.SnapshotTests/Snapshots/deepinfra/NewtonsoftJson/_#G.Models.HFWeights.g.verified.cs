//HintName: G.Models.HFWeights.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HFWeights
    {
        /// <summary>
        /// huggingface repository i.e username/reponame
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repo", Required = global::Newtonsoft.Json.Required.Always)]
        public string Repo { get; set; } = default!;

        /// <summary>
        /// commit sha or branch name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("revision")]
        public string? Revision { get; set; }

        /// <summary>
        /// huggingface access token with read access to the repo
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HFWeights" /> class.
        /// </summary>
        /// <param name="repo">
        /// huggingface repository i.e username/reponame
        /// </param>
        /// <param name="revision">
        /// commit sha or branch name
        /// </param>
        /// <param name="token">
        /// huggingface access token with read access to the repo
        /// </param>
        public HFWeights(
            string repo,
            string? revision,
            string? token)
        {
            this.Repo = repo ?? throw new global::System.ArgumentNullException(nameof(repo));
            this.Revision = revision;
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HFWeights" /> class.
        /// </summary>
        public HFWeights()
        {
        }
    }
}