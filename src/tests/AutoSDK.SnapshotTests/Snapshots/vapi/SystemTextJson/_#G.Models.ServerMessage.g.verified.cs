//HintName: G.Models.ServerMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServerMessage
    {
        /// <summary>
        /// These are all the messages that can be sent to your server before, after and during the call. Configure the messages you'd like to receive in `assistant.serverMessages`.<br/>
        /// The server where the message is sent is determined by the following precedence order:<br/>
        /// 1. `tool.server.url` (if configured, and only for "tool-calls" message)<br/>
        /// 2. `assistant.serverUrl` (if configure)<br/>
        /// 3. `phoneNumber.serverUrl` (if configured)<br/>
        /// 4. `org.serverUrl` (if configured)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.ServerMessageAssistantRequest, global::G.ServerMessageConversationUpdate, global::G.ServerMessageEndOfCallReport, global::G.ServerMessageHandoffDestinationRequest, global::G.ServerMessageHang, global::G.ServerMessageKnowledgeBaseRequest, global::G.ServerMessageModelOutput, global::G.ServerMessagePhoneCallControl, global::G.ServerMessageSpeechUpdate, global::G.ServerMessageStatusUpdate, global::G.ServerMessageToolCalls, global::G.ServerMessageTransferDestinationRequest, global::G.ServerMessageTransferUpdate, global::G.ServerMessageTranscript, global::G.ServerMessageUserInterrupted, global::G.ServerMessageLanguageChangeDetected, global::G.ServerMessageVoiceInput, global::G.ServerMessageVoiceRequest, global::G.ServerMessageCallEndpointingRequest, global::G.ServerMessageChatCreated, global::G.ServerMessageChatDeleted, global::G.ServerMessageSessionCreated, global::G.ServerMessageSessionUpdated, global::G.ServerMessageSessionDeleted, global::G.ServerMessageCallDeleted, global::G.ServerMessageCallDeleteFailed>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.ServerMessageAssistantRequest, global::G.ServerMessageConversationUpdate, global::G.ServerMessageEndOfCallReport, global::G.ServerMessageHandoffDestinationRequest, global::G.ServerMessageHang, global::G.ServerMessageKnowledgeBaseRequest, global::G.ServerMessageModelOutput, global::G.ServerMessagePhoneCallControl, global::G.ServerMessageSpeechUpdate, global::G.ServerMessageStatusUpdate, global::G.ServerMessageToolCalls, global::G.ServerMessageTransferDestinationRequest, global::G.ServerMessageTransferUpdate, global::G.ServerMessageTranscript, global::G.ServerMessageUserInterrupted, global::G.ServerMessageLanguageChangeDetected, global::G.ServerMessageVoiceInput, global::G.ServerMessageVoiceRequest, global::G.ServerMessageCallEndpointingRequest, global::G.ServerMessageChatCreated, global::G.ServerMessageChatDeleted, global::G.ServerMessageSessionCreated, global::G.ServerMessageSessionUpdated, global::G.ServerMessageSessionDeleted, global::G.ServerMessageCallDeleted, global::G.ServerMessageCallDeleteFailed> Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessage" /> class.
        /// </summary>
        /// <param name="message">
        /// These are all the messages that can be sent to your server before, after and during the call. Configure the messages you'd like to receive in `assistant.serverMessages`.<br/>
        /// The server where the message is sent is determined by the following precedence order:<br/>
        /// 1. `tool.server.url` (if configured, and only for "tool-calls" message)<br/>
        /// 2. `assistant.serverUrl` (if configure)<br/>
        /// 3. `phoneNumber.serverUrl` (if configured)<br/>
        /// 4. `org.serverUrl` (if configured)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerMessage(
            global::G.OneOf<global::G.ServerMessageAssistantRequest, global::G.ServerMessageConversationUpdate, global::G.ServerMessageEndOfCallReport, global::G.ServerMessageHandoffDestinationRequest, global::G.ServerMessageHang, global::G.ServerMessageKnowledgeBaseRequest, global::G.ServerMessageModelOutput, global::G.ServerMessagePhoneCallControl, global::G.ServerMessageSpeechUpdate, global::G.ServerMessageStatusUpdate, global::G.ServerMessageToolCalls, global::G.ServerMessageTransferDestinationRequest, global::G.ServerMessageTransferUpdate, global::G.ServerMessageTranscript, global::G.ServerMessageUserInterrupted, global::G.ServerMessageLanguageChangeDetected, global::G.ServerMessageVoiceInput, global::G.ServerMessageVoiceRequest, global::G.ServerMessageCallEndpointingRequest, global::G.ServerMessageChatCreated, global::G.ServerMessageChatDeleted, global::G.ServerMessageSessionCreated, global::G.ServerMessageSessionUpdated, global::G.ServerMessageSessionDeleted, global::G.ServerMessageCallDeleted, global::G.ServerMessageCallDeleteFailed> message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessage" /> class.
        /// </summary>
        public ServerMessage()
        {
        }
    }
}