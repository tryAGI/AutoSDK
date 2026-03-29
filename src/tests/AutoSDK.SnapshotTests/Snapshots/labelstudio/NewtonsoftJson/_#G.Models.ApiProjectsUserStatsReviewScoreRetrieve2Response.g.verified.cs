//HintName: G.Models.ApiProjectsUserStatsReviewScoreRetrieve2Response.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiProjectsUserStatsReviewScoreRetrieve2Response
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("performance_score")]
        public global::G.OneOf<double?, global::System.Collections.Generic.Dictionary<string, double>>? PerformanceScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("review_score")]
        public global::G.OneOf<double?, global::System.Collections.Generic.Dictionary<string, double>>? ReviewScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsUserStatsReviewScoreRetrieve2Response" /> class.
        /// </summary>
        /// <param name="performanceScore"></param>
        /// <param name="reviewScore"></param>
        public ApiProjectsUserStatsReviewScoreRetrieve2Response(
            global::G.OneOf<double?, global::System.Collections.Generic.Dictionary<string, double>>? performanceScore,
            global::G.OneOf<double?, global::System.Collections.Generic.Dictionary<string, double>>? reviewScore)
        {
            this.PerformanceScore = performanceScore;
            this.ReviewScore = reviewScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsUserStatsReviewScoreRetrieve2Response" /> class.
        /// </summary>
        public ApiProjectsUserStatsReviewScoreRetrieve2Response()
        {
        }
    }
}