//HintName: G.Models.ReviewResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReviewResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("review_status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ReviewResponseModelReviewStatusJsonConverter))]
        public global::G.ReviewResponseModelReviewStatus ReviewStatus { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reviewed_at_unix", Required = global::Newtonsoft.Json.Required.Always)]
        public int ReviewedAtUnix { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reviewed_by")]
        public string? ReviewedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reject_reasons")]
        public global::System.Collections.Generic.IList<global::G.ReviewResponseModelRejectReasonsVariant1Item>? RejectReasons { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scores_breakdown")]
        public global::System.Collections.Generic.Dictionary<string, int>? ScoresBreakdown { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rejected_details")]
        public string? RejectedDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewResponseModel" /> class.
        /// </summary>
        /// <param name="reviewStatus"></param>
        /// <param name="reviewedAtUnix"></param>
        /// <param name="reviewedBy"></param>
        /// <param name="rejectReasons"></param>
        /// <param name="scoresBreakdown"></param>
        /// <param name="rejectedDetails"></param>
        public ReviewResponseModel(
            global::G.ReviewResponseModelReviewStatus reviewStatus,
            int reviewedAtUnix,
            string? reviewedBy,
            global::System.Collections.Generic.IList<global::G.ReviewResponseModelRejectReasonsVariant1Item>? rejectReasons,
            global::System.Collections.Generic.Dictionary<string, int>? scoresBreakdown,
            string? rejectedDetails)
        {
            this.ReviewStatus = reviewStatus;
            this.ReviewedAtUnix = reviewedAtUnix;
            this.ReviewedBy = reviewedBy;
            this.RejectReasons = rejectReasons;
            this.ScoresBreakdown = scoresBreakdown;
            this.RejectedDetails = rejectedDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewResponseModel" /> class.
        /// </summary>
        public ReviewResponseModel()
        {
        }
    }
}