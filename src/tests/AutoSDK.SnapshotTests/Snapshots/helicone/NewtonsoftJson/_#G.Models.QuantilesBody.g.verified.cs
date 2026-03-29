//HintName: G.Models.QuantilesBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QuantilesBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FilterNode Filter { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeFilter", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.QuantilesBodyTimeFilter TimeFilter { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dbIncrement")]
        public global::G.TimeIncrement? DbIncrement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeZoneDifference", Required = global::Newtonsoft.Json.Required.Always)]
        public double TimeZoneDifference { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metric", Required = global::Newtonsoft.Json.Required.Always)]
        public string Metric { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QuantilesBody" /> class.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="timeFilter"></param>
        /// <param name="timeZoneDifference"></param>
        /// <param name="metric"></param>
        /// <param name="dbIncrement"></param>
        public QuantilesBody(
            global::G.FilterNode filter,
            global::G.QuantilesBodyTimeFilter timeFilter,
            double timeZoneDifference,
            string metric,
            global::G.TimeIncrement? dbIncrement)
        {
            this.Filter = filter;
            this.TimeFilter = timeFilter ?? throw new global::System.ArgumentNullException(nameof(timeFilter));
            this.DbIncrement = dbIncrement;
            this.TimeZoneDifference = timeZoneDifference;
            this.Metric = metric ?? throw new global::System.ArgumentNullException(nameof(metric));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuantilesBody" /> class.
        /// </summary>
        public QuantilesBody()
        {
        }
    }
}