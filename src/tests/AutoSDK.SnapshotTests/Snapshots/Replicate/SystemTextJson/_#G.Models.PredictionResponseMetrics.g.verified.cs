//HintName: G.Models.PredictionResponseMetrics.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PredictionResponseMetrics
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_count")]
        public double? ImageCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predict_time")]
        public double? PredictTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_time")]
        public double? TotalTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionResponseMetrics" /> class.
        /// </summary>
        /// <param name="imageCount"></param>
        /// <param name="predictTime"></param>
        /// <param name="totalTime"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PredictionResponseMetrics(
            double? imageCount,
            double? predictTime,
            double? totalTime)
        {
            this.ImageCount = imageCount;
            this.PredictTime = predictTime;
            this.TotalTime = totalTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionResponseMetrics" /> class.
        /// </summary>
        public PredictionResponseMetrics()
        {
        }
    }
}