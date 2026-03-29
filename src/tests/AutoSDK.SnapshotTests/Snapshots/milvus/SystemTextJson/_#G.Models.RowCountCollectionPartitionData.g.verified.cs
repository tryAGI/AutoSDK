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
        [global::System.Text.Json.Serialization.JsonPropertyName("rowCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RowCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RowCountCollectionPartitionData" /> class.
        /// </summary>
        /// <param name="rowCount">
        /// The number of entities.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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