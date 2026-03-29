//HintName: G.Models.V2PhoneCallResponseVariant1TelephonyIdentifier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Telephony identifier of the call, populated when available. Tracking purposes only.
    /// </summary>
    public sealed partial class V2PhoneCallResponseVariant1TelephonyIdentifier
    {
        /// <summary>
        /// Twilio call sid.<br/>
        /// Example: CA5d0d0d8047bf685c3f0ff980fe62c123
        /// </summary>
        /// <example>CA5d0d0d8047bf685c3f0ff980fe62c123</example>
        [global::Newtonsoft.Json.JsonProperty("twilio_call_sid")]
        public string? TwilioCallSid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V2PhoneCallResponseVariant1TelephonyIdentifier" /> class.
        /// </summary>
        /// <param name="twilioCallSid">
        /// Twilio call sid.<br/>
        /// Example: CA5d0d0d8047bf685c3f0ff980fe62c123
        /// </param>
        public V2PhoneCallResponseVariant1TelephonyIdentifier(
            string? twilioCallSid)
        {
            this.TwilioCallSid = twilioCallSid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2PhoneCallResponseVariant1TelephonyIdentifier" /> class.
        /// </summary>
        public V2PhoneCallResponseVariant1TelephonyIdentifier()
        {
        }
    }
}