//HintName: G.Models.PurchaseNumberRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PurchaseNumberRequest
    {
        /// <summary>
        /// Three-digit area code for the phone number<br/>
        /// Default Value: 415
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("area_code")]
        public string? AreaCode { get; set; }

        /// <summary>
        /// Country code (US or CA; contact support for others)<br/>
        /// Default Value: US
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("country_code")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PurchaseNumberRequestCountryCodeJsonConverter))]
        public global::G.PurchaseNumberRequestCountryCode? CountryCode { get; set; }

        /// <summary>
        /// Exact number in E.164 format (overrides area_code if provided)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseNumberRequest" /> class.
        /// </summary>
        /// <param name="areaCode">
        /// Three-digit area code for the phone number<br/>
        /// Default Value: 415
        /// </param>
        /// <param name="countryCode">
        /// Country code (US or CA; contact support for others)<br/>
        /// Default Value: US
        /// </param>
        /// <param name="phoneNumber">
        /// Exact number in E.164 format (overrides area_code if provided)
        /// </param>
        public PurchaseNumberRequest(
            string? areaCode,
            global::G.PurchaseNumberRequestCountryCode? countryCode,
            string? phoneNumber)
        {
            this.AreaCode = areaCode;
            this.CountryCode = countryCode;
            this.PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseNumberRequest" /> class.
        /// </summary>
        public PurchaseNumberRequest()
        {
        }
    }
}