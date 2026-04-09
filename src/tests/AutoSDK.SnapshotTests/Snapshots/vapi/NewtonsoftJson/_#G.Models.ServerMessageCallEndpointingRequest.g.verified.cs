//HintName: G.Models.ServerMessageCallEndpointingRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServerMessageCallEndpointingRequest
    {
        /// <summary>
        /// This is the phone number that the message is associated with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phoneNumber")]
        public global::G.OneOf<global::G.CreateByoPhoneNumberDTO, global::G.CreateTwilioPhoneNumberDTO, global::G.CreateVonagePhoneNumberDTO, global::G.CreateVapiPhoneNumberDTO, global::G.CreateTelnyxPhoneNumberDTO>? PhoneNumber { get; set; }

        /// <summary>
        /// This is the type of the message. "call.endpointing.request" is sent when using `assistant.startSpeakingPlan.smartEndpointingPlan={ "provider": "custom-endpointing-model" }`.<br/>
        /// Here is what the request will look like:<br/>
        /// POST https://{assistant.startSpeakingPlan.smartEndpointingPlan.server.url}<br/>
        /// Content-Type: application/json<br/>
        /// {<br/>
        ///   "message": {<br/>
        ///     "type": "call.endpointing.request",<br/>
        ///     "messages": [<br/>
        ///       {<br/>
        ///         "role": "user",<br/>
        ///         "message": "Hello, how are you?",<br/>
        ///         "time": 1234567890,<br/>
        ///         "secondsFromStart": 0<br/>
        ///       }<br/>
        ///     ],<br/>
        ///     ...other metadata about the call...<br/>
        ///   }<br/>
        /// }<br/>
        /// The expected response:<br/>
        /// {<br/>
        ///   "timeoutSeconds": 0.5<br/>
        /// }
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ServerMessageCallEndpointingRequestTypeJsonConverter))]
        public global::G.ServerMessageCallEndpointingRequestType Type { get; set; }

        /// <summary>
        /// This is the conversation history at the time of the endpointing request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.UserMessage, global::G.SystemMessage, global::G.BotMessage, global::G.ToolCallMessage, global::G.ToolCallResultMessage>>? Messages { get; set; }

        /// <summary>
        /// This is just `messages` formatted for OpenAI.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messagesOpenAIFormatted", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OpenAIMessage> MessagesOpenAIFormatted { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="ServerMessageCallEndpointingRequest" /> class.
        /// </summary>
        /// <param name="messagesOpenAIFormatted">
        /// This is just `messages` formatted for OpenAI.
        /// </param>
        /// <param name="phoneNumber">
        /// This is the phone number that the message is associated with.
        /// </param>
        /// <param name="type">
        /// This is the type of the message. "call.endpointing.request" is sent when using `assistant.startSpeakingPlan.smartEndpointingPlan={ "provider": "custom-endpointing-model" }`.<br/>
        /// Here is what the request will look like:<br/>
        /// POST https://{assistant.startSpeakingPlan.smartEndpointingPlan.server.url}<br/>
        /// Content-Type: application/json<br/>
        /// {<br/>
        ///   "message": {<br/>
        ///     "type": "call.endpointing.request",<br/>
        ///     "messages": [<br/>
        ///       {<br/>
        ///         "role": "user",<br/>
        ///         "message": "Hello, how are you?",<br/>
        ///         "time": 1234567890,<br/>
        ///         "secondsFromStart": 0<br/>
        ///       }<br/>
        ///     ],<br/>
        ///     ...other metadata about the call...<br/>
        ///   }<br/>
        /// }<br/>
        /// The expected response:<br/>
        /// {<br/>
        ///   "timeoutSeconds": 0.5<br/>
        /// }
        /// </param>
        /// <param name="messages">
        /// This is the conversation history at the time of the endpointing request.
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
        public ServerMessageCallEndpointingRequest(
            global::System.Collections.Generic.IList<global::G.OpenAIMessage> messagesOpenAIFormatted,
            global::G.OneOf<global::G.CreateByoPhoneNumberDTO, global::G.CreateTwilioPhoneNumberDTO, global::G.CreateVonagePhoneNumberDTO, global::G.CreateVapiPhoneNumberDTO, global::G.CreateTelnyxPhoneNumberDTO>? phoneNumber,
            global::G.ServerMessageCallEndpointingRequestType type,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.UserMessage, global::G.SystemMessage, global::G.BotMessage, global::G.ToolCallMessage, global::G.ToolCallResultMessage>>? messages,
            double? timestamp,
            global::G.Artifact? artifact,
            global::G.CreateAssistantDTO? assistant,
            global::G.CreateCustomerDTO? customer,
            global::G.Call? call,
            global::G.Chat? chat)
        {
            this.PhoneNumber = phoneNumber;
            this.Type = type;
            this.Messages = messages;
            this.MessagesOpenAIFormatted = messagesOpenAIFormatted ?? throw new global::System.ArgumentNullException(nameof(messagesOpenAIFormatted));
            this.Timestamp = timestamp;
            this.Artifact = artifact;
            this.Assistant = assistant;
            this.Customer = customer;
            this.Call = call;
            this.Chat = chat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageCallEndpointingRequest" /> class.
        /// </summary>
        public ServerMessageCallEndpointingRequest()
        {
        }
    }
}