//HintName: G.Models.VapiPhoneNumber.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VapiPhoneNumber
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
        /// This is to create free SIP phone numbers on Vapi.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.VapiPhoneNumberProvider Provider { get; set; }

        /// <summary>
        /// This is the unique identifier for the phone number.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// This is the unique identifier for the org that this phone number belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("orgId", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrgId { get; set; } = default!;

        /// <summary>
        /// This is the ISO 8601 date-time string of when the phone number was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// This is the ISO 8601 date-time string of when the phone number was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// This is the status of the phone number.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.VapiPhoneNumberStatus? Status { get; set; }

        /// <summary>
        /// These are the digits of the phone number you purchased from Vapi.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("number")]
        public string? Number { get; set; }

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
        /// This is the area code of the phone number to purchase.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("numberDesiredAreaCode")]
        public string? NumberDesiredAreaCode { get; set; }

        /// <summary>
        /// This is the SIP URI of the phone number. You can SIP INVITE this. The assistant attached to this number will answer.<br/>
        /// This is case-insensitive.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sipUri")]
        public string? SipUri { get; set; }

        /// <summary>
        /// This enables authentication for incoming SIP INVITE requests to the `sipUri`.<br/>
        /// If not set, any username/password to the 401 challenge of the SIP INVITE will be accepted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authentication")]
        public global::G.SipAuthentication? Authentication { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VapiPhoneNumber" /> class.
        /// </summary>
        /// <param name="id">
        /// This is the unique identifier for the phone number.
        /// </param>
        /// <param name="orgId">
        /// This is the unique identifier for the org that this phone number belongs to.
        /// </param>
        /// <param name="createdAt">
        /// This is the ISO 8601 date-time string of when the phone number was created.
        /// </param>
        /// <param name="updatedAt">
        /// This is the ISO 8601 date-time string of when the phone number was last updated.
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
        /// This is to create free SIP phone numbers on Vapi.
        /// </param>
        /// <param name="status">
        /// This is the status of the phone number.
        /// </param>
        /// <param name="number">
        /// These are the digits of the phone number you purchased from Vapi.
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
        /// <param name="numberDesiredAreaCode">
        /// This is the area code of the phone number to purchase.
        /// </param>
        /// <param name="sipUri">
        /// This is the SIP URI of the phone number. You can SIP INVITE this. The assistant attached to this number will answer.<br/>
        /// This is case-insensitive.
        /// </param>
        /// <param name="authentication">
        /// This enables authentication for incoming SIP INVITE requests to the `sipUri`.<br/>
        /// If not set, any username/password to the 401 challenge of the SIP INVITE will be accepted.
        /// </param>
        public VapiPhoneNumber(
            string id,
            string orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::G.OneOf<global::G.TransferDestinationNumber, global::G.TransferDestinationSip>? fallbackDestination,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.PhoneNumberHookCallRinging, global::G.PhoneNumberHookCallEnding>>? hooks,
            global::G.VapiPhoneNumberProvider provider,
            global::G.VapiPhoneNumberStatus? status,
            string? number,
            string? name,
            string? assistantId,
            string? workflowId,
            string? squadId,
            global::G.Server? server,
            string? numberDesiredAreaCode,
            string? sipUri,
            global::G.SipAuthentication? authentication)
        {
            this.FallbackDestination = fallbackDestination;
            this.Hooks = hooks;
            this.Provider = provider;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Status = status;
            this.Number = number;
            this.Name = name;
            this.AssistantId = assistantId;
            this.WorkflowId = workflowId;
            this.SquadId = squadId;
            this.Server = server;
            this.NumberDesiredAreaCode = numberDesiredAreaCode;
            this.SipUri = sipUri;
            this.Authentication = authentication;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VapiPhoneNumber" /> class.
        /// </summary>
        public VapiPhoneNumber()
        {
        }
    }
}