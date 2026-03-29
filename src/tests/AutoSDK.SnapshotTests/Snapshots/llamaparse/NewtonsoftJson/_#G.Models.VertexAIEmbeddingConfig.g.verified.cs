//HintName: G.Models.VertexAIEmbeddingConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VertexAIEmbeddingConfig
    {
        /// <summary>
        /// Type of the embedding model.<br/>
        /// Default Value: VERTEXAI_EMBEDDING
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Configuration for the VertexAI embedding model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("component")]
        public global::G.VertexTextEmbedding? Component { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VertexAIEmbeddingConfig" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of the embedding model.<br/>
        /// Default Value: VERTEXAI_EMBEDDING
        /// </param>
        /// <param name="component">
        /// Configuration for the VertexAI embedding model.
        /// </param>
        public VertexAIEmbeddingConfig(
            string? type,
            global::G.VertexTextEmbedding? component)
        {
            this.Type = type;
            this.Component = component;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VertexAIEmbeddingConfig" /> class.
        /// </summary>
        public VertexAIEmbeddingConfig()
        {
        }
    }
}