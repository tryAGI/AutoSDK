//HintName: G.Models.PredictionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PredictionRequest
    {
        /// <summary>
        /// Cluster for the current prediction
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cluster")]
        public int? Cluster { get; set; }

        /// <summary>
        /// Related task mislabeling score
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mislabeling")]
        public double? Mislabeling { get; set; }

        /// <summary>
        /// An ML Backend instance that created the prediction.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public int? Model { get; set; }

        /// <summary>
        /// A run of a ModelVersion that created the prediction.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_run")]
        public int? ModelRun { get; set; }

        /// <summary>
        /// Model version - tag for predictions that can be used to filter tasks in Data Manager, as well as select specific model version for showing preannotations in the labeling interface
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_version")]
        public string? ModelVersion { get; set; }

        /// <summary>
        /// Array of task IDs of the closest neighbors
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("neighbors")]
        public object? Neighbors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project")]
        public int? Project { get; set; }

        /// <summary>
        /// List of prediction results for the task
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<object> Result { get; set; } = default!;

        /// <summary>
        /// Prediction score
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score")]
        public double? Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task", Required = global::Newtonsoft.Json.Required.Always)]
        public int Task { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionRequest" /> class.
        /// </summary>
        /// <param name="result">
        /// List of prediction results for the task
        /// </param>
        /// <param name="task"></param>
        /// <param name="cluster">
        /// Cluster for the current prediction
        /// </param>
        /// <param name="mislabeling">
        /// Related task mislabeling score
        /// </param>
        /// <param name="model">
        /// An ML Backend instance that created the prediction.
        /// </param>
        /// <param name="modelRun">
        /// A run of a ModelVersion that created the prediction.
        /// </param>
        /// <param name="modelVersion">
        /// Model version - tag for predictions that can be used to filter tasks in Data Manager, as well as select specific model version for showing preannotations in the labeling interface
        /// </param>
        /// <param name="neighbors">
        /// Array of task IDs of the closest neighbors
        /// </param>
        /// <param name="project"></param>
        /// <param name="score">
        /// Prediction score
        /// </param>
        public PredictionRequest(
            global::System.Collections.Generic.IList<object> result,
            int task,
            int? cluster,
            double? mislabeling,
            int? model,
            int? modelRun,
            string? modelVersion,
            object? neighbors,
            int? project,
            double? score)
        {
            this.Cluster = cluster;
            this.Mislabeling = mislabeling;
            this.Model = model;
            this.ModelRun = modelRun;
            this.ModelVersion = modelVersion;
            this.Neighbors = neighbors;
            this.Project = project;
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.Score = score;
            this.Task = task;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionRequest" /> class.
        /// </summary>
        public PredictionRequest()
        {
        }
    }
}