//HintName: G.Models.Model.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Model
    {
        /// <summary>
        /// The LLM provider (e.g. openai, anthropic, google, openai.azure, vertexai, mistral, cohere, amazon.bedrock, huggingface).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// Optional display name for the model configuration.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_config_display_name")]
        public string? ModelConfigDisplayName { get; set; }

        /// <summary>
        /// The base model name (e.g. for fine-tuned models).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_model")]
        public string? BaseModel { get; set; }

        /// <summary>
        /// The model name (e.g. gpt-4o, claude-sonnet-4-20250514).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Model parameters (e.g. temperature, max_tokens, top_p).<br/>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// Display-friendly parameter values shown in the UI.<br/>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_params")]
        public object? DisplayParams { get; set; }

        /// <summary>
        /// The API type (e.g. chat.completions, responses, images). Used to select the correct API endpoint for the provider.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_type")]
        public string? ApiType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        /// <param name="provider">
        /// The LLM provider (e.g. openai, anthropic, google, openai.azure, vertexai, mistral, cohere, amazon.bedrock, huggingface).
        /// </param>
        /// <param name="name">
        /// The model name (e.g. gpt-4o, claude-sonnet-4-20250514).
        /// </param>
        /// <param name="modelConfigDisplayName">
        /// Optional display name for the model configuration.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="baseModel">
        /// The base model name (e.g. for fine-tuned models).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="parameters">
        /// Model parameters (e.g. temperature, max_tokens, top_p).<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="displayParams">
        /// Display-friendly parameter values shown in the UI.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="apiType">
        /// The API type (e.g. chat.completions, responses, images). Used to select the correct API endpoint for the provider.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Model(
            string provider,
            string name,
            string? modelConfigDisplayName,
            string? baseModel,
            object? parameters,
            object? displayParams,
            string? apiType)
        {
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.ModelConfigDisplayName = modelConfigDisplayName;
            this.BaseModel = baseModel;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Parameters = parameters;
            this.DisplayParams = displayParams;
            this.ApiType = apiType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        public Model()
        {
        }
    }
}