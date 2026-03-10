//HintName: G.Models.GetWhatsAppAccountResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWhatsAppAccountResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("business_account_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BusinessAccountId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phone_number_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string PhoneNumberId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("business_account_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string BusinessAccountName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phone_number_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string PhoneNumberName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phone_number", Required = global::Newtonsoft.Json.Required.Always)]
        public string PhoneNumber { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assigned_agent_id")]
        public string? AssignedAgentId { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable_messaging")]
        public bool? EnableMessaging { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable_audio_message_response")]
        public bool? EnableAudioMessageResponse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assigned_agent_name")]
        public string? AssignedAgentName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWhatsAppAccountResponse" /> class.
        /// </summary>
        /// <param name="businessAccountId"></param>
        /// <param name="phoneNumberId"></param>
        /// <param name="businessAccountName"></param>
        /// <param name="phoneNumberName"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="assignedAgentId"></param>
        /// <param name="enableMessaging">
        /// Default Value: true
        /// </param>
        /// <param name="enableAudioMessageResponse">
        /// Default Value: true
        /// </param>
        /// <param name="assignedAgentName"></param>
        public GetWhatsAppAccountResponse(
            string businessAccountId,
            string phoneNumberId,
            string businessAccountName,
            string phoneNumberName,
            string phoneNumber,
            string? assignedAgentId,
            bool? enableMessaging,
            bool? enableAudioMessageResponse,
            string? assignedAgentName)
        {
            this.BusinessAccountId = businessAccountId ?? throw new global::System.ArgumentNullException(nameof(businessAccountId));
            this.PhoneNumberId = phoneNumberId ?? throw new global::System.ArgumentNullException(nameof(phoneNumberId));
            this.BusinessAccountName = businessAccountName ?? throw new global::System.ArgumentNullException(nameof(businessAccountName));
            this.PhoneNumberName = phoneNumberName ?? throw new global::System.ArgumentNullException(nameof(phoneNumberName));
            this.PhoneNumber = phoneNumber ?? throw new global::System.ArgumentNullException(nameof(phoneNumber));
            this.AssignedAgentId = assignedAgentId;
            this.EnableMessaging = enableMessaging;
            this.EnableAudioMessageResponse = enableAudioMessageResponse;
            this.AssignedAgentName = assignedAgentName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWhatsAppAccountResponse" /> class.
        /// </summary>
        public GetWhatsAppAccountResponse()
        {
        }
    }
}