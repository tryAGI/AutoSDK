//HintName: G.Models.UrlMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Context of the a single url retrieval.
    /// </summary>
    public sealed partial class UrlMetadata
    {
        /// <summary>
        /// Retrieved url by the tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retrievedUrl")]
        public string? RetrievedUrl { get; set; }

        /// <summary>
        /// Status of the url retrieval.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("urlRetrievalStatus")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.UrlMetadataUrlRetrievalStatusJsonConverter))]
        public global::G.UrlMetadataUrlRetrievalStatus? UrlRetrievalStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UrlMetadata" /> class.
        /// </summary>
        /// <param name="retrievedUrl">
        /// Retrieved url by the tool.
        /// </param>
        /// <param name="urlRetrievalStatus">
        /// Status of the url retrieval.
        /// </param>
        public UrlMetadata(
            string? retrievedUrl,
            global::G.UrlMetadataUrlRetrievalStatus? urlRetrievalStatus)
        {
            this.RetrievedUrl = retrievedUrl;
            this.UrlRetrievalStatus = urlRetrievalStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UrlMetadata" /> class.
        /// </summary>
        public UrlMetadata()
        {
        }
    }
}