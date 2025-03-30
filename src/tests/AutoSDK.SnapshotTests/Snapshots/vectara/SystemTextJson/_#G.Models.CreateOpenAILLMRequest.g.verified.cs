//HintName: G.Models.CreateOpenAILLMRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to create an OpenAI-compatible Large Language Model connection.
    /// </summary>
    public sealed partial class CreateOpenAILLMRequest
    {
        /// <summary>
        /// Must be "openai-compatible" for OpenAI and OpenAI-compatible APIs (like Anthropic Claude, Azure OpenAI, etc)<br/>
        /// Default Value: openai-compatible
        /// </summary>
        /// <default>"openai-compatible"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "openai-compatible";

        /// <summary>
        /// Name to reference the LLM.  This will be used in other endpoints (like query) when using this LLM.<br/>
        /// If this name conflicts with a global LLM (a LLM that is precofnigured with the Vectara platform),<br/>
        /// then it will override that LLM for all usages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of the LLM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The model name to use with the API (e.g. gpt-4, claude-2, etc). This is used in the API request to the remote LLM provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The URI endpoint for the API (can be OpenAI or any compatible API endpoint)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uri { get; set; }

        /// <summary>
        /// Authentication configuration for an LLM
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RemoteAuthJsonConverter))]
        public global::G.RemoteAuth? Auth { get; set; }

        /// <summary>
        /// Any additional parameters that are required for the LLM during the test call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_model_parameters")]
        public object? TestModelParameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOpenAILLMRequest" /> class.
        /// </summary>
        /// <param name="type">
        /// Must be "openai-compatible" for OpenAI and OpenAI-compatible APIs (like Anthropic Claude, Azure OpenAI, etc)<br/>
        /// Default Value: openai-compatible
        /// </param>
        /// <param name="name">
        /// Name to reference the LLM.  This will be used in other endpoints (like query) when using this LLM.<br/>
        /// If this name conflicts with a global LLM (a LLM that is precofnigured with the Vectara platform),<br/>
        /// then it will override that LLM for all usages.
        /// </param>
        /// <param name="description">
        /// Description of the LLM.
        /// </param>
        /// <param name="model">
        /// The model name to use with the API (e.g. gpt-4, claude-2, etc). This is used in the API request to the remote LLM provider.
        /// </param>
        /// <param name="uri">
        /// The URI endpoint for the API (can be OpenAI or any compatible API endpoint)
        /// </param>
        /// <param name="auth">
        /// Authentication configuration for an LLM
        /// </param>
        /// <param name="testModelParameters">
        /// Any additional parameters that are required for the LLM during the test call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOpenAILLMRequest(
            string type,
            string name,
            string model,
            string uri,
            string? description,
            global::G.RemoteAuth? auth,
            object? testModelParameters)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Uri = uri ?? throw new global::System.ArgumentNullException(nameof(uri));
            this.Description = description;
            this.Auth = auth;
            this.TestModelParameters = testModelParameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOpenAILLMRequest" /> class.
        /// </summary>
        public CreateOpenAILLMRequest()
        {
        }
    }
}