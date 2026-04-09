//HintName: G.Models.LLMResponseBodyDataDetailsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LLMResponseBodyDataDetailsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.LLMResponseBodyDataDetailsResponseTypeJsonConverter))]
        public global::G.LLMResponseBodyDataDetailsResponseType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.LLMResponseBodyDataDetailsResponseMetadata Metadata { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="LLMResponseBodyDataDetailsResponse" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="metadata"></param>
        /// <param name="message"></param>
        /// <param name="status"></param>
        /// <param name="type"></param>
        public LLMResponseBodyDataDetailsResponse(
            string name,
            global::G.LLMResponseBodyDataDetailsResponseMetadata metadata,
            string message,
            string status,
            global::G.LLMResponseBodyDataDetailsResponseType type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMResponseBodyDataDetailsResponse" /> class.
        /// </summary>
        public LLMResponseBodyDataDetailsResponse()
        {
        }
    }
}