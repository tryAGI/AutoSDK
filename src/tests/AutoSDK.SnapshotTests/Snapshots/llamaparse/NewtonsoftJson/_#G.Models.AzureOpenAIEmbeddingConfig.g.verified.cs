//HintName: G.Models.AzureOpenAIEmbeddingConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AzureOpenAIEmbeddingConfig
    {
        /// <summary>
        /// Type of the embedding model.<br/>
        /// Default Value: AZURE_EMBEDDING
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Configuration for the Azure OpenAI embedding model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("component")]
        public global::G.AzureOpenAIEmbedding? Component { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureOpenAIEmbeddingConfig" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of the embedding model.<br/>
        /// Default Value: AZURE_EMBEDDING
        /// </param>
        /// <param name="component">
        /// Configuration for the Azure OpenAI embedding model.
        /// </param>
        public AzureOpenAIEmbeddingConfig(
            string? type,
            global::G.AzureOpenAIEmbedding? component)
        {
            this.Type = type;
            this.Component = component;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureOpenAIEmbeddingConfig" /> class.
        /// </summary>
        public AzureOpenAIEmbeddingConfig()
        {
        }
    }
}