//HintName: G.Models.CreateTwilioPhoneNumberRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

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
        /// This field is deprecated and will be removed in the future. Whether this phone number supports inbound calls<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("supports_inbound")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? SupportsInbound { get; set; }

        /// <summary>
        /// This field is deprecated and will be removed in the future. Whether this phone number supports outbound calls<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("supports_outbound")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? SupportsOutbound { get; set; }

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
        /// Twilio Additional Region Configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("region_config")]
        public global::G.RegionConfigRequest? RegionConfig { get; set; }

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
        /// <param name="sid">
        /// Twilio Account SID
        /// </param>
        /// <param name="token">
        /// Twilio Auth Token
        /// </param>
        /// <param name="provider">
        /// Default Value: twilio
        /// </param>
        /// <param name="regionConfig">
        /// Twilio Additional Region Configuration
        /// </param>
        public CreateTwilioPhoneNumberRequest(
            string phoneNumber,
            string label,
            string sid,
            string token,
            string? provider,
            global::G.RegionConfigRequest? regionConfig)
        {
            this.PhoneNumber = phoneNumber ?? throw new global::System.ArgumentNullException(nameof(phoneNumber));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Provider = provider;
            this.Sid = sid ?? throw new global::System.ArgumentNullException(nameof(sid));
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.RegionConfig = regionConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTwilioPhoneNumberRequest" /> class.
        /// </summary>
        public CreateTwilioPhoneNumberRequest()
        {
        }
    }
}