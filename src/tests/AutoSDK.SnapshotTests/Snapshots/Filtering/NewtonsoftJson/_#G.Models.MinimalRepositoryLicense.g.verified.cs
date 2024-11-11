//HintName: G.Models.MinimalRepositoryLicense.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MinimalRepositoryLicense
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key")]
        public string? Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("spdx_id")]
        public string? SpdxId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MinimalRepositoryLicense" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="name"></param>
        /// <param name="spdxId"></param>
        /// <param name="url"></param>
        /// <param name="nodeId"></param>
        public MinimalRepositoryLicense(
            string? key,
            string? name,
            string? spdxId,
            string? url,
            string? nodeId)
        {
            this.Key = key;
            this.Name = name;
            this.SpdxId = spdxId;
            this.Url = url;
            this.NodeId = nodeId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MinimalRepositoryLicense" /> class.
        /// </summary>
        public MinimalRepositoryLicense()
        {
        }
    }
}