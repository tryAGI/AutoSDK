//HintName: G.Models.PullRequestHeadRepoLicense.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PullRequestHeadRepoLicense
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("spdx_id")]
        public string? SpdxId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestHeadRepoLicense" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="name"></param>
        /// <param name="nodeId"></param>
        /// <param name="url"></param>
        /// <param name="spdxId"></param>
        public PullRequestHeadRepoLicense(
            string key,
            string name,
            string nodeId,
            string? url,
            string? spdxId)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Url = url;
            this.SpdxId = spdxId;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestHeadRepoLicense" /> class.
        /// </summary>
        public PullRequestHeadRepoLicense()
        {
        }
    }
}