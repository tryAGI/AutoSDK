//HintName: G.Models.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public object Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
        public PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2(
            object data,
            global::G.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2Type type)
        {
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2" /> class.
        /// </summary>
        public PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2()
        {
        }
    }
}