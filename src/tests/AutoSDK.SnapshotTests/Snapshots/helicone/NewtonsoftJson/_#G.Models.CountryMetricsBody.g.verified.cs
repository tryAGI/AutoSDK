//HintName: G.Models.CountryMetricsBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CountryMetricsBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FilterNode Filter { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("offset", Required = global::Newtonsoft.Json.Required.Always)]
        public double Offset { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit", Required = global::Newtonsoft.Json.Required.Always)]
        public double Limit { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeFilter", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CountryMetricsBodyTimeFilter TimeFilter { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CountryMetricsBody" /> class.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="timeFilter"></param>
        public CountryMetricsBody(
            global::G.FilterNode filter,
            double offset,
            double limit,
            global::G.CountryMetricsBodyTimeFilter timeFilter)
        {
            this.Filter = filter;
            this.Offset = offset;
            this.Limit = limit;
            this.TimeFilter = timeFilter ?? throw new global::System.ArgumentNullException(nameof(timeFilter));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CountryMetricsBody" /> class.
        /// </summary>
        public CountryMetricsBody()
        {
        }
    }
}