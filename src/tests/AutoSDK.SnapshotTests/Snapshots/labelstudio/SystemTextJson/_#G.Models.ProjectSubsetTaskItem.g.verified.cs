//HintName: G.Models.ProjectSubsetTaskItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectSubsetTaskItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public object? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ground_truth")]
        public object? GroundTruth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prediction")]
        public object? Prediction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSubsetTaskItem" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="error"></param>
        /// <param name="groundTruth"></param>
        /// <param name="id"></param>
        /// <param name="prediction"></param>
        /// <param name="score"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectSubsetTaskItem(
            object data,
            object? error,
            object? groundTruth,
            int? id,
            object? prediction,
            double? score)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Error = error;
            this.GroundTruth = groundTruth;
            this.Id = id;
            this.Prediction = prediction;
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSubsetTaskItem" /> class.
        /// </summary>
        public ProjectSubsetTaskItem()
        {
        }
    }
}