//HintName: G.Models.UpsertLlmConnectionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to create or update an LLM connection (upsert)
    /// </summary>
    public sealed partial class UpsertLlmConnectionRequest
    {
        /// <summary>
        /// Provider name (e.g., 'openai', 'my-gateway'). Must be unique in project, used for upserting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adapter")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LlmAdapterJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.LlmAdapter Adapter { get; set; }

        /// <summary>
        /// Secret key for the LLM API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secretKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretKey { get; set; }

        /// <summary>
        /// Custom base URL for the LLM API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseURL")]
        public string? BaseURL { get; set; }

        /// <summary>
        /// List of custom model names
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customModels")]
        public global::System.Collections.Generic.IList<string>? CustomModels { get; set; }

        /// <summary>
        /// Whether to include default models. Default is true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("withDefaultModels")]
        public bool? WithDefaultModels { get; set; }

        /// <summary>
        /// Extra headers to send with requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extraHeaders")]
        public global::System.Collections.Generic.Dictionary<string, string>? ExtraHeaders { get; set; }

        /// <summary>
        /// Adapter-specific configuration. Validation rules: - **Bedrock**: Required. Must be `{"region": "&lt;aws-region&gt;"}` (e.g., `{"region":"us-east-1"}`) - **VertexAI**: Optional. If provided, must be `{"location": "&lt;gcp-location&gt;"}` (e.g., `{"location":"us-central1"}`) - **Other adapters**: Not supported. Omit this field or set to null.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public object? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertLlmConnectionRequest" /> class.
        /// </summary>
        /// <param name="provider">
        /// Provider name (e.g., 'openai', 'my-gateway'). Must be unique in project, used for upserting.
        /// </param>
        /// <param name="adapter"></param>
        /// <param name="secretKey">
        /// Secret key for the LLM API.
        /// </param>
        /// <param name="baseURL">
        /// Custom base URL for the LLM API
        /// </param>
        /// <param name="customModels">
        /// List of custom model names
        /// </param>
        /// <param name="withDefaultModels">
        /// Whether to include default models. Default is true.
        /// </param>
        /// <param name="extraHeaders">
        /// Extra headers to send with requests
        /// </param>
        /// <param name="config">
        /// Adapter-specific configuration. Validation rules: - **Bedrock**: Required. Must be `{"region": "&lt;aws-region&gt;"}` (e.g., `{"region":"us-east-1"}`) - **VertexAI**: Optional. If provided, must be `{"location": "&lt;gcp-location&gt;"}` (e.g., `{"location":"us-central1"}`) - **Other adapters**: Not supported. Omit this field or set to null.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpsertLlmConnectionRequest(
            string provider,
            global::G.LlmAdapter adapter,
            string secretKey,
            string? baseURL,
            global::System.Collections.Generic.IList<string>? customModels,
            bool? withDefaultModels,
            global::System.Collections.Generic.Dictionary<string, string>? extraHeaders,
            object? config)
        {
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Adapter = adapter;
            this.SecretKey = secretKey ?? throw new global::System.ArgumentNullException(nameof(secretKey));
            this.BaseURL = baseURL;
            this.CustomModels = customModels;
            this.WithDefaultModels = withDefaultModels;
            this.ExtraHeaders = extraHeaders;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertLlmConnectionRequest" /> class.
        /// </summary>
        public UpsertLlmConnectionRequest()
        {
        }
    }
}