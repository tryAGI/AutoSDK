//HintName: G.Models.RowCountCollectionPartitionData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RowCountCollectionPartitionData
    {
        /// <summary>
        /// The number of entities.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rowCount", Required = global::Newtonsoft.Json.Required.Always)]
        public int RowCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RowCountCollectionPartitionData" /> class.
        /// </summary>
        /// <param name="rowCount">
        /// The number of entities.
        /// </param>
        public RowCountCollectionPartitionData(
            int rowCount)
        {
            this.RowCount = rowCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RowCountCollectionPartitionData" /> class.
        /// </summary>
        public RowCountCollectionPartitionData()
        {
        }
    }
}