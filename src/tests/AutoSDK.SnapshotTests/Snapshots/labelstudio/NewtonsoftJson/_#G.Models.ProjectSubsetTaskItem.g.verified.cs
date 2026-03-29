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
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public object Data { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public object? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ground_truth")]
        public object? GroundTruth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prediction")]
        public object? Prediction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score")]
        public double? Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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