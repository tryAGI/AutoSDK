//HintName: G.Models.DatasetVersionDiffStats.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetVersionDiffStats
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("itemsAdded")]
        public int? ItemsAdded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("itemsModified")]
        public int? ItemsModified { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("itemsDeleted")]
        public int? ItemsDeleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("itemsUnchanged")]
        public int? ItemsUnchanged { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetVersionDiffStats" /> class.
        /// </summary>
        /// <param name="itemsAdded"></param>
        /// <param name="itemsModified"></param>
        /// <param name="itemsDeleted"></param>
        /// <param name="itemsUnchanged"></param>
        public DatasetVersionDiffStats(
            int? itemsAdded,
            int? itemsModified,
            int? itemsDeleted,
            int? itemsUnchanged)
        {
            this.ItemsAdded = itemsAdded;
            this.ItemsModified = itemsModified;
            this.ItemsDeleted = itemsDeleted;
            this.ItemsUnchanged = itemsUnchanged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetVersionDiffStats" /> class.
        /// </summary>
        public DatasetVersionDiffStats()
        {
        }
    }
}