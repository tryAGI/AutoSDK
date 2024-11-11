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
        [global::Newtonsoft.Json.JsonProperty("experiment_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExperimentName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experiment_description")]
        public string? ExperimentDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_id")]
        public global::System.Guid? DatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_name")]
        public string? DatasetName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_description")]
        public string? DatasetDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary_experiment_scores")]
        public global::System.Collections.Generic.IList<global::G.FeedbackCreateCoreSchema>? SummaryExperimentScores { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ExperimentResultRow> Results { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experiment_start_time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime ExperimentStartTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experiment_end_time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime ExperimentEndTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experiment_metadata")]
        public object? ExperimentMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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