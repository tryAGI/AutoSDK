//HintName: G.Models.OpenAIEmbeddingConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAIEmbeddingConfig
    {
        /// <summary>
        /// Type of the embedding model.<br/>
        /// Default Value: OPENAI_EMBEDDING
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Configuration for the OpenAI embedding model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("component")]
        public global::G.OpenAIEmbedding? Component { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIEmbeddingConfig" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of the embedding model.<br/>
        /// Default Value: OPENAI_EMBEDDING
        /// </param>
        /// <param name="component">
        /// Configuration for the OpenAI embedding model.
        /// </param>
        public OpenAIEmbeddingConfig(
            string? type,
            global::G.OpenAIEmbedding? component)
        {
            this.Type = type;
            this.Component = component;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIEmbeddingConfig" /> class.
        /// </summary>
        public OpenAIEmbeddingConfig()
        {
        }
    }
}