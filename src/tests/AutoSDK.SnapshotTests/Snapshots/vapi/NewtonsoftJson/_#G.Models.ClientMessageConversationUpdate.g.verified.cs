//HintName: G.Models.ClientMessageConversationUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClientMessageConversationUpdate
    {
        /// <summary>
        /// This is the phone number that the message is associated with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phoneNumber")]
        public global::G.OneOf<global::G.CreateByoPhoneNumberDTO, global::G.CreateTwilioPhoneNumberDTO, global::G.CreateVonagePhoneNumberDTO, global::G.CreateVapiPhoneNumberDTO, global::G.CreateTelnyxPhoneNumberDTO>? PhoneNumber { get; set; }

        /// <summary>
        /// This is the type of the message. "conversation-update" is sent when an update is committed to the conversation history.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ClientMessageConversationUpdateTypeJsonConverter))]
        public global::G.ClientMessageConversationUpdateType Type { get; set; }

        /// <summary>
        /// This is the most up-to-date conversation history at the time the message is sent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.UserMessage, global::G.SystemMessage, global::G.BotMessage, global::G.ToolCallMessage, global::G.ToolCallResultMessage>>? Messages { get; set; }

        /// <summary>
        /// This is the most up-to-date conversation history at the time the message is sent, formatted for OpenAI.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messagesOpenAIFormatted", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OpenAIMessage> MessagesOpenAIFormatted { get; set; } = default!;

        /// <summary>
        /// This is the timestamp of the message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp")]
        public double? Timestamp { get; set; }

        /// <summary>
        /// This is the call that the message is associated with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call")]
        public global::G.Call? Call { get; set; }

        /// <summary>
        /// This is the customer that the message is associated with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("customer")]
        public global::G.CreateCustomerDTO? Customer { get; set; }

        /// <summary>
        /// This is the assistant that the message is associated with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistant")]
        public global::G.CreateAssistantDTO? Assistant { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientMessageConversationUpdate" /> class.
        /// </summary>
        /// <param name="messagesOpenAIFormatted">
        /// This is the most up-to-date conversation history at the time the message is sent, formatted for OpenAI.
        /// </param>
        /// <param name="phoneNumber">
        /// This is the phone number that the message is associated with.
        /// </param>
        /// <param name="type">
        /// This is the type of the message. "conversation-update" is sent when an update is committed to the conversation history.
        /// </param>
        /// <param name="messages">
        /// This is the most up-to-date conversation history at the time the message is sent.
        /// </param>
        /// <param name="timestamp">
        /// This is the timestamp of the message.
        /// </param>
        /// <param name="call">
        /// This is the call that the message is associated with.
        /// </param>
        /// <param name="customer">
        /// This is the customer that the message is associated with.
        /// </param>
        /// <param name="assistant">
        /// This is the assistant that the message is associated with.
        /// </param>
        public ClientMessageConversationUpdate(
            global::System.Collections.Generic.IList<global::G.OpenAIMessage> messagesOpenAIFormatted,
            global::G.OneOf<global::G.CreateByoPhoneNumberDTO, global::G.CreateTwilioPhoneNumberDTO, global::G.CreateVonagePhoneNumberDTO, global::G.CreateVapiPhoneNumberDTO, global::G.CreateTelnyxPhoneNumberDTO>? phoneNumber,
            global::G.ClientMessageConversationUpdateType type,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.UserMessage, global::G.SystemMessage, global::G.BotMessage, global::G.ToolCallMessage, global::G.ToolCallResultMessage>>? messages,
            double? timestamp,
            global::G.Call? call,
            global::G.CreateCustomerDTO? customer,
            global::G.CreateAssistantDTO? assistant)
        {
            this.PhoneNumber = phoneNumber;
            this.Type = type;
            this.Messages = messages;
            this.MessagesOpenAIFormatted = messagesOpenAIFormatted ?? throw new global::System.ArgumentNullException(nameof(messagesOpenAIFormatted));
            this.Timestamp = timestamp;
            this.Call = call;
            this.Customer = customer;
            this.Assistant = assistant;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientMessageConversationUpdate" /> class.
        /// </summary>
        public ClientMessageConversationUpdate()
        {
        }
    }
}