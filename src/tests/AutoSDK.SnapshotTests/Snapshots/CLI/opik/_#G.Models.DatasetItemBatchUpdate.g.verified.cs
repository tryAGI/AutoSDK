//HintName: G.Models.DatasetItemBatchUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to batch update multiple dataset items
    /// </summary>
    public sealed partial class DatasetItemBatchUpdate
    {
        /// <summary>
        /// List of dataset item IDs to update (max 1000). Mutually exclusive with 'filters'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? Ids { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.IList<global::G.DatasetItemFilter>? Filters { get; set; }

        /// <summary>
        /// Dataset ID. Required when using 'filters', optional when using 'ids'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        public global::System.Guid? DatasetId { get; set; }

        /// <summary>
        /// Dataset item update request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("update")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DatasetItemUpdate Update { get; set; }

        /// <summary>
        /// If true, merge tags with existing tags instead of replacing them. Default: false. When using 'filters', this is automatically set to true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_tags")]
        public bool? MergeTags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetItemBatchUpdate" /> class.
        /// </summary>
        /// <param name="update">
        /// Dataset item update request
        /// </param>
        /// <param name="ids">
        /// List of dataset item IDs to update (max 1000). Mutually exclusive with 'filters'.
        /// </param>
        /// <param name="filters"></param>
        /// <param name="datasetId">
        /// Dataset ID. Required when using 'filters', optional when using 'ids'.
        /// </param>
        /// <param name="mergeTags">
        /// If true, merge tags with existing tags instead of replacing them. Default: false. When using 'filters', this is automatically set to true.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetItemBatchUpdate(
            global::G.DatasetItemUpdate update,
            global::System.Collections.Generic.IList<global::System.Guid>? ids,
            global::System.Collections.Generic.IList<global::G.DatasetItemFilter>? filters,
            global::System.Guid? datasetId,
            bool? mergeTags)
        {
            this.Ids = ids;
            this.Filters = filters;
            this.DatasetId = datasetId;
            this.Update = update ?? throw new global::System.ArgumentNullException(nameof(update));
            this.MergeTags = mergeTags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetItemBatchUpdate" /> class.
        /// </summary>
        public DatasetItemBatchUpdate()
        {
        }
    }
}