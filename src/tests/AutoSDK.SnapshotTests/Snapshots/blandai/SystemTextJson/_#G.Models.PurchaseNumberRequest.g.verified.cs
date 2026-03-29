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
        [global::System.Text.Json.Serialization.JsonPropertyName("area_code")]
        public string? AreaCode { get; set; }

        /// <summary>
        /// Country code (US or CA; contact support for others)<br/>
        /// Default Value: US
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country_code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PurchaseNumberRequestCountryCodeJsonConverter))]
        public global::G.PurchaseNumberRequestCountryCode? CountryCode { get; set; }

        /// <summary>
        /// Exact number in E.164 format (overrides area_code if provided)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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