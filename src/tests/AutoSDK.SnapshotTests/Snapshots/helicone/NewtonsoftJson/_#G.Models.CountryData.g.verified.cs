//HintName: G.Models.CountryData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CountryData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("country", Required = global::Newtonsoft.Json.Required.Always)]
        public string Country { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_requests", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalRequests { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CountryData" /> class.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="totalRequests"></param>
        public CountryData(
            string country,
            double totalRequests)
        {
            this.Country = country ?? throw new global::System.ArgumentNullException(nameof(country));
            this.TotalRequests = totalRequests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CountryData" /> class.
        /// </summary>
        public CountryData()
        {
        }
    }
}