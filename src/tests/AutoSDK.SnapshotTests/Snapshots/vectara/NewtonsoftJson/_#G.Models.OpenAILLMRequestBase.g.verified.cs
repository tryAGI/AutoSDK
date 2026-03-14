//HintName: G.Models.OpenAILLMRequestBase.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Common fields for OpenAI-compatible and Responses API LLM requests.
    /// </summary>
    public sealed partial class OpenAILLMRequestBase
    {
        /// <summary>
        /// Name to reference the LLM. This will be used in other endpoints (like query) when using this LLM. If this name conflicts with a global LLM (a LLM that is preconfigured with the Vectara platform), then it will override that LLM for all usages.<br/>
        /// Example: Claude 3.7 Sonnet
        /// </summary>
        /// <example>Claude 3.7 Sonnet</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Description of the LLM.<br/>
        /// Example: The Anthropic Claude 3.7 Sonnet model
        /// </summary>
        /// <example>The Anthropic Claude 3.7 Sonnet model</example>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The model name to use with the API (e.g. gpt-4, claude-2, etc). This is used in the API request to the remote LLM provider.<br/>
        /// Example: claude-3-7-sonnet-20250219
        /// </summary>
        /// <example>claude-3-7-sonnet-20250219</example>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The URI endpoint for the API (can be OpenAI or any compatible API endpoint)<br/>
        /// Example: https://api.anthropic.com/v1/chat/completions
        /// </summary>
        /// <example>https://api.anthropic.com/v1/chat/completions</example>
        [global::Newtonsoft.Json.JsonProperty("uri", Required = global::Newtonsoft.Json.Required.Always)]
        public string Uri { get; set; } = default!;

        /// <summary>
        /// Authentication configuration for an LLM
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth")]
        public global::G.RemoteAuth? Auth { get; set; }

        /// <summary>
        /// Additional HTTP headers to include with requests to the LLM API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Any additional parameters that are required for the LLM during the test call.<br/>
        /// Example: {"max_tokens":512}
        /// </summary>
        /// <example>{"max_tokens":512}</example>
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
        /// Initializes a new instance of the <see cref="OpenAILLMRequestBase" /> class.
        /// </summary>
        /// <param name="name">
        /// Name to reference the LLM. This will be used in other endpoints (like query) when using this LLM. If this name conflicts with a global LLM (a LLM that is preconfigured with the Vectara platform), then it will override that LLM for all usages.<br/>
        /// Example: Claude 3.7 Sonnet
        /// </param>
        /// <param name="description">
        /// Description of the LLM.<br/>
        /// Example: The Anthropic Claude 3.7 Sonnet model
        /// </param>
        /// <param name="model">
        /// The model name to use with the API (e.g. gpt-4, claude-2, etc). This is used in the API request to the remote LLM provider.<br/>
        /// Example: claude-3-7-sonnet-20250219
        /// </param>
        /// <param name="uri">
        /// The URI endpoint for the API (can be OpenAI or any compatible API endpoint)<br/>
        /// Example: https://api.anthropic.com/v1/chat/completions
        /// </param>
        /// <param name="auth">
        /// Authentication configuration for an LLM
        /// </param>
        /// <param name="headers">
        /// Additional HTTP headers to include with requests to the LLM API.
        /// </param>
        /// <param name="testModelParameters">
        /// Any additional parameters that are required for the LLM during the test call.<br/>
        /// Example: {"max_tokens":512}
        /// </param>
        /// <param name="capabilities">
        /// Capabilities of a Large Language Model.
        /// </param>
        public OpenAILLMRequestBase(
            string name,
            string uri,
            string? description,
            string? model,
            global::G.RemoteAuth? auth,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            object? testModelParameters,
            global::G.LLMCapabilities? capabilities)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Uri = uri ?? throw new global::System.ArgumentNullException(nameof(uri));
            this.Description = description;
            this.Model = model;
            this.Auth = auth;
            this.Headers = headers;
            this.TestModelParameters = testModelParameters;
            this.Capabilities = capabilities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAILLMRequestBase" /> class.
        /// </summary>
        public OpenAILLMRequestBase()
        {
        }
    }
}