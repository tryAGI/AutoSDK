//HintName: G.Models.FeedsSubscribeAgentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedsSubscribeAgentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cron_schedule", Required = global::Newtonsoft.Json.Required.Always)]
        public string CronSchedule { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="FeedsSubscribeAgentRequest" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="cronSchedule"></param>
        /// <param name="promptTemplate"></param>
        public FeedsSubscribeAgentRequest(
            string agentId,
            string cronSchedule,
            string? promptTemplate)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.CronSchedule = cronSchedule ?? throw new global::System.ArgumentNullException(nameof(cronSchedule));
            this.PromptTemplate = promptTemplate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsSubscribeAgentRequest" /> class.
        /// </summary>
        public FeedsSubscribeAgentRequest()
        {
        }
    }
}