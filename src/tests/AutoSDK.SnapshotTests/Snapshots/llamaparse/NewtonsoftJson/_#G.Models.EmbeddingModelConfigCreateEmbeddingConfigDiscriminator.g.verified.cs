//HintName: G.Models.EmbeddingModelConfigCreateEmbeddingConfigDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingModelConfigCreateEmbeddingConfigDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorTypeJsonConverter))]
        public global::G.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingModelConfigCreateEmbeddingConfigDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public EmbeddingModelConfigCreateEmbeddingConfigDiscriminator(
            global::G.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingModelConfigCreateEmbeddingConfigDiscriminator" /> class.
        /// </summary>
        public EmbeddingModelConfigCreateEmbeddingConfigDiscriminator()
        {
        }
    }
}