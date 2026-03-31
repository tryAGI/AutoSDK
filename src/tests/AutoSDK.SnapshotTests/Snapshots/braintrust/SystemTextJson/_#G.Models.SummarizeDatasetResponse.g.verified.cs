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
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectName { get; set; }

        /// <summary>
        /// Name of the dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetName { get; set; }

        /// <summary>
        /// URL to the project's page in the Braintrust app
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectUrl { get; set; }

        /// <summary>
        /// URL to the dataset's page in the Braintrust app
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetUrl { get; set; }

        /// <summary>
        /// Summary of a dataset's data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_summary")]
        public global::G.DataSummary? DataSummary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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