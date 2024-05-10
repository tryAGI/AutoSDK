//HintName: G.Models.GenerateEmbeddingRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Generate embeddings from a model.
    /// </summary>
    public sealed partial class GenerateEmbeddingRequest
    {
        /// <summary>
        /// The model name. 
        /// Model names follow a `model:tag` format. Some examples are `orca-mini:3b-q4_1` and `llama2:70b`. The tag is optional and, if not provided, will default to `latest`. The tag is used to identify a specific version.
        /// <br/>Example: llama2:7b
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public required string Model { get; set; }

        /// <summary>
        /// Text to generate embeddings for.
        /// <br/>Example: Here is an article about llamas...
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public required string Prompt { get; set; }

        /// <summary>
        /// Additional model parameters listed in the documentation for the Modelfile such as `temperature`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public RequestOptions? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}