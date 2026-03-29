//HintName: G.Models.LLMResponseBodyDataDetailsResponseMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LLMResponseBodyDataDetailsResponseMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public string Timestamp { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMResponseBodyDataDetailsResponseMetadata" /> class.
        /// </summary>
        /// <param name="timestamp"></param>
        public LLMResponseBodyDataDetailsResponseMetadata(
            string timestamp)
        {
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMResponseBodyDataDetailsResponseMetadata" /> class.
        /// </summary>
        public LLMResponseBodyDataDetailsResponseMetadata()
        {
        }
    }
}