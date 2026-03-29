//HintName: G.Models.LseTaskSerializerForReviewersPrediction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LseTaskSerializerForReviewersPrediction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public object? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_run")]
        public object? ModelRun { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_version")]
        public string? ModelVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public int? Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::System.Collections.Generic.IList<object>? Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        public int? Task { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LseTaskSerializerForReviewersPrediction" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="model"></param>
        /// <param name="modelRun"></param>
        /// <param name="modelVersion"></param>
        /// <param name="project"></param>
        /// <param name="result"></param>
        /// <param name="score"></param>
        /// <param name="task"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LseTaskSerializerForReviewersPrediction(
            global::System.DateTime? createdAt,
            object? model,
            object? modelRun,
            string? modelVersion,
            int? project,
            global::System.Collections.Generic.IList<object>? result,
            double? score,
            int? task,
            global::System.DateTime? updatedAt)
        {
            this.CreatedAt = createdAt;
            this.Model = model;
            this.ModelRun = modelRun;
            this.ModelVersion = modelVersion;
            this.Project = project;
            this.Result = result;
            this.Score = score;
            this.Task = task;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LseTaskSerializerForReviewersPrediction" /> class.
        /// </summary>
        public LseTaskSerializerForReviewersPrediction()
        {
        }
    }
}