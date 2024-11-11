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
        [global::Newtonsoft.Json.JsonProperty("image_count")]
        public double? ImageCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("predict_time")]
        public double? PredictTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_time")]
        public double? TotalTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionResponseMetrics" /> class.
        /// </summary>
        /// <param name="imageCount"></param>
        /// <param name="predictTime"></param>
        /// <param name="totalTime"></param>
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