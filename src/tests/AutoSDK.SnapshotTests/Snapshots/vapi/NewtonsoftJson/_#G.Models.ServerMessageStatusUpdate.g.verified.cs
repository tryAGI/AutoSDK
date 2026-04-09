//HintName: G.Models.ServerMessageStatusUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServerMessageStatusUpdate
    {
        /// <summary>
        /// This is the phone number that the message is associated with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phoneNumber")]
        public global::G.OneOf<global::G.CreateByoPhoneNumberDTO, global::G.CreateTwilioPhoneNumberDTO, global::G.CreateVonagePhoneNumberDTO, global::G.CreateVapiPhoneNumberDTO, global::G.CreateTelnyxPhoneNumberDTO>? PhoneNumber { get; set; }

        /// <summary>
        /// This is the type of the message. "status-update" is sent whenever the `call.status` changes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ServerMessageStatusUpdateTypeJsonConverter))]
        public global::G.ServerMessageStatusUpdateType Type { get; set; }

        /// <summary>
        /// This is the status of the call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ServerMessageStatusUpdateStatusJsonConverter))]
        public global::G.ServerMessageStatusUpdateStatus Status { get; set; } = default!;

        /// <summary>
        /// This is the reason the call ended. This is only sent if the status is "ended".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endedReason")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ServerMessageStatusUpdateEndedReasonJsonConverter))]
        public global::G.ServerMessageStatusUpdateEndedReason? EndedReason { get; set; }

        /// <summary>
        /// These are the conversation messages of the call. This is only sent if the status is "forwarding".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.UserMessage, global::G.SystemMessage, global::G.BotMessage, global::G.ToolCallMessage, global::G.ToolCallResultMessage>>? Messages { get; set; }

        /// <summary>
        /// These are the conversation messages of the call. This is only sent if the status is "forwarding".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messagesOpenAIFormatted")]
        public global::System.Collections.Generic.IList<global::G.OpenAIMessage>? MessagesOpenAIFormatted { get; set; }

        /// <summary>
        /// This is the destination the call is being transferred to. This is only sent if the status is "forwarding".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("destination")]
        public global::G.OneOf<global::G.TransferDestinationNumber, global::G.TransferDestinationSip>? Destination { get; set; }

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
        /// This is the transcript of the call. This is only sent if the status is "forwarding".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// This is the summary of the call. This is only sent if the status is "forwarding".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// This is the inbound phone call debugging artifacts. This is only sent if the status is "ended" and there was an error accepting the inbound phone call.<br/>
        /// This will include any errors related to the "assistant-request" if one was made.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inboundPhoneCallDebuggingArtifacts")]
        public object? InboundPhoneCallDebuggingArtifacts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageStatusUpdate" /> class.
        /// </summary>
        /// <param name="status">
        /// This is the status of the call.
        /// </param>
        /// <param name="phoneNumber">
        /// This is the phone number that the message is associated with.
        /// </param>
        /// <param name="type">
        /// This is the type of the message. "status-update" is sent whenever the `call.status` changes.
        /// </param>
        /// <param name="endedReason">
        /// This is the reason the call ended. This is only sent if the status is "ended".
        /// </param>
        /// <param name="messages">
        /// These are the conversation messages of the call. This is only sent if the status is "forwarding".
        /// </param>
        /// <param name="messagesOpenAIFormatted">
        /// These are the conversation messages of the call. This is only sent if the status is "forwarding".
        /// </param>
        /// <param name="destination">
        /// This is the destination the call is being transferred to. This is only sent if the status is "forwarding".
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
        /// <param name="transcript">
        /// This is the transcript of the call. This is only sent if the status is "forwarding".
        /// </param>
        /// <param name="summary">
        /// This is the summary of the call. This is only sent if the status is "forwarding".
        /// </param>
        /// <param name="inboundPhoneCallDebuggingArtifacts">
        /// This is the inbound phone call debugging artifacts. This is only sent if the status is "ended" and there was an error accepting the inbound phone call.<br/>
        /// This will include any errors related to the "assistant-request" if one was made.
        /// </param>
        public ServerMessageStatusUpdate(
            global::G.ServerMessageStatusUpdateStatus status,
            global::G.OneOf<global::G.CreateByoPhoneNumberDTO, global::G.CreateTwilioPhoneNumberDTO, global::G.CreateVonagePhoneNumberDTO, global::G.CreateVapiPhoneNumberDTO, global::G.CreateTelnyxPhoneNumberDTO>? phoneNumber,
            global::G.ServerMessageStatusUpdateType type,
            global::G.ServerMessageStatusUpdateEndedReason? endedReason,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.UserMessage, global::G.SystemMessage, global::G.BotMessage, global::G.ToolCallMessage, global::G.ToolCallResultMessage>>? messages,
            global::System.Collections.Generic.IList<global::G.OpenAIMessage>? messagesOpenAIFormatted,
            global::G.OneOf<global::G.TransferDestinationNumber, global::G.TransferDestinationSip>? destination,
            double? timestamp,
            global::G.Artifact? artifact,
            global::G.CreateAssistantDTO? assistant,
            global::G.CreateCustomerDTO? customer,
            global::G.Call? call,
            global::G.Chat? chat,
            string? transcript,
            string? summary,
            object? inboundPhoneCallDebuggingArtifacts)
        {
            this.PhoneNumber = phoneNumber;
            this.Type = type;
            this.Status = status;
            this.EndedReason = endedReason;
            this.Messages = messages;
            this.MessagesOpenAIFormatted = messagesOpenAIFormatted;
            this.Destination = destination;
            this.Timestamp = timestamp;
            this.Artifact = artifact;
            this.Assistant = assistant;
            this.Customer = customer;
            this.Call = call;
            this.Chat = chat;
            this.Transcript = transcript;
            this.Summary = summary;
            this.InboundPhoneCallDebuggingArtifacts = inboundPhoneCallDebuggingArtifacts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageStatusUpdate" /> class.
        /// </summary>
        public ServerMessageStatusUpdate()
        {
        }
    }
}