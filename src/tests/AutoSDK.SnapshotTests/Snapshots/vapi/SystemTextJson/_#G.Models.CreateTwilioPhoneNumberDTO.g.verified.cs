//HintName: G.Models.CreateTwilioPhoneNumberDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTwilioPhoneNumberDTO
    {
        /// <summary>
        /// This is the fallback destination an inbound call will be transferred to if:<br/>
        /// 1. `assistantId` is not set<br/>
        /// 2. `squadId` is not set<br/>
        /// 3. and, `assistant-request` message to the `serverUrl` fails<br/>
        /// If this is not set and above conditions are met, the inbound call is hung up with an error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallbackDestination")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.TransferDestinationNumber, global::G.TransferDestinationSip>))]
        public global::G.OneOf<global::G.TransferDestinationNumber, global::G.TransferDestinationSip>? FallbackDestination { get; set; }

        /// <summary>
        /// This is the hooks that will be used for incoming calls to this phone number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hooks")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.PhoneNumberHookCallRinging, global::G.PhoneNumberHookCallEnding>>? Hooks { get; set; }

        /// <summary>
        /// This is to use numbers bought on Twilio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateTwilioPhoneNumberDTOProviderJsonConverter))]
        public global::G.CreateTwilioPhoneNumberDTOProvider Provider { get; set; }

        /// <summary>
        /// Controls whether Vapi sets the messaging webhook URL on the Twilio number during import.<br/>
        /// If set to `false`, Vapi will not update the Twilio messaging URL, leaving it as is.<br/>
        /// If `true` or omitted (default), Vapi will configure both the voice and messaging URLs.<br/>
        /// @default true<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smsEnabled")]
        public bool? SmsEnabled { get; set; }

        /// <summary>
        /// These are the digits of the phone number you own on your Twilio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Number { get; set; }

        /// <summary>
        /// This is the Twilio Account SID for the phone number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("twilioAccountSid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TwilioAccountSid { get; set; }

        /// <summary>
        /// This is the Twilio Auth Token for the phone number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("twilioAuthToken")]
        public string? TwilioAuthToken { get; set; }

        /// <summary>
        /// This is the Twilio API Key for the phone number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("twilioApiKey")]
        public string? TwilioApiKey { get; set; }

        /// <summary>
        /// This is the Twilio API Secret for the phone number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("twilioApiSecret")]
        public string? TwilioApiSecret { get; set; }

        /// <summary>
        /// This is the name of the phone number. This is just for your own reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the assistant that will be used for incoming calls to this phone number.<br/>
        /// If neither `assistantId`, `squadId` nor `workflowId` is set, `assistant-request` will be sent to your Server URL. Check `ServerMessage` and `ServerMessageResponse` for the shape of the message and response that is expected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantId")]
        public string? AssistantId { get; set; }

        /// <summary>
        /// This is the workflow that will be used for incoming calls to this phone number.<br/>
        /// If neither `assistantId`, `squadId`, nor `workflowId` is set, `assistant-request` will be sent to your Server URL. Check `ServerMessage` and `ServerMessageResponse` for the shape of the message and response that is expected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflowId")]
        public string? WorkflowId { get; set; }

        /// <summary>
        /// This is the squad that will be used for incoming calls to this phone number.<br/>
        /// If neither `assistantId`, `squadId`, nor `workflowId` is set, `assistant-request` will be sent to your Server URL. Check `ServerMessage` and `ServerMessageResponse` for the shape of the message and response that is expected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("squadId")]
        public string? SquadId { get; set; }

        /// <summary>
        /// This is where Vapi will send webhooks. You can find all webhooks available along with their shape in ServerMessage schema.<br/>
        /// The order of precedence is:<br/>
        /// 1. assistant.server<br/>
        /// 2. phoneNumber.server<br/>
        /// 3. org.server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server")]
        public global::G.Server? Server { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTwilioPhoneNumberDTO" /> class.
        /// </summary>
        /// <param name="number">
        /// These are the digits of the phone number you own on your Twilio.
        /// </param>
        /// <param name="twilioAccountSid">
        /// This is the Twilio Account SID for the phone number.
        /// </param>
        /// <param name="fallbackDestination">
        /// This is the fallback destination an inbound call will be transferred to if:<br/>
        /// 1. `assistantId` is not set<br/>
        /// 2. `squadId` is not set<br/>
        /// 3. and, `assistant-request` message to the `serverUrl` fails<br/>
        /// If this is not set and above conditions are met, the inbound call is hung up with an error message.
        /// </param>
        /// <param name="hooks">
        /// This is the hooks that will be used for incoming calls to this phone number.
        /// </param>
        /// <param name="provider">
        /// This is to use numbers bought on Twilio.
        /// </param>
        /// <param name="smsEnabled">
        /// Controls whether Vapi sets the messaging webhook URL on the Twilio number during import.<br/>
        /// If set to `false`, Vapi will not update the Twilio messaging URL, leaving it as is.<br/>
        /// If `true` or omitted (default), Vapi will configure both the voice and messaging URLs.<br/>
        /// @default true<br/>
        /// Default Value: true
        /// </param>
        /// <param name="twilioAuthToken">
        /// This is the Twilio Auth Token for the phone number.
        /// </param>
        /// <param name="twilioApiKey">
        /// This is the Twilio API Key for the phone number.
        /// </param>
        /// <param name="twilioApiSecret">
        /// This is the Twilio API Secret for the phone number.
        /// </param>
        /// <param name="name">
        /// This is the name of the phone number. This is just for your own reference.
        /// </param>
        /// <param name="assistantId">
        /// This is the assistant that will be used for incoming calls to this phone number.<br/>
        /// If neither `assistantId`, `squadId` nor `workflowId` is set, `assistant-request` will be sent to your Server URL. Check `ServerMessage` and `ServerMessageResponse` for the shape of the message and response that is expected.
        /// </param>
        /// <param name="workflowId">
        /// This is the workflow that will be used for incoming calls to this phone number.<br/>
        /// If neither `assistantId`, `squadId`, nor `workflowId` is set, `assistant-request` will be sent to your Server URL. Check `ServerMessage` and `ServerMessageResponse` for the shape of the message and response that is expected.
        /// </param>
        /// <param name="squadId">
        /// This is the squad that will be used for incoming calls to this phone number.<br/>
        /// If neither `assistantId`, `squadId`, nor `workflowId` is set, `assistant-request` will be sent to your Server URL. Check `ServerMessage` and `ServerMessageResponse` for the shape of the message and response that is expected.
        /// </param>
        /// <param name="server">
        /// This is where Vapi will send webhooks. You can find all webhooks available along with their shape in ServerMessage schema.<br/>
        /// The order of precedence is:<br/>
        /// 1. assistant.server<br/>
        /// 2. phoneNumber.server<br/>
        /// 3. org.server
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTwilioPhoneNumberDTO(
            string number,
            string twilioAccountSid,
            global::G.OneOf<global::G.TransferDestinationNumber, global::G.TransferDestinationSip>? fallbackDestination,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.PhoneNumberHookCallRinging, global::G.PhoneNumberHookCallEnding>>? hooks,
            global::G.CreateTwilioPhoneNumberDTOProvider provider,
            bool? smsEnabled,
            string? twilioAuthToken,
            string? twilioApiKey,
            string? twilioApiSecret,
            string? name,
            string? assistantId,
            string? workflowId,
            string? squadId,
            global::G.Server? server)
        {
            this.FallbackDestination = fallbackDestination;
            this.Hooks = hooks;
            this.Provider = provider;
            this.SmsEnabled = smsEnabled;
            this.Number = number ?? throw new global::System.ArgumentNullException(nameof(number));
            this.TwilioAccountSid = twilioAccountSid ?? throw new global::System.ArgumentNullException(nameof(twilioAccountSid));
            this.TwilioAuthToken = twilioAuthToken;
            this.TwilioApiKey = twilioApiKey;
            this.TwilioApiSecret = twilioApiSecret;
            this.Name = name;
            this.AssistantId = assistantId;
            this.WorkflowId = workflowId;
            this.SquadId = squadId;
            this.Server = server;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTwilioPhoneNumberDTO" /> class.
        /// </summary>
        public CreateTwilioPhoneNumberDTO()
        {
        }
    }
}