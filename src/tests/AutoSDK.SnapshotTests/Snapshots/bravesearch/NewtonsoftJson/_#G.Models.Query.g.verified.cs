//HintName: G.Models.Query.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information about the original search query.
    /// </summary>
    public sealed partial class Query
    {
        /// <summary>
        /// The original query string as submitted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("original")]
        public string? Original { get; set; }

        /// <summary>
        /// Whether the query has SafeSearch-filtered results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("show_strict_warning")]
        public bool? ShowStrictWarning { get; set; }

        /// <summary>
        /// The altered/corrected query, if any.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("altered")]
        public string? Altered { get; set; }

        /// <summary>
        /// Whether SafeSearch is enabled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("safesearch")]
        public bool? Safesearch { get; set; }

        /// <summary>
        /// Whether the query is navigational in nature.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_navigational")]
        public bool? IsNavigational { get; set; }

        /// <summary>
        /// Whether the query has local intent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_geolocal")]
        public bool? IsGeolocal { get; set; }

        /// <summary>
        /// Decision on local results relevance.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("local_decision")]
        public string? LocalDecision { get; set; }

        /// <summary>
        /// Index of the local location result.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("local_locations_idx")]
        public int? LocalLocationsIdx { get; set; }

        /// <summary>
        /// Whether the query is trending.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_trending")]
        public bool? IsTrending { get; set; }

        /// <summary>
        /// Whether the query is about breaking news.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_news_breaking")]
        public bool? IsNewsBreaking { get; set; }

        /// <summary>
        /// Whether the search engine wants to ask for query clarification.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ask_for_clarification")]
        public bool? AskForClarification { get; set; }

        /// <summary>
        /// Detected language of the query.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Whether spellcheck is disabled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("spellcheck_off")]
        public bool? SpellcheckOff { get; set; }

        /// <summary>
        /// Detected country of the query.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("country")]
        public string? Country { get; set; }

        /// <summary>
        /// Whether there are bad results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bad_results")]
        public bool? BadResults { get; set; }

        /// <summary>
        /// Whether a fallback query should be used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("should_fallback")]
        public bool? ShouldFallback { get; set; }

        /// <summary>
        /// Latitude for geolocation queries.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lat")]
        public string? Lat { get; set; }

        /// <summary>
        /// Longitude for geolocation queries.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("long")]
        public string? Long { get; set; }

        /// <summary>
        /// Postal code for geolocation queries.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("postal_code")]
        public string? PostalCode { get; set; }

        /// <summary>
        /// City for geolocation queries.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("city")]
        public string? City { get; set; }

        /// <summary>
        /// State for geolocation queries.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public string? State { get; set; }

        /// <summary>
        /// Country from request headers.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("header_country")]
        public string? HeaderCountry { get; set; }

        /// <summary>
        /// Whether more results are available beyond the current page.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("more_results_available")]
        public bool? MoreResultsAvailable { get; set; }

        /// <summary>
        /// Custom label for location, if specified.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_location_label")]
        public string? CustomLocationLabel { get; set; }

        /// <summary>
        /// Reddit cluster identifier, if applicable.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reddit_cluster")]
        public string? RedditCluster { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Query" /> class.
        /// </summary>
        /// <param name="original">
        /// The original query string as submitted.
        /// </param>
        /// <param name="showStrictWarning">
        /// Whether the query has SafeSearch-filtered results.
        /// </param>
        /// <param name="altered">
        /// The altered/corrected query, if any.
        /// </param>
        /// <param name="safesearch">
        /// Whether SafeSearch is enabled.
        /// </param>
        /// <param name="isNavigational">
        /// Whether the query is navigational in nature.
        /// </param>
        /// <param name="isGeolocal">
        /// Whether the query has local intent.
        /// </param>
        /// <param name="localDecision">
        /// Decision on local results relevance.
        /// </param>
        /// <param name="localLocationsIdx">
        /// Index of the local location result.
        /// </param>
        /// <param name="isTrending">
        /// Whether the query is trending.
        /// </param>
        /// <param name="isNewsBreaking">
        /// Whether the query is about breaking news.
        /// </param>
        /// <param name="askForClarification">
        /// Whether the search engine wants to ask for query clarification.
        /// </param>
        /// <param name="language">
        /// Detected language of the query.
        /// </param>
        /// <param name="spellcheckOff">
        /// Whether spellcheck is disabled.
        /// </param>
        /// <param name="country">
        /// Detected country of the query.
        /// </param>
        /// <param name="badResults">
        /// Whether there are bad results.
        /// </param>
        /// <param name="shouldFallback">
        /// Whether a fallback query should be used.
        /// </param>
        /// <param name="lat">
        /// Latitude for geolocation queries.
        /// </param>
        /// <param name="long">
        /// Longitude for geolocation queries.
        /// </param>
        /// <param name="postalCode">
        /// Postal code for geolocation queries.
        /// </param>
        /// <param name="city">
        /// City for geolocation queries.
        /// </param>
        /// <param name="state">
        /// State for geolocation queries.
        /// </param>
        /// <param name="headerCountry">
        /// Country from request headers.
        /// </param>
        /// <param name="moreResultsAvailable">
        /// Whether more results are available beyond the current page.
        /// </param>
        /// <param name="customLocationLabel">
        /// Custom label for location, if specified.
        /// </param>
        /// <param name="redditCluster">
        /// Reddit cluster identifier, if applicable.
        /// </param>
        public Query(
            string? original,
            bool? showStrictWarning,
            string? altered,
            bool? safesearch,
            bool? isNavigational,
            bool? isGeolocal,
            string? localDecision,
            int? localLocationsIdx,
            bool? isTrending,
            bool? isNewsBreaking,
            bool? askForClarification,
            string? language,
            bool? spellcheckOff,
            string? country,
            bool? badResults,
            bool? shouldFallback,
            string? lat,
            string? @long,
            string? postalCode,
            string? city,
            string? state,
            string? headerCountry,
            bool? moreResultsAvailable,
            string? customLocationLabel,
            string? redditCluster)
        {
            this.Original = original;
            this.ShowStrictWarning = showStrictWarning;
            this.Altered = altered;
            this.Safesearch = safesearch;
            this.IsNavigational = isNavigational;
            this.IsGeolocal = isGeolocal;
            this.LocalDecision = localDecision;
            this.LocalLocationsIdx = localLocationsIdx;
            this.IsTrending = isTrending;
            this.IsNewsBreaking = isNewsBreaking;
            this.AskForClarification = askForClarification;
            this.Language = language;
            this.SpellcheckOff = spellcheckOff;
            this.Country = country;
            this.BadResults = badResults;
            this.ShouldFallback = shouldFallback;
            this.Lat = lat;
            this.Long = @long;
            this.PostalCode = postalCode;
            this.City = city;
            this.State = state;
            this.HeaderCountry = headerCountry;
            this.MoreResultsAvailable = moreResultsAvailable;
            this.CustomLocationLabel = customLocationLabel;
            this.RedditCluster = redditCluster;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Query" /> class.
        /// </summary>
        public Query()
        {
        }
    }
}