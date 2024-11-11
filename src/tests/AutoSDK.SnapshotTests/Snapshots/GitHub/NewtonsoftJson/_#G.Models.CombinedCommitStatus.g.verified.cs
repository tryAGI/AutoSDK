//HintName: G.Models.CombinedCommitStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Combined Commit Status
    /// </summary>
    public sealed partial class CombinedCommitStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public string State { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("statuses", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SimpleCommitStatus> Statuses { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string Sha { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCount { get; set; } = default!;

        /// <summary>
        /// Minimal Repository
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MinimalRepository Repository { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommitUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CombinedCommitStatus" /> class.
        /// </summary>
        /// <param name="state"></param>
        /// <param name="statuses"></param>
        /// <param name="sha"></param>
        /// <param name="totalCount"></param>
        /// <param name="repository">
        /// Minimal Repository
        /// </param>
        /// <param name="commitUrl"></param>
        /// <param name="url"></param>
        public CombinedCommitStatus(
            string state,
            global::System.Collections.Generic.IList<global::G.SimpleCommitStatus> statuses,
            string sha,
            int totalCount,
            global::G.MinimalRepository repository,
            string commitUrl,
            string url)
        {
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
            this.Statuses = statuses ?? throw new global::System.ArgumentNullException(nameof(statuses));
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.TotalCount = totalCount;
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
            this.CommitUrl = commitUrl ?? throw new global::System.ArgumentNullException(nameof(commitUrl));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CombinedCommitStatus" /> class.
        /// </summary>
        public CombinedCommitStatus()
        {
        }
    }
}