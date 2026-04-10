//HintName: G.Models.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1TypeJsonConverter))]
        public global::G.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1Data Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
        public PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1(
            global::G.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1Data data,
            global::G.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1Type type)
        {
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1" /> class.
        /// </summary>
        public PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1()
        {
        }
    }
}