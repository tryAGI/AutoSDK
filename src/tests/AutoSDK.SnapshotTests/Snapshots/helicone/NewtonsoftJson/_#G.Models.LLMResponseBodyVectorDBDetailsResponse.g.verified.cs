//HintName: G.Models.LLMResponseBodyVectorDBDetailsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LLMResponseBodyVectorDBDetailsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.LLMResponseBodyVectorDBDetailsResponseTypeJsonConverter))]
        public global::G.LLMResponseBodyVectorDBDetailsResponseType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.LLMResponseBodyVectorDBDetailsResponseMetadata Metadata { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("actualSimilarity")]
        public double? ActualSimilarity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("similarityThreshold")]
        public double? SimilarityThreshold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMResponseBodyVectorDBDetailsResponse" /> class.
        /// </summary>
        /// <param name="metadata"></param>
        /// <param name="message"></param>
        /// <param name="status"></param>
        /// <param name="type"></param>
        /// <param name="actualSimilarity"></param>
        /// <param name="similarityThreshold"></param>
        public LLMResponseBodyVectorDBDetailsResponse(
            global::G.LLMResponseBodyVectorDBDetailsResponseMetadata metadata,
            string message,
            string status,
            global::G.LLMResponseBodyVectorDBDetailsResponseType type,
            double? actualSimilarity,
            double? similarityThreshold)
        {
            this.Type = type;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.ActualSimilarity = actualSimilarity;
            this.SimilarityThreshold = similarityThreshold;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMResponseBodyVectorDBDetailsResponse" /> class.
        /// </summary>
        public LLMResponseBodyVectorDBDetailsResponse()
        {
        }
    }
}