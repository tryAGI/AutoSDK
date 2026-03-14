//HintName: G.Models.VertexAiApiKeyAuth.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API key authentication for Vertex AI
    /// </summary>
    public sealed partial class VertexAiApiKeyAuth
    {
        /// <summary>
        /// Must be "api_key" for API key authentication<br/>
        /// Default Value: api_key
        /// </summary>
        /// <default>"api_key"</default>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// The Google Cloud API key for authentication
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApiKey { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VertexAiApiKeyAuth" /> class.
        /// </summary>
        /// <param name="type">
        /// Must be "api_key" for API key authentication<br/>
        /// Default Value: api_key
        /// </param>
        /// <param name="apiKey">
        /// The Google Cloud API key for authentication
        /// </param>
        public VertexAiApiKeyAuth(
            string type,
            string apiKey)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VertexAiApiKeyAuth" /> class.
        /// </summary>
        public VertexAiApiKeyAuth()
        {
        }
    }
}