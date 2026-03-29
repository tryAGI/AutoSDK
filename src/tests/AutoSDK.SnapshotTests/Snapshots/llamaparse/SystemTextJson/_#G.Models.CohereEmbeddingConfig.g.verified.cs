//HintName: G.Models.CohereEmbeddingConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CohereEmbeddingConfig
    {
        /// <summary>
        /// Type of the embedding model.<br/>
        /// Default Value: COHERE_EMBEDDING
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Configuration for the Cohere embedding model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("component")]
        public global::G.CohereEmbedding? Component { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CohereEmbeddingConfig" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of the embedding model.<br/>
        /// Default Value: COHERE_EMBEDDING
        /// </param>
        /// <param name="component">
        /// Configuration for the Cohere embedding model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CohereEmbeddingConfig(
            string? type,
            global::G.CohereEmbedding? component)
        {
            this.Type = type;
            this.Component = component;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CohereEmbeddingConfig" /> class.
        /// </summary>
        public CohereEmbeddingConfig()
        {
        }
    }
}