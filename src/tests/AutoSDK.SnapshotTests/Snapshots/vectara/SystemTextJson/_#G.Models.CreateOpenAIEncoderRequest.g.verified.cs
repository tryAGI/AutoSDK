//HintName: G.Models.CreateOpenAIEncoderRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for an OpenAI-compatible encoder
    /// </summary>
    public sealed partial class CreateOpenAIEncoderRequest
    {
        /// <summary>
        /// Must be "openai-compatible" for OpenAI and OpenAI-compatible APIs<br/>
        /// Default Value: openai-compatible
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// A unique name for the encoder<br/>
        /// Example: openai-text-encoder
        /// </summary>
        /// <example>openai-text-encoder</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A description of what this encoder does<br/>
        /// Example: description
        /// </summary>
        /// <example>description</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The number of dimensions in the output embedding vector. If provided and the model supports truncation, the response will be truncated to this number of dimensions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_dimensions")]
        public int? OutputDimensions { get; set; }

        /// <summary>
        /// The URI endpoint for the embedding API (can be OpenAI or any compatible embedding API endpoint)<br/>
        /// Example: https://api.openai.com/v1/embeddings
        /// </summary>
        /// <example>https://api.openai.com/v1/embeddings</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uri { get; set; }

        /// <summary>
        /// The model name to use for embeddings<br/>
        /// Example: text-embedding-ada-002
        /// </summary>
        /// <example>text-embedding-ada-002</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Authentication configuration for an LLM
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RemoteAuthJsonConverter))]
        public global::G.RemoteAuth? Auth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOpenAIEncoderRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// A unique name for the encoder<br/>
        /// Example: openai-text-encoder
        /// </param>
        /// <param name="description">
        /// A description of what this encoder does<br/>
        /// Example: description
        /// </param>
        /// <param name="uri">
        /// The URI endpoint for the embedding API (can be OpenAI or any compatible embedding API endpoint)<br/>
        /// Example: https://api.openai.com/v1/embeddings
        /// </param>
        /// <param name="model">
        /// The model name to use for embeddings<br/>
        /// Example: text-embedding-ada-002
        /// </param>
        /// <param name="type">
        /// Must be "openai-compatible" for OpenAI and OpenAI-compatible APIs<br/>
        /// Default Value: openai-compatible
        /// </param>
        /// <param name="outputDimensions">
        /// The number of dimensions in the output embedding vector. If provided and the model supports truncation, the response will be truncated to this number of dimensions.
        /// </param>
        /// <param name="auth">
        /// Authentication configuration for an LLM
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOpenAIEncoderRequest(
            string name,
            string description,
            string uri,
            string model,
            string? type,
            int? outputDimensions,
            global::G.RemoteAuth? auth)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.OutputDimensions = outputDimensions;
            this.Uri = uri ?? throw new global::System.ArgumentNullException(nameof(uri));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Auth = auth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOpenAIEncoderRequest" /> class.
        /// </summary>
        public CreateOpenAIEncoderRequest()
        {
        }
    }
}