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
        [global::System.Text.Json.Serialization.JsonPropertyName("itemsAdded")]
        public int? ItemsAdded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemsModified")]
        public int? ItemsModified { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemsDeleted")]
        public int? ItemsDeleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemsUnchanged")]
        public int? ItemsUnchanged { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetVersionDiffStats" /> class.
        /// </summary>
        /// <param name="itemsAdded"></param>
        /// <param name="itemsModified"></param>
        /// <param name="itemsDeleted"></param>
        /// <param name="itemsUnchanged"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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