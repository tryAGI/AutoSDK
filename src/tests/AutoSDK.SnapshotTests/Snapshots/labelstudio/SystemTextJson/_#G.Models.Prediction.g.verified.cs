//HintName: G.Models.Prediction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Prediction
    {
        /// <summary>
        /// Cluster for the current prediction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cluster")]
        public int? Cluster { get; set; }

        /// <summary>
        /// Delta time from creation time<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_ago")]
        public string CreatedAgo { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Related task mislabeling score
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mislabeling")]
        public double? Mislabeling { get; set; }

        /// <summary>
        /// An ML Backend instance that created the prediction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public int? Model { get; set; }

        /// <summary>
        /// A run of a ModelVersion that created the prediction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_run")]
        public int? ModelRun { get; set; }

        /// <summary>
        /// Model version - tag for predictions that can be used to filter tasks in Data Manager, as well as select specific model version for showing preannotations in the labeling interface
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_version")]
        public string? ModelVersion { get; set; }

        /// <summary>
        /// Array of task IDs of the closest neighbors
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("neighbors")]
        public object? Neighbors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public int? Project { get; set; }

        /// <summary>
        /// List of prediction results for the task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Result { get; set; }

        /// <summary>
        /// Prediction score
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Task { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Prediction" /> class.
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
        /// <param name="createdAgo">
        /// Delta time from creation time<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Prediction(
            global::System.Collections.Generic.IList<object> result,
            int task,
            int? cluster,
            double? mislabeling,
            int? model,
            int? modelRun,
            string? modelVersion,
            object? neighbors,
            int? project,
            double? score,
            string createdAgo = default!,
            global::System.DateTime createdAt = default!,
            int id = default!,
            global::System.DateTime updatedAt = default!)
        {
            this.Cluster = cluster;
            this.CreatedAgo = createdAgo;
            this.CreatedAt = createdAt;
            this.Id = id;
            this.Mislabeling = mislabeling;
            this.Model = model;
            this.ModelRun = modelRun;
            this.ModelVersion = modelVersion;
            this.Neighbors = neighbors;
            this.Project = project;
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.Score = score;
            this.Task = task;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Prediction" /> class.
        /// </summary>
        public Prediction()
        {
        }
    }
}