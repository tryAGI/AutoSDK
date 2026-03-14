//HintName: G.Models.UpdateAnthropicLLMRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to update an Anthropic Large Language Model connection. All fields are optional.
    /// </summary>
    public sealed partial class UpdateAnthropicLLMRequest
    {
        /// <summary>
        /// Must be "anthropic" for Anthropic Claude models<br/>
        /// Default Value: anthropic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The model identifier to use for this LLM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The API endpoint for this LLM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// Description of the LLM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Authentication configuration for Anthropic LLM via direct Anthropic API (use RemoteAuth with header "x-api-key"), AWS Bedrock, or GCP Vertex AI Model Garden
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnthropicAuthJsonConverter))]
        public global::G.AnthropicAuth? Auth { get; set; }

        /// <summary>
        /// Optional additional headers to send with the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Whether the LLM is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Any additional parameters that are required for the LLM during the test call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_model_parameters")]
        public object? TestModelParameters { get; set; }

        /// <summary>
        /// Capabilities of a Large Language Model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capabilities")]
        public global::G.LLMCapabilities? Capabilities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAnthropicLLMRequest" /> class.
        /// </summary>
        /// <param name="type">
        /// Must be "anthropic" for Anthropic Claude models<br/>
        /// Default Value: anthropic
        /// </param>
        /// <param name="model">
        /// The model identifier to use for this LLM.
        /// </param>
        /// <param name="uri">
        /// The API endpoint for this LLM.
        /// </param>
        /// <param name="description">
        /// Description of the LLM.
        /// </param>
        /// <param name="auth">
        /// Authentication configuration for Anthropic LLM via direct Anthropic API (use RemoteAuth with header "x-api-key"), AWS Bedrock, or GCP Vertex AI Model Garden
        /// </param>
        /// <param name="headers">
        /// Optional additional headers to send with the request
        /// </param>
        /// <param name="enabled">
        /// Whether the LLM is enabled.
        /// </param>
        /// <param name="testModelParameters">
        /// Any additional parameters that are required for the LLM during the test call.
        /// </param>
        /// <param name="capabilities">
        /// Capabilities of a Large Language Model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAnthropicLLMRequest(
            string? type,
            string? model,
            string? uri,
            string? description,
            global::G.AnthropicAuth? auth,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            bool? enabled,
            object? testModelParameters,
            global::G.LLMCapabilities? capabilities)
        {
            this.Type = type;
            this.Model = model;
            this.Uri = uri;
            this.Description = description;
            this.Auth = auth;
            this.Headers = headers;
            this.Enabled = enabled;
            this.TestModelParameters = testModelParameters;
            this.Capabilities = capabilities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAnthropicLLMRequest" /> class.
        /// </summary>
        public UpdateAnthropicLLMRequest()
        {
        }
    }
}