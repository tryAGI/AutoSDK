//HintName: G.Models.CreateVertexAILLMRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to create a Vertex AI Large Language Model connection for Gemini models.
    /// </summary>
    public sealed partial class CreateVertexAILLMRequest
    {
        /// <summary>
        /// Must be "vertex-ai" for Google Cloud Vertex AI Gemini models<br/>
        /// Default Value: vertex-ai
        /// </summary>
        /// <default>"vertex-ai"</default>
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
        /// The model name to use (e.g. gemini-2.5-flash, gemini-2.5-pro, gemini-2.0-experimental-1219, etc).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// The base URI for the Gemini API. You can provide URIs in various formats — the system will normalize them automatically, stripping any model path, method suffix, or query parameters.<br/>
        /// **Vertex AI** (for service account auth): Provide the project/location base URI. Example: `https://us-central1-aiplatform.googleapis.com/v1/projects/YOUR-PROJECT/locations/us-central1`<br/>
        /// **Google AI Studio** (for API key auth): Provide the Generative Language API base URI. Example: `https://generativelanguage.googleapis.com/v1beta`<br/>
        /// Full URIs copied from Google docs also work — the model path and `:generateContent` suffix will be stripped and rebuilt automatically from the `model` field.<br/>
        /// Example: https://us-central1-aiplatform.googleapis.com/v1/projects/my-project/locations/us-central1
        /// </summary>
        /// <example>https://us-central1-aiplatform.googleapis.com/v1/projects/my-project/locations/us-central1</example>
        [global::Newtonsoft.Json.JsonProperty("uri", Required = global::Newtonsoft.Json.Required.Always)]
        public string Uri { get; set; } = default!;

        /// <summary>
        /// Authentication configuration for Vertex AI
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.VertexAiAuth Auth { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="CreateVertexAILLMRequest" /> class.
        /// </summary>
        /// <param name="type">
        /// Must be "vertex-ai" for Google Cloud Vertex AI Gemini models<br/>
        /// Default Value: vertex-ai
        /// </param>
        /// <param name="name">
        /// Name to reference the LLM. This will be used in other endpoints (like query) when using this LLM. If this name conflicts with a global LLM (a LLM that is preconfigured with the Vectara platform), then it will override that LLM for all usages.
        /// </param>
        /// <param name="description">
        /// Description of the LLM.
        /// </param>
        /// <param name="model">
        /// The model name to use (e.g. gemini-2.5-flash, gemini-2.5-pro, gemini-2.0-experimental-1219, etc).
        /// </param>
        /// <param name="uri">
        /// The base URI for the Gemini API. You can provide URIs in various formats — the system will normalize them automatically, stripping any model path, method suffix, or query parameters.<br/>
        /// **Vertex AI** (for service account auth): Provide the project/location base URI. Example: `https://us-central1-aiplatform.googleapis.com/v1/projects/YOUR-PROJECT/locations/us-central1`<br/>
        /// **Google AI Studio** (for API key auth): Provide the Generative Language API base URI. Example: `https://generativelanguage.googleapis.com/v1beta`<br/>
        /// Full URIs copied from Google docs also work — the model path and `:generateContent` suffix will be stripped and rebuilt automatically from the `model` field.<br/>
        /// Example: https://us-central1-aiplatform.googleapis.com/v1/projects/my-project/locations/us-central1
        /// </param>
        /// <param name="auth">
        /// Authentication configuration for Vertex AI
        /// </param>
        /// <param name="testModelParameters">
        /// Any additional parameters that are required for the LLM during the test call.
        /// </param>
        /// <param name="capabilities">
        /// Capabilities of a Large Language Model.
        /// </param>
        public CreateVertexAILLMRequest(
            string type,
            string name,
            string model,
            string uri,
            global::G.VertexAiAuth auth,
            string? description,
            object? testModelParameters,
            global::G.LLMCapabilities? capabilities)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Uri = uri ?? throw new global::System.ArgumentNullException(nameof(uri));
            this.Auth = auth;
            this.Description = description;
            this.TestModelParameters = testModelParameters;
            this.Capabilities = capabilities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVertexAILLMRequest" /> class.
        /// </summary>
        public CreateVertexAILLMRequest()
        {
        }
    }
}