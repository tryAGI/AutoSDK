//HintName: G.Models.RunReportRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunReportRequest
    {
        /// <summary>
        /// The name of the final report to be created. Must be between 1 and 255 characters in length.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The ID of the dataset to use for the report. If not provided, uses the evaluation pipeline's default dataset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_id")]
        public int? DatasetId { get; set; }

        /// <summary>
        /// Whether to refresh the dataset before running the report. Only applicable for dynamic datasets.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("refresh_dataset")]
        public bool? RefreshDataset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunReportRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the final report to be created. Must be between 1 and 255 characters in length.
        /// </param>
        /// <param name="datasetId">
        /// The ID of the dataset to use for the report. If not provided, uses the evaluation pipeline's default dataset.
        /// </param>
        /// <param name="refreshDataset">
        /// Whether to refresh the dataset before running the report. Only applicable for dynamic datasets.
        /// </param>
        public RunReportRequest(
            string name,
            int? datasetId,
            bool? refreshDataset)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DatasetId = datasetId;
            this.RefreshDataset = refreshDataset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunReportRequest" /> class.
        /// </summary>
        public RunReportRequest()
        {
        }
    }
}