//HintName: G.Models.NamespaceMetadataIndexIndexUpdating.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NamespaceMetadataIndexIndexUpdating
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"updating"</default>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; } = "updating";

        /// <summary>
        /// The number of bytes in the namespace that are in the write-ahead log but have not yet been indexed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unindexed_bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public long UnindexedBytes { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceMetadataIndexIndexUpdating" /> class.
        /// </summary>
        /// <param name="unindexedBytes">
        /// The number of bytes in the namespace that are in the write-ahead log but have not yet been indexed.
        /// </param>
        /// <param name="status"></param>
        public NamespaceMetadataIndexIndexUpdating(
            long unindexedBytes,
            string status = "updating")
        {
            this.Status = status;
            this.UnindexedBytes = unindexedBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceMetadataIndexIndexUpdating" /> class.
        /// </summary>
        public NamespaceMetadataIndexIndexUpdating()
        {
        }
    }
}