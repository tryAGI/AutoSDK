//HintName: G.Models.CustomLLM.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomLLM
    {
        /// <summary>
        /// The URL of the Chat Completions compatible endpoint
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// The model ID to be used if URL serves multiple models
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// The API key for authentication. Either a workspace secret reference {'secret_id': '...'} or an environment variable reference {'env_var_label': '...'}.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_key")]
        public global::G.ConvAISecretLocator? ApiKey { get; set; }

        /// <summary>
        /// Headers that should be included in the request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_headers")]
        public object? RequestHeaders { get; set; }

        /// <summary>
        /// The API version to use for the request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_version")]
        public string? ApiVersion { get; set; }

        /// <summary>
        /// The API type to use (chat_completions or responses)<br/>
        /// Default Value: chat_completions
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CustomLLMAPITypeJsonConverter))]
        public global::G.CustomLLMAPIType? ApiType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomLLM" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL of the Chat Completions compatible endpoint
        /// </param>
        /// <param name="modelId">
        /// The model ID to be used if URL serves multiple models
        /// </param>
        /// <param name="apiKey">
        /// The API key for authentication. Either a workspace secret reference {'secret_id': '...'} or an environment variable reference {'env_var_label': '...'}.
        /// </param>
        /// <param name="requestHeaders">
        /// Headers that should be included in the request
        /// </param>
        /// <param name="apiVersion">
        /// The API version to use for the request
        /// </param>
        /// <param name="apiType">
        /// The API type to use (chat_completions or responses)<br/>
        /// Default Value: chat_completions
        /// </param>
        public CustomLLM(
            string url,
            string? modelId,
            global::G.ConvAISecretLocator? apiKey,
            object? requestHeaders,
            string? apiVersion,
            global::G.CustomLLMAPIType? apiType)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ModelId = modelId;
            this.ApiKey = apiKey;
            this.RequestHeaders = requestHeaders;
            this.ApiVersion = apiVersion;
            this.ApiType = apiType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomLLM" /> class.
        /// </summary>
        public CustomLLM()
        {
        }
    }
}