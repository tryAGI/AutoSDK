//HintName: G.Models.LocationResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A local/location result.
    /// </summary>
    public sealed partial class LocationResult
    {
        /// <summary>
        /// The result type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Unique identifier for the location.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// URL of the location on the data provider.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_url")]
        public string? ProviderUrl { get; set; }

        /// <summary>
        /// Geographic coordinates [latitude, longitude].
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("coordinates")]
        public global::System.Collections.Generic.IList<double>? Coordinates { get; set; }

        /// <summary>
        /// Map zoom level for the location.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("zoom_level")]
        public int? ZoomLevel { get; set; }

        /// <summary>
        /// Thumbnail image information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thumbnail")]
        public global::G.Thumbnail? Thumbnail { get; set; }

        /// <summary>
        /// Postal address of the location.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("postal_address")]
        public global::G.LocationResultPostalAddress? PostalAddress { get; set; }

        /// <summary>
        /// Opening hours information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("opening_hours")]
        public global::G.LocationResultOpeningHours? OpeningHours { get; set; }

        /// <summary>
        /// Contact information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contact")]
        public global::G.LocationResultContact? Contact { get; set; }

        /// <summary>
        /// Price range indicator (e.g., "$$").
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("price_range")]
        public string? PriceRange { get; set; }

        /// <summary>
        /// Rating information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rating")]
        public global::G.LocationResultRating? Rating { get; set; }

        /// <summary>
        /// List of reviews.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reviews")]
        public global::System.Collections.Generic.IList<global::G.LocationResultReview>? Reviews { get; set; }

        /// <summary>
        /// Timezone of the location.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Timezone UTC offset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timezone_offset")]
        public string? TimezoneOffset { get; set; }

        /// <summary>
        /// Categories/tags for the location.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("categories")]
        public global::System.Collections.Generic.IList<string>? Categories { get; set; }

        /// <summary>
        /// Cuisine types served (for restaurants).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("serves_cuisine")]
        public global::System.Collections.Generic.IList<string>? ServesCuisine { get; set; }

        /// <summary>
        /// Name of the location.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of the location.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationResult" /> class.
        /// </summary>
        /// <param name="type">
        /// The result type.
        /// </param>
        /// <param name="id">
        /// Unique identifier for the location.
        /// </param>
        /// <param name="providerUrl">
        /// URL of the location on the data provider.
        /// </param>
        /// <param name="coordinates">
        /// Geographic coordinates [latitude, longitude].
        /// </param>
        /// <param name="zoomLevel">
        /// Map zoom level for the location.
        /// </param>
        /// <param name="thumbnail">
        /// Thumbnail image information.
        /// </param>
        /// <param name="postalAddress">
        /// Postal address of the location.
        /// </param>
        /// <param name="openingHours">
        /// Opening hours information.
        /// </param>
        /// <param name="contact">
        /// Contact information.
        /// </param>
        /// <param name="priceRange">
        /// Price range indicator (e.g., "$$").
        /// </param>
        /// <param name="rating">
        /// Rating information.
        /// </param>
        /// <param name="reviews">
        /// List of reviews.
        /// </param>
        /// <param name="timezone">
        /// Timezone of the location.
        /// </param>
        /// <param name="timezoneOffset">
        /// Timezone UTC offset.
        /// </param>
        /// <param name="categories">
        /// Categories/tags for the location.
        /// </param>
        /// <param name="servesCuisine">
        /// Cuisine types served (for restaurants).
        /// </param>
        /// <param name="name">
        /// Name of the location.
        /// </param>
        /// <param name="description">
        /// Description of the location.
        /// </param>
        public LocationResult(
            string? type,
            string? id,
            string? providerUrl,
            global::System.Collections.Generic.IList<double>? coordinates,
            int? zoomLevel,
            global::G.Thumbnail? thumbnail,
            global::G.LocationResultPostalAddress? postalAddress,
            global::G.LocationResultOpeningHours? openingHours,
            global::G.LocationResultContact? contact,
            string? priceRange,
            global::G.LocationResultRating? rating,
            global::System.Collections.Generic.IList<global::G.LocationResultReview>? reviews,
            string? timezone,
            string? timezoneOffset,
            global::System.Collections.Generic.IList<string>? categories,
            global::System.Collections.Generic.IList<string>? servesCuisine,
            string? name,
            string? description)
        {
            this.Type = type;
            this.Id = id;
            this.ProviderUrl = providerUrl;
            this.Coordinates = coordinates;
            this.ZoomLevel = zoomLevel;
            this.Thumbnail = thumbnail;
            this.PostalAddress = postalAddress;
            this.OpeningHours = openingHours;
            this.Contact = contact;
            this.PriceRange = priceRange;
            this.Rating = rating;
            this.Reviews = reviews;
            this.Timezone = timezone;
            this.TimezoneOffset = timezoneOffset;
            this.Categories = categories;
            this.ServesCuisine = servesCuisine;
            this.Name = name;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationResult" /> class.
        /// </summary>
        public LocationResult()
        {
        }
    }
}