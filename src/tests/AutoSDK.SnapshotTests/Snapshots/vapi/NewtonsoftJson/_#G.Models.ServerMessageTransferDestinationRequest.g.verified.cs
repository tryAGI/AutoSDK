//HintName: G.Models.ServerMessageTransferDestinationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServerMessageTransferDestinationRequest
    {
        /// <summary>
        /// This is the phone number that the message is associated with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phoneNumber")]
        public global::G.OneOf<global::G.CreateByoPhoneNumberDTO, global::G.CreateTwilioPhoneNumberDTO, global::G.CreateVonagePhoneNumberDTO, global::G.CreateVapiPhoneNumberDTO, global::G.CreateTelnyxPhoneNumberDTO>? PhoneNumber { get; set; }

        /// <summary>
        /// This is the type of the message. "transfer-destination-request" is sent when the model is requesting transfer but destination is unknown.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ServerMessageTransferDestinationRequestType Type { get; set; }

        /// <summary>
        /// This is the timestamp of the message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp")]
        public double? Timestamp { get; set; }

        /// <summary>
        /// This is a live version of the `call.artifact`.<br/>
        /// This matches what is stored on `call.artifact` after the call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("artifact")]
        public global::G.Artifact? Artifact { get; set; }

        /// <summary>
        /// This is the assistant that the message is associated with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistant")]
        public global::G.CreateAssistantDTO? Assistant { get; set; }

        /// <summary>
        /// This is the customer that the message is associated with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("customer")]
        public global::G.CreateCustomerDTO? Customer { get; set; }

        /// <summary>
        /// This is the call that the message is associated with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call")]
        public global::G.Call? Call { get; set; }

        /// <summary>
        /// This is the chat object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chat")]
        public global::G.Chat? Chat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageTransferDestinationRequest" /> class.
        /// </summary>
        /// <param name="phoneNumber">
        /// This is the phone number that the message is associated with.
        /// </param>
        /// <param name="type">
        /// This is the type of the message. "transfer-destination-request" is sent when the model is requesting transfer but destination is unknown.
        /// </param>
        /// <param name="timestamp">
        /// This is the timestamp of the message.
        /// </param>
        /// <param name="artifact">
        /// This is a live version of the `call.artifact`.<br/>
        /// This matches what is stored on `call.artifact` after the call.
        /// </param>
        /// <param name="assistant">
        /// This is the assistant that the message is associated with.
        /// </param>
        /// <param name="customer">
        /// This is the customer that the message is associated with.
        /// </param>
        /// <param name="call">
        /// This is the call that the message is associated with.
        /// </param>
        /// <param name="chat">
        /// This is the chat object.
        /// </param>
        public ServerMessageTransferDestinationRequest(
            global::G.OneOf<global::G.CreateByoPhoneNumberDTO, global::G.CreateTwilioPhoneNumberDTO, global::G.CreateVonagePhoneNumberDTO, global::G.CreateVapiPhoneNumberDTO, global::G.CreateTelnyxPhoneNumberDTO>? phoneNumber,
            global::G.ServerMessageTransferDestinationRequestType type,
            double? timestamp,
            global::G.Artifact? artifact,
            global::G.CreateAssistantDTO? assistant,
            global::G.CreateCustomerDTO? customer,
            global::G.Call? call,
            global::G.Chat? chat)
        {
            this.PhoneNumber = phoneNumber;
            this.Type = type;
            this.Timestamp = timestamp;
            this.Artifact = artifact;
            this.Assistant = assistant;
            this.Customer = customer;
            this.Call = call;
            this.Chat = chat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageTransferDestinationRequest" /> class.
        /// </summary>
        public ServerMessageTransferDestinationRequest()
        {
        }
    }
}