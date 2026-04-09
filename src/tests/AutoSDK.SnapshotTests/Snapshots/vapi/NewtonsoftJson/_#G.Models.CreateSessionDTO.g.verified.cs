//HintName: G.Models.CreateSessionDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSessionDTO
    {
        /// <summary>
        /// This is a user-defined name for the session. Maximum length is 40 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the current status of the session. Can be either 'active' or 'completed'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateSessionDTOStatusJsonConverter))]
        public global::G.CreateSessionDTOStatus? Status { get; set; }

        /// <summary>
        /// Session expiration time in seconds. Defaults to 24 hours (86400 seconds) if not set.<br/>
        /// Example: 86400
        /// </summary>
        /// <example>86400</example>
        [global::Newtonsoft.Json.JsonProperty("expirationSeconds")]
        public double? ExpirationSeconds { get; set; }

        /// <summary>
        /// This is the ID of the assistant associated with this session. Use this when referencing an existing assistant.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistantId")]
        public string? AssistantId { get; set; }

        /// <summary>
        /// This is the assistant configuration for this session. Use this when creating a new assistant configuration.<br/>
        /// If assistantId is provided, this will be ignored.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistant")]
        public global::G.CreateAssistantDTO? Assistant { get; set; }

        /// <summary>
        /// These are the overrides for the assistant configuration.<br/>
        /// Use this to provide variable values and other overrides when using assistantId.<br/>
        /// Variable substitution will be applied to the assistant's messages and other text-based fields.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistantOverrides")]
        public global::G.AssistantOverrides? AssistantOverrides { get; set; }

        /// <summary>
        /// This is the squad ID associated with this session. Use this when referencing an existing squad.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("squadId")]
        public string? SquadId { get; set; }

        /// <summary>
        /// This is the squad configuration for this session. Use this when creating a new squad configuration.<br/>
        /// If squadId is provided, this will be ignored.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("squad")]
        public global::G.CreateSquadDTO? Squad { get; set; }

        /// <summary>
        /// This is an array of chat messages in the session.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.SystemMessage, global::G.UserMessage, global::G.AssistantMessage, global::G.ToolMessage, global::G.DeveloperMessage>>? Messages { get; set; }

        /// <summary>
        /// This is the customer information associated with this session.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("customer")]
        public global::G.CreateCustomerDTO? Customer { get; set; }

        /// <summary>
        /// This is the customerId of the customer associated with this session.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("customerId")]
        public string? CustomerId { get; set; }

        /// <summary>
        /// This is the ID of the phone number associated with this session.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phoneNumberId")]
        public string? PhoneNumberId { get; set; }

        /// <summary>
        /// This is the phone number configuration for this session.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phoneNumber")]
        public global::G.ImportTwilioPhoneNumberDTO? PhoneNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSessionDTO" /> class.
        /// </summary>
        /// <param name="name">
        /// This is a user-defined name for the session. Maximum length is 40 characters.
        /// </param>
        /// <param name="status">
        /// This is the current status of the session. Can be either 'active' or 'completed'.
        /// </param>
        /// <param name="expirationSeconds">
        /// Session expiration time in seconds. Defaults to 24 hours (86400 seconds) if not set.<br/>
        /// Example: 86400
        /// </param>
        /// <param name="assistantId">
        /// This is the ID of the assistant associated with this session. Use this when referencing an existing assistant.
        /// </param>
        /// <param name="assistant">
        /// This is the assistant configuration for this session. Use this when creating a new assistant configuration.<br/>
        /// If assistantId is provided, this will be ignored.
        /// </param>
        /// <param name="assistantOverrides">
        /// These are the overrides for the assistant configuration.<br/>
        /// Use this to provide variable values and other overrides when using assistantId.<br/>
        /// Variable substitution will be applied to the assistant's messages and other text-based fields.
        /// </param>
        /// <param name="squadId">
        /// This is the squad ID associated with this session. Use this when referencing an existing squad.
        /// </param>
        /// <param name="squad">
        /// This is the squad configuration for this session. Use this when creating a new squad configuration.<br/>
        /// If squadId is provided, this will be ignored.
        /// </param>
        /// <param name="messages">
        /// This is an array of chat messages in the session.
        /// </param>
        /// <param name="customer">
        /// This is the customer information associated with this session.
        /// </param>
        /// <param name="customerId">
        /// This is the customerId of the customer associated with this session.
        /// </param>
        /// <param name="phoneNumberId">
        /// This is the ID of the phone number associated with this session.
        /// </param>
        /// <param name="phoneNumber">
        /// This is the phone number configuration for this session.
        /// </param>
        public CreateSessionDTO(
            string? name,
            global::G.CreateSessionDTOStatus? status,
            double? expirationSeconds,
            string? assistantId,
            global::G.CreateAssistantDTO? assistant,
            global::G.AssistantOverrides? assistantOverrides,
            string? squadId,
            global::G.CreateSquadDTO? squad,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.SystemMessage, global::G.UserMessage, global::G.AssistantMessage, global::G.ToolMessage, global::G.DeveloperMessage>>? messages,
            global::G.CreateCustomerDTO? customer,
            string? customerId,
            string? phoneNumberId,
            global::G.ImportTwilioPhoneNumberDTO? phoneNumber)
        {
            this.Name = name;
            this.Status = status;
            this.ExpirationSeconds = expirationSeconds;
            this.AssistantId = assistantId;
            this.Assistant = assistant;
            this.AssistantOverrides = assistantOverrides;
            this.SquadId = squadId;
            this.Squad = squad;
            this.Messages = messages;
            this.Customer = customer;
            this.CustomerId = customerId;
            this.PhoneNumberId = phoneNumberId;
            this.PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSessionDTO" /> class.
        /// </summary>
        public CreateSessionDTO()
        {
        }
    }
}