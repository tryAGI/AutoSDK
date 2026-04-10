//HintName: G.Models.PipelinesPreviewPipelineRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelinesPreviewPipelineRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("integration_type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PipelinesPreviewPipelineRequestIntegrationTypeJsonConverter))]
        public global::G.PipelinesPreviewPipelineRequestIntegrationType IntegrationType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("integration_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string IntegrationId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("producer_config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ProducerConfig3 ProducerConfig { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesPreviewPipelineRequest" /> class.
        /// </summary>
        /// <param name="integrationType"></param>
        /// <param name="integrationId"></param>
        /// <param name="producerConfig"></param>
        public PipelinesPreviewPipelineRequest(
            global::G.PipelinesPreviewPipelineRequestIntegrationType integrationType,
            string integrationId,
            global::G.ProducerConfig3 producerConfig)
        {
            this.IntegrationType = integrationType;
            this.IntegrationId = integrationId ?? throw new global::System.ArgumentNullException(nameof(integrationId));
            this.ProducerConfig = producerConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesPreviewPipelineRequest" /> class.
        /// </summary>
        public PipelinesPreviewPipelineRequest()
        {
        }
    }
}