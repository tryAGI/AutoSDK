//HintName: G.Models.Geolocation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Geolocation
    {
        /// <summary>
        /// row in CSV file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FileIndex { get; set; }

        /// <summary>
        /// Start of IP range as integer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("range_start_int")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RangeStartInt { get; set; }

        /// <summary>
        /// End of IP range as integer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("range_end_int")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RangeEndInt { get; set; }

        /// <summary>
        /// Start of IP range in dotted decimal notation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("range_start_ip")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RangeStartIp { get; set; }

        /// <summary>
        /// End of IP range in dotted decimal notation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("range_end_ip")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RangeEndIp { get; set; }

        /// <summary>
        /// 2-letter country code in ISO 3166-1 Alpha 2 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CountryCode { get; set; }

        /// <summary>
        /// Country name, None if could not be determined
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country_name")]
        public string? CountryName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Geolocation" /> class.
        /// </summary>
        /// <param name="fileIndex">
        /// row in CSV file
        /// </param>
        /// <param name="rangeStartInt">
        /// Start of IP range as integer
        /// </param>
        /// <param name="rangeEndInt">
        /// End of IP range as integer
        /// </param>
        /// <param name="rangeStartIp">
        /// Start of IP range in dotted decimal notation
        /// </param>
        /// <param name="rangeEndIp">
        /// End of IP range in dotted decimal notation
        /// </param>
        /// <param name="countryCode">
        /// 2-letter country code in ISO 3166-1 Alpha 2 format
        /// </param>
        /// <param name="countryName">
        /// Country name, None if could not be determined
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Geolocation(
            int fileIndex,
            int rangeStartInt,
            int rangeEndInt,
            string rangeStartIp,
            string rangeEndIp,
            string countryCode,
            string? countryName)
        {
            this.FileIndex = fileIndex;
            this.RangeStartInt = rangeStartInt;
            this.RangeEndInt = rangeEndInt;
            this.RangeStartIp = rangeStartIp ?? throw new global::System.ArgumentNullException(nameof(rangeStartIp));
            this.RangeEndIp = rangeEndIp ?? throw new global::System.ArgumentNullException(nameof(rangeEndIp));
            this.CountryCode = countryCode ?? throw new global::System.ArgumentNullException(nameof(countryCode));
            this.CountryName = countryName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Geolocation" /> class.
        /// </summary>
        public Geolocation()
        {
        }
    }
}