//HintName: G.Models.LLMResponseBodyVectorDBDetailsResponseMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LLMResponseBodyVectorDBDetailsResponseMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public string Timestamp { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("destination_parsed")]
        public bool? DestinationParsed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("destination")]
        public string? Destination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMResponseBodyVectorDBDetailsResponseMetadata" /> class.
        /// </summary>
        /// <param name="timestamp"></param>
        /// <param name="destinationParsed"></param>
        /// <param name="destination"></param>
        public LLMResponseBodyVectorDBDetailsResponseMetadata(
            string timestamp,
            bool? destinationParsed,
            string? destination)
        {
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
            this.DestinationParsed = destinationParsed;
            this.Destination = destination;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMResponseBodyVectorDBDetailsResponseMetadata" /> class.
        /// </summary>
        public LLMResponseBodyVectorDBDetailsResponseMetadata()
        {
        }
    }
}