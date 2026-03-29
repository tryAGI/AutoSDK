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
        [global::System.Text.Json.Serialization.JsonPropertyName("performance_score")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>))]
        public global::G.OneOf<double?, global::System.Collections.Generic.Dictionary<string, double>>? PerformanceScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_score")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>))]
        public global::G.OneOf<double?, global::System.Collections.Generic.Dictionary<string, double>>? ReviewScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsUserStatsReviewScoreRetrieve2Response" /> class.
        /// </summary>
        /// <param name="performanceScore"></param>
        /// <param name="reviewScore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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