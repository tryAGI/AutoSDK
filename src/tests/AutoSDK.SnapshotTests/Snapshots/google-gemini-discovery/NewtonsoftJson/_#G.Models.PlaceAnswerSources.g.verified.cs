//HintName: G.Models.PlaceAnswerSources.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Collection of sources that provide answers about the features of a given place in Google Maps. Each PlaceAnswerSources message corresponds to a specific place in Google Maps. The Google Maps tool used these sources in order to answer questions about features of the place (e.g: "does Bar Foo have Wifi" or "is Foo Bar wheelchair accessible?"). Currently we only support review snippets as sources.
    /// </summary>
    public sealed partial class PlaceAnswerSources
    {
        /// <summary>
        /// Snippets of reviews that are used to generate answers about the features of a given place in Google Maps.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reviewSnippets")]
        public global::System.Collections.Generic.IList<global::G.ReviewSnippet>? ReviewSnippets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaceAnswerSources" /> class.
        /// </summary>
        /// <param name="reviewSnippets">
        /// Snippets of reviews that are used to generate answers about the features of a given place in Google Maps.
        /// </param>
        public PlaceAnswerSources(
            global::System.Collections.Generic.IList<global::G.ReviewSnippet>? reviewSnippets)
        {
            this.ReviewSnippets = reviewSnippets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaceAnswerSources" /> class.
        /// </summary>
        public PlaceAnswerSources()
        {
        }
    }
}