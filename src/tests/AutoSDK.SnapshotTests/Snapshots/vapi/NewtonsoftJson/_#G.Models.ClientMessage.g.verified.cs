//HintName: G.Models.ClientMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClientMessage
    {
        /// <summary>
        /// These are all the messages that can be sent to the client-side SDKs during the call. Configure the messages you'd like to receive in `assistant.clientMessages`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.ClientMessageWorkflowNodeStarted, global::G.ClientMessageAssistantStarted, global::G.ClientMessageConversationUpdate, global::G.ClientMessageHang, global::G.ClientMessageMetadata, global::G.ClientMessageModelOutput, global::G.ClientMessageSpeechUpdate, global::G.ClientMessageTranscript, global::G.ClientMessageToolCalls, global::G.ClientMessageToolCallsResult, global::G.ClientMessageTransferUpdate, global::G.ClientMessageUserInterrupted, global::G.ClientMessageLanguageChangeDetected, global::G.ClientMessageVoiceInput, global::G.ClientMessageChatCreated, global::G.ClientMessageChatDeleted, global::G.ClientMessageSessionCreated, global::G.ClientMessageSessionUpdated, global::G.ClientMessageSessionDeleted, global::G.ClientMessageCallDeleted, global::G.ClientMessageCallDeleteFailed> Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientMessage" /> class.
        /// </summary>
        /// <param name="message">
        /// These are all the messages that can be sent to the client-side SDKs during the call. Configure the messages you'd like to receive in `assistant.clientMessages`.
        /// </param>
        public ClientMessage(
            global::G.OneOf<global::G.ClientMessageWorkflowNodeStarted, global::G.ClientMessageAssistantStarted, global::G.ClientMessageConversationUpdate, global::G.ClientMessageHang, global::G.ClientMessageMetadata, global::G.ClientMessageModelOutput, global::G.ClientMessageSpeechUpdate, global::G.ClientMessageTranscript, global::G.ClientMessageToolCalls, global::G.ClientMessageToolCallsResult, global::G.ClientMessageTransferUpdate, global::G.ClientMessageUserInterrupted, global::G.ClientMessageLanguageChangeDetected, global::G.ClientMessageVoiceInput, global::G.ClientMessageChatCreated, global::G.ClientMessageChatDeleted, global::G.ClientMessageSessionCreated, global::G.ClientMessageSessionUpdated, global::G.ClientMessageSessionDeleted, global::G.ClientMessageCallDeleted, global::G.ClientMessageCallDeleteFailed> message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientMessage" /> class.
        /// </summary>
        public ClientMessage()
        {
        }
    }
}