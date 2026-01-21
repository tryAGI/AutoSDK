//HintName: G.Models.CreateTwilioPhoneNumberRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTwilioPhoneNumberRequest
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
        /// Default Value: twilio
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// Twilio Account SID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sid", Required = global::Newtonsoft.Json.Required.Always)]
        public string Sid { get; set; } = default!;

        /// <summary>
        /// Twilio Auth Token
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token", Required = global::Newtonsoft.Json.Required.Always)]
        public string Token { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTwilioPhoneNumberRequest" /> class.
        /// </summary>
        /// <param name="phoneNumber">
        /// Phone number
        /// </param>
        /// <param name="label">
        /// Label for the phone number
        /// </param>
        /// <param name="provider">
        /// Default Value: twilio
        /// </param>
        /// <param name="sid">
        /// Twilio Account SID
        /// </param>
        /// <param name="token">
        /// Twilio Auth Token
        /// </param>
        public CreateTwilioPhoneNumberRequest(
            string phoneNumber,
            string label,
            string sid,
            string token,
            string? provider)
        {
            this.PhoneNumber = phoneNumber ?? throw new global::System.ArgumentNullException(nameof(phoneNumber));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Sid = sid ?? throw new global::System.ArgumentNullException(nameof(sid));
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTwilioPhoneNumberRequest" /> class.
        /// </summary>
        public CreateTwilioPhoneNumberRequest()
        {
        }
    }
}