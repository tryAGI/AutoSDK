//HintName: G.Models.BedrockEmbeddingConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BedrockEmbeddingConfig
    {
        /// <summary>
        /// Type of the embedding model.<br/>
        /// Default Value: BEDROCK_EMBEDDING
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Configuration for the Bedrock embedding model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("component")]
        public global::G.BedrockEmbedding? Component { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BedrockEmbeddingConfig" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of the embedding model.<br/>
        /// Default Value: BEDROCK_EMBEDDING
        /// </param>
        /// <param name="component">
        /// Configuration for the Bedrock embedding model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BedrockEmbeddingConfig(
            string? type,
            global::G.BedrockEmbedding? component)
        {
            this.Type = type;
            this.Component = component;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BedrockEmbeddingConfig" /> class.
        /// </summary>
        public BedrockEmbeddingConfig()
        {
        }
    }
}