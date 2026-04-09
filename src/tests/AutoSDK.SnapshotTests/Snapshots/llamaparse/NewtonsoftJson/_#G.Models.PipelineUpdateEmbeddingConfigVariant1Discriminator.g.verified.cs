//HintName: G.Models.PipelineUpdateEmbeddingConfigVariant1Discriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelineUpdateEmbeddingConfigVariant1Discriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PipelineUpdateEmbeddingConfigVariant1DiscriminatorTypeJsonConverter))]
        public global::G.PipelineUpdateEmbeddingConfigVariant1DiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineUpdateEmbeddingConfigVariant1Discriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public PipelineUpdateEmbeddingConfigVariant1Discriminator(
            global::G.PipelineUpdateEmbeddingConfigVariant1DiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineUpdateEmbeddingConfigVariant1Discriminator" /> class.
        /// </summary>
        public PipelineUpdateEmbeddingConfigVariant1Discriminator()
        {
        }
    }
}