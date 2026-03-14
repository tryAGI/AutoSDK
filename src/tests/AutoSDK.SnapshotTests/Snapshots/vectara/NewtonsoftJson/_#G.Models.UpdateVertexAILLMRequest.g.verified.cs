//HintName: G.Models.UpdateVertexAILLMRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to update a Vertex AI Large Language Model connection. All fields are optional.
    /// </summary>
    public sealed partial class UpdateVertexAILLMRequest
    {
        /// <summary>
        /// Must be "vertex-ai" for Google Cloud Vertex AI Gemini models<br/>
        /// Default Value: vertex-ai
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The model identifier to use for this LLM.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The base URI for the Gemini API. Accepts Vertex AI or Google AI Studio URIs in any format.<br/>
        /// See the create endpoint for full details and examples.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// Description of the LLM.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Authentication configuration for Vertex AI
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth")]
        public global::G.VertexAiAuth? Auth { get; set; }

        /// <summary>
        /// Whether the LLM is enabled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

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
        /// Initializes a new instance of the <see cref="UpdateVertexAILLMRequest" /> class.
        /// </summary>
        /// <param name="type">
        /// Must be "vertex-ai" for Google Cloud Vertex AI Gemini models<br/>
        /// Default Value: vertex-ai
        /// </param>
        /// <param name="model">
        /// The model identifier to use for this LLM.
        /// </param>
        /// <param name="uri">
        /// The base URI for the Gemini API. Accepts Vertex AI or Google AI Studio URIs in any format.<br/>
        /// See the create endpoint for full details and examples.
        /// </param>
        /// <param name="description">
        /// Description of the LLM.
        /// </param>
        /// <param name="auth">
        /// Authentication configuration for Vertex AI
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
        public UpdateVertexAILLMRequest(
            string? type,
            string? model,
            string? uri,
            string? description,
            global::G.VertexAiAuth? auth,
            bool? enabled,
            object? testModelParameters,
            global::G.LLMCapabilities? capabilities)
        {
            this.Type = type;
            this.Model = model;
            this.Uri = uri;
            this.Description = description;
            this.Auth = auth;
            this.Enabled = enabled;
            this.TestModelParameters = testModelParameters;
            this.Capabilities = capabilities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVertexAILLMRequest" /> class.
        /// </summary>
        public UpdateVertexAILLMRequest()
        {
        }
    }
}