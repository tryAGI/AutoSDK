//HintName: G.Models.InfoboxResultRating.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InfoboxResultRating
    {
        /// <summary>
        /// Name of the rating source.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("profile_name")]
        public string? ProfileName { get; set; }

        /// <summary>
        /// The rating value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rating_value")]
        public double? RatingValue { get; set; }

        /// <summary>
        /// Maximum possible rating.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("best_rating")]
        public double? BestRating { get; set; }

        /// <summary>
        /// Number of reviews.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("review_count")]
        public int? ReviewCount { get; set; }

        /// <summary>
        /// Whether the rating is from TripAdvisor.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_tripadvisor")]
        public bool? IsTripadvisor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoboxResultRating" /> class.
        /// </summary>
        /// <param name="profileName">
        /// Name of the rating source.
        /// </param>
        /// <param name="ratingValue">
        /// The rating value.
        /// </param>
        /// <param name="bestRating">
        /// Maximum possible rating.
        /// </param>
        /// <param name="reviewCount">
        /// Number of reviews.
        /// </param>
        /// <param name="isTripadvisor">
        /// Whether the rating is from TripAdvisor.
        /// </param>
        public InfoboxResultRating(
            string? profileName,
            double? ratingValue,
            double? bestRating,
            int? reviewCount,
            bool? isTripadvisor)
        {
            this.ProfileName = profileName;
            this.RatingValue = ratingValue;
            this.BestRating = bestRating;
            this.ReviewCount = reviewCount;
            this.IsTripadvisor = isTripadvisor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoboxResultRating" /> class.
        /// </summary>
        public InfoboxResultRating()
        {
        }
    }
}