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
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsUnsubscribeAgentRequest" /> class.
        /// </summary>
        /// <param name="agentId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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