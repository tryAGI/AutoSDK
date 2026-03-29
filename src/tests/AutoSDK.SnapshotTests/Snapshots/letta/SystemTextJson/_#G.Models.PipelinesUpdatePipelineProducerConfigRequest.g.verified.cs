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
        [global::System.Text.Json.Serialization.JsonPropertyName("producer_config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProducerConfig2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ProducerConfig2 ProducerConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesUpdatePipelineProducerConfigRequest" /> class.
        /// </summary>
        /// <param name="producerConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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