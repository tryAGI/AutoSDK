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
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cron_schedule")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CronSchedule { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_template")]
        public string? PromptTemplate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsSubscribeAgentRequest" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="cronSchedule"></param>
        /// <param name="promptTemplate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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