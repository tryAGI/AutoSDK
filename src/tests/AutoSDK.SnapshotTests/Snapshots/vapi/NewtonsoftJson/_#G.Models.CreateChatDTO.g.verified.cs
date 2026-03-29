//HintName: G.Models.CreateChatDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateChatDTO
    {
        /// <summary>
        /// This is the assistant that will be used for the chat. To use an existing assistant, use `assistantId` instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistantId")]
        public string? AssistantId { get; set; }

        /// <summary>
        /// This is the assistant that will be used for the chat. To use an existing assistant, use `assistantId` instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistant")]
        public global::G.CreateAssistantDTO? Assistant { get; set; }

        /// <summary>
        /// These are the variable values that will be used to replace template variables in the assistant messages.<br/>
        /// Only variable substitution is supported in chat contexts - other assistant properties cannot be overridden.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistantOverrides")]
        public global::G.AssistantOverrides? AssistantOverrides { get; set; }

        /// <summary>
        /// This is the squad that will be used for the chat. To use a transient squad, use `squad` instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("squadId")]
        public string? SquadId { get; set; }

        /// <summary>
        /// This is the squad that will be used for the chat. To use an existing squad, use `squadId` instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("squad")]
        public global::G.CreateSquadDTO? Squad { get; set; }

        /// <summary>
        /// This is the name of the chat. This is just for your own reference.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the ID of the session that will be used for the chat.<br/>
        /// Mutually exclusive with previousChatId.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sessionId")]
        public string? SessionId { get; set; }

        /// <summary>
        /// This is the input text for the chat.<br/>
        /// Can be a string or an array of chat messages.<br/>
        /// This field is REQUIRED for chat creation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.OneOf<global::G.SystemMessage, global::G.UserMessage, global::G.AssistantMessage, global::G.ToolMessage, global::G.DeveloperMessage>>> Input { get; set; } = default!;

        /// <summary>
        /// This is a flag that determines whether the response should be streamed.<br/>
        /// When true, the response will be sent as chunks of text.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// This is the ID of the chat that will be used as context for the new chat.<br/>
        /// The messages from the previous chat will be used as context.<br/>
        /// Mutually exclusive with sessionId.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("previousChatId")]
        public string? PreviousChatId { get; set; }

        /// <summary>
        /// This is used to send the chat through a transport like SMS.<br/>
        /// If transport.phoneNumberId and transport.customer are provided, creates a new session.<br/>
        /// If sessionId is provided without transport fields, uses existing session data.<br/>
        /// Cannot specify both sessionId and transport fields (phoneNumberId/customer) together.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transport")]
        public global::G.TwilioSMSChatTransport? Transport { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatDTO" /> class.
        /// </summary>
        /// <param name="input">
        /// This is the input text for the chat.<br/>
        /// Can be a string or an array of chat messages.<br/>
        /// This field is REQUIRED for chat creation.
        /// </param>
        /// <param name="assistantId">
        /// This is the assistant that will be used for the chat. To use an existing assistant, use `assistantId` instead.
        /// </param>
        /// <param name="assistant">
        /// This is the assistant that will be used for the chat. To use an existing assistant, use `assistantId` instead.
        /// </param>
        /// <param name="assistantOverrides">
        /// These are the variable values that will be used to replace template variables in the assistant messages.<br/>
        /// Only variable substitution is supported in chat contexts - other assistant properties cannot be overridden.
        /// </param>
        /// <param name="squadId">
        /// This is the squad that will be used for the chat. To use a transient squad, use `squad` instead.
        /// </param>
        /// <param name="squad">
        /// This is the squad that will be used for the chat. To use an existing squad, use `squadId` instead.
        /// </param>
        /// <param name="name">
        /// This is the name of the chat. This is just for your own reference.
        /// </param>
        /// <param name="sessionId">
        /// This is the ID of the session that will be used for the chat.<br/>
        /// Mutually exclusive with previousChatId.
        /// </param>
        /// <param name="stream">
        /// This is a flag that determines whether the response should be streamed.<br/>
        /// When true, the response will be sent as chunks of text.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="previousChatId">
        /// This is the ID of the chat that will be used as context for the new chat.<br/>
        /// The messages from the previous chat will be used as context.<br/>
        /// Mutually exclusive with sessionId.
        /// </param>
        /// <param name="transport">
        /// This is used to send the chat through a transport like SMS.<br/>
        /// If transport.phoneNumberId and transport.customer are provided, creates a new session.<br/>
        /// If sessionId is provided without transport fields, uses existing session data.<br/>
        /// Cannot specify both sessionId and transport fields (phoneNumberId/customer) together.
        /// </param>
        public CreateChatDTO(
            global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.OneOf<global::G.SystemMessage, global::G.UserMessage, global::G.AssistantMessage, global::G.ToolMessage, global::G.DeveloperMessage>>> input,
            string? assistantId,
            global::G.CreateAssistantDTO? assistant,
            global::G.AssistantOverrides? assistantOverrides,
            string? squadId,
            global::G.CreateSquadDTO? squad,
            string? name,
            string? sessionId,
            bool? stream,
            string? previousChatId,
            global::G.TwilioSMSChatTransport? transport)
        {
            this.AssistantId = assistantId;
            this.Assistant = assistant;
            this.AssistantOverrides = assistantOverrides;
            this.SquadId = squadId;
            this.Squad = squad;
            this.Name = name;
            this.SessionId = sessionId;
            this.Input = input;
            this.Stream = stream;
            this.PreviousChatId = previousChatId;
            this.Transport = transport;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatDTO" /> class.
        /// </summary>
        public CreateChatDTO()
        {
        }
    }
}