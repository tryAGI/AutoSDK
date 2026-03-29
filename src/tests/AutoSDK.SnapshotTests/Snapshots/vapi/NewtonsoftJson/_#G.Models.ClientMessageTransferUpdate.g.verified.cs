//HintName: G.Models.ClientMessageTransferUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClientMessageTransferUpdate
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
        public global::G.ClientMessageTransferUpdateType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="ClientMessageTransferUpdate" /> class.
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
        /// <param name="call">
        /// This is the call that the message is associated with.
        /// </param>
        /// <param name="customer">
        /// This is the customer that the message is associated with.
        /// </param>
        /// <param name="assistant">
        /// This is the assistant that the message is associated with.
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
        public ClientMessageTransferUpdate(
            global::G.OneOf<global::G.CreateByoPhoneNumberDTO, global::G.CreateTwilioPhoneNumberDTO, global::G.CreateVonagePhoneNumberDTO, global::G.CreateVapiPhoneNumberDTO, global::G.CreateTelnyxPhoneNumberDTO>? phoneNumber,
            global::G.ClientMessageTransferUpdateType type,
            global::G.OneOf<global::G.TransferDestinationAssistant, global::G.TransferDestinationNumber, global::G.TransferDestinationSip>? destination,
            double? timestamp,
            global::G.Call? call,
            global::G.CreateCustomerDTO? customer,
            global::G.CreateAssistantDTO? assistant,
            global::G.CreateAssistantDTO? toAssistant,
            global::G.CreateAssistantDTO? fromAssistant,
            object? toStepRecord,
            object? fromStepRecord)
        {
            this.PhoneNumber = phoneNumber;
            this.Type = type;
            this.Destination = destination;
            this.Timestamp = timestamp;
            this.Call = call;
            this.Customer = customer;
            this.Assistant = assistant;
            this.ToAssistant = toAssistant;
            this.FromAssistant = fromAssistant;
            this.ToStepRecord = toStepRecord;
            this.FromStepRecord = fromStepRecord;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientMessageTransferUpdate" /> class.
        /// </summary>
        public ClientMessageTransferUpdate()
        {
        }
    }
}