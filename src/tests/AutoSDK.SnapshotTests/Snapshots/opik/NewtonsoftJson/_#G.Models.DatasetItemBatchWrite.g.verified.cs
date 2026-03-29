//HintName: G.Models.DatasetItemBatchWrite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetItemBatchWrite
    {
        /// <summary>
        /// If null, dataset_id must be provided
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_name")]
        public string? DatasetName { get; set; }

        /// <summary>
        /// If null, dataset_name must be provided
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_id")]
        public global::System.Guid? DatasetId { get; set; }

        /// <summary>
        /// Optional. Associates the batch with a project by name. Ignored if project_id is provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// Optional. Associates the batch with a project by ID. Takes precedence over project_name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("items", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.DatasetItemWrite> Items { get; set; } = default!;

        /// <summary>
        /// Optional batch group ID to group multiple batches into a single dataset version. If null, mutates the latest version instead of creating a new one.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch_group_id")]
        public global::System.Guid? BatchGroupId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetItemBatchWrite" /> class.
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
        public DatasetItemBatchWrite(
            global::System.Collections.Generic.IList<global::G.DatasetItemWrite> items,
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
        /// Initializes a new instance of the <see cref="DatasetItemBatchWrite" /> class.
        /// </summary>
        public DatasetItemBatchWrite()
        {
        }
    }
}