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
        [global::Newtonsoft.Json.JsonProperty("count", Required = global::Newtonsoft.Json.Required.Always)]
        public int Count { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("digest", Required = global::Newtonsoft.Json.Required.Always)]
        public string Digest { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("storage_size_bytes")]
        public long? StorageSizeBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableStatsRow" /> class.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="digest"></param>
        /// <param name="storageSizeBytes"></param>
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