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
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = "updating";

        /// <summary>
        /// The number of bytes in the namespace that are in the write-ahead log but have not yet been indexed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unindexed_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long UnindexedBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceMetadataIndexIndexUpdating" /> class.
        /// </summary>
        /// <param name="unindexedBytes">
        /// The number of bytes in the namespace that are in the write-ahead log but have not yet been indexed.
        /// </param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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