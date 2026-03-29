//HintName: G.Models.GroundingMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metadata returned to client when grounding is enabled.
    /// </summary>
    public sealed partial class GroundingMetadata
    {
        /// <summary>
        /// Google search entry point.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("searchEntryPoint")]
        public global::G.SearchEntryPoint? SearchEntryPoint { get; set; }

        /// <summary>
        /// List of supporting references retrieved from specified grounding source. When streaming, this only contains the grounding chunks that have not been included in the grounding metadata of previous responses.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("groundingChunks")]
        public global::System.Collections.Generic.IList<global::G.GroundingChunk>? GroundingChunks { get; set; }

        /// <summary>
        /// List of grounding support.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("groundingSupports")]
        public global::System.Collections.Generic.IList<global::G.GoogleAiGenerativelanguageV1betaGroundingSupport>? GroundingSupports { get; set; }

        /// <summary>
        /// Metadata related to retrieval in the grounding flow.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retrievalMetadata")]
        public global::G.RetrievalMetadata? RetrievalMetadata { get; set; }

        /// <summary>
        /// Web search queries for the following-up web search.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webSearchQueries")]
        public global::System.Collections.Generic.IList<string>? WebSearchQueries { get; set; }

        /// <summary>
        /// Image search queries used for grounding.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("imageSearchQueries")]
        public global::System.Collections.Generic.IList<string>? ImageSearchQueries { get; set; }

        /// <summary>
        /// Optional. Resource name of the Google Maps widget context token that can be used with the PlacesContextElement widget in order to render contextual data. Only populated in the case that grounding with Google Maps is enabled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("googleMapsWidgetContextToken")]
        public string? GoogleMapsWidgetContextToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundingMetadata" /> class.
        /// </summary>
        /// <param name="searchEntryPoint">
        /// Google search entry point.
        /// </param>
        /// <param name="groundingChunks">
        /// List of supporting references retrieved from specified grounding source. When streaming, this only contains the grounding chunks that have not been included in the grounding metadata of previous responses.
        /// </param>
        /// <param name="groundingSupports">
        /// List of grounding support.
        /// </param>
        /// <param name="retrievalMetadata">
        /// Metadata related to retrieval in the grounding flow.
        /// </param>
        /// <param name="webSearchQueries">
        /// Web search queries for the following-up web search.
        /// </param>
        /// <param name="imageSearchQueries">
        /// Image search queries used for grounding.
        /// </param>
        /// <param name="googleMapsWidgetContextToken">
        /// Optional. Resource name of the Google Maps widget context token that can be used with the PlacesContextElement widget in order to render contextual data. Only populated in the case that grounding with Google Maps is enabled.
        /// </param>
        public GroundingMetadata(
            global::G.SearchEntryPoint? searchEntryPoint,
            global::System.Collections.Generic.IList<global::G.GroundingChunk>? groundingChunks,
            global::System.Collections.Generic.IList<global::G.GoogleAiGenerativelanguageV1betaGroundingSupport>? groundingSupports,
            global::G.RetrievalMetadata? retrievalMetadata,
            global::System.Collections.Generic.IList<string>? webSearchQueries,
            global::System.Collections.Generic.IList<string>? imageSearchQueries,
            string? googleMapsWidgetContextToken)
        {
            this.SearchEntryPoint = searchEntryPoint;
            this.GroundingChunks = groundingChunks;
            this.GroundingSupports = groundingSupports;
            this.RetrievalMetadata = retrievalMetadata;
            this.WebSearchQueries = webSearchQueries;
            this.ImageSearchQueries = imageSearchQueries;
            this.GoogleMapsWidgetContextToken = googleMapsWidgetContextToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroundingMetadata" /> class.
        /// </summary>
        public GroundingMetadata()
        {
        }
    }
}