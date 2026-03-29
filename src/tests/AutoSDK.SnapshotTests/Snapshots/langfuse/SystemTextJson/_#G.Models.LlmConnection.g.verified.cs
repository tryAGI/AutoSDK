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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Provider name (e.g., 'openai', 'my-gateway'). Must be unique in project, used for upserting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// The adapter used to interface with the LLM
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adapter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Adapter { get; set; }

        /// <summary>
        /// Masked version of the secret key for display purposes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displaySecretKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplaySecretKey { get; set; }

        /// <summary>
        /// Custom base URL for the LLM API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseURL")]
        public string? BaseURL { get; set; }

        /// <summary>
        /// List of custom model names available for this connection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customModels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> CustomModels { get; set; }

        /// <summary>
        /// Whether to include default models for this adapter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("withDefaultModels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool WithDefaultModels { get; set; }

        /// <summary>
        /// Keys of extra headers sent with requests (values excluded for security)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extraHeaderKeys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ExtraHeaderKeys { get; set; }

        /// <summary>
        /// Adapter-specific configuration. Required for Bedrock (`{"region":"us-east-1"}`), optional for VertexAI (`{"location":"us-central1"}`), not used by other adapters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public object? Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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