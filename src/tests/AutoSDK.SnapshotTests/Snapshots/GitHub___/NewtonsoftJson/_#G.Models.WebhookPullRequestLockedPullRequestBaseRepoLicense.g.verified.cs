//HintName: G.Models.WebhookPullRequestLockedPullRequestBaseRepoLicense.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPullRequestLockedPullRequestBaseRepoLicense
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
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("spdx_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SpdxId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestLockedPullRequestBaseRepoLicense" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="name"></param>
        /// <param name="nodeId"></param>
        /// <param name="spdxId"></param>
        /// <param name="url"></param>
        public WebhookPullRequestLockedPullRequestBaseRepoLicense(
            string key,
            string name,
            string nodeId,
            string spdxId,
            string? url)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.SpdxId = spdxId ?? throw new global::System.ArgumentNullException(nameof(spdxId));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestLockedPullRequestBaseRepoLicense" /> class.
        /// </summary>
        public WebhookPullRequestLockedPullRequestBaseRepoLicense()
        {
        }
    }
}