//HintName: G.Models.TableStatsRow.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TableStatsRow
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Digest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage_size_bytes")]
        public long? StorageSizeBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableStatsRow" /> class.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="digest"></param>
        /// <param name="storageSizeBytes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableStatsRow(
            int count,
            string digest,
            long? storageSizeBytes)
        {
            this.Count = count;
            this.Digest = digest ?? throw new global::System.ArgumentNullException(nameof(digest));
            this.StorageSizeBytes = storageSizeBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableStatsRow" /> class.
        /// </summary>
        public TableStatsRow()
        {
        }
    }
}