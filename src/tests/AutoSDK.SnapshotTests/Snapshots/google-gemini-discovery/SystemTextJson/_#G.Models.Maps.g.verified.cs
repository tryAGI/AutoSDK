//HintName: G.Models.Maps.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A grounding chunk from Google Maps. A Maps chunk corresponds to a single place.
    /// </summary>
    public sealed partial class Maps
    {
        /// <summary>
        /// URI reference of the place.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// Title of the place.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Text description of the place answer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The ID of the place, in `places/{place_id}` format. A user can use this ID to look up that place.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placeId")]
        public string? PlaceId { get; set; }

        /// <summary>
        /// Collection of sources that provide answers about the features of a given place in Google Maps. Each PlaceAnswerSources message corresponds to a specific place in Google Maps. The Google Maps tool used these sources in order to answer questions about features of the place (e.g: "does Bar Foo have Wifi" or "is Foo Bar wheelchair accessible?"). Currently we only support review snippets as sources.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placeAnswerSources")]
        public global::G.PlaceAnswerSources? PlaceAnswerSources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Maps" /> class.
        /// </summary>
        /// <param name="uri">
        /// URI reference of the place.
        /// </param>
        /// <param name="title">
        /// Title of the place.
        /// </param>
        /// <param name="text">
        /// Text description of the place answer.
        /// </param>
        /// <param name="placeId">
        /// The ID of the place, in `places/{place_id}` format. A user can use this ID to look up that place.
        /// </param>
        /// <param name="placeAnswerSources">
        /// Collection of sources that provide answers about the features of a given place in Google Maps. Each PlaceAnswerSources message corresponds to a specific place in Google Maps. The Google Maps tool used these sources in order to answer questions about features of the place (e.g: "does Bar Foo have Wifi" or "is Foo Bar wheelchair accessible?"). Currently we only support review snippets as sources.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Maps(
            string? uri,
            string? title,
            string? text,
            string? placeId,
            global::G.PlaceAnswerSources? placeAnswerSources)
        {
            this.Uri = uri;
            this.Title = title;
            this.Text = text;
            this.PlaceId = placeId;
            this.PlaceAnswerSources = placeAnswerSources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Maps" /> class.
        /// </summary>
        public Maps()
        {
        }
    }
}