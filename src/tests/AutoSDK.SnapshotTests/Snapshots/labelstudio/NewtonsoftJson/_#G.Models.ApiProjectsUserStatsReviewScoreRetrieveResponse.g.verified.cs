//HintName: G.Models.ApiProjectsUserStatsReviewScoreRetrieveResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiProjectsUserStatsReviewScoreRetrieveResponse
    {
        /// <summary>
        /// Performance scores mapped by annotator ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("performance_score")]
        public object? PerformanceScore { get; set; }

        /// <summary>
        /// Review scores mapped by annotator ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("review_score")]
        public object? ReviewScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsUserStatsReviewScoreRetrieveResponse" /> class.
        /// </summary>
        /// <param name="performanceScore">
        /// Performance scores mapped by annotator ID
        /// </param>
        /// <param name="reviewScore">
        /// Review scores mapped by annotator ID
        /// </param>
        public ApiProjectsUserStatsReviewScoreRetrieveResponse(
            object? performanceScore,
            object? reviewScore)
        {
            this.PerformanceScore = performanceScore;
            this.ReviewScore = reviewScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsUserStatsReviewScoreRetrieveResponse" /> class.
        /// </summary>
        public ApiProjectsUserStatsReviewScoreRetrieveResponse()
        {
        }
    }
}