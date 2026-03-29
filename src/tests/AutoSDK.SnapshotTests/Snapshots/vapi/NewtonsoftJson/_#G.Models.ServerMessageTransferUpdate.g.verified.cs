//HintName: G.Models.ServerMessageTransferUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServerMessageTransferUpdate
    {
        /// <summary>
        /// This is the phone number that the message is associated with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phoneNumber")]
        public global::G.OneOf<global::G.CreateByoPhoneNumberDTO, global::G.CreateTwilioPhoneNumberDTO, global::G.CreateVonagePhoneNumberDTO, global::G.CreateVapiPhoneNumberDTO, global::G.CreateTelnyxPhoneNumberDTO>? PhoneNumber { get; set; }

        /// <summary>
        /// This is the type of the message. "transfer-update" is sent whenever a transfer happens.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ServerMessageTransferUpdateType Type { get; set; }

        /// <summary>
        /// This is the destination of the transfer.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("destination")]
        public global::G.OneOf<global::G.TransferDestinationAssistant, global::G.TransferDestinationNumber, global::G.TransferDestinationSip>? Destination { get; set; }

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
        /// This is the assistant that the call is being transferred to. This is only sent if `destination.type` is "assistant".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toAssistant")]
        public global::G.CreateAssistantDTO? ToAssistant { get; set; }

        /// <summary>
        /// This is the assistant that the call is being transferred from. This is only sent if `destination.type` is "assistant".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fromAssistant")]
        public global::G.CreateAssistantDTO? FromAssistant { get; set; }

        /// <summary>
        /// This is the step that the conversation moved to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toStepRecord")]
        public object? ToStepRecord { get; set; }

        /// <summary>
        /// This is the step that the conversation moved from. =
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fromStepRecord")]
        public object? FromStepRecord { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageTransferUpdate" /> class.
        /// </summary>
        /// <param name="phoneNumber">
        /// This is the phone number that the message is associated with.
        /// </param>
        /// <param name="type">
        /// This is the type of the message. "transfer-update" is sent whenever a transfer happens.
        /// </param>
        /// <param name="destination">
        /// This is the destination of the transfer.
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
        /// <param name="toAssistant">
        /// This is the assistant that the call is being transferred to. This is only sent if `destination.type` is "assistant".
        /// </param>
        /// <param name="fromAssistant">
        /// This is the assistant that the call is being transferred from. This is only sent if `destination.type` is "assistant".
        /// </param>
        /// <param name="toStepRecord">
        /// This is the step that the conversation moved to.
        /// </param>
        /// <param name="fromStepRecord">
        /// This is the step that the conversation moved from. =
        /// </param>
        public ServerMessageTransferUpdate(
            global::G.OneOf<global::G.CreateByoPhoneNumberDTO, global::G.CreateTwilioPhoneNumberDTO, global::G.CreateVonagePhoneNumberDTO, global::G.CreateVapiPhoneNumberDTO, global::G.CreateTelnyxPhoneNumberDTO>? phoneNumber,
            global::G.ServerMessageTransferUpdateType type,
            global::G.OneOf<global::G.TransferDestinationAssistant, global::G.TransferDestinationNumber, global::G.TransferDestinationSip>? destination,
            double? timestamp,
            global::G.Artifact? artifact,
            global::G.CreateAssistantDTO? assistant,
            global::G.CreateCustomerDTO? customer,
            global::G.Call? call,
            global::G.Chat? chat,
            global::G.CreateAssistantDTO? toAssistant,
            global::G.CreateAssistantDTO? fromAssistant,
            object? toStepRecord,
            object? fromStepRecord)
        {
            this.PhoneNumber = phoneNumber;
            this.Type = type;
            this.Destination = destination;
            this.Timestamp = timestamp;
            this.Artifact = artifact;
            this.Assistant = assistant;
            this.Customer = customer;
            this.Call = call;
            this.Chat = chat;
            this.ToAssistant = toAssistant;
            this.FromAssistant = fromAssistant;
            this.ToStepRecord = toStepRecord;
            this.FromStepRecord = fromStepRecord;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageTransferUpdate" /> class.
        /// </summary>
        public ServerMessageTransferUpdate()
        {
        }
    }
}