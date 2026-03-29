//HintName: G.Models.DatasetItemBatch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetItemBatch
    {
        /// <summary>
        /// If null, dataset_id must be provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_name")]
        public string? DatasetName { get; set; }

        /// <summary>
        /// If null, dataset_name must be provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        public global::System.Guid? DatasetId { get; set; }

        /// <summary>
        /// Optional. Associates the batch with a project by name. Ignored if project_id is provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// Optional. Associates the batch with a project by ID. Takes precedence over project_name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.DatasetItem> Items { get; set; }

        /// <summary>
        /// Optional batch group ID to group multiple batches into a single dataset version. If null, mutates the latest version instead of creating a new one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_group_id")]
        public global::System.Guid? BatchGroupId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetItemBatch" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="datasetName">
        /// If null, dataset_id must be provided
        /// </param>
        /// <param name="datasetId">
        /// If null, dataset_name must be provided
        /// </param>
        /// <param name="projectName">
        /// Optional. Associates the batch with a project by name. Ignored if project_id is provided.
        /// </param>
        /// <param name="projectId">
        /// Optional. Associates the batch with a project by ID. Takes precedence over project_name.
        /// </param>
        /// <param name="batchGroupId">
        /// Optional batch group ID to group multiple batches into a single dataset version. If null, mutates the latest version instead of creating a new one.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetItemBatch(
            global::System.Collections.Generic.IList<global::G.DatasetItem> items,
            string? datasetName,
            global::System.Guid? datasetId,
            string? projectName,
            global::System.Guid? projectId,
            global::System.Guid? batchGroupId)
        {
            this.DatasetName = datasetName;
            this.DatasetId = datasetId;
            this.ProjectName = projectName;
            this.ProjectId = projectId;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.BatchGroupId = batchGroupId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetItemBatch" /> class.
        /// </summary>
        public DatasetItemBatch()
        {
        }
    }
}