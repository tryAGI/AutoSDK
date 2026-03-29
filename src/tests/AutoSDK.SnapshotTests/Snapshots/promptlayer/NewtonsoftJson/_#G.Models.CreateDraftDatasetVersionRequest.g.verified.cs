//HintName: G.Models.CreateDraftDatasetVersionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDraftDatasetVersionRequest
    {
        /// <summary>
        /// ID of the dataset group to create a draft version for
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_group_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int DatasetGroupId { get; set; } = default!;

        /// <summary>
        /// Optional. ID of an existing dataset version to copy rows from. Must belong to the same dataset group.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_dataset_id")]
        public int? SourceDatasetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDraftDatasetVersionRequest" /> class.
        /// </summary>
        /// <param name="datasetGroupId">
        /// ID of the dataset group to create a draft version for
        /// </param>
        /// <param name="sourceDatasetId">
        /// Optional. ID of an existing dataset version to copy rows from. Must belong to the same dataset group.
        /// </param>
        public CreateDraftDatasetVersionRequest(
            int datasetGroupId,
            int? sourceDatasetId)
        {
            this.DatasetGroupId = datasetGroupId;
            this.SourceDatasetId = sourceDatasetId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDraftDatasetVersionRequest" /> class.
        /// </summary>
        public CreateDraftDatasetVersionRequest()
        {
        }
    }
}