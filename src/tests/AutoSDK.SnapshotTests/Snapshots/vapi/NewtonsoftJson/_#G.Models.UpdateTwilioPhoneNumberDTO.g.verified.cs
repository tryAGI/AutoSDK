//HintName: G.Models.UpdateTwilioPhoneNumberDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateTwilioPhoneNumberDTO
    {
        /// <summary>
        /// This is the fallback destination an inbound call will be transferred to if:<br/>
        /// 1. `assistantId` is not set<br/>
        /// 2. `squadId` is not set<br/>
        /// 3. and, `assistant-request` message to the `serverUrl` fails<br/>
        /// If this is not set and above conditions are met, the inbound call is hung up with an error message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fallbackDestination")]
        public global::G.OneOf<global::G.TransferDestinationNumber, global::G.TransferDestinationSip>? FallbackDestination { get; set; }

        /// <summary>
        /// This is the hooks that will be used for incoming calls to this phone number.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hooks")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.PhoneNumberHookCallRinging, global::G.PhoneNumberHookCallEnding>>? Hooks { get; set; }

        /// <summary>
        /// Controls whether Vapi sets the messaging webhook URL on the Twilio number during import.<br/>
        /// If set to `false`, Vapi will not update the Twilio messaging URL, leaving it as is.<br/>
        /// If `true` or omitted (default), Vapi will configure both the voice and messaging URLs.<br/>
        /// @default true<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("smsEnabled")]
        public bool? SmsEnabled { get; set; }

        /// <summary>
        /// This is the name of the phone number. This is just for your own reference.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the assistant that will be used for incoming calls to this phone number.<br/>
        /// If neither `assistantId`, `squadId` nor `workflowId` is set, `assistant-request` will be sent to your Server URL. Check `ServerMessage` and `ServerMessageResponse` for the shape of the message and response that is expected.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistantId")]
        public string? AssistantId { get; set; }

        /// <summary>
        /// This is the workflow that will be used for incoming calls to this phone number.<br/>
        /// If neither `assistantId`, `squadId`, nor `workflowId` is set, `assistant-request` will be sent to your Server URL. Check `ServerMessage` and `ServerMessageResponse` for the shape of the message and response that is expected.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflowId")]
        public string? WorkflowId { get; set; }

        /// <summary>
        /// This is the squad that will be used for incoming calls to this phone number.<br/>
        /// If neither `assistantId`, `squadId`, nor `workflowId` is set, `assistant-request` will be sent to your Server URL. Check `ServerMessage` and `ServerMessageResponse` for the shape of the message and response that is expected.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("squadId")]
        public string? SquadId { get; set; }

        /// <summary>
        /// This is where Vapi will send webhooks. You can find all webhooks available along with their shape in ServerMessage schema.<br/>
        /// The order of precedence is:<br/>
        /// 1. assistant.server<br/>
        /// 2. phoneNumber.server<br/>
        /// 3. org.server
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server")]
        public global::G.Server? Server { get; set; }

        /// <summary>
        /// These are the digits of the phone number you own on your Twilio.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("number")]
        public string? Number { get; set; }

        /// <summary>
        /// This is the Twilio Account SID for the phone number.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("twilioAccountSid")]
        public string? TwilioAccountSid { get; set; }

        /// <summary>
        /// This is the Twilio Auth Token for the phone number.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("twilioAuthToken")]
        public string? TwilioAuthToken { get; set; }

        /// <summary>
        /// This is the Twilio API Key for the phone number.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("twilioApiKey")]
        public string? TwilioApiKey { get; set; }

        /// <summary>
        /// This is the Twilio API Secret for the phone number.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("twilioApiSecret")]
        public string? TwilioApiSecret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTwilioPhoneNumberDTO" /> class.
        /// </summary>
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
        /// <param name="smsEnabled">
        /// Controls whether Vapi sets the messaging webhook URL on the Twilio number during import.<br/>
        /// If set to `false`, Vapi will not update the Twilio messaging URL, leaving it as is.<br/>
        /// If `true` or omitted (default), Vapi will configure both the voice and messaging URLs.<br/>
        /// @default true<br/>
        /// Default Value: true
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
        /// <param name="number">
        /// These are the digits of the phone number you own on your Twilio.
        /// </param>
        /// <param name="twilioAccountSid">
        /// This is the Twilio Account SID for the phone number.
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
        public UpdateTwilioPhoneNumberDTO(
            global::G.OneOf<global::G.TransferDestinationNumber, global::G.TransferDestinationSip>? fallbackDestination,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.PhoneNumberHookCallRinging, global::G.PhoneNumberHookCallEnding>>? hooks,
            bool? smsEnabled,
            string? name,
            string? assistantId,
            string? workflowId,
            string? squadId,
            global::G.Server? server,
            string? number,
            string? twilioAccountSid,
            string? twilioAuthToken,
            string? twilioApiKey,
            string? twilioApiSecret)
        {
            this.FallbackDestination = fallbackDestination;
            this.Hooks = hooks;
            this.SmsEnabled = smsEnabled;
            this.Name = name;
            this.AssistantId = assistantId;
            this.WorkflowId = workflowId;
            this.SquadId = squadId;
            this.Server = server;
            this.Number = number;
            this.TwilioAccountSid = twilioAccountSid;
            this.TwilioAuthToken = twilioAuthToken;
            this.TwilioApiKey = twilioApiKey;
            this.TwilioApiSecret = twilioApiSecret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTwilioPhoneNumberDTO" /> class.
        /// </summary>
        public UpdateTwilioPhoneNumberDTO()
        {
        }
    }
}