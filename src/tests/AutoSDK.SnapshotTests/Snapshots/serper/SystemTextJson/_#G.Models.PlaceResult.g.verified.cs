//HintName: G.Models.PlaceResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A single places/maps search result.
    /// </summary>
    public sealed partial class PlaceResult
    {
        /// <summary>
        /// Name of the place.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Address of the place.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address")]
        public string? Address { get; set; }

        /// <summary>
        /// Latitude coordinate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latitude")]
        public double? Latitude { get; set; }

        /// <summary>
        /// Longitude coordinate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("longitude")]
        public double? Longitude { get; set; }

        /// <summary>
        /// Average rating (out of 5).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rating")]
        public double? Rating { get; set; }

        /// <summary>
        /// Number of ratings/reviews.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratingCount")]
        public int? RatingCount { get; set; }

        /// <summary>
        /// Google CID (customer ID) for the place.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cid")]
        public string? Cid { get; set; }

        /// <summary>
        /// Category of the place.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        public string? Category { get; set; }

        /// <summary>
        /// Phone number of the place.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phoneNumber")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Website URL of the place.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website")]
        public string? Website { get; set; }

        /// <summary>
        /// Position of the result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public int? Position { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaceResult" /> class.
        /// </summary>
        /// <param name="title">
        /// Name of the place.
        /// </param>
        /// <param name="address">
        /// Address of the place.
        /// </param>
        /// <param name="latitude">
        /// Latitude coordinate.
        /// </param>
        /// <param name="longitude">
        /// Longitude coordinate.
        /// </param>
        /// <param name="rating">
        /// Average rating (out of 5).
        /// </param>
        /// <param name="ratingCount">
        /// Number of ratings/reviews.
        /// </param>
        /// <param name="cid">
        /// Google CID (customer ID) for the place.
        /// </param>
        /// <param name="category">
        /// Category of the place.
        /// </param>
        /// <param name="phoneNumber">
        /// Phone number of the place.
        /// </param>
        /// <param name="website">
        /// Website URL of the place.
        /// </param>
        /// <param name="position">
        /// Position of the result.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlaceResult(
            string? title,
            string? address,
            double? latitude,
            double? longitude,
            double? rating,
            int? ratingCount,
            string? cid,
            string? category,
            string? phoneNumber,
            string? website,
            int? position)
        {
            this.Title = title;
            this.Address = address;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Rating = rating;
            this.RatingCount = ratingCount;
            this.Cid = cid;
            this.Category = category;
            this.PhoneNumber = phoneNumber;
            this.Website = website;
            this.Position = position;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaceResult" /> class.
        /// </summary>
        public PlaceResult()
        {
        }
    }
}