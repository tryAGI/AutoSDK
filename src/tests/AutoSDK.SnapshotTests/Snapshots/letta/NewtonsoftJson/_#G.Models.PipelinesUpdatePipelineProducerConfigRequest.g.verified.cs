//HintName: G.Models.PipelinesUpdatePipelineProducerConfigRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelinesUpdatePipelineProducerConfigRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("producer_config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ProducerConfig2 ProducerConfig { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesUpdatePipelineProducerConfigRequest" /> class.
        /// </summary>
        /// <param name="producerConfig"></param>
        public PipelinesUpdatePipelineProducerConfigRequest(
            global::G.ProducerConfig2 producerConfig)
        {
            this.ProducerConfig = producerConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesUpdatePipelineProducerConfigRequest" /> class.
        /// </summary>
        public PipelinesUpdatePipelineProducerConfigRequest()
        {
        }
    }
}