﻿//HintName: G.Models.PhoneNumber.g.cs

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

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumber" /> class.
        /// </summary>
        /// <param name="input">
        /// The raw input as the phone number is present in your raw data set. It will be parsed into the standardized formats if valid.
        /// </param>
        /// <param name="internationalFormatted">
        /// Read-only. Parsed result in the international format (e.g. +49 123 ...)
        /// </param>
        /// <param name="defaultCountry">
        /// Optional. The ISO 3166-1 alpha-2 country code. This is used to figure out the correct countryCode and international format if only a national number (e.g. 0123 4567) is provided
        /// </param>
        /// <param name="countryCode">
        /// Read-only. The numerical country code (e.g. 49)
        /// </param>
        /// <param name="national">
        /// Read-only. The numerical representation of the national part
        /// </param>
        /// <param name="nationalFormatted">
        /// Read-only. Parsed result in the national format (e.g. 0123 456789)
        /// </param>
        /// <param name="valid">
        /// Read-only. Indicates whether the parsed number is a valid phone number
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhoneNumber(
            string? input,
            string? internationalFormatted,
            string? defaultCountry,
            double? countryCode,
            double? national,
            string? nationalFormatted,
            bool? valid)
        {
            this.Input = input;
            this.InternationalFormatted = internationalFormatted;
            this.DefaultCountry = defaultCountry;
            this.CountryCode = countryCode;
            this.National = national;
            this.NationalFormatted = nationalFormatted;
            this.Valid = valid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumber" /> class.
        /// </summary>
        public PhoneNumber()
        {
        }
    }
}