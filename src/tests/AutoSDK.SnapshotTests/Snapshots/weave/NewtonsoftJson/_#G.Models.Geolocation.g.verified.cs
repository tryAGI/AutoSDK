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
        [global::Newtonsoft.Json.JsonProperty("file_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int FileIndex { get; set; } = default!;

        /// <summary>
        /// Start of IP range as integer
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("range_start_int", Required = global::Newtonsoft.Json.Required.Always)]
        public int RangeStartInt { get; set; } = default!;

        /// <summary>
        /// End of IP range as integer
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("range_end_int", Required = global::Newtonsoft.Json.Required.Always)]
        public int RangeEndInt { get; set; } = default!;

        /// <summary>
        /// Start of IP range in dotted decimal notation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("range_start_ip", Required = global::Newtonsoft.Json.Required.Always)]
        public string RangeStartIp { get; set; } = default!;

        /// <summary>
        /// End of IP range in dotted decimal notation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("range_end_ip", Required = global::Newtonsoft.Json.Required.Always)]
        public string RangeEndIp { get; set; } = default!;

        /// <summary>
        /// 2-letter country code in ISO 3166-1 Alpha 2 format
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("country_code", Required = global::Newtonsoft.Json.Required.Always)]
        public string CountryCode { get; set; } = default!;

        /// <summary>
        /// Country name, None if could not be determined
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("country_name")]
        public string? CountryName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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