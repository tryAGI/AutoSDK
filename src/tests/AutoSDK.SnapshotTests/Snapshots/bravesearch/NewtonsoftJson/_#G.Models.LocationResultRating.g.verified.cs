//HintName: G.Models.LocationResultRating.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Rating information.
    /// </summary>
    public sealed partial class LocationResultRating
    {
        /// <summary>
        /// Average rating value.
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
        /// Profile information for a content creator.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("profile")]
        public global::G.Profile? Profile { get; set; }

        /// <summary>
        /// Whether this rating is from TripAdvisor.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_tripadvisor")]
        public bool? IsTripadvisor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationResultRating" /> class.
        /// </summary>
        /// <param name="ratingValue">
        /// Average rating value.
        /// </param>
        /// <param name="bestRating">
        /// Maximum possible rating.
        /// </param>
        /// <param name="reviewCount">
        /// Number of reviews.
        /// </param>
        /// <param name="profile">
        /// Profile information for a content creator.
        /// </param>
        /// <param name="isTripadvisor">
        /// Whether this rating is from TripAdvisor.
        /// </param>
        public LocationResultRating(
            double? ratingValue,
            double? bestRating,
            int? reviewCount,
            global::G.Profile? profile,
            bool? isTripadvisor)
        {
            this.RatingValue = ratingValue;
            this.BestRating = bestRating;
            this.ReviewCount = reviewCount;
            this.Profile = profile;
            this.IsTripadvisor = isTripadvisor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationResultRating" /> class.
        /// </summary>
        public LocationResultRating()
        {
        }
    }
}