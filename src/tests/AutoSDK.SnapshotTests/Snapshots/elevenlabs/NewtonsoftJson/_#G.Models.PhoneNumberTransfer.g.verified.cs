//HintName: G.Models.PhoneNumberTransfer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PhoneNumberTransfer
    {
        /// <summary>
        /// Custom SIP headers to include when transferring the call. Each header can be either a static value or a dynamic variable reference.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_sip_headers")]
        public global::System.Collections.Generic.IList<global::G.CustomSipHeadersItem>? CustomSipHeaders { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transfer_destination")]
        public global::G.TransferDestinationVariant1? TransferDestination { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phone_number")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("condition", Required = global::Newtonsoft.Json.Required.Always)]
        public string Condition { get; set; } = default!;

        /// <summary>
        /// Default Value: conference
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transfer_type")]
        public global::G.TransferTypeEnum? TransferType { get; set; }

        /// <summary>
        /// DTMF digits to send after call connects (e.g., 'ww1234' for extension). Can be either a static value or a dynamic variable reference. Use 'w' for 0.5s pause. Only supported for Twilio transfers.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("post_dial_digits")]
        public global::G.PostDialDigitsVariant1? PostDialDigits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberTransfer" /> class.
        /// </summary>
        /// <param name="customSipHeaders">
        /// Custom SIP headers to include when transferring the call. Each header can be either a static value or a dynamic variable reference.
        /// </param>
        /// <param name="transferDestination"></param>
        /// <param name="condition"></param>
        /// <param name="transferType">
        /// Default Value: conference
        /// </param>
        /// <param name="postDialDigits">
        /// DTMF digits to send after call connects (e.g., 'ww1234' for extension). Can be either a static value or a dynamic variable reference. Use 'w' for 0.5s pause. Only supported for Twilio transfers.
        /// </param>
        public PhoneNumberTransfer(
            string condition,
            global::System.Collections.Generic.IList<global::G.CustomSipHeadersItem>? customSipHeaders,
            global::G.TransferDestinationVariant1? transferDestination,
            global::G.TransferTypeEnum? transferType,
            global::G.PostDialDigitsVariant1? postDialDigits)
        {
            this.Condition = condition ?? throw new global::System.ArgumentNullException(nameof(condition));
            this.CustomSipHeaders = customSipHeaders;
            this.TransferDestination = transferDestination;
            this.TransferType = transferType;
            this.PostDialDigits = postDialDigits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberTransfer" /> class.
        /// </summary>
        public PhoneNumberTransfer()
        {
        }
    }
}