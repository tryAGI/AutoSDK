//HintName: G.Models.FeedsUnsubscribeAgentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedsUnsubscribeAgentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsUnsubscribeAgentRequest" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        public FeedsUnsubscribeAgentRequest(
            string agentId)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsUnsubscribeAgentRequest" /> class.
        /// </summary>
        public FeedsUnsubscribeAgentRequest()
        {
        }
    }
}