//HintName: G.Models.GetPhoneNumberSIPTrunkResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPhoneNumberSIPTrunkResponseModel
    {
        /// <summary>
        /// Phone number
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phone_number", Required = global::Newtonsoft.Json.Required.Always)]
        public string PhoneNumber { get; set; } = default!;

        /// <summary>
        /// Label for the phone number
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label", Required = global::Newtonsoft.Json.Required.Always)]
        public string Label { get; set; } = default!;

        /// <summary>
        /// The ID of the phone number
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phone_number_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string PhoneNumberId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assigned_agent")]
        public global::G.PhoneNumberAgentInfo? AssignedAgent { get; set; }

        /// <summary>
        /// Phone provider<br/>
        /// Default Value: sip_trunk
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.GetPhoneNumberSIPTrunkResponseModelProvider? Provider { get; set; }

        /// <summary>
        /// SIP Trunk configuration details for a phone number
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_config")]
        public global::G.SIPTrunkConfigResponseModel? ProviderConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPhoneNumberSIPTrunkResponseModel" /> class.
        /// </summary>
        /// <param name="phoneNumber">
        /// Phone number
        /// </param>
        /// <param name="label">
        /// Label for the phone number
        /// </param>
        /// <param name="phoneNumberId">
        /// The ID of the phone number
        /// </param>
        /// <param name="assignedAgent"></param>
        /// <param name="provider">
        /// Phone provider<br/>
        /// Default Value: sip_trunk
        /// </param>
        /// <param name="providerConfig">
        /// SIP Trunk configuration details for a phone number
        /// </param>
        public GetPhoneNumberSIPTrunkResponseModel(
            string phoneNumber,
            string label,
            string phoneNumberId,
            global::G.PhoneNumberAgentInfo? assignedAgent,
            global::G.GetPhoneNumberSIPTrunkResponseModelProvider? provider,
            global::G.SIPTrunkConfigResponseModel? providerConfig)
        {
            this.PhoneNumber = phoneNumber ?? throw new global::System.ArgumentNullException(nameof(phoneNumber));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.PhoneNumberId = phoneNumberId ?? throw new global::System.ArgumentNullException(nameof(phoneNumberId));
            this.AssignedAgent = assignedAgent;
            this.Provider = provider;
            this.ProviderConfig = providerConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPhoneNumberSIPTrunkResponseModel" /> class.
        /// </summary>
        public GetPhoneNumberSIPTrunkResponseModel()
        {
        }
    }
}