//HintName: G.Models.GetPhoneNumberResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPhoneNumberResponseModel
    {
        /// <summary>
        /// Phone number
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phone_number", Required = global::Newtonsoft.Json.Required.Always)]
        public string PhoneNumber { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TelephonyProvider Provider { get; set; } = default!;

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPhoneNumberResponseModel" /> class.
        /// </summary>
        /// <param name="phoneNumber">
        /// Phone number
        /// </param>
        /// <param name="provider"></param>
        /// <param name="label">
        /// Label for the phone number
        /// </param>
        /// <param name="phoneNumberId">
        /// The ID of the phone number
        /// </param>
        /// <param name="assignedAgent"></param>
        public GetPhoneNumberResponseModel(
            string phoneNumber,
            global::G.TelephonyProvider provider,
            string label,
            string phoneNumberId,
            global::G.PhoneNumberAgentInfo? assignedAgent)
        {
            this.PhoneNumber = phoneNumber ?? throw new global::System.ArgumentNullException(nameof(phoneNumber));
            this.Provider = provider;
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.PhoneNumberId = phoneNumberId ?? throw new global::System.ArgumentNullException(nameof(phoneNumberId));
            this.AssignedAgent = assignedAgent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPhoneNumberResponseModel" /> class.
        /// </summary>
        public GetPhoneNumberResponseModel()
        {
        }
    }
}