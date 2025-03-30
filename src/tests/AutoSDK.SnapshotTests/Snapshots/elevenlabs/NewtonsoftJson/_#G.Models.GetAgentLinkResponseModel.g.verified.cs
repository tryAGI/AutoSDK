//HintName: G.Models.GetAgentLinkResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAgentLinkResponseModel
    {
        /// <summary>
        /// The ID of the agent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token")]
        public global::G.ConversationTokenDBModel? Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentLinkResponseModel" /> class.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent
        /// </param>
        /// <param name="token"></param>
        public GetAgentLinkResponseModel(
            string agentId,
            global::G.ConversationTokenDBModel? token)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentLinkResponseModel" /> class.
        /// </summary>
        public GetAgentLinkResponseModel()
        {
        }
    }
}