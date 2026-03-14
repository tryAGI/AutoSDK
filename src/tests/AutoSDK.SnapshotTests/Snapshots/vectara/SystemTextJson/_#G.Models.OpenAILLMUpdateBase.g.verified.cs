//HintName: G.Models.OpenAILLMUpdateBase.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Common updatable fields for OpenAI-compatible and Responses API LLM requests.
    /// </summary>
    public sealed partial class OpenAILLMUpdateBase
    {
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
        /// Authentication configuration for an LLM
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RemoteAuthJsonConverter))]
        public global::G.RemoteAuth? Auth { get; set; }

        /// <summary>
        /// Additional HTTP headers to include with requests to the LLM API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Whether the LLM is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Any additional parameters that are required for the LLM during the test call.<br/>
        /// Example: {"max_tokens":512}
        /// </summary>
        /// <example>{"max_tokens":512}</example>
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
        /// Initializes a new instance of the <see cref="OpenAILLMUpdateBase" /> class.
        /// </summary>
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
        /// Authentication configuration for an LLM
        /// </param>
        /// <param name="headers">
        /// Additional HTTP headers to include with requests to the LLM API.
        /// </param>
        /// <param name="enabled">
        /// Whether the LLM is enabled.
        /// </param>
        /// <param name="testModelParameters">
        /// Any additional parameters that are required for the LLM during the test call.<br/>
        /// Example: {"max_tokens":512}
        /// </param>
        /// <param name="capabilities">
        /// Capabilities of a Large Language Model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAILLMUpdateBase(
            string? model,
            string? uri,
            string? description,
            global::G.RemoteAuth? auth,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            bool? enabled,
            object? testModelParameters,
            global::G.LLMCapabilities? capabilities)
        {
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
        /// Initializes a new instance of the <see cref="OpenAILLMUpdateBase" /> class.
        /// </summary>
        public OpenAILLMUpdateBase()
        {
        }
    }
}