//HintName: G.Models.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant2TypeJsonConverter))]
        public global::G.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant2" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant2(
            object data,
            global::G.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant2Type type)
        {
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant2" /> class.
        /// </summary>
        public PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant2()
        {
        }
    }
}