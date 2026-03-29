//HintName: G.Models.V2PhoneCallResponseVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V2PhoneCallResponseVariant1
    {
        /// <summary>
        /// Type of the call. Used to distinguish between web call and phone call.<br/>
        /// Example: phone_call
        /// </summary>
        /// <example>phone_call</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.V2PhoneCallResponseVariant1CallTypeJsonConverter))]
        public global::G.V2PhoneCallResponseVariant1CallType CallType { get; set; }

        /// <summary>
        /// The caller number.<br/>
        /// Example: +12137771234
        /// </summary>
        /// <example>+12137771234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FromNumber { get; set; }

        /// <summary>
        /// The callee number.<br/>
        /// Example: +12137771235
        /// </summary>
        /// <example>+12137771235</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("to_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToNumber { get; set; }

        /// <summary>
        /// Direction of the phone call.<br/>
        /// Example: inbound
        /// </summary>
        /// <example>inbound</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.V2PhoneCallResponseVariant1DirectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.V2PhoneCallResponseVariant1Direction Direction { get; set; }

        /// <summary>
        /// Telephony identifier of the call, populated when available. Tracking purposes only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("telephony_identifier")]
        public global::G.V2PhoneCallResponseVariant1TelephonyIdentifier? TelephonyIdentifier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V2PhoneCallResponseVariant1" /> class.
        /// </summary>
        /// <param name="fromNumber">
        /// The caller number.<br/>
        /// Example: +12137771234
        /// </param>
        /// <param name="toNumber">
        /// The callee number.<br/>
        /// Example: +12137771235
        /// </param>
        /// <param name="direction">
        /// Direction of the phone call.<br/>
        /// Example: inbound
        /// </param>
        /// <param name="callType">
        /// Type of the call. Used to distinguish between web call and phone call.<br/>
        /// Example: phone_call
        /// </param>
        /// <param name="telephonyIdentifier">
        /// Telephony identifier of the call, populated when available. Tracking purposes only.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V2PhoneCallResponseVariant1(
            string fromNumber,
            string toNumber,
            global::G.V2PhoneCallResponseVariant1Direction direction,
            global::G.V2PhoneCallResponseVariant1CallType callType,
            global::G.V2PhoneCallResponseVariant1TelephonyIdentifier? telephonyIdentifier)
        {
            this.CallType = callType;
            this.FromNumber = fromNumber ?? throw new global::System.ArgumentNullException(nameof(fromNumber));
            this.ToNumber = toNumber ?? throw new global::System.ArgumentNullException(nameof(toNumber));
            this.Direction = direction;
            this.TelephonyIdentifier = telephonyIdentifier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2PhoneCallResponseVariant1" /> class.
        /// </summary>
        public V2PhoneCallResponseVariant1()
        {
        }
    }
}