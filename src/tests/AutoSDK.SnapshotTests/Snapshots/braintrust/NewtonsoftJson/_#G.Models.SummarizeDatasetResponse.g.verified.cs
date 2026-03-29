//HintName: G.Models.SummarizeDatasetResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Summary of a dataset
    /// </summary>
    public sealed partial class SummarizeDatasetResponse
    {
        /// <summary>
        /// Name of the project that the dataset belongs to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectName { get; set; } = default!;

        /// <summary>
        /// Name of the dataset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string DatasetName { get; set; } = default!;

        /// <summary>
        /// URL to the project's page in the Braintrust app
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectUrl { get; set; } = default!;

        /// <summary>
        /// URL to the dataset's page in the Braintrust app
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string DatasetUrl { get; set; } = default!;

        /// <summary>
        /// Summary of a dataset's data
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_summary")]
        public global::G.DataSummary? DataSummary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizeDatasetResponse" /> class.
        /// </summary>
        /// <param name="projectName">
        /// Name of the project that the dataset belongs to
        /// </param>
        /// <param name="datasetName">
        /// Name of the dataset
        /// </param>
        /// <param name="projectUrl">
        /// URL to the project's page in the Braintrust app
        /// </param>
        /// <param name="datasetUrl">
        /// URL to the dataset's page in the Braintrust app
        /// </param>
        /// <param name="dataSummary">
        /// Summary of a dataset's data
        /// </param>
        public SummarizeDatasetResponse(
            string projectName,
            string datasetName,
            string projectUrl,
            string datasetUrl,
            global::G.DataSummary? dataSummary)
        {
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
            this.DatasetName = datasetName ?? throw new global::System.ArgumentNullException(nameof(datasetName));
            this.ProjectUrl = projectUrl ?? throw new global::System.ArgumentNullException(nameof(projectUrl));
            this.DatasetUrl = datasetUrl ?? throw new global::System.ArgumentNullException(nameof(datasetUrl));
            this.DataSummary = dataSummary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizeDatasetResponse" /> class.
        /// </summary>
        public SummarizeDatasetResponse()
        {
        }
    }
}