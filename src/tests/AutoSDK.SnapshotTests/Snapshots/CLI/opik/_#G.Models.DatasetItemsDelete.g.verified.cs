//HintName: G.Models.DatasetItemsDelete.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to delete multiple dataset items
    /// </summary>
    public sealed partial class DatasetItemsDelete
    {
        /// <summary>
        /// List of dataset item IDs to delete (max 1000). Use this to delete specific items by their IDs. Mutually exclusive with 'dataset_id' and 'filters'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ItemIds { get; set; }

        /// <summary>
        /// Dataset ID to scope the deletion. Required when using 'filters'. Mutually exclusive with 'item_ids'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        public global::System.Guid? DatasetId { get; set; }

        /// <summary>
        /// Filters to select dataset items to delete within the specified dataset. Must be used with 'dataset_id'. Mutually exclusive with 'item_ids'. Empty array means 'delete all items in the dataset'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.IList<global::G.DatasetItemFilter>? Filters { get; set; }

        /// <summary>
        /// Optional batch group ID to group multiple delete operations into a single dataset version. If null, mutates the latest version instead of creating a new one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_group_id")]
        public global::System.Guid? BatchGroupId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetItemsDelete" /> class.
        /// </summary>
        /// <param name="itemIds">
        /// List of dataset item IDs to delete (max 1000). Use this to delete specific items by their IDs. Mutually exclusive with 'dataset_id' and 'filters'.
        /// </param>
        /// <param name="datasetId">
        /// Dataset ID to scope the deletion. Required when using 'filters'. Mutually exclusive with 'item_ids'.
        /// </param>
        /// <param name="filters">
        /// Filters to select dataset items to delete within the specified dataset. Must be used with 'dataset_id'. Mutually exclusive with 'item_ids'. Empty array means 'delete all items in the dataset'.
        /// </param>
        /// <param name="batchGroupId">
        /// Optional batch group ID to group multiple delete operations into a single dataset version. If null, mutates the latest version instead of creating a new one.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetItemsDelete(
            global::System.Collections.Generic.IList<global::System.Guid>? itemIds,
            global::System.Guid? datasetId,
            global::System.Collections.Generic.IList<global::G.DatasetItemFilter>? filters,
            global::System.Guid? batchGroupId)
        {
            this.ItemIds = itemIds;
            this.DatasetId = datasetId;
            this.Filters = filters;
            this.BatchGroupId = batchGroupId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetItemsDelete" /> class.
        /// </summary>
        public DatasetItemsDelete()
        {
        }
    }
}