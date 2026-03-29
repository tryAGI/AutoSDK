//HintName: G.Models.LlmConnection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// LLM API connection configuration (secrets excluded)
    /// </summary>
    public sealed partial class LlmConnection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Provider name (e.g., 'openai', 'my-gateway'). Must be unique in project, used for upserting.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        public string Provider { get; set; } = default!;

        /// <summary>
        /// The adapter used to interface with the LLM
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("adapter", Required = global::Newtonsoft.Json.Required.Always)]
        public string Adapter { get; set; } = default!;

        /// <summary>
        /// Masked version of the secret key for display purposes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("displaySecretKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string DisplaySecretKey { get; set; } = default!;

        /// <summary>
        /// Custom base URL for the LLM API
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("baseURL")]
        public string? BaseURL { get; set; }

        /// <summary>
        /// List of custom model names available for this connection
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("customModels", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> CustomModels { get; set; } = default!;

        /// <summary>
        /// Whether to include default models for this adapter
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("withDefaultModels", Required = global::Newtonsoft.Json.Required.Always)]
        public bool WithDefaultModels { get; set; } = default!;

        /// <summary>
        /// Keys of extra headers sent with requests (values excluded for security)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extraHeaderKeys", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> ExtraHeaderKeys { get; set; } = default!;

        /// <summary>
        /// Adapter-specific configuration. Required for Bedrock (`{"region":"us-east-1"}`), optional for VertexAI (`{"location":"us-central1"}`), not used by other adapters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public object? Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmConnection" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="provider">
        /// Provider name (e.g., 'openai', 'my-gateway'). Must be unique in project, used for upserting.
        /// </param>
        /// <param name="adapter">
        /// The adapter used to interface with the LLM
        /// </param>
        /// <param name="displaySecretKey">
        /// Masked version of the secret key for display purposes
        /// </param>
        /// <param name="customModels">
        /// List of custom model names available for this connection
        /// </param>
        /// <param name="withDefaultModels">
        /// Whether to include default models for this adapter
        /// </param>
        /// <param name="extraHeaderKeys">
        /// Keys of extra headers sent with requests (values excluded for security)
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="baseURL">
        /// Custom base URL for the LLM API
        /// </param>
        /// <param name="config">
        /// Adapter-specific configuration. Required for Bedrock (`{"region":"us-east-1"}`), optional for VertexAI (`{"location":"us-central1"}`), not used by other adapters.
        /// </param>
        public LlmConnection(
            string id,
            string provider,
            string adapter,
            string displaySecretKey,
            global::System.Collections.Generic.IList<string> customModels,
            bool withDefaultModels,
            global::System.Collections.Generic.IList<string> extraHeaderKeys,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? baseURL,
            object? config)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Adapter = adapter ?? throw new global::System.ArgumentNullException(nameof(adapter));
            this.DisplaySecretKey = displaySecretKey ?? throw new global::System.ArgumentNullException(nameof(displaySecretKey));
            this.BaseURL = baseURL;
            this.CustomModels = customModels ?? throw new global::System.ArgumentNullException(nameof(customModels));
            this.WithDefaultModels = withDefaultModels;
            this.ExtraHeaderKeys = extraHeaderKeys ?? throw new global::System.ArgumentNullException(nameof(extraHeaderKeys));
            this.Config = config;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmConnection" /> class.
        /// </summary>
        public LlmConnection()
        {
        }
    }
}