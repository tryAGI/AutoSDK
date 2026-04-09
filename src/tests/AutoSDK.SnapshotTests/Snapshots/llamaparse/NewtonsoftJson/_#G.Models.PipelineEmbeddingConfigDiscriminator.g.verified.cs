//HintName: G.Models.PipelineEmbeddingConfigDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelineEmbeddingConfigDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PipelineEmbeddingConfigDiscriminatorTypeJsonConverter))]
        public global::G.PipelineEmbeddingConfigDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineEmbeddingConfigDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public PipelineEmbeddingConfigDiscriminator(
            global::G.PipelineEmbeddingConfigDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineEmbeddingConfigDiscriminator" /> class.
        /// </summary>
        public PipelineEmbeddingConfigDiscriminator()
        {
        }
    }
}