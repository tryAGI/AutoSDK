//HintName: G.Models.EmbeddingModelConfigCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingModelConfigCreate
    {
        /// <summary>
        /// The name of the embedding model config.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The embedding configuration for the embedding model config.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EmbeddingConfig2 EmbeddingConfig { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingModelConfigCreate" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the embedding model config.
        /// </param>
        /// <param name="embeddingConfig">
        /// The embedding configuration for the embedding model config.
        /// </param>
        public EmbeddingModelConfigCreate(
            string name,
            global::G.EmbeddingConfig2 embeddingConfig)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.EmbeddingConfig = embeddingConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingModelConfigCreate" /> class.
        /// </summary>
        public EmbeddingModelConfigCreate()
        {
        }
    }
}