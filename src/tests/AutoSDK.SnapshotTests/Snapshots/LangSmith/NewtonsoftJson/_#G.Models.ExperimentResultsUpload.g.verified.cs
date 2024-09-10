//HintName: G.Models.ExperimentResultsUpload.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

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
        public global::G.AnyOf<string, object>? ExperimentDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_id")]
        public global::G.AnyOf<global::System.Guid?, object>? DatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_name")]
        public global::G.AnyOf<string, object>? DatasetName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_description")]
        public global::G.AnyOf<string, object>? DatasetDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary_experiment_scores")]
        public global::G.AnyOf<global::System.Collections.Generic.IList<global::G.FeedbackCreateCoreSchema>, object>? SummaryExperimentScores { get; set; }

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
        public global::G.AnyOf<global::G.ExperimentResultsUploadExperimentMetadata, object>? ExperimentMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}