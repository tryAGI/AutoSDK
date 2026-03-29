//HintName: G.Models.PipelinesCreatePipelineRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelinesCreatePipelineRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("integration_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PipelinesCreatePipelineRequestIntegrationType IntegrationType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("producer_config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ProducerConfig ProducerConfig { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subscriber_agent_ids")]
        public global::System.Collections.Generic.IList<string>? SubscriberAgentIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subscriber_cron_schedule")]
        public string? SubscriberCronSchedule { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_template")]
        public string? PromptTemplate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesCreatePipelineRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="projectId"></param>
        /// <param name="integrationType"></param>
        /// <param name="producerConfig"></param>
        /// <param name="subscriberAgentIds"></param>
        /// <param name="subscriberCronSchedule"></param>
        /// <param name="promptTemplate"></param>
        public PipelinesCreatePipelineRequest(
            string name,
            string projectId,
            global::G.PipelinesCreatePipelineRequestIntegrationType integrationType,
            global::G.ProducerConfig producerConfig,
            global::System.Collections.Generic.IList<string>? subscriberAgentIds,
            string? subscriberCronSchedule,
            string? promptTemplate)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.IntegrationType = integrationType;
            this.ProducerConfig = producerConfig;
            this.SubscriberAgentIds = subscriberAgentIds;
            this.SubscriberCronSchedule = subscriberCronSchedule;
            this.PromptTemplate = promptTemplate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesCreatePipelineRequest" /> class.
        /// </summary>
        public PipelinesCreatePipelineRequest()
        {
        }
    }
}