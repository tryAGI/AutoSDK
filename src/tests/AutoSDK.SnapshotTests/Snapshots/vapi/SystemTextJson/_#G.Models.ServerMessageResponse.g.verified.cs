//HintName: G.Models.ServerMessageResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServerMessageResponse
    {
        /// <summary>
        /// This is the response that is expected from the server to the message.<br/>
        /// Note: Most messages don't expect a response. Only "assistant-request", "tool-calls" and "transfer-destination-request" do.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messageResponse")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.ServerMessageResponseAssistantRequest, global::G.ServerMessageResponseHandoffDestinationRequest, global::G.ServerMessageResponseKnowledgeBaseRequest, global::G.ServerMessageResponseToolCalls, global::G.ServerMessageResponseTransferDestinationRequest, global::G.ServerMessageResponseVoiceRequest, global::G.ServerMessageResponseCallEndpointingRequest>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.ServerMessageResponseAssistantRequest, global::G.ServerMessageResponseHandoffDestinationRequest, global::G.ServerMessageResponseKnowledgeBaseRequest, global::G.ServerMessageResponseToolCalls, global::G.ServerMessageResponseTransferDestinationRequest, global::G.ServerMessageResponseVoiceRequest, global::G.ServerMessageResponseCallEndpointingRequest> MessageResponse { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageResponse" /> class.
        /// </summary>
        /// <param name="messageResponse">
        /// This is the response that is expected from the server to the message.<br/>
        /// Note: Most messages don't expect a response. Only "assistant-request", "tool-calls" and "transfer-destination-request" do.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerMessageResponse(
            global::G.OneOf<global::G.ServerMessageResponseAssistantRequest, global::G.ServerMessageResponseHandoffDestinationRequest, global::G.ServerMessageResponseKnowledgeBaseRequest, global::G.ServerMessageResponseToolCalls, global::G.ServerMessageResponseTransferDestinationRequest, global::G.ServerMessageResponseVoiceRequest, global::G.ServerMessageResponseCallEndpointingRequest> messageResponse)
        {
            this.MessageResponse = messageResponse;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageResponse" /> class.
        /// </summary>
        public ServerMessageResponse()
        {
        }
    }
}