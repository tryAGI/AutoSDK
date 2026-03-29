//HintName: G.Models.ExperimentItemBulkUploadExperimentItemBulkWriteView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentItemBulkUploadExperimentItemBulkWriteView
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experiment_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExperimentName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string DatasetName { get; set; } = default!;

        /// <summary>
        /// Optional experiment ID. If provided, items will be added to the existing experiment and experimentName will be ignored. If not provided or experiment with that ID doesn't exist, a new experiment will be created with the given experimentName
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experiment_id")]
        public global::System.Guid? ExperimentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("items", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ExperimentItemBulkRecordExperimentItemBulkWriteView> Items { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentItemBulkUploadExperimentItemBulkWriteView" /> class.
        /// </summary>
        /// <param name="experimentName"></param>
        /// <param name="datasetName"></param>
        /// <param name="items"></param>
        /// <param name="experimentId">
        /// Optional experiment ID. If provided, items will be added to the existing experiment and experimentName will be ignored. If not provided or experiment with that ID doesn't exist, a new experiment will be created with the given experimentName
        /// </param>
        public ExperimentItemBulkUploadExperimentItemBulkWriteView(
            string experimentName,
            string datasetName,
            global::System.Collections.Generic.IList<global::G.ExperimentItemBulkRecordExperimentItemBulkWriteView> items,
            global::System.Guid? experimentId)
        {
            this.ExperimentName = experimentName ?? throw new global::System.ArgumentNullException(nameof(experimentName));
            this.DatasetName = datasetName ?? throw new global::System.ArgumentNullException(nameof(datasetName));
            this.ExperimentId = experimentId;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentItemBulkUploadExperimentItemBulkWriteView" /> class.
        /// </summary>
        public ExperimentItemBulkUploadExperimentItemBulkWriteView()
        {
        }
    }
}