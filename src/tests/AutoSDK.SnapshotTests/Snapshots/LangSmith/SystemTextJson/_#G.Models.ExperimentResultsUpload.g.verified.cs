//HintName: G.Models.ExperimentResultsUpload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Class for uploading the results of an already-run experiment.
    /// </summary>
    public sealed partial class ExperimentResultsUpload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExperimentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment_description")]
        public string? ExperimentDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        public global::System.Guid? DatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_name")]
        public string? DatasetName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_description")]
        public string? DatasetDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_experiment_scores")]
        public global::System.Collections.Generic.IList<global::G.FeedbackCreateCoreSchema>? SummaryExperimentScores { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ExperimentResultRow> Results { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment_start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExperimentStartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment_end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExperimentEndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment_metadata")]
        public object? ExperimentMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentResultsUpload" /> class.
        /// </summary>
        /// <param name="experimentName"></param>
        /// <param name="experimentDescription"></param>
        /// <param name="datasetId"></param>
        /// <param name="datasetName"></param>
        /// <param name="datasetDescription"></param>
        /// <param name="summaryExperimentScores"></param>
        /// <param name="results"></param>
        /// <param name="experimentStartTime"></param>
        /// <param name="experimentEndTime"></param>
        /// <param name="experimentMetadata"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ExperimentResultsUpload(
            string experimentName,
            global::System.Collections.Generic.IList<global::G.ExperimentResultRow> results,
            global::System.DateTime experimentStartTime,
            global::System.DateTime experimentEndTime,
            string? experimentDescription,
            global::System.Guid? datasetId,
            string? datasetName,
            string? datasetDescription,
            global::System.Collections.Generic.IList<global::G.FeedbackCreateCoreSchema>? summaryExperimentScores,
            object? experimentMetadata)
        {
            this.ExperimentName = experimentName ?? throw new global::System.ArgumentNullException(nameof(experimentName));
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.ExperimentStartTime = experimentStartTime;
            this.ExperimentEndTime = experimentEndTime;
            this.ExperimentDescription = experimentDescription;
            this.DatasetId = datasetId;
            this.DatasetName = datasetName;
            this.DatasetDescription = datasetDescription;
            this.SummaryExperimentScores = summaryExperimentScores;
            this.ExperimentMetadata = experimentMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentResultsUpload" /> class.
        /// </summary>
        public ExperimentResultsUpload()
        {
        }
    }
}