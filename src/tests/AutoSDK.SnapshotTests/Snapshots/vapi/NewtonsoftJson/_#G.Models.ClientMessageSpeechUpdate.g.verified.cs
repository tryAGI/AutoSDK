//HintName: G.Models.ClientMessageSpeechUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClientMessageSpeechUpdate
    {
        /// <summary>
        /// This is the phone number that the message is associated with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phoneNumber")]
        public global::G.OneOf<global::G.CreateByoPhoneNumberDTO, global::G.CreateTwilioPhoneNumberDTO, global::G.CreateVonagePhoneNumberDTO, global::G.CreateVapiPhoneNumberDTO, global::G.CreateTelnyxPhoneNumberDTO>? PhoneNumber { get; set; }

        /// <summary>
        /// This is the type of the message. "speech-update" is sent whenever assistant or user start or stop speaking.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ClientMessageSpeechUpdateType Type { get; set; }

        /// <summary>
        /// This is the status of the speech update.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ClientMessageSpeechUpdateStatus Status { get; set; } = default!;

        /// <summary>
        /// This is the role which the speech update is for.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ClientMessageSpeechUpdateRole Role { get; set; } = default!;

        /// <summary>
        /// This is the turn number of the speech update (0-indexed).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("turn")]
        public double? Turn { get; set; }

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
        /// Initializes a new instance of the <see cref="ClientMessageSpeechUpdate" /> class.
        /// </summary>
        /// <param name="status">
        /// This is the status of the speech update.
        /// </param>
        /// <param name="role">
        /// This is the role which the speech update is for.
        /// </param>
        /// <param name="phoneNumber">
        /// This is the phone number that the message is associated with.
        /// </param>
        /// <param name="type">
        /// This is the type of the message. "speech-update" is sent whenever assistant or user start or stop speaking.
        /// </param>
        /// <param name="turn">
        /// This is the turn number of the speech update (0-indexed).
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
        public ClientMessageSpeechUpdate(
            global::G.ClientMessageSpeechUpdateStatus status,
            global::G.ClientMessageSpeechUpdateRole role,
            global::G.OneOf<global::G.CreateByoPhoneNumberDTO, global::G.CreateTwilioPhoneNumberDTO, global::G.CreateVonagePhoneNumberDTO, global::G.CreateVapiPhoneNumberDTO, global::G.CreateTelnyxPhoneNumberDTO>? phoneNumber,
            global::G.ClientMessageSpeechUpdateType type,
            double? turn,
            double? timestamp,
            global::G.Call? call,
            global::G.CreateCustomerDTO? customer,
            global::G.CreateAssistantDTO? assistant)
        {
            this.PhoneNumber = phoneNumber;
            this.Type = type;
            this.Status = status;
            this.Role = role;
            this.Turn = turn;
            this.Timestamp = timestamp;
            this.Call = call;
            this.Customer = customer;
            this.Assistant = assistant;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientMessageSpeechUpdate" /> class.
        /// </summary>
        public ClientMessageSpeechUpdate()
        {
        }
    }
}