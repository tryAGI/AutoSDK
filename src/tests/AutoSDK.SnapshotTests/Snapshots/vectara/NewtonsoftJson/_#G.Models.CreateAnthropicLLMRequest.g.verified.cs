//HintName: G.Models.CreateAnthropicLLMRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to create an Anthropic Large Language Model connection for Claude models (direct API, Bedrock, or Vertex).
    /// </summary>
    public sealed partial class CreateAnthropicLLMRequest
    {
        /// <summary>
        /// Must be "anthropic" for Anthropic Claude models<br/>
        /// Default Value: anthropic
        /// </summary>
        /// <default>"anthropic"</default>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Name to reference the LLM. This will be used in other endpoints (like query) when using this LLM. If this name conflicts with a global LLM (a LLM that is preconfigured with the Vectara platform), then it will override that LLM for all usages.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Description of the LLM.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The Claude model name to use (e.g. claude-3-5-sonnet-20241022, claude-3-opus-20240229, etc).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Optional custom endpoint URI for the Anthropic API. Defaults to https://api.anthropic.com/v1/messages if not specified when using direct Anthropic API (header auth with x-api-key). Not required when using Bedrock or Vertex authentication as the endpoint is determined from region/project configuration.<br/>
        /// Default Value: https://api.anthropic.com/v1/messages<br/>
        /// Example: https://api.anthropic.com/v1/messages
        /// </summary>
        /// <example>https://api.anthropic.com/v1/messages</example>
        [global::Newtonsoft.Json.JsonProperty("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// Authentication configuration for Anthropic LLM via direct Anthropic API (use RemoteAuth with header "x-api-key"), AWS Bedrock, or GCP Vertex AI Model Garden
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnthropicAuth Auth { get; set; } = default!;

        /// <summary>
        /// Optional additional headers to send with the request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Any additional parameters that are required for the LLM during the test call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("test_model_parameters")]
        public object? TestModelParameters { get; set; }

        /// <summary>
        /// Capabilities of a Large Language Model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("capabilities")]
        public global::G.LLMCapabilities? Capabilities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAnthropicLLMRequest" /> class.
        /// </summary>
        /// <param name="type">
        /// Must be "anthropic" for Anthropic Claude models<br/>
        /// Default Value: anthropic
        /// </param>
        /// <param name="name">
        /// Name to reference the LLM. This will be used in other endpoints (like query) when using this LLM. If this name conflicts with a global LLM (a LLM that is preconfigured with the Vectara platform), then it will override that LLM for all usages.
        /// </param>
        /// <param name="description">
        /// Description of the LLM.
        /// </param>
        /// <param name="model">
        /// The Claude model name to use (e.g. claude-3-5-sonnet-20241022, claude-3-opus-20240229, etc).
        /// </param>
        /// <param name="uri">
        /// Optional custom endpoint URI for the Anthropic API. Defaults to https://api.anthropic.com/v1/messages if not specified when using direct Anthropic API (header auth with x-api-key). Not required when using Bedrock or Vertex authentication as the endpoint is determined from region/project configuration.<br/>
        /// Default Value: https://api.anthropic.com/v1/messages<br/>
        /// Example: https://api.anthropic.com/v1/messages
        /// </param>
        /// <param name="auth">
        /// Authentication configuration for Anthropic LLM via direct Anthropic API (use RemoteAuth with header "x-api-key"), AWS Bedrock, or GCP Vertex AI Model Garden
        /// </param>
        /// <param name="headers">
        /// Optional additional headers to send with the request
        /// </param>
        /// <param name="testModelParameters">
        /// Any additional parameters that are required for the LLM during the test call.
        /// </param>
        /// <param name="capabilities">
        /// Capabilities of a Large Language Model.
        /// </param>
        public CreateAnthropicLLMRequest(
            string type,
            string name,
            string model,
            global::G.AnthropicAuth auth,
            string? description,
            string? uri,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            object? testModelParameters,
            global::G.LLMCapabilities? capabilities)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Auth = auth;
            this.Description = description;
            this.Uri = uri;
            this.Headers = headers;
            this.TestModelParameters = testModelParameters;
            this.Capabilities = capabilities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAnthropicLLMRequest" /> class.
        /// </summary>
        public CreateAnthropicLLMRequest()
        {
        }
    }
}