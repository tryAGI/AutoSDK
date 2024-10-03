//HintName: G.Models.PhoneNumber.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PhoneNumber
    {
        /// <summary>
        /// The raw input as the phone number is present in your raw data set. It will be parsed into the standardized formats if valid.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public string? Input { get; set; }

        /// <summary>
        /// Read-only. Parsed result in the international format (e.g. +49 123 ...)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internationalFormatted")]
        public string? InternationalFormatted { get; set; }

        /// <summary>
        /// Optional. The ISO 3166-1 alpha-2 country code. This is used to figure out the correct countryCode and international format if only a national number (e.g. 0123 4567) is provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultCountry")]
        public string? DefaultCountry { get; set; }

        /// <summary>
        /// Read-only. The numerical country code (e.g. 49)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("countryCode")]
        public double? CountryCode { get; set; }

        /// <summary>
        /// Read-only. The numerical representation of the national part
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("national")]
        public double? National { get; set; }

        /// <summary>
        /// Read-only. Parsed result in the national format (e.g. 0123 456789)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nationalFormatted")]
        public string? NationalFormatted { get; set; }

        /// <summary>
        /// Read-only. Indicates whether the parsed number is a valid phone number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valid")]
        public bool? Valid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}