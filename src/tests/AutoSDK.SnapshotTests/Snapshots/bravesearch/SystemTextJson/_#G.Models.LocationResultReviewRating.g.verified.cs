//HintName: G.Models.LocationResultReviewRating.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LocationResultReviewRating
    {
        /// <summary>
        /// Rating value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rating_value")]
        public double? RatingValue { get; set; }

        /// <summary>
        /// Maximum rating.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("best_rating")]
        public double? BestRating { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationResultReviewRating" /> class.
        /// </summary>
        /// <param name="ratingValue">
        /// Rating value.
        /// </param>
        /// <param name="bestRating">
        /// Maximum rating.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LocationResultReviewRating(
            double? ratingValue,
            double? bestRating)
        {
            this.RatingValue = ratingValue;
            this.BestRating = bestRating;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationResultReviewRating" /> class.
        /// </summary>
        public LocationResultReviewRating()
        {
        }
    }
}