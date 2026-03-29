//HintName: G.Models.HuggingFaceInferenceAPIEmbeddingConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HuggingFaceInferenceAPIEmbeddingConfig
    {
        /// <summary>
        /// Type of the embedding model.<br/>
        /// Default Value: HUGGINGFACE_API_EMBEDDING
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Configuration for the HuggingFace Inference API embedding model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("component")]
        public global::G.HuggingFaceInferenceAPIEmbedding? Component { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HuggingFaceInferenceAPIEmbeddingConfig" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of the embedding model.<br/>
        /// Default Value: HUGGINGFACE_API_EMBEDDING
        /// </param>
        /// <param name="component">
        /// Configuration for the HuggingFace Inference API embedding model.
        /// </param>
        public HuggingFaceInferenceAPIEmbeddingConfig(
            string? type,
            global::G.HuggingFaceInferenceAPIEmbedding? component)
        {
            this.Type = type;
            this.Component = component;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HuggingFaceInferenceAPIEmbeddingConfig" /> class.
        /// </summary>
        public HuggingFaceInferenceAPIEmbeddingConfig()
        {
        }
    }
}