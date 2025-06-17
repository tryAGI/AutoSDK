//HintName: G.Models.AgentSimulatedChatTestResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentSimulatedChatTestResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("simulated_conversation", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ConversationHistoryTranscriptCommonModelOutput> SimulatedConversation { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("analysis", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ConversationHistoryAnalysisCommonModel Analysis { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSimulatedChatTestResponseModel" /> class.
        /// </summary>
        /// <param name="simulatedConversation"></param>
        /// <param name="analysis"></param>
        public AgentSimulatedChatTestResponseModel(
            global::System.Collections.Generic.IList<global::G.ConversationHistoryTranscriptCommonModelOutput> simulatedConversation,
            global::G.ConversationHistoryAnalysisCommonModel analysis)
        {
            this.SimulatedConversation = simulatedConversation ?? throw new global::System.ArgumentNullException(nameof(simulatedConversation));
            this.Analysis = analysis ?? throw new global::System.ArgumentNullException(nameof(analysis));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSimulatedChatTestResponseModel" /> class.
        /// </summary>
        public AgentSimulatedChatTestResponseModel()
        {
        }
    }
}