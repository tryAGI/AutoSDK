//HintName: G.Models.CreateWebChatDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWebChatDTO
    {
        /// <summary>
        /// This is the assistant ID to use for this chat. To use a transient assistant, use `assistant` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantId")]
        public string? AssistantId { get; set; }

        /// <summary>
        /// This is the transient assistant configuration for this chat. To use an existing assistant, use `assistantId` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistant")]
        public global::G.CreateAssistantDTO? Assistant { get; set; }

        /// <summary>
        /// This is the ID of the session that will be used for the chat.<br/>
        /// If provided, the conversation will continue from the previous state.<br/>
        /// If not provided or expired, a new session will be created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionId")]
        public string? SessionId { get; set; }

        /// <summary>
        /// This is the expiration time for the session. This can ONLY be set if starting a new chat and therefore a new session is created.<br/>
        /// If session already exists, this will be ignored and NOT be updated for the existing session. Use PATCH /session/:id to update the session expiration time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionExpirationSeconds")]
        public double? SessionExpirationSeconds { get; set; }

        /// <summary>
        /// These are the variable values that will be used to replace template variables in the assistant messages.<br/>
        /// Only variable substitution is supported in web chat - other assistant properties cannot be overridden.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantOverrides")]
        public global::G.ChatAssistantOverrides? AssistantOverrides { get; set; }

        /// <summary>
        /// This is the customer information for the chat.<br/>
        /// Used to automatically manage sessions for repeat customers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer")]
        public global::G.CreateWebCustomerDTO? Customer { get; set; }

        /// <summary>
        /// This is the input text for the chat.<br/>
        /// Can be a string or an array of chat messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.OneOf<global::G.SystemMessage, global::G.UserMessage, global::G.AssistantMessage, global::G.ToolMessage, global::G.DeveloperMessage>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.OneOf<global::G.SystemMessage, global::G.UserMessage, global::G.AssistantMessage, global::G.ToolMessage, global::G.DeveloperMessage>>> Input { get; set; }

        /// <summary>
        /// This is a flag that determines whether the response should be streamed.<br/>
        /// When true, the response will be sent as chunks of text.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// This is a flag to indicate end of session. When true, the session will be marked as completed and the chat will be ended.<br/>
        /// Used to end session to send End-of-session report to the customer.<br/>
        /// When flag is set to true, any messages sent will not be processed and session will directly be marked as completed.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionEnd")]
        public bool? SessionEnd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebChatDTO" /> class.
        /// </summary>
        /// <param name="input">
        /// This is the input text for the chat.<br/>
        /// Can be a string or an array of chat messages.
        /// </param>
        /// <param name="assistantId">
        /// This is the assistant ID to use for this chat. To use a transient assistant, use `assistant` instead.
        /// </param>
        /// <param name="assistant">
        /// This is the transient assistant configuration for this chat. To use an existing assistant, use `assistantId` instead.
        /// </param>
        /// <param name="sessionId">
        /// This is the ID of the session that will be used for the chat.<br/>
        /// If provided, the conversation will continue from the previous state.<br/>
        /// If not provided or expired, a new session will be created.
        /// </param>
        /// <param name="sessionExpirationSeconds">
        /// This is the expiration time for the session. This can ONLY be set if starting a new chat and therefore a new session is created.<br/>
        /// If session already exists, this will be ignored and NOT be updated for the existing session. Use PATCH /session/:id to update the session expiration time.
        /// </param>
        /// <param name="assistantOverrides">
        /// These are the variable values that will be used to replace template variables in the assistant messages.<br/>
        /// Only variable substitution is supported in web chat - other assistant properties cannot be overridden.
        /// </param>
        /// <param name="customer">
        /// This is the customer information for the chat.<br/>
        /// Used to automatically manage sessions for repeat customers.
        /// </param>
        /// <param name="stream">
        /// This is a flag that determines whether the response should be streamed.<br/>
        /// When true, the response will be sent as chunks of text.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="sessionEnd">
        /// This is a flag to indicate end of session. When true, the session will be marked as completed and the chat will be ended.<br/>
        /// Used to end session to send End-of-session report to the customer.<br/>
        /// When flag is set to true, any messages sent will not be processed and session will directly be marked as completed.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWebChatDTO(
            global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.OneOf<global::G.SystemMessage, global::G.UserMessage, global::G.AssistantMessage, global::G.ToolMessage, global::G.DeveloperMessage>>> input,
            string? assistantId,
            global::G.CreateAssistantDTO? assistant,
            string? sessionId,
            double? sessionExpirationSeconds,
            global::G.ChatAssistantOverrides? assistantOverrides,
            global::G.CreateWebCustomerDTO? customer,
            bool? stream,
            bool? sessionEnd)
        {
            this.AssistantId = assistantId;
            this.Assistant = assistant;
            this.SessionId = sessionId;
            this.SessionExpirationSeconds = sessionExpirationSeconds;
            this.AssistantOverrides = assistantOverrides;
            this.Customer = customer;
            this.Input = input;
            this.Stream = stream;
            this.SessionEnd = sessionEnd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebChatDTO" /> class.
        /// </summary>
        public CreateWebChatDTO()
        {
        }
    }
}